namespace OS
{
    partial class InputData
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
            this.backButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.groupBox_processDetail = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.priorityTimesNummeric = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.criticalTimesNummeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.arrivalTimesNummeric = new System.Windows.Forms.NumericUpDown();
            this.quantTimeNummeric = new System.Windows.Forms.NumericUpDown();
            this.burstTimesNummeric = new System.Windows.Forms.NumericUpDown();
            this.processNames = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox_processDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priorityTimesNummeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.criticalTimesNummeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrivalTimesNummeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantTimeNummeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.burstTimesNummeric)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.backButton.Location = new System.Drawing.Point(73, 391);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(85, 38);
            this.backButton.TabIndex = 53;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.Transparent;
            this.nextButton.FlatAppearance.BorderSize = 0;
            this.nextButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.nextButton.Location = new System.Drawing.Point(654, 391);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(85, 40);
            this.nextButton.TabIndex = 52;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // groupBox_processDetail
            // 
            this.groupBox_processDetail.AutoScroll = true;
            this.groupBox_processDetail.AutoScrollMargin = new System.Drawing.Size(0, 50);
            this.groupBox_processDetail.BackColor = System.Drawing.Color.White;
            this.groupBox_processDetail.Controls.Add(this.label9);
            this.groupBox_processDetail.Controls.Add(this.priorityTimesNummeric);
            this.groupBox_processDetail.Controls.Add(this.label8);
            this.groupBox_processDetail.Controls.Add(this.criticalTimesNummeric);
            this.groupBox_processDetail.Controls.Add(this.label3);
            this.groupBox_processDetail.Controls.Add(this.label4);
            this.groupBox_processDetail.Controls.Add(this.arrivalTimesNummeric);
            this.groupBox_processDetail.Controls.Add(this.quantTimeNummeric);
            this.groupBox_processDetail.Controls.Add(this.burstTimesNummeric);
            this.groupBox_processDetail.Controls.Add(this.processNames);
            this.groupBox_processDetail.Controls.Add(this.label6);
            this.groupBox_processDetail.Controls.Add(this.label7);
            this.groupBox_processDetail.Location = new System.Drawing.Point(72, 12);
            this.groupBox_processDetail.Name = "groupBox_processDetail";
            this.groupBox_processDetail.Size = new System.Drawing.Size(674, 360);
            this.groupBox_processDetail.TabIndex = 74;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(567, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 17);
            this.label9.TabIndex = 77;
            this.label9.Text = "Quant";
            // 
            // priorityTimesNummeric
            // 
            this.priorityTimesNummeric.BackColor = System.Drawing.Color.Bisque;
            this.priorityTimesNummeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priorityTimesNummeric.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priorityTimesNummeric.Location = new System.Drawing.Point(437, 90);
            this.priorityTimesNummeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.priorityTimesNummeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.priorityTimesNummeric.Name = "priorityTimesNummeric";
            this.priorityTimesNummeric.ReadOnly = true;
            this.priorityTimesNummeric.Size = new System.Drawing.Size(61, 35);
            this.priorityTimesNummeric.TabIndex = 76;
            this.priorityTimesNummeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.priorityTimesNummeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(447, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 75;
            this.label8.Text = "Priority";
            // 
            // criticalTimesNummeric
            // 
            this.criticalTimesNummeric.BackColor = System.Drawing.Color.Bisque;
            this.criticalTimesNummeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.criticalTimesNummeric.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.criticalTimesNummeric.Location = new System.Drawing.Point(337, 90);
            this.criticalTimesNummeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.criticalTimesNummeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.criticalTimesNummeric.Name = "criticalTimesNummeric";
            this.criticalTimesNummeric.ReadOnly = true;
            this.criticalTimesNummeric.Size = new System.Drawing.Size(60, 35);
            this.criticalTimesNummeric.TabIndex = 53;
            this.criticalTimesNummeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.criticalTimesNummeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(323, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 54;
            this.label3.Text = "Critical time (ms)";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(223, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 39);
            this.label4.TabIndex = 52;
            this.label4.Text = "Processes Details";
            // 
            // arrivalTimesNummeric
            // 
            this.arrivalTimesNummeric.BackColor = System.Drawing.Color.Bisque;
            this.arrivalTimesNummeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.arrivalTimesNummeric.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrivalTimesNummeric.Location = new System.Drawing.Point(119, 90);
            this.arrivalTimesNummeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.arrivalTimesNummeric.Name = "arrivalTimesNummeric";
            this.arrivalTimesNummeric.ReadOnly = true;
            this.arrivalTimesNummeric.Size = new System.Drawing.Size(61, 35);
            this.arrivalTimesNummeric.TabIndex = 51;
            this.arrivalTimesNummeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // quantTimeNummeric
            // 
            this.quantTimeNummeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.quantTimeNummeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quantTimeNummeric.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantTimeNummeric.Location = new System.Drawing.Point(555, 90);
            this.quantTimeNummeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.quantTimeNummeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantTimeNummeric.Name = "quantTimeNummeric";
            this.quantTimeNummeric.ReadOnly = true;
            this.quantTimeNummeric.Size = new System.Drawing.Size(61, 29);
            this.quantTimeNummeric.TabIndex = 28;
            this.quantTimeNummeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantTimeNummeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // burstTimesNummeric
            // 
            this.burstTimesNummeric.BackColor = System.Drawing.Color.Bisque;
            this.burstTimesNummeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.burstTimesNummeric.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burstTimesNummeric.Location = new System.Drawing.Point(229, 90);
            this.burstTimesNummeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.burstTimesNummeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.burstTimesNummeric.Name = "burstTimesNummeric";
            this.burstTimesNummeric.ReadOnly = true;
            this.burstTimesNummeric.Size = new System.Drawing.Size(60, 35);
            this.burstTimesNummeric.TabIndex = 7;
            this.burstTimesNummeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.burstTimesNummeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // processNames
            // 
            this.processNames.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processNames.ForeColor = System.Drawing.Color.Gray;
            this.processNames.Location = new System.Drawing.Point(17, 102);
            this.processNames.Name = "processNames";
            this.processNames.Size = new System.Drawing.Size(82, 17);
            this.processNames.TabIndex = 43;
            this.processNames.Text = "Process 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(215, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Burst time (ms)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(99, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Arrival time (ms)";
            // 
            // InputData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox_processDetail);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.nextButton);
            this.Name = "InputData";
            this.Text = "InputData";
            this.groupBox_processDetail.ResumeLayout(false);
            this.groupBox_processDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priorityTimesNummeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.criticalTimesNummeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrivalTimesNummeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantTimeNummeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.burstTimesNummeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Panel groupBox_processDetail;
        private System.Windows.Forms.NumericUpDown criticalTimesNummeric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown arrivalTimesNummeric;
        private System.Windows.Forms.NumericUpDown quantTimeNummeric;
        private System.Windows.Forms.NumericUpDown burstTimesNummeric;
        private System.Windows.Forms.Label processNames;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown priorityTimesNummeric;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}