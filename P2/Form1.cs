using P2.AnomalyDetection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2
{
    public partial class Form1 : Form
    {
        Gaussian gaussian = new Gaussian();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BrowseDataFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();

            DialogResult result = fd.ShowDialog();

            if (result == DialogResult.OK)
            {
                DataFileTextBox.Text = fd.FileName;
            }
        }

        private void GaussianFindTrainingFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();

            DialogResult result = fd.ShowDialog();

            if (result == DialogResult.OK)
            {
                GaussianTrainingFileTextBox.Text = fd.FileName;
            }
        }

        private void GaussianTrain_Click(object sender, EventArgs e)
        {
            try
            {
                UnitCollection units = new UnitCollection();
                
                units.FromFile(GaussianTrainingFileTextBox.Text);
                
                UnitCollection standardized = new UnitCollection();
                
                standardized = gaussian.Standardize(units);

                gaussian.Train(standardized);

                double plim = gaussian.CalculateProbabilityLimit(standardized);

                DialogResult result = MessageBox.Show("The recommended probability limit is:\n\n" + plim + "\n\nWould you like to apply it?", "Recommended Probability Limit", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    GaussianPlimNumericUpDown.Value = (decimal)plim;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StartDetectionButton_Click(object sender, EventArgs e)
        {
            try
            {
                AnomaliesDetectedListView.Items.Clear();
                AnomaliesDetectedListView.Columns.Clear();

                UnitCollection units = new UnitCollection();
                
                units.FromFile(DataFileTextBox.Text);
                
                UnitCollection standardized = new UnitCollection();
                
                standardized = gaussian.Standardize(units);

                ColumnHeader hID = new ColumnHeader();
                hID.Text = "ID";
                hID.Width = 50;
                AnomaliesDetectedListView.Columns.Add(hID);

                for (int i = 0; i < units.Headers.Count(); i++)
                {
                    ColumnHeader h = new ColumnHeader();
                    h.Text = char.ToUpper(units.Headers[i][0]) + units.Headers[i].Substring(1);
                    h.Width = 120;
                    AnomaliesDetectedListView.Columns.Add(h);
                }

                int count = 0;

                for (int i = 0; i < standardized.List.Count(); i++)
                {
                    if (gaussian.IsAnomaly(standardized.List[i], (double)GaussianPlimNumericUpDown.Value))
                    {
                        ListViewItem lvi = new ListViewItem();

                        lvi.Text = units.List[i].ID.ToString();

                        foreach (double value in units.List[i].Values)
                        {
                            lvi.SubItems.Add(value.ToString());
                        }

                        AnomaliesDetectedListView.Items.Add(lvi);
                        count++;
                    }
                }

                AnomaliesDetectedCount.Text = "Count: " + count.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
