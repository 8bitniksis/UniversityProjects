using CPUScheduling_Sim.Source;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CPUScheduling_Sim
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // A process
            /*Scheduler.Processes.Add(new Process { PID = 1, ArriveTime = TimeSpan.Zero, CPUTime = TimeSpan.FromMilliseconds(40), Priority = 1,                   CriticalTime = TimeSpan.FromMilliseconds(140) });
            Scheduler.Processes.Add(new Process { PID = 2, ArriveTime = TimeSpan.FromMilliseconds(140), CPUTime = TimeSpan.FromMilliseconds(40), Priority = 1,  CriticalTime = TimeSpan.FromMilliseconds(280) });
            Scheduler.Processes.Add(new Process { PID = 3, ArriveTime = TimeSpan.FromMilliseconds(280), CPUTime = TimeSpan.FromMilliseconds(40), Priority = 1,  CriticalTime = TimeSpan.FromMilliseconds(420) });
            Scheduler.Processes.Add(new Process { PID = 4, ArriveTime = TimeSpan.FromMilliseconds(420), CPUTime = TimeSpan.FromMilliseconds(40), Priority = 1,  CriticalTime = TimeSpan.FromMilliseconds(560) });
            Scheduler.Processes.Add(new Process { PID = 5, ArriveTime = TimeSpan.FromMilliseconds(560), CPUTime = TimeSpan.FromMilliseconds(40), Priority = 1,  CriticalTime = TimeSpan.FromMilliseconds(700) });

            // B process
            Scheduler.Processes.Add(new Process { PID = 6, ArriveTime = TimeSpan.FromMilliseconds(0), CPUTime = TimeSpan.FromMilliseconds(100), Priority = 0,   CriticalTime = TimeSpan.FromMilliseconds(350) });
            Scheduler.Processes.Add(new Process { PID = 7, ArriveTime = TimeSpan.FromMilliseconds(350), CPUTime = TimeSpan.FromMilliseconds(100), Priority = 0, CriticalTime = TimeSpan.FromMilliseconds(700) });*/
            Scheduler.Processes.Add(new Process { PID = 0, ArriveTime = TimeSpan.FromMilliseconds(80), CPUTime = TimeSpan.FromMilliseconds(160), Priority = 0, CriticalTime = TimeSpan.FromMilliseconds(880) });
            Scheduler.Processes.Add(new Process { PID = 1, ArriveTime = TimeSpan.FromMilliseconds(160), CPUTime = TimeSpan.FromMilliseconds(160), Priority = 0, CriticalTime = TimeSpan.FromMilliseconds(160) });
            Scheduler.Processes.Add(new Process { PID = 2, ArriveTime = TimeSpan.FromMilliseconds(320), CPUTime = TimeSpan.FromMilliseconds(160), Priority = 0, CriticalTime = TimeSpan.FromMilliseconds(400) });
            Scheduler.Processes.Add(new Process { PID = 3, ArriveTime = TimeSpan.FromMilliseconds(400), CPUTime = TimeSpan.FromMilliseconds(160), Priority = 0, CriticalTime = TimeSpan.FromMilliseconds(720) });
            Scheduler.Processes.Add(new Process { PID = 4, ArriveTime = TimeSpan.FromMilliseconds(480), CPUTime = TimeSpan.FromMilliseconds(160), Priority = 0, CriticalTime = TimeSpan.FromMilliseconds(560) });

            DataContext = this;
            processTable.ItemsSource = Scheduler.Processes;
        }

        void Calculate()
        {
            if (algothimsCB.SelectedIndex == 0)
                return;

            if (Scheduler.Processes.Count == 0)
                return;

            Algorithm algorithm = (Algorithm)algothimsCB.SelectedIndex;

            if(algorithm == Algorithm.ROUND_ROBIN)
            {
                timeQuantum.Visibility = Visibility.Visible;
                timeQuantum.Focus();

                int quantum;
                if(!int.TryParse(timeQuantum.Text, out quantum) || quantum == 0)
                {
                    return;
                }
                Scheduler.TimeQuantum = TimeSpan.FromMilliseconds(quantum);
            }
            else
                timeQuantum.Visibility = Visibility.Hidden;

            try
            {
                var processes = Scheduler.ScheduleProcesses(algorithm);

                if (processStack.Children.Count > 0)
                    processStack.Children.Clear();

                var chart = Chart.GenerateChart(processStack, processes);
                foreach (var item in chart)
                    processStack.Children.Add(item);

                avgWaitingTime.Text = $"Average Waiting Time: {processes.AverageWaitingTime.TotalMilliseconds}ms";
                avgTurnAroundTime.Text = $"Average Turn Around Time: { processes.AverageTurnAroundTime.TotalMilliseconds}ms";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void addProcess_Click(object sender, RoutedEventArgs e)
        {            
            arriveTimeTB.Text = criticalTimeTB.Text = cpuTimeTB.Text = priorityTB.Text = string.Empty;
            addDialogBox.IsOpen = true;
        }

        private void dialog_AddProcess_Click(object sender, RoutedEventArgs e)
        {
            AddProcess();
        }
        void AddProcess()
        {
            float arriveTime, cpuTime, criticalTime;
            int priority;

            if (!float.TryParse(arriveTimeTB.Text, out arriveTime) || arriveTime < 0)
            {
                MessageBox.Show("Arrive Time is invalid");
                return;
            }
            if (!float.TryParse(cpuTimeTB.Text, out cpuTime) || cpuTime < 0)
            {
                MessageBox.Show("CPU Time is invalid");
                return;
            }
            if (!int.TryParse(priorityTB.Text, out priority) || priority < 0)
            {
                MessageBox.Show("Priority is invalid");
                return;
            }
            if (!float.TryParse(criticalTimeTB.Text, out criticalTime) || criticalTime < 0)
            {
                MessageBox.Show("Critical Time is invalid");
                return;
            }

            Process process = new Process
            {
                PID = Scheduler.Processes.Count > 0 ? Scheduler.Processes[Scheduler.Processes.Count - 1].PID + 1 : 1,
                ArriveTime = TimeSpan.FromMilliseconds(arriveTime),
                CPUTime = TimeSpan.FromMilliseconds(cpuTime),
                Priority = priority,
                CriticalTime = TimeSpan.FromMilliseconds(criticalTime)
            };
            Scheduler.Processes.Add(process);

            processTable.Items.Refresh();
            Calculate();

            addDialogBox.IsOpen = false;

        }
        private void dialog_Cancel_Click(object sender, RoutedEventArgs e)
        {
            addDialogBox.IsOpen = false;
        }

        private void algothimsCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Calculate();
        }

        private void clearBtn_Click(object sender, RoutedEventArgs e)
        {
            Scheduler.Processes.Clear();

            processTable.Items.Refresh();

            if (processStack.Children.Count > 0)
                processStack.Children.Clear();

            avgWaitingTime.Text = "Average Waiting Time:";
            avgTurnAroundTime.Text = "Average Turn Around Time:";
            
        }

        private void processTable_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            var selectedIndex = processTable.SelectedIndex;
            if (e.Key != Key.Delete || selectedIndex < 0)
                return;

            Scheduler.Processes.RemoveAt(selectedIndex);

            processTable.Items.Refresh();
            Calculate();
        }

        private void addBtn_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
                AddProcess();
        }

        private void timeQuantum_TextChanged(object sender, TextChangedEventArgs e)
        {
            Calculate();
        }
    }
}
