using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeadLocks_App
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        //===Константы программы
        const int PR_Max = 100;                                          //максимальная размерность матрицы графа            
        //===Переменные программы
        public static int Processes_Count;                               //кол-во процессов в ВС
        public static int Resources_Count;                               //кол-во ресурсов в ВС 
        public static int PR;                                            //реальная размерность матрицы смежности графа
        public static int[,] Adjacency_Matrix = new int[PR_Max, PR_Max]; //матрица смежности графа

        //===Обработка события загрузки формы
        private void Form_Main_Load(object sender, EventArgs e)
        {
            Processes_Count = Convert.ToInt32(Processes_NumericUpDown.Value); //кол-во процессов в ВС
            Resources_Count = Convert.ToInt32(Resources_NumericUpDown.Value); //кол-во ресурсов в ВС
            PR = Processes_Count + Resources_Count;                      //размерность матрицы смежности
            Func_MatrZeros();                                            //обнуление элементов матрицы
            Graph_DataGridView.Rows.Clear();                             //очистка графа       
            Graph_DataGridView.RowCount = Processes_Count;               //кол-во строк в графе
            for (int i = 0; i < Graph_DataGridView.RowCount; i++)
            {
                Graph_DataGridView.Rows[i].Cells[0].Value = i + 1;
            }
        }

        //===Функция обнуления элементов матрицы смежности
        public void Func_MatrZeros()
        {
            for (int i = 0; i < PR; i++)
            {
                for (int j = 0; j < PR; j++)
                {
                    Adjacency_Matrix[i, j] = 0;
                }
            }
        }
        //===Обработка события изменения количества процессов
        private void Processes_NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Processes_Count = Convert.ToInt32(Processes_NumericUpDown.Value); //кол-во процессов в ВС
            Resources_Count = Convert.ToInt32(Resources_NumericUpDown.Value); //кол-во ресурсов в ВС
            PR = Processes_Count + Resources_Count;                      //размерность матрицы смежности            
            Graph_DataGridView.Rows.Clear();                             //очистка графа       
            Graph_DataGridView.RowCount = Processes_Count;               //кол-во строк в графе
            for (int i = 0; i < Graph_DataGridView.RowCount; i++)
            {
                Graph_DataGridView.Rows[i].Cells[0].Value = i + 1;
            }
        }
        //===Обработка события изменения количества ресурсов
        private void Resources_NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Processes_Count = Convert.ToInt32(Processes_NumericUpDown.Value); //кол-во процессов в ВС
            Resources_Count = Convert.ToInt32(Resources_NumericUpDown.Value); //кол-во ресурсов в ВС
            PR = Processes_Count + Resources_Count;                      //размерность матрицы смежности            
        }
        //===Обработка нажатия кнопки "Обнаружение взаимных блокировок процессов"
        private void button1_Click(object sender, EventArgs e)
        {
            Results_TextBox.Clear();                                     //очистка окна результатов
            Func_MatrZeros();                                            //обнуление элементов матрицы
            MyOrientedGraph my_graph = new MyOrientedGraph(PR);          //добавление графа             
            //Формирование графа (матрицы смежности)
            for (int i = 0; i < Graph_DataGridView.RowCount - 1; i++)
            {
                if (Graph_DataGridView.Rows[i].Cells[1].Value != "")  //заполнение занимаемых процессами ресурсов
                {
                    int temp_From = Processes_Count + Convert.ToInt32(Graph_DataGridView.Rows[i].Cells[1].Value);
                    int temp_To = Convert.ToInt32(Graph_DataGridView.Rows[i].Cells[0].Value);
                    //Adjacency_Matrix[temp_From, temp_To] = 1;
                    my_graph.addEdge(temp_From - 1, temp_To - 1);
                }
                if (Graph_DataGridView.Rows[i].Cells[2].Value != "")  //заполнение требуемых процессами ресурсов
                {
                    int temp_To = Processes_Count + Convert.ToInt32(Graph_DataGridView.Rows[i].Cells[2].Value);
                    int temp_From = Convert.ToInt32(Graph_DataGridView.Rows[i].Cells[0].Value);
                    //Adjacency_Matrix[temp_From + 1, temp_To + 2] = 1;
                    my_graph.addEdge(temp_From - 1, temp_To - 1);
                }
            }
           
           
            // вызов метода определения циклов
            if (my_graph.isCyclicResult())
            {
                Results_TextBox.Text += "Взаимные блокировки процессов найдены!" + Environment.NewLine;
                Del_Button.Enabled = true;
            }
            else
            {
                Results_TextBox.Text += "Взаимные блокировки процессов не найдены!" + Environment.NewLine;
                Results_TextBox.Text += "Все процессы успешно выполнены!" + Environment.NewLine;
                Del_Button.Enabled = false;
            }


        }

        //===Функция поиска всех циклов в глубину
        IEnumerable<Stack<int>> Func_FindAllCycles(int[,] edg_arr, int curr_v, HashSet<int> vis_alr, Stack<int> curr_p)
        {
            if (vis_alr.Contains(curr_v))
            {
                var res = new Stack<int>();
                res.Push(curr_v);
                foreach (var vert in curr_p)
                {
                    res.Push(vert);
                    // обнаружение пути только до начала цикла
                    if (vert == curr_v) break;
                }

                yield return res;
            }
            else
            {
                vis_alr.Add(curr_v);
                curr_p.Push(curr_v);

                for (int i = 0; i < edg_arr.GetLength(1); i++)
                    if (curr_v != i && edg_arr[curr_v, i] == 1)
                        foreach (var cycle in Func_FindAllCycles(edg_arr, i, vis_alr, curr_p)) yield return cycle;

                vis_alr.Remove(curr_v);
                curr_p.Pop();
            }
        }
        //===Обработка события нажатия кнопки "Удалить взаимные блокировки"
        private void Del_Button_Click(object sender, EventArgs e)
        {
            //TODO:Delete only row there get deadlocks
            Graph_DataGridView.Rows.Clear();
            Results_TextBox.Text += "Взаимные блокировки процессов удалены!" + Environment.NewLine;
            Results_TextBox.Text += "Заполните заново матрицу!" + Environment.NewLine;
            Del_Button.Enabled = false;
        }
        //===Обработка события нажатия кнопки "Выход"
        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
