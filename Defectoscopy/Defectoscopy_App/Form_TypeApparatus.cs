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
    public partial class Form_TypeApparatus : Form
    {
        public Form_TypeApparatus()
        {
            InitializeComponent();
        }

        private void Form_TypeApparatus_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "defectoscopyDataSet.typeapparatus". При необходимости она может быть перемещена или удалена.
            this.typeapparatusTableAdapter.Fill(this.defectoscopyDataSet.typeapparatus);

        }
        //===Обработка нажатия кнопки "Записать" (попытка сохранения изменений в базе данных)
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.typeapparatusBindingSource.EndEdit();
                this.typeapparatusTableAdapter.Update(this.defectoscopyDataSet.typeapparatus);
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
