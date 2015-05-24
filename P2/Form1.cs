using MathNet.Numerics.LinearAlgebra;
using P2.AnomalyDetection;
using P2.Units;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
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
            UnitTypeDropdown.SelectedIndex = 0;
        }

        private void DataFindFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();

            DialogResult result = fd.ShowDialog();

            if (result == DialogResult.OK)
            {
                DataFileTextBox.Text = fd.FileName;
            }
        }

        private void GaussianTrainingFindFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();

            DialogResult result = fd.ShowDialog();

            if (result == DialogResult.OK)
            {
                GaussianTrainingFileTextBox.Text = fd.FileName;
            }
        }

        private void GaussianTrainButton_Click(object sender, EventArgs e)
        {
            Pig.Increment = 0;
            List<Pig> pigs = Algorithms.FileToList<Pig>(GaussianTrainingFileTextBox.Text);
            List<Pig> sPigs = Algorithms.Standardize(ref pigs);
            
            gaussian.Train(ref sPigs);

            double plim = gaussian.CalculatePlim(ref sPigs);

            DialogResult result = MessageBox.Show("Den anbefalede sandsynlighedsgrænse er:\n" + plim + "\nVil du anvende den?", "Anbefalede sandsynlighedsgrænse", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                GaussianPlimNumericUpDown.Value = (decimal)plim;
            }
        }

        private void GaussianStartButton_Click(object sender, EventArgs e)
        {
            Pig.Increment = 0;
            List<Pig> pigs = Algorithms.FileToList<Pig>(DataFileTextBox.Text);
            List<Pig> sPigs = Algorithms.Standardize(ref pigs);

            int count = 0;

            AnomalyDetectedListView.Items.Clear();

            for(int i = 0; i < sPigs.Count(); i++) {
                if (gaussian.IsAnomaly(sPigs[i], (double)GaussianPlimNumericUpDown.Value))
                {
                    ListViewItem listviewItem = new ListViewItem();
                    listviewItem.Text = pigs[i].ID.ToString();
                    listviewItem.SubItems.Add(pigs[i].Distance.ToString());
                    listviewItem.SubItems.Add(pigs[i].Angle.ToString());
                    AnomalyDetectedListView.Items.Add(listviewItem);
                    count++;
                }
            }

            AnomalitiesDetected.Text = "Antal: " + count.ToString();
        }

        private void UnitTypeDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (UnitTypeDropdown.SelectedIndex)
            {
                case 0:
                    AddColumnsToListView();
                    break;

                default:
                    AnomalyDetectedListView.Columns.Clear();
                    break;
            }
        }

        void AddColumnsToListView()
        {
            AnomalyDetectedListView.Columns.Clear();

            ColumnHeader columnID = new ColumnHeader();
            columnID.Text = "ID";
            columnID.Width = 50;
            AnomalyDetectedListView.Columns.Add(columnID);

            PropertyInfo[] properties = typeof(Pig).GetProperties();

            foreach (var prop in properties)
            {
                ColumnHeader header = new ColumnHeader();
                header.Text = prop.Name;
                header.Width = (AnomalyDetectedListView.Width - 71) / properties.Count();
                AnomalyDetectedListView.Columns.Add(header);
            }
        }
    }
}
