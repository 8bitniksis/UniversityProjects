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
    public partial class Form_PlanControl : Form
    {
        public Form_PlanControl()
        {
            InitializeComponent();
        }

        private void Form_PlanControl_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "defectoscopyDataSet.apparatus". При необходимости она может быть перемещена или удалена.
            this.apparatusTableAdapter.Fill(this.defectoscopyDataSet.apparatus);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "defectoscopyDataSet.plancontrol". При необходимости она может быть перемещена или удалена.
            this.plancontrolTableAdapter.Fill(this.defectoscopyDataSet.plancontrol);

        }
        //===Обработка нажатия кнопки "Записать" (попытка сохранения изменений в базу данных)
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.plancontrolBindingSource.EndEdit();
                this.plancontrolTableAdapter.Update(this.defectoscopyDataSet.plancontrol);
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
