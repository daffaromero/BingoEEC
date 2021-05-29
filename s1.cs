using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class s1 : Form
    {

        public s1()
        {
            InitializeComponent();
        }

        public int benars1 = 0;
        System.Timers.Timer t;
        int m = 0, s = 60;

        int teamnum;

        private void s1_Load(object sender, EventArgs e)
        {
            t = new System.Timers.Timer();
            t.Interval = 1000; //1s
            t.Elapsed += OnTimeEvent;
            t.Start();
        }

        public int _teamNumInt
        {
            set { teamnum = value; }
        }

        public string _textBox
        {
            set { TeamNumber.Text = value; }
        }

        private void OnTimeEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s -= 1;
                tbTimer.Text = string.Format("{0}:{1}", m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
            }));
        }

        private void btnBenar_Click(object sender, EventArgs e)
        {
            t.Stop();
            s = 60;
            this.benars1 = teamnum;
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            s = 60;
            t.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            t.Stop();
        }

        private void btnSalah_Click(object sender, EventArgs e)
        {
            t.Stop();
            s = 60;
            this.Close();
        }

        private void s1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            t.Stop();
            s = 60;
        }
    }
}
