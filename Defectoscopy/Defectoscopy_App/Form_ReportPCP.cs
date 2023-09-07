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
    public partial class Form_ReportPCP : Form
    {
        public Form_ReportPCP()
        {
            InitializeComponent();
        }
        //===Обработка события загрузки формы
        private void Form_ReportPCP_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "defectoscopyDataSet1.apparatus". При необходимости она может быть перемещена или удалена.
            this.apparatusTableAdapter.Fill(this.defectoscopyDataSet1.apparatus);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "defectoscopyDataSet1.planapparatus". При необходимости она может быть перемещена или удалена.
            this.planapparatusTableAdapter.Fill(this.defectoscopyDataSet1.planapparatus);
            planapparatusBindingSource.Filter = "";
            string apparatus_str = "nameapparatus Like " + "'%" + Apparatus_ComboBox.Text + "%'";
            planapparatusBindingSource.Filter = apparatus_str;
        }
        //===Обработка нажатия кнопки "Закрыть"
        private void Close_Button_Click(object sender, EventArgs e)
        {
            Close();
        }
        //===Обработка нажатия кнопки "Показать результаты"
        private void button1_Click(object sender, EventArgs e)
        {
            planapparatusBindingSource.Filter = "";
            string apparatus_str = "nameapparatus Like " + "'%" + Apparatus_ComboBox.Text + "%'";
            planapparatusBindingSource.Filter = apparatus_str;
        }
    }
}
