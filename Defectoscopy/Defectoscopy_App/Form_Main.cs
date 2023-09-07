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
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }
        //===Обработка события закрытия формы
        private void Form_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_Auth Form_Auth = new Form_Auth();
            Form_Auth.Close();
            Application.Exit();
        }
        //===Обработка выбора пункта меню "Справочники -> Материально ответственные лица"
        private void материальноответственныеЛицаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Employees Form_Employees = new Form_Employees();
            Form_Employees.ShowDialog();
        }
        //===Обработка выбора пункта меню "Справочники -> Типы приборов"
        private void типыПриборовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_TypeApparatus Form_TypeApparatus = new Form_TypeApparatus();
            Form_TypeApparatus.ShowDialog();
        }
        //===Обработка выбора пункта меню "Справочники -> Приборы"
        private void приборыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Apparatus Form_Apparatus = new Form_Apparatus();
            Form_Apparatus.ShowDialog();
        }
        //===Обработка выбора пункта меню "Документы -> Планы проведения контроля"
        private void планПроведенияКонтроляToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_PlanControl Form_PlanControl = new Form_PlanControl();
            Form_PlanControl.ShowDialog();
        }
        
        //===Обработка выбора пункта меню "О программе"
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_About Form_About = new Form_About();
            Form_About.ShowDialog();
        }
        //===Обработка выбора пункта меню "Выход"
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //===Обработка выбора пункта меню "Отчеты -> Параметры планового контроля"
        private void параметрыПлановогоКонтроляToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ReportPCP Form_ReportPCP = new Form_ReportPCP();
            Form_ReportPCP.ShowDialog();
        }
        //===Обработка выбора пункта меню "Отчеті -> План-факторный анализ"
        private void планфакторныйАнализToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ReportPFA Form_ReportPFA = new Form_ReportPFA();
            Form_ReportPFA.ShowDialog();
        }
        //===Обработка события загрузки формы
        private void Form_Main_Load(object sender, EventArgs e)
        {
            if (Form_Auth.User_Rights != 1)  //зашел не администратор
            {
                справочникиToolStripMenuItem.Enabled = false;
                groupBox1.Enabled = false;
            }
        }

        //===Обработка выбора пункта меню "Документы -> Планы проведения контроля"
        private void PlanControl_Button_Click(object sender, EventArgs e)
        {
            Form_PlanControl Form_PlanControl = new Form_PlanControl();
            Form_PlanControl.ShowDialog();
        }

        //===Обработка выбора пункта меню "Фактическое проведение контроля"
        private void FactControl_Button_Click(object sender, EventArgs e)
        {
            Form_FactControl Form_FactControl = new Form_FactControl();
            Form_FactControl.ShowDialog();
        }
    }
}
