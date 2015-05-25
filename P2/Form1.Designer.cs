namespace P2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.BrowseDataFile = new System.Windows.Forms.Button();
            this.AnomaliesDetectedListView = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.AnomaliesDetectedCount = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.GaussianPlimNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.GaussianTrainingFileTextBox = new System.Windows.Forms.TextBox();
            this.GaussianBrowseTrainingFile = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.GaussianTrain = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.StartDetectionButton = new System.Windows.Forms.Button();
            this.DataFileTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GaussianPlimNumericUpDown)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detection data";
            // 
            // BrowseDataFile
            // 
            this.BrowseDataFile.Location = new System.Drawing.Point(11, 29);
            this.BrowseDataFile.Name = "BrowseDataFile";
            this.BrowseDataFile.Size = new System.Drawing.Size(75, 23);
            this.BrowseDataFile.TabIndex = 1;
            this.BrowseDataFile.Text = "Browse";
            this.BrowseDataFile.UseVisualStyleBackColor = true;
            this.BrowseDataFile.Click += new System.EventHandler(this.BrowseDataFile_Click);
            // 
            // AnomaliesDetectedListView
            // 
            this.AnomaliesDetectedListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AnomaliesDetectedListView.Location = new System.Drawing.Point(278, 29);
            this.AnomaliesDetectedListView.Name = "AnomaliesDetectedListView";
            this.AnomaliesDetectedListView.Size = new System.Drawing.Size(344, 217);
            this.AnomaliesDetectedListView.TabIndex = 4;
            this.AnomaliesDetectedListView.UseCompatibleStateImageBehavior = false;
            this.AnomaliesDetectedListView.View = System.Windows.Forms.View.Details;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Anomalies detected";
            // 
            // AnomaliesDetectedCount
            // 
            this.AnomaliesDetectedCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnomaliesDetectedCount.Location = new System.Drawing.Point(472, 13);
            this.AnomaliesDetectedCount.Name = "AnomaliesDetectedCount";
            this.AnomaliesDetectedCount.Size = new System.Drawing.Size(150, 13);
            this.AnomaliesDetectedCount.TabIndex = 4;
            this.AnomaliesDetectedCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 58);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(260, 143);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.GaussianPlimNumericUpDown);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.GaussianTrainingFileTextBox);
            this.tabPage1.Controls.Add(this.GaussianBrowseTrainingFile);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.GaussianTrain);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(252, 117);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Gaussian";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // GaussianPlimNumericUpDown
            // 
            this.GaussianPlimNumericUpDown.DecimalPlaces = 16;
            this.GaussianPlimNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.GaussianPlimNumericUpDown.Location = new System.Drawing.Point(5, 91);
            this.GaussianPlimNumericUpDown.Name = "GaussianPlimNumericUpDown";
            this.GaussianPlimNumericUpDown.Size = new System.Drawing.Size(240, 20);
            this.GaussianPlimNumericUpDown.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Probability limit";
            // 
            // GaussianTrainingFileTextBox
            // 
            this.GaussianTrainingFileTextBox.Location = new System.Drawing.Point(86, 21);
            this.GaussianTrainingFileTextBox.Name = "GaussianTrainingFileTextBox";
            this.GaussianTrainingFileTextBox.Size = new System.Drawing.Size(159, 20);
            this.GaussianTrainingFileTextBox.TabIndex = 3;
            // 
            // GaussianBrowseTrainingFile
            // 
            this.GaussianBrowseTrainingFile.Location = new System.Drawing.Point(4, 20);
            this.GaussianBrowseTrainingFile.Name = "GaussianBrowseTrainingFile";
            this.GaussianBrowseTrainingFile.Size = new System.Drawing.Size(75, 23);
            this.GaussianBrowseTrainingFile.TabIndex = 2;
            this.GaussianBrowseTrainingFile.Text = "Browse";
            this.GaussianBrowseTrainingFile.UseVisualStyleBackColor = true;
            this.GaussianBrowseTrainingFile.Click += new System.EventHandler(this.GaussianFindTrainingFile_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Training data";
            // 
            // GaussianTrain
            // 
            this.GaussianTrain.Location = new System.Drawing.Point(4, 49);
            this.GaussianTrain.Name = "GaussianTrain";
            this.GaussianTrain.Size = new System.Drawing.Size(242, 23);
            this.GaussianTrain.TabIndex = 0;
            this.GaussianTrain.Text = "Train";
            this.GaussianTrain.UseVisualStyleBackColor = true;
            this.GaussianTrain.Click += new System.EventHandler(this.GaussianTrain_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(252, 117);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Density";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Location = new System.Drawing.Point(6, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 111);
            this.label6.TabIndex = 0;
            this.label6.Text = "label6";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(252, 117);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Distance";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(246, 117);
            this.label7.TabIndex = 0;
            this.label7.Text = "label7";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartDetectionButton
            // 
            this.StartDetectionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StartDetectionButton.Location = new System.Drawing.Point(11, 207);
            this.StartDetectionButton.Name = "StartDetectionButton";
            this.StartDetectionButton.Size = new System.Drawing.Size(259, 40);
            this.StartDetectionButton.TabIndex = 6;
            this.StartDetectionButton.Text = "Start";
            this.StartDetectionButton.UseVisualStyleBackColor = true;
            this.StartDetectionButton.Click += new System.EventHandler(this.StartDetectionButton_Click);
            // 
            // DataFileTextBox
            // 
            this.DataFileTextBox.Location = new System.Drawing.Point(93, 30);
            this.DataFileTextBox.Name = "DataFileTextBox";
            this.DataFileTextBox.Size = new System.Drawing.Size(177, 20);
            this.DataFileTextBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 258);
            this.Controls.Add(this.StartDetectionButton);
            this.Controls.Add(this.DataFileTextBox);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.AnomaliesDetectedCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AnomaliesDetectedListView);
            this.Controls.Add(this.BrowseDataFile);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(650, 297);
            this.Name = "Form1";
            this.Text = "A419 - Anomaly Detection";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GaussianPlimNumericUpDown)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BrowseDataFile;
        private System.Windows.Forms.ListView AnomaliesDetectedListView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AnomaliesDetectedCount;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button GaussianTrain;
        private System.Windows.Forms.TextBox DataFileTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox GaussianTrainingFileTextBox;
        private System.Windows.Forms.Button GaussianBrowseTrainingFile;
        private System.Windows.Forms.NumericUpDown GaussianPlimNumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button StartDetectionButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label7;


    }
}

