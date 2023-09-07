
namespace Defectoscopy_App
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.материальноответственныеЛицаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.типыПриборовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.приборыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.документыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.планПроведенияКонтроляToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.фактическоеПроведениеКонтроляToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.параметрыПлановогоКонтроляToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.планфакторныйАнализToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Apparatus_Button = new System.Windows.Forms.Button();
            this.TypeApparatus_Button = new System.Windows.Forms.Button();
            this.Employees_Button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.FactControl_Button = new System.Windows.Forms.Button();
            this.PlanControl_Button = new System.Windows.Forms.Button();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ReportPFA_Button = new System.Windows.Forms.Button();
            this.ReportPCP_Button = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem,
            this.документыToolStripMenuItem,
            this.отчетыToolStripMenuItem,
            this.оПрограммеToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(964, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.материальноответственныеЛицаToolStripMenuItem,
            this.toolStripMenuItem1,
            this.типыПриборовToolStripMenuItem,
            this.приборыToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // материальноответственныеЛицаToolStripMenuItem
            // 
            this.материальноответственныеЛицаToolStripMenuItem.Name = "материальноответственныеЛицаToolStripMenuItem";
            this.материальноответственныеЛицаToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.материальноответственныеЛицаToolStripMenuItem.Text = "Материально ответственные лица";
            this.материальноответственныеЛицаToolStripMenuItem.Click += new System.EventHandler(this.материальноответственныеЛицаToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(285, 6);
            // 
            // типыПриборовToolStripMenuItem
            // 
            this.типыПриборовToolStripMenuItem.Name = "типыПриборовToolStripMenuItem";
            this.типыПриборовToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.типыПриборовToolStripMenuItem.Text = "Типы приборов";
            this.типыПриборовToolStripMenuItem.Click += new System.EventHandler(this.типыПриборовToolStripMenuItem_Click);
            // 
            // приборыToolStripMenuItem
            // 
            this.приборыToolStripMenuItem.Name = "приборыToolStripMenuItem";
            this.приборыToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.приборыToolStripMenuItem.Text = "Приборы";
            this.приборыToolStripMenuItem.Click += new System.EventHandler(this.приборыToolStripMenuItem_Click);
            // 
            // документыToolStripMenuItem
            // 
            this.документыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.планПроведенияКонтроляToolStripMenuItem,
            this.toolStripMenuItem2,
            this.фактическоеПроведениеКонтроляToolStripMenuItem});
            this.документыToolStripMenuItem.Name = "документыToolStripMenuItem";
            this.документыToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.документыToolStripMenuItem.Text = "Документы";
            // 
            // планПроведенияКонтроляToolStripMenuItem
            // 
            this.планПроведенияКонтроляToolStripMenuItem.Name = "планПроведенияКонтроляToolStripMenuItem";
            this.планПроведенияКонтроляToolStripMenuItem.Size = new System.Drawing.Size(295, 22);
            this.планПроведенияКонтроляToolStripMenuItem.Text = "План проведения контроля";
            this.планПроведенияКонтроляToolStripMenuItem.Click += new System.EventHandler(this.PlanControl_Button_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(292, 6);
            // 
            // фактическоеПроведениеКонтроляToolStripMenuItem
            // 
            this.фактическоеПроведениеКонтроляToolStripMenuItem.Name = "фактическоеПроведениеКонтроляToolStripMenuItem";
            this.фактическоеПроведениеКонтроляToolStripMenuItem.Size = new System.Drawing.Size(295, 22);
            this.фактическоеПроведениеКонтроляToolStripMenuItem.Text = "Фактическое проведение контроля";
            this.фактическоеПроведениеКонтроляToolStripMenuItem.Click += new System.EventHandler(this.FactControl_Button_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.параметрыПлановогоКонтроляToolStripMenuItem,
            this.планфакторныйАнализToolStripMenuItem});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // параметрыПлановогоКонтроляToolStripMenuItem
            // 
            this.параметрыПлановогоКонтроляToolStripMenuItem.Name = "параметрыПлановогоКонтроляToolStripMenuItem";
            this.параметрыПлановогоКонтроляToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.параметрыПлановогоКонтроляToolStripMenuItem.Text = "Параметры планового контроля";
            this.параметрыПлановогоКонтроляToolStripMenuItem.Click += new System.EventHandler(this.параметрыПлановогоКонтроляToolStripMenuItem_Click);
            // 
            // планфакторныйАнализToolStripMenuItem
            // 
            this.планфакторныйАнализToolStripMenuItem.Name = "планфакторныйАнализToolStripMenuItem";
            this.планфакторныйАнализToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.планфакторныйАнализToolStripMenuItem.Text = "План-факторный анализ";
            this.планфакторныйАнализToolStripMenuItem.Click += new System.EventHandler(this.планфакторныйАнализToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.Apparatus_Button);
            this.groupBox1.Controls.Add(this.TypeApparatus_Button);
            this.groupBox1.Controls.Add(this.Employees_Button);
            this.groupBox1.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(6, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 161);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Справочники";
            // 
            // Apparatus_Button
            // 
            this.Apparatus_Button.BackColor = System.Drawing.Color.Silver;
            this.Apparatus_Button.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Apparatus_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Apparatus_Button.Location = new System.Drawing.Point(6, 115);
            this.Apparatus_Button.Name = "Apparatus_Button";
            this.Apparatus_Button.Size = new System.Drawing.Size(366, 32);
            this.Apparatus_Button.TabIndex = 71;
            this.Apparatus_Button.Text = "Приборы";
            this.Apparatus_Button.UseVisualStyleBackColor = false;
            this.Apparatus_Button.Click += new System.EventHandler(this.приборыToolStripMenuItem_Click);
            // 
            // TypeApparatus_Button
            // 
            this.TypeApparatus_Button.BackColor = System.Drawing.Color.Silver;
            this.TypeApparatus_Button.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeApparatus_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.TypeApparatus_Button.Location = new System.Drawing.Point(6, 68);
            this.TypeApparatus_Button.Name = "TypeApparatus_Button";
            this.TypeApparatus_Button.Size = new System.Drawing.Size(366, 32);
            this.TypeApparatus_Button.TabIndex = 70;
            this.TypeApparatus_Button.Text = "Типы приборов";
            this.TypeApparatus_Button.UseVisualStyleBackColor = false;
            this.TypeApparatus_Button.Click += new System.EventHandler(this.типыПриборовToolStripMenuItem_Click);
            // 
            // Employees_Button
            // 
            this.Employees_Button.BackColor = System.Drawing.Color.Silver;
            this.Employees_Button.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Employees_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Employees_Button.Location = new System.Drawing.Point(6, 21);
            this.Employees_Button.Name = "Employees_Button";
            this.Employees_Button.Size = new System.Drawing.Size(366, 32);
            this.Employees_Button.TabIndex = 69;
            this.Employees_Button.Text = "Материально ответственные лица";
            this.Employees_Button.UseVisualStyleBackColor = false;
            this.Employees_Button.Click += new System.EventHandler(this.материальноответственныеЛицаToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.FactControl_Button);
            this.groupBox2.Controls.Add(this.PlanControl_Button);
            this.groupBox2.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox2.Location = new System.Drawing.Point(6, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 114);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Документы";
            // 
            // FactControl_Button
            // 
            this.FactControl_Button.BackColor = System.Drawing.Color.Silver;
            this.FactControl_Button.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FactControl_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.FactControl_Button.Location = new System.Drawing.Point(6, 68);
            this.FactControl_Button.Name = "FactControl_Button";
            this.FactControl_Button.Size = new System.Drawing.Size(366, 32);
            this.FactControl_Button.TabIndex = 70;
            this.FactControl_Button.Text = "Фактическое проведение контроля";
            this.FactControl_Button.UseVisualStyleBackColor = false;
            this.FactControl_Button.Click += new System.EventHandler(this.FactControl_Button_Click);
            // 
            // PlanControl_Button
            // 
            this.PlanControl_Button.BackColor = System.Drawing.Color.Silver;
            this.PlanControl_Button.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlanControl_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.PlanControl_Button.Location = new System.Drawing.Point(6, 21);
            this.PlanControl_Button.Name = "PlanControl_Button";
            this.PlanControl_Button.Size = new System.Drawing.Size(366, 32);
            this.PlanControl_Button.TabIndex = 69;
            this.PlanControl_Button.Text = "План проведения контроля";
            this.PlanControl_Button.UseVisualStyleBackColor = false;
            this.PlanControl_Button.Click += new System.EventHandler(this.PlanControl_Button_Click);
            // 
            // Exit_Button
            // 
            this.Exit_Button.BackColor = System.Drawing.Color.Silver;
            this.Exit_Button.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Exit_Button.Location = new System.Drawing.Point(6, 476);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(378, 38);
            this.Exit_Button.TabIndex = 71;
            this.Exit_Button.Text = "Выход";
            this.Exit_Button.UseVisualStyleBackColor = false;
            this.Exit_Button.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(387, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(574, 479);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox3.Controls.Add(this.ReportPFA_Button);
            this.groupBox3.Controls.Add(this.ReportPCP_Button);
            this.groupBox3.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox3.Location = new System.Drawing.Point(6, 347);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(378, 114);
            this.groupBox3.TabIndex = 73;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Отчеты";
            // 
            // ReportPFA_Button
            // 
            this.ReportPFA_Button.BackColor = System.Drawing.Color.Silver;
            this.ReportPFA_Button.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReportPFA_Button.ForeColor = System.Drawing.Color.Green;
            this.ReportPFA_Button.Location = new System.Drawing.Point(6, 68);
            this.ReportPFA_Button.Name = "ReportPFA_Button";
            this.ReportPFA_Button.Size = new System.Drawing.Size(366, 32);
            this.ReportPFA_Button.TabIndex = 70;
            this.ReportPFA_Button.Text = "План-факторный аналаиз";
            this.ReportPFA_Button.UseVisualStyleBackColor = false;
            this.ReportPFA_Button.Click += new System.EventHandler(this.планфакторныйАнализToolStripMenuItem_Click);
            // 
            // ReportPCP_Button
            // 
            this.ReportPCP_Button.BackColor = System.Drawing.Color.Silver;
            this.ReportPCP_Button.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReportPCP_Button.ForeColor = System.Drawing.Color.Green;
            this.ReportPCP_Button.Location = new System.Drawing.Point(6, 21);
            this.ReportPCP_Button.Name = "ReportPCP_Button";
            this.ReportPCP_Button.Size = new System.Drawing.Size(366, 32);
            this.ReportPCP_Button.TabIndex = 69;
            this.ReportPCP_Button.Text = "Параметры планового контроля";
            this.ReportPCP_Button.UseVisualStyleBackColor = false;
            this.ReportPCP_Button.Click += new System.EventHandler(this.параметрыПлановогоКонтроляToolStripMenuItem_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(964, 517);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Garamond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.Text = "Form_Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Main_FormClosed);
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem документыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem материальноответственныеЛицаToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem типыПриборовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem приборыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem планПроведенияКонтроляToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem фактическоеПроведениеКонтроляToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Employees_Button;
        private System.Windows.Forms.Button Apparatus_Button;
        private System.Windows.Forms.Button TypeApparatus_Button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button FactControl_Button;
        private System.Windows.Forms.Button PlanControl_Button;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem параметрыПлановогоКонтроляToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem планфакторныйАнализToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ReportPFA_Button;
        private System.Windows.Forms.Button ReportPCP_Button;
    }
}