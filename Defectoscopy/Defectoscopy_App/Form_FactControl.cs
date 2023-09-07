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
    public partial class Form_FactControl : Form
    {
        public Form_FactControl()
        {
            InitializeComponent();
        }

        private void Form_FactControl_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "defectoscopyDataSet.employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.defectoscopyDataSet.employees);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "defectoscopyDataSet.plancontrol". При необходимости она может быть перемещена или удалена.
            this.plancontrolTableAdapter.Fill(this.defectoscopyDataSet.plancontrol);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "defectoscopyDataSet.factcontrol". При необходимости она может быть перемещена или удалена.
            this.factcontrolTableAdapter.Fill(this.defectoscopyDataSet.factcontrol);

        }
        //===Обработка нажатия кнопки "Записать" (попытка сохранения изменений в базу данных)
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.factcontrolBindingSource.EndEdit();
                this.factcontrolTableAdapter.Update(this.defectoscopyDataSet.factcontrol);
                MessageBox.Show("Данные записаны!", "Операция прошла успешно", MessageBoxButtons.OK);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Невозможно записать данные", "Сообщение об ошибке", MessageBoxButtons.OK);
            }
        }
        //===Обработка нажатия кнопки "Закрыть"
        private void Close_Button_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                MessageBox.Show("Добавленно новое поле для данных в БД!", "Операция прошла успешно", MessageBoxButtons.OK);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Невозможно добавить новое поле для данных", "Сообщение об ошибке", MessageBoxButtons.OK);
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                MessageBox.Show("Данные удаленны!", "Операция прошла успешно", MessageBoxButtons.OK);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Невозможно удалить данные", "Сообщение об ошибке", MessageBoxButtons.OK);
            }
        }
    }
}
