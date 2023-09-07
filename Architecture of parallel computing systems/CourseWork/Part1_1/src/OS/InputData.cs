using System;
using System.Drawing;
using System.Windows.Forms;

namespace OS
{
    public partial class InputData : Form
    {
        public static int mQuantumTime;
        public static int[] mBurstsTime;
        public static int[] mArrivalsTime;
        public static int[] mPrioritys;
        public static int[] mCriticalsTime;

        private NumericUpDown[] arrival;
        private NumericUpDown[] burst;
        private NumericUpDown[] priority;
        private NumericUpDown[] critical;

        private readonly int mWidthOffset = 60;

        public InputData()
        {
            Initialize();
        }

        private void Initialize()
        {
            InitializeComponent();
            InitializeData();
            InitializeNames();
            InitializeArrivalsTime();
            InitializeBurstsTime();
            InitializeCriticalTime();
            InitializePriority();
        }

        private void InitializeData()
        {
            arrival = new NumericUpDown[Form_process.no_of_process+1];
            burst = new NumericUpDown[Form_process.no_of_process+1];
            priority = new NumericUpDown[Form_process.no_of_process+1];
            critical = new NumericUpDown[Form_process.no_of_process+1];

            mBurstsTime = new int[Form_process.no_of_process + 1];
            mArrivalsTime = new int[Form_process.no_of_process + 1];
            mPrioritys = new int[Form_process.no_of_process + 1];
            mCriticalsTime = new int[Form_process.no_of_process + 1];
        }

        private void InitializeNames()
        {
            Label old_lb = new Label();
            old_lb = this.processNames;
            old_lb.Visible = true;
            int y = mWidthOffset;
            for (int i = 1; i < Form_process.no_of_process; i++)
            {
                Label new_lb = new Label();
                new_lb.Size = old_lb.Size;
                new_lb.Location = new Point(old_lb.Location.X , old_lb.Location.Y + y);
                int x = i + 1;
                new_lb.Text = "Process:" + x;
                new_lb.Font = old_lb.Font;
                new_lb.BackColor = old_lb.BackColor;
                new_lb.TextAlign = old_lb.TextAlign;
                new_lb.Visible=true;
                this.groupBox_processDetail.Controls.Add(new_lb);
                y = y + mWidthOffset;
            }
        }

        private void InitializeArrivalsTime()
        {
            NumericUpDown num_old = new NumericUpDown();
            num_old = this.arrivalTimesNummeric;
            num_old.Enabled = true;
            int y = mWidthOffset;
            arrival[0] = this.arrivalTimesNummeric;
            for (int i = 1; i < Form_process.no_of_process; i++)
            {
                NumericUpDown num = new NumericUpDown();
                num.Size = num_old.Size;
                num.Minimum = num_old.Minimum;
                num.Maximum = num_old.Maximum;
                num.TextAlign = num_old.TextAlign;
                num.Location = new Point(num_old.Location.X,num_old.Location.Y+y);
                num.Enabled = num_old.Enabled;
                num.Name = "ArrivalTime" + (i + 1).ToString();
                num.BackColor = num_old.BackColor;
                num.Font = num_old.Font;
                arrival[i] = num;
                this.groupBox_processDetail.Controls.Add(num);
                y = y + mWidthOffset;
            }
        }

        private void InitializeBurstsTime()
        {
            NumericUpDown num_old = new NumericUpDown();
            num_old = this.burstTimesNummeric;
            num_old.Enabled = true;
            int y = mWidthOffset;
            burst[0] = this.burstTimesNummeric;
            for (int i = 1; i < Form_process.no_of_process; i++)
            {
                NumericUpDown num = new NumericUpDown();
                num.Size = num_old.Size;
                num.Minimum = num_old.Minimum;
                num.Maximum = num_old.Maximum;
                num.Location = new Point(num_old.Location.X, num_old.Location.Y + y);
                num.Enabled = num_old.Enabled;
                num.Name = "ProcessBurst" + (i + 1).ToString();
                num.BackColor = num_old.BackColor;
                num.Font = num_old.Font;
                burst[i] = num;
                this.groupBox_processDetail.Controls.Add(num);
                y = y + mWidthOffset;
            }
        }

        private void InitializeCriticalTime()
        {
            NumericUpDown num_old = new NumericUpDown();
            num_old = this.criticalTimesNummeric;
            num_old.Enabled = true;
            int y = mWidthOffset;
            critical[0] = this.criticalTimesNummeric;
            for (int i = 1; i < Form_process.no_of_process; i++)
            {
                NumericUpDown num = new NumericUpDown();
                num.Size = num_old.Size;
                num.Minimum = num_old.Minimum;
                num.Maximum = num_old.Maximum;
                num.TextAlign = num_old.TextAlign;
                num.Location = new Point(num_old.Location.X, num_old.Location.Y + y);
                num.Enabled = num_old.Enabled;
                num.Name = "CriticalTime" + (i + 1).ToString();
                num.BackColor = num_old.BackColor;
                num.Font = num_old.Font;
                critical[i] = num;
                this.groupBox_processDetail.Controls.Add(num);
                y = y + mWidthOffset;
            }
        }

        private void InitializePriority()
        {
            NumericUpDown num_old = new NumericUpDown();
            num_old = this.priorityTimesNummeric;
            num_old.Enabled = true;
            int y = mWidthOffset;
            priority[0] = this.priorityTimesNummeric;
            for (int i = 1; i < Form_process.no_of_process; i++)
            {
                NumericUpDown num = new NumericUpDown();
                num.Size = num_old.Size;
                num.Minimum = num_old.Minimum;
                num.Maximum = num_old.Maximum;
                num.TextAlign = num_old.TextAlign;
                num.Location = new Point(num_old.Location.X, num_old.Location.Y + y);
                num.Enabled = num_old.Enabled;
                num.Name = "Priority" + (i + 1).ToString();
                num.BackColor = num_old.BackColor;
                num.Font = num_old.Font;
                priority[i] = num;
                this.groupBox_processDetail.Controls.Add(num);
                y = y + mWidthOffset;
            }
        }
        
        private void SetDataArrays()
        {
            for (int i = 0; i < Form_process.no_of_process; i++)
            {
                mArrivalsTime[i] = (int)arrival[i].Value;
                mBurstsTime[i] = (int)burst[i].Value;
                mPrioritys[i] = (int)priority[i].Value;
                mCriticalsTime[i] = (int)critical[i].Value;
            }
            mQuantumTime = (int)this.quantTimeNummeric.Value;
        }

        //Back button
        private void backButton_Click(object sender, EventArgs e)
        {
            Form_process form2 = new Form_process();
            form2.Show();
            form2.Location = this.Location;
            Hide();
        }

        //Next button
        private void nextButton_Click(object sender, EventArgs e)
        {
            SetDataArrays();
            Results R = new Results();
            R.Show();
            this.Hide();
        }
    }
}
