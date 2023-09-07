using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Defectoscopy_App
{
    public partial class Form_Auth : Form
    {
        public Form_Auth()
        {
            InitializeComponent();
        }

        //===Константы и переменные формы
        public const int Max_Number_Attempt = 5;        //максимальное число попыток входа в систему
        public static int Number_Attempt;               //число неправильных попыток входа в систему
        public static int User_Rights;                  //права пользователя: 1 - администратор, 2 - обычный пользователь

        //===Обработка события загрузки формы
        private void Form_Auth_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "defectoscopyDataSet.employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.defectoscopyDataSet.employees);
            Number_Attempt = 0;                         //сброс количества попыток входа в систему
        }
        //===Обработка нажатия кнопки "Выход"
        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //===Обработка нажатия кнопки "Войти" (попытка авторизации в системе)
        private void Enter_Button_Click(object sender, EventArgs e)
        {
            var Login_Form_Index = Login_ComboBox.SelectedIndex;     //Выбранный логин (индекс)
            var Password_Form = Password_TextBox.Text.Trim();        //Выбранный пароль
            string Password_Table = Employees_DataGridView.Rows[Login_Form_Index].Cells[4].Value.ToString(); //Пароль из БД
            string Login_Table = Employees_DataGridView.Rows[Login_Form_Index].Cells[3].Value.ToString();    //Логин из БД
            string Login_Text = Login_Table.Trim();                                                          //удаление лишних пробелов слева и справа
            if (Password_Form != Password_Table)  //пароль введен неверно
            {
                Number_Attempt++;  //увеличиваем кол-во неудачных попыток
                if (Number_Attempt == Max_Number_Attempt) //число попыток входа достигло максимума
                {
                    MessageBox.Show("Превышено кол-во попыток входа в систему. Выход из приложения!", "Сообщение об ошибке", MessageBoxButtons.OK);
                    Close(); //Выход из приложения                    
                }
                else
                {
                    MessageBox.Show("Неверный пароль. Осталось попыток: " + Convert.ToString(Max_Number_Attempt - Number_Attempt), "Сообщение об ошибке", MessageBoxButtons.OK);
                    Password_TextBox.Text = ""; //Очистка поля ввода пароля
                }
            }
            else   //пароль введен правильно
            {
                if (Login_Text == "admin")
                {
                    User_Rights = 1;               //права администратора
                }
                else
                {
                    User_Rights = 2;               //обычный пользователь
                }
                Form_Main Form_Main = new Form_Main();
                Form_Main.Show();
                this.Hide(); //скрываем форму входа в приложение                
            }
        }
    }
}
