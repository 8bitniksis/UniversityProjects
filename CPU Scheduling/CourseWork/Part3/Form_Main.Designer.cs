
namespace DeadLocks_App
{
    partial class Form_Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Graph_DataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.Resources_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.Processes_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Results_TextBox = new System.Windows.Forms.TextBox();
            this.Check_Button = new System.Windows.Forms.Button();
            this.Del_Button = new System.Windows.Forms.Button();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Graph_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Resources_NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Processes_NumericUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Graph_DataGridView);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Resources_NumericUpDown);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Processes_NumericUpDown);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 503);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Исходные данные";
            // 
            // Graph_DataGridView
            // 
            this.Graph_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Graph_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Graph_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.Graph_DataGridView.Location = new System.Drawing.Point(6, 180);
            this.Graph_DataGridView.Name = "Graph_DataGridView";
            this.Graph_DataGridView.Size = new System.Drawing.Size(546, 313);
            this.Graph_DataGridView.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Номер ресурса";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Занимает ресурс";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Требует ресурс";
            this.Column3.Name = "Column3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(134, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Граф процессов и ресурсов";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // Resources_NumericUpDown
            // 
            this.Resources_NumericUpDown.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Resources_NumericUpDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Resources_NumericUpDown.Location = new System.Drawing.Point(183, 88);
            this.Resources_NumericUpDown.Name = "Resources_NumericUpDown";
            this.Resources_NumericUpDown.Size = new System.Drawing.Size(369, 26);
            this.Resources_NumericUpDown.TabIndex = 3;
            this.Resources_NumericUpDown.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.Resources_NumericUpDown.ValueChanged += new System.EventHandler(this.Resources_NumericUpDown_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(6, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Количество ресурсов :";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // Processes_NumericUpDown
            // 
            this.Processes_NumericUpDown.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Processes_NumericUpDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Processes_NumericUpDown.Location = new System.Drawing.Point(183, 40);
            this.Processes_NumericUpDown.Name = "Processes_NumericUpDown";
            this.Processes_NumericUpDown.Size = new System.Drawing.Size(369, 26);
            this.Processes_NumericUpDown.TabIndex = 1;
            this.Processes_NumericUpDown.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.Processes_NumericUpDown.ValueChanged += new System.EventHandler(this.Processes_NumericUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество процессов :";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Results_TextBox);
            this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(576, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(601, 330);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результаты работы";
            // 
            // Results_TextBox
            // 
            this.Results_TextBox.ForeColor = System.Drawing.Color.Purple;
            this.Results_TextBox.Location = new System.Drawing.Point(6, 25);
            this.Results_TextBox.Multiline = true;
            this.Results_TextBox.Name = "Results_TextBox";
            this.Results_TextBox.ReadOnly = true;
            this.Results_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Results_TextBox.Size = new System.Drawing.Size(589, 299);
            this.Results_TextBox.TabIndex = 0;
            // 
            // Check_Button
            // 
            this.Check_Button.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Check_Button.ForeColor = System.Drawing.Color.Teal;
            this.Check_Button.Location = new System.Drawing.Point(576, 360);
            this.Check_Button.Name = "Check_Button";
            this.Check_Button.Size = new System.Drawing.Size(601, 40);
            this.Check_Button.TabIndex = 2;
            this.Check_Button.Text = "Обнаружение взаимных блокировок процессов";
            this.Check_Button.UseVisualStyleBackColor = true;
            this.Check_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Del_Button
            // 
            this.Del_Button.Enabled = false;
            this.Del_Button.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Del_Button.ForeColor = System.Drawing.Color.Teal;
            this.Del_Button.Location = new System.Drawing.Point(576, 418);
            this.Del_Button.Name = "Del_Button";
            this.Del_Button.Size = new System.Drawing.Size(601, 40);
            this.Del_Button.TabIndex = 3;
            this.Del_Button.Text = "Удаление взаимных блокировок процессов";
            this.Del_Button.UseVisualStyleBackColor = true;
            this.Del_Button.Click += new System.EventHandler(this.Del_Button_Click);
            // 
            // Exit_Button
            // 
            this.Exit_Button.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Exit_Button.Location = new System.Drawing.Point(576, 475);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(601, 40);
            this.Exit_Button.TabIndex = 4;
            this.Exit_Button.Text = "Выход";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1189, 522);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.Del_Button);
            this.Controls.Add(this.Check_Button);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form_Main";
            this.Text = "Взаимные блокировки процессов в в вычислительной системе при наличии одного ресур" +
    "са каждого типа";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Graph_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Resources_NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Processes_NumericUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown Resources_NumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Processes_NumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Graph_DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Check_Button;
        private System.Windows.Forms.TextBox Results_TextBox;
        private System.Windows.Forms.Button Del_Button;
        private System.Windows.Forms.Button Exit_Button;
    }
}

