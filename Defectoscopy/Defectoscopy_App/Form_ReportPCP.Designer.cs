
namespace Defectoscopy_App
{
    partial class Form_ReportPCP
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ReportPCP));
            this.PlanApparatus_DataGridView = new System.Windows.Forms.DataGridView();
            this.defectoscopyDataSet1 = new Defectoscopy_App.defectoscopyDataSet1();
            this.planapparatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.planapparatusTableAdapter = new Defectoscopy_App.defectoscopyDataSet1TableAdapters.planapparatusTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Apparatus_ComboBox = new System.Windows.Forms.ComboBox();
            this.Close_Button = new System.Windows.Forms.Button();
            this.Report_Button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nameapparatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelcontrolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateplanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.apparatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apparatusTableAdapter = new Defectoscopy_App.defectoscopyDataSet1TableAdapters.apparatusTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PlanApparatus_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defectoscopyDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planapparatusBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apparatusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PlanApparatus_DataGridView
            // 
            this.PlanApparatus_DataGridView.AutoGenerateColumns = false;
            this.PlanApparatus_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PlanApparatus_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlanApparatus_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameapparatusDataGridViewTextBoxColumn,
            this.levelcontrolDataGridViewTextBoxColumn,
            this.dateplanDataGridViewTextBoxColumn});
            this.PlanApparatus_DataGridView.DataSource = this.planapparatusBindingSource;
            this.PlanApparatus_DataGridView.Location = new System.Drawing.Point(6, 21);
            this.PlanApparatus_DataGridView.Name = "PlanApparatus_DataGridView";
            this.PlanApparatus_DataGridView.ReadOnly = true;
            this.PlanApparatus_DataGridView.Size = new System.Drawing.Size(382, 470);
            this.PlanApparatus_DataGridView.TabIndex = 0;
            // 
            // defectoscopyDataSet1
            // 
            this.defectoscopyDataSet1.DataSetName = "defectoscopyDataSet1";
            this.defectoscopyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // planapparatusBindingSource
            // 
            this.planapparatusBindingSource.DataMember = "planapparatus";
            this.planapparatusBindingSource.DataSource = this.defectoscopyDataSet1;
            // 
            // planapparatusTableAdapter
            // 
            this.planapparatusTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Report_Button);
            this.groupBox1.Controls.Add(this.Apparatus_ComboBox);
            this.groupBox1.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(7, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 105);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор прибора:";
            // 
            // Apparatus_ComboBox
            // 
            this.Apparatus_ComboBox.DataSource = this.apparatusBindingSource;
            this.Apparatus_ComboBox.DisplayMember = "nameapparatus";
            this.Apparatus_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Apparatus_ComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Apparatus_ComboBox.FormattingEnabled = true;
            this.Apparatus_ComboBox.Location = new System.Drawing.Point(6, 21);
            this.Apparatus_ComboBox.Name = "Apparatus_ComboBox";
            this.Apparatus_ComboBox.Size = new System.Drawing.Size(454, 22);
            this.Apparatus_ComboBox.TabIndex = 0;
            this.Apparatus_ComboBox.ValueMember = "nameapparatus";
            // 
            // Close_Button
            // 
            this.Close_Button.BackColor = System.Drawing.Color.Silver;
            this.Close_Button.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close_Button.ForeColor = System.Drawing.Color.Maroon;
            this.Close_Button.Location = new System.Drawing.Point(4, 513);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(163, 32);
            this.Close_Button.TabIndex = 69;
            this.Close_Button.Text = "Закрыть";
            this.Close_Button.UseVisualStyleBackColor = false;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // Report_Button
            // 
            this.Report_Button.BackColor = System.Drawing.Color.Silver;
            this.Report_Button.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Report_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Report_Button.Location = new System.Drawing.Point(6, 58);
            this.Report_Button.Name = "Report_Button";
            this.Report_Button.Size = new System.Drawing.Size(454, 32);
            this.Report_Button.TabIndex = 69;
            this.Report_Button.Text = "Показать результаты";
            this.Report_Button.UseVisualStyleBackColor = false;
            this.Report_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PlanApparatus_DataGridView);
            this.groupBox2.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.Color.Navy;
            this.groupBox2.Location = new System.Drawing.Point(484, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(394, 497);
            this.groupBox2.TabIndex = 70;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результаты";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(474, 377);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            // 
            // nameapparatusDataGridViewTextBoxColumn
            // 
            this.nameapparatusDataGridViewTextBoxColumn.DataPropertyName = "nameapparatus";
            this.nameapparatusDataGridViewTextBoxColumn.HeaderText = "nameapparatus";
            this.nameapparatusDataGridViewTextBoxColumn.Name = "nameapparatusDataGridViewTextBoxColumn";
            this.nameapparatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameapparatusDataGridViewTextBoxColumn.Visible = false;
            // 
            // levelcontrolDataGridViewTextBoxColumn
            // 
            this.levelcontrolDataGridViewTextBoxColumn.DataPropertyName = "levelcontrol";
            this.levelcontrolDataGridViewTextBoxColumn.HeaderText = "Уровень контроля";
            this.levelcontrolDataGridViewTextBoxColumn.Name = "levelcontrolDataGridViewTextBoxColumn";
            this.levelcontrolDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateplanDataGridViewTextBoxColumn
            // 
            this.dateplanDataGridViewTextBoxColumn.DataPropertyName = "dateplan";
            this.dateplanDataGridViewTextBoxColumn.HeaderText = "Планируемая дата контроля";
            this.dateplanDataGridViewTextBoxColumn.Name = "dateplanDataGridViewTextBoxColumn";
            this.dateplanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Garamond", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(173, 520);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(380, 18);
            this.label6.TabIndex = 76;
            this.label6.Text = "Отчет: параметры планового контроля по приборам";
            // 
            // apparatusBindingSource
            // 
            this.apparatusBindingSource.DataMember = "apparatus";
            this.apparatusBindingSource.DataSource = this.defectoscopyDataSet1;
            // 
            // apparatusTableAdapter
            // 
            this.apparatusTableAdapter.ClearBeforeFill = true;
            // 
            // Form_ReportPCP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(881, 546);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Close_Button);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Garamond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_ReportPCP";
            this.Text = "Отчет: параметры планового контроля";
            this.Load += new System.EventHandler(this.Form_ReportPCP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlanApparatus_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defectoscopyDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planapparatusBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apparatusBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PlanApparatus_DataGridView;
        private defectoscopyDataSet1 defectoscopyDataSet1;
        private System.Windows.Forms.BindingSource planapparatusBindingSource;
        private defectoscopyDataSet1TableAdapters.planapparatusTableAdapter planapparatusTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Apparatus_ComboBox;
        private System.Windows.Forms.Button Report_Button;
        private System.Windows.Forms.Button Close_Button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameapparatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelcontrolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateplanDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource apparatusBindingSource;
        private defectoscopyDataSet1TableAdapters.apparatusTableAdapter apparatusTableAdapter;
    }
}