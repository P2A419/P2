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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.GaussianTrainButton = new System.Windows.Forms.Button();
            this.GaussianTrainingFileTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GaussianStartButton = new System.Windows.Forms.Button();
            this.GaussianTrainingFindFileButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.GaussianPlimNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.DataFindFileButton = new System.Windows.Forms.Button();
            this.DataFileTextBox = new System.Windows.Forms.TextBox();
            this.AnomalyDetectedListView = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.UnitTypeDropdown = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AnomalitiesDetected = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GaussianPlimNumericUpDown)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 113);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(273, 201);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.GaussianTrainButton);
            this.tabPage1.Controls.Add(this.GaussianTrainingFileTextBox);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.GaussianStartButton);
            this.tabPage1.Controls.Add(this.GaussianTrainingFindFileButton);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.GaussianPlimNumericUpDown);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(265, 175);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Gaussian";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // GaussianTrainButton
            // 
            this.GaussianTrainButton.Location = new System.Drawing.Point(6, 48);
            this.GaussianTrainButton.Name = "GaussianTrainButton";
            this.GaussianTrainButton.Size = new System.Drawing.Size(250, 23);
            this.GaussianTrainButton.TabIndex = 8;
            this.GaussianTrainButton.Text = "Træn";
            this.GaussianTrainButton.UseVisualStyleBackColor = true;
            this.GaussianTrainButton.Click += new System.EventHandler(this.GaussianTrainButton_Click);
            // 
            // GaussianTrainingFileTextBox
            // 
            this.GaussianTrainingFileTextBox.Location = new System.Drawing.Point(87, 20);
            this.GaussianTrainingFileTextBox.Name = "GaussianTrainingFileTextBox";
            this.GaussianTrainingFileTextBox.Size = new System.Drawing.Size(169, 20);
            this.GaussianTrainingFileTextBox.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Vælg træningsdata";
            // 
            // GaussianStartButton
            // 
            this.GaussianStartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GaussianStartButton.Location = new System.Drawing.Point(6, 128);
            this.GaussianStartButton.Name = "GaussianStartButton";
            this.GaussianStartButton.Size = new System.Drawing.Size(250, 40);
            this.GaussianStartButton.TabIndex = 9;
            this.GaussianStartButton.Text = "Start";
            this.GaussianStartButton.UseVisualStyleBackColor = true;
            this.GaussianStartButton.Click += new System.EventHandler(this.GaussianStartButton_Click);
            // 
            // GaussianTrainingFindFileButton
            // 
            this.GaussianTrainingFindFileButton.Location = new System.Drawing.Point(6, 19);
            this.GaussianTrainingFindFileButton.Name = "GaussianTrainingFindFileButton";
            this.GaussianTrainingFindFileButton.Size = new System.Drawing.Size(75, 23);
            this.GaussianTrainingFindFileButton.TabIndex = 4;
            this.GaussianTrainingFindFileButton.Text = "Find";
            this.GaussianTrainingFindFileButton.UseVisualStyleBackColor = true;
            this.GaussianTrainingFindFileButton.Click += new System.EventHandler(this.GaussianTrainingFindFileButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sandsynlighedsgrænseværdi";
            // 
            // GaussianPlimNumericUpDown
            // 
            this.GaussianPlimNumericUpDown.DecimalPlaces = 10;
            this.GaussianPlimNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            327680});
            this.GaussianPlimNumericUpDown.Location = new System.Drawing.Point(6, 97);
            this.GaussianPlimNumericUpDown.Name = "GaussianPlimNumericUpDown";
            this.GaussianPlimNumericUpDown.Size = new System.Drawing.Size(250, 20);
            this.GaussianPlimNumericUpDown.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(265, 175);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Density";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Algorithm not yet implemented";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(265, 175);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Distance";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Algorithm not yet implemented";
            // 
            // DataFindFileButton
            // 
            this.DataFindFileButton.Location = new System.Drawing.Point(12, 68);
            this.DataFindFileButton.Name = "DataFindFileButton";
            this.DataFindFileButton.Size = new System.Drawing.Size(75, 23);
            this.DataFindFileButton.TabIndex = 2;
            this.DataFindFileButton.Text = "Find";
            this.DataFindFileButton.UseVisualStyleBackColor = true;
            this.DataFindFileButton.Click += new System.EventHandler(this.DataFindFileButton_Click);
            // 
            // DataFileTextBox
            // 
            this.DataFileTextBox.Location = new System.Drawing.Point(90, 69);
            this.DataFileTextBox.Name = "DataFileTextBox";
            this.DataFileTextBox.Size = new System.Drawing.Size(192, 20);
            this.DataFileTextBox.TabIndex = 3;
            // 
            // AnomalyDetectedListView
            // 
            this.AnomalyDetectedListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AnomalyDetectedListView.FullRowSelect = true;
            this.AnomalyDetectedListView.Location = new System.Drawing.Point(291, 25);
            this.AnomalyDetectedListView.Name = "AnomalyDetectedListView";
            this.AnomalyDetectedListView.Size = new System.Drawing.Size(401, 289);
            this.AnomalyDetectedListView.TabIndex = 4;
            this.AnomalyDetectedListView.UseCompatibleStateImageBehavior = false;
            this.AnomalyDetectedListView.View = System.Windows.Forms.View.Details;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Vælg data til unormalhedsdetektetring";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 97);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Vælg algoritme";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(288, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Unormalheder detekteret";
            // 
            // UnitTypeDropdown
            // 
            this.UnitTypeDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UnitTypeDropdown.FormattingEnabled = true;
            this.UnitTypeDropdown.Items.AddRange(new object[] {
            "Grise",
            "Boller",
            "Æbler"});
            this.UnitTypeDropdown.Location = new System.Drawing.Point(12, 25);
            this.UnitTypeDropdown.Name = "UnitTypeDropdown";
            this.UnitTypeDropdown.Size = new System.Drawing.Size(270, 21);
            this.UnitTypeDropdown.TabIndex = 8;
            this.UnitTypeDropdown.SelectedIndexChanged += new System.EventHandler(this.UnitTypeDropdown_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Vælg produkt type";
            // 
            // AnomalitiesDetected
            // 
            this.AnomalitiesDetected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnomalitiesDetected.Location = new System.Drawing.Point(592, 9);
            this.AnomalitiesDetected.Name = "AnomalitiesDetected";
            this.AnomalitiesDetected.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AnomalitiesDetected.Size = new System.Drawing.Size(100, 13);
            this.AnomalitiesDetected.TabIndex = 10;
            this.AnomalitiesDetected.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 323);
            this.Controls.Add(this.AnomalitiesDetected);
            this.Controls.Add(this.AnomalyDetectedListView);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.UnitTypeDropdown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DataFileTextBox);
            this.Controls.Add(this.DataFindFileButton);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Unormalhedsdetektering";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GaussianPlimNumericUpDown)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button DataFindFileButton;
        private System.Windows.Forms.NumericUpDown GaussianPlimNumericUpDown;
        private System.Windows.Forms.TextBox GaussianTrainingFileTextBox;
        private System.Windows.Forms.Button GaussianTrainingFindFileButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DataFileTextBox;
        private System.Windows.Forms.Button GaussianTrainButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button GaussianStartButton;
        private System.Windows.Forms.ListView AnomalyDetectedListView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox UnitTypeDropdown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label AnomalitiesDetected;

    }
}

