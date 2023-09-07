
namespace Defectoscopy_App
{
    partial class Form_ReportPFA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ReportPFA));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Report_Button = new System.Windows.Forms.Button();
            this.Apparatus_ComboBox = new System.Windows.Forms.ComboBox();
            this.apparatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.defectoscopyDataSet1 = new Defectoscopy_App.defectoscopyDataSet1();
            this.apparatusTableAdapter = new Defectoscopy_App.defectoscopyDataSet1TableAdapters.apparatusTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PlanFact_DataGridView = new System.Windows.Forms.DataGridView();
            this.nameapparatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelcontrolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateplanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datefactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultcontorolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameemployeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planfactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.planfactTableAdapter = new Defectoscopy_App.defectoscopyDataSet1TableAdapters.planfactTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.Close_Button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apparatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defectoscopyDataSet1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlanFact_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planfactBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Report_Button);
            this.groupBox1.Controls.Add(this.Apparatus_ComboBox);
            this.groupBox1.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(7, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 105);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор прибора:";
            // 
            // Report_Button
            // 
            this.Report_Button.BackColor = System.Drawing.Color.Silver;
            this.Report_Button.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Report_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Report_Button.Location = new System.Drawing.Point(6, 58);
            this.Report_Button.Name = "Report_Button";
            this.Report_Button.Size = new System.Drawing.Size(357, 32);
            this.Report_Button.TabIndex = 69;
            this.Report_Button.Text = "Показать результаты";
            this.Report_Button.UseVisualStyleBackColor = false;
            this.Report_Button.Click += new System.EventHandler(this.Report_Button_Click);
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
            this.Apparatus_ComboBox.Size = new System.Drawing.Size(357, 22);
            this.Apparatus_ComboBox.TabIndex = 0;
            this.Apparatus_ComboBox.ValueMember = "nameapparatus";
            // 
            // apparatusBindingSource
            // 
            this.apparatusBindingSource.DataMember = "apparatus";
            this.apparatusBindingSource.DataSource = this.defectoscopyDataSet1;
            // 
            // defectoscopyDataSet1
            // 
            this.defectoscopyDataSet1.DataSetName = "defectoscopyDataSet1";
            this.defectoscopyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // apparatusTableAdapter
            // 
            this.apparatusTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PlanFact_DataGridView);
            this.groupBox2.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.Color.Navy;
            this.groupBox2.Location = new System.Drawing.Point(387, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(657, 524);
            this.groupBox2.TabIndex = 71;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результаты";
            // 
            // PlanFact_DataGridView
            // 
            this.PlanFact_DataGridView.AutoGenerateColumns = false;
            this.PlanFact_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PlanFact_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlanFact_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameapparatusDataGridViewTextBoxColumn,
            this.levelcontrolDataGridViewTextBoxColumn,
            this.dateplanDataGridViewTextBoxColumn,
            this.datefactDataGridViewTextBoxColumn,
            this.resultcontorolDataGridViewTextBoxColumn,
            this.nameemployeeDataGridViewTextBoxColumn});
            this.PlanFact_DataGridView.DataSource = this.planfactBindingSource;
            this.PlanFact_DataGridView.Location = new System.Drawing.Point(6, 21);
            this.PlanFact_DataGridView.Name = "PlanFact_DataGridView";
            this.PlanFact_DataGridView.ReadOnly = true;
            this.PlanFact_DataGridView.Size = new System.Drawing.Size(645, 497);
            this.PlanFact_DataGridView.TabIndex = 0;
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
            // datefactDataGridViewTextBoxColumn
            // 
            this.datefactDataGridViewTextBoxColumn.DataPropertyName = "datefact";
            this.datefactDataGridViewTextBoxColumn.HeaderText = "Дата фактического контроля";
            this.datefactDataGridViewTextBoxColumn.Name = "datefactDataGridViewTextBoxColumn";
            this.datefactDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resultcontorolDataGridViewTextBoxColumn
            // 
            this.resultcontorolDataGridViewTextBoxColumn.DataPropertyName = "resultcontorol";
            this.resultcontorolDataGridViewTextBoxColumn.HeaderText = "Результат контроля";
            this.resultcontorolDataGridViewTextBoxColumn.Name = "resultcontorolDataGridViewTextBoxColumn";
            this.resultcontorolDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameemployeeDataGridViewTextBoxColumn
            // 
            this.nameemployeeDataGridViewTextBoxColumn.DataPropertyName = "nameemployee";
            this.nameemployeeDataGridViewTextBoxColumn.HeaderText = "Материально ответственное лицо";
            this.nameemployeeDataGridViewTextBoxColumn.Name = "nameemployeeDataGridViewTextBoxColumn";
            this.nameemployeeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // planfactBindingSource
            // 
            this.planfactBindingSource.DataMember = "planfact";
            this.planfactBindingSource.DataSource = this.defectoscopyDataSet1;
            // 
            // planfactTableAdapter
            // 
            this.planfactTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Garamond", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(176, 549);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(329, 18);
            this.label6.TabIndex = 78;
            this.label6.Text = "Отчет: план-факторный анализ по приборам";
            // 
            // Close_Button
            // 
            this.Close_Button.BackColor = System.Drawing.Color.Silver;
            this.Close_Button.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close_Button.ForeColor = System.Drawing.Color.Maroon;
            this.Close_Button.Location = new System.Drawing.Point(7, 542);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(163, 32);
            this.Close_Button.TabIndex = 77;
            this.Close_Button.Text = "Закрыть";
            this.Close_Button.UseVisualStyleBackColor = false;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(374, 407);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 79;
            this.pictureBox1.TabStop = false;
            // 
            // Form_ReportPFA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1047, 575);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Close_Button);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Garamond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_ReportPFA";
            this.Text = "Отчет: план-факторный анализ";
            this.Load += new System.EventHandler(this.Form_ReportPFA_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.apparatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defectoscopyDataSet1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PlanFact_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planfactBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Report_Button;
        private System.Windows.Forms.ComboBox Apparatus_ComboBox;
        private defectoscopyDataSet1 defectoscopyDataSet1;
        private System.Windows.Forms.BindingSource apparatusBindingSource;
        private defectoscopyDataSet1TableAdapters.apparatusTableAdapter apparatusTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView PlanFact_DataGridView;
        private System.Windows.Forms.BindingSource planfactBindingSource;
        private defectoscopyDataSet1TableAdapters.planfactTableAdapter planfactTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameapparatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelcontrolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateplanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datefactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultcontorolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameemployeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Close_Button;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}