
namespace Defectoscopy_App
{
    partial class Form_Auth
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Auth));
            this.Exit_Button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Enter_Button = new System.Windows.Forms.Button();
            this.Password_TextBox = new System.Windows.Forms.TextBox();
            this.Login_ComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Employees_DataGridView = new System.Windows.Forms.DataGridView();
            this.defectoscopyDataSet = new Defectoscopy_App.defectoscopyDataSet();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new Defectoscopy_App.defectoscopyDataSetTableAdapters.employeesTableAdapter();
            this.idemployeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameemployeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionemployeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginemployeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordemployeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Employees_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defectoscopyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit_Button
            // 
            this.Exit_Button.BackColor = System.Drawing.Color.Silver;
            this.Exit_Button.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit_Button.ForeColor = System.Drawing.Color.Maroon;
            this.Exit_Button.Location = new System.Drawing.Point(168, 118);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(163, 32);
            this.Exit_Button.TabIndex = 63;
            this.Exit_Button.Text = "Выход";
            this.Exit_Button.UseVisualStyleBackColor = false;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 62;
            this.label3.Text = "Пароль :";
            // 
            // Enter_Button
            // 
            this.Enter_Button.BackColor = System.Drawing.Color.Silver;
            this.Enter_Button.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Enter_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Enter_Button.Location = new System.Drawing.Point(1, 118);
            this.Enter_Button.Name = "Enter_Button";
            this.Enter_Button.Size = new System.Drawing.Size(163, 32);
            this.Enter_Button.TabIndex = 61;
            this.Enter_Button.Text = "Войти";
            this.Enter_Button.UseVisualStyleBackColor = false;
            this.Enter_Button.Click += new System.EventHandler(this.Enter_Button_Click);
            // 
            // Password_TextBox
            // 
            this.Password_TextBox.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password_TextBox.Location = new System.Drawing.Point(116, 55);
            this.Password_TextBox.Name = "Password_TextBox";
            this.Password_TextBox.PasswordChar = '*';
            this.Password_TextBox.Size = new System.Drawing.Size(215, 25);
            this.Password_TextBox.TabIndex = 60;
            // 
            // Login_ComboBox
            // 
            this.Login_ComboBox.BackColor = System.Drawing.Color.Silver;
            this.Login_ComboBox.DataSource = this.employeesBindingSource;
            this.Login_ComboBox.DisplayMember = "loginemployee";
            this.Login_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Login_ComboBox.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login_ComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Login_ComboBox.FormattingEnabled = true;
            this.Login_ComboBox.Location = new System.Drawing.Point(116, 6);
            this.Login_ComboBox.Name = "Login_ComboBox";
            this.Login_ComboBox.Size = new System.Drawing.Size(215, 26);
            this.Login_ComboBox.TabIndex = 59;
            this.Login_ComboBox.ValueMember = "idemployee";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 58;
            this.label1.Text = "Логин :";
            // 
            // Employees_DataGridView
            // 
            this.Employees_DataGridView.AutoGenerateColumns = false;
            this.Employees_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Employees_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Employees_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idemployeeDataGridViewTextBoxColumn,
            this.nameemployeeDataGridViewTextBoxColumn,
            this.positionemployeeDataGridViewTextBoxColumn,
            this.loginemployeeDataGridViewTextBoxColumn,
            this.passwordemployeeDataGridViewTextBoxColumn});
            this.Employees_DataGridView.DataSource = this.employeesBindingSource;
            this.Employees_DataGridView.Location = new System.Drawing.Point(116, 86);
            this.Employees_DataGridView.Name = "Employees_DataGridView";
            this.Employees_DataGridView.Size = new System.Drawing.Size(40, 22);
            this.Employees_DataGridView.TabIndex = 64;
            this.Employees_DataGridView.Visible = false;
            // 
            // defectoscopyDataSet
            // 
            this.defectoscopyDataSet.DataSetName = "defectoscopyDataSet";
            this.defectoscopyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "employees";
            this.employeesBindingSource.DataSource = this.defectoscopyDataSet;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // idemployeeDataGridViewTextBoxColumn
            // 
            this.idemployeeDataGridViewTextBoxColumn.DataPropertyName = "idemployee";
            this.idemployeeDataGridViewTextBoxColumn.HeaderText = "idemployee";
            this.idemployeeDataGridViewTextBoxColumn.Name = "idemployeeDataGridViewTextBoxColumn";
            // 
            // nameemployeeDataGridViewTextBoxColumn
            // 
            this.nameemployeeDataGridViewTextBoxColumn.DataPropertyName = "nameemployee";
            this.nameemployeeDataGridViewTextBoxColumn.HeaderText = "nameemployee";
            this.nameemployeeDataGridViewTextBoxColumn.Name = "nameemployeeDataGridViewTextBoxColumn";
            // 
            // positionemployeeDataGridViewTextBoxColumn
            // 
            this.positionemployeeDataGridViewTextBoxColumn.DataPropertyName = "positionemployee";
            this.positionemployeeDataGridViewTextBoxColumn.HeaderText = "positionemployee";
            this.positionemployeeDataGridViewTextBoxColumn.Name = "positionemployeeDataGridViewTextBoxColumn";
            // 
            // loginemployeeDataGridViewTextBoxColumn
            // 
            this.loginemployeeDataGridViewTextBoxColumn.DataPropertyName = "loginemployee";
            this.loginemployeeDataGridViewTextBoxColumn.HeaderText = "loginemployee";
            this.loginemployeeDataGridViewTextBoxColumn.Name = "loginemployeeDataGridViewTextBoxColumn";
            // 
            // passwordemployeeDataGridViewTextBoxColumn
            // 
            this.passwordemployeeDataGridViewTextBoxColumn.DataPropertyName = "passwordemployee";
            this.passwordemployeeDataGridViewTextBoxColumn.HeaderText = "passwordemployee";
            this.passwordemployeeDataGridViewTextBoxColumn.Name = "passwordemployeeDataGridViewTextBoxColumn";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(337, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(598, 155);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Employees_DataGridView);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Enter_Button);
            this.Controls.Add(this.Password_TextBox);
            this.Controls.Add(this.Login_ComboBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Garamond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Auth";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Form_Auth_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Employees_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defectoscopyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Enter_Button;
        private System.Windows.Forms.TextBox Password_TextBox;
        private System.Windows.Forms.ComboBox Login_ComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Employees_DataGridView;
        private defectoscopyDataSet defectoscopyDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private defectoscopyDataSetTableAdapters.employeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idemployeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameemployeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionemployeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginemployeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordemployeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

