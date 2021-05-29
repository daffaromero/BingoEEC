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
    public partial class s38 : Form
    {
        public s38()
        {
            InitializeComponent();
        }

        public int benar = 0;
        System.Timers.Timer t;
        int m = 0, s = 120;

        int teamnum;

        public int _teamNumInt
        {
            set { teamnum = value; }
        }

        public string _textBox
        {
            set { TeamNumber.Text = value; }
        }

        private void s38_Load(object sender, EventArgs e)
        {
            t = new System.Timers.Timer();
            t.Interval = 1000; //1s
            t.Elapsed += OnTimeEvent;
            t.Start();
        }

        private void OnTimeEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s -= 1;
                tbTimer.Text = s.ToString();
            }));
        }

        private void btnBenar_Click(object sender, EventArgs e)
        {
            t.Stop();
            s = 120;
            this.benar = teamnum;
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            s = 120;
            t.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            t.Stop();
        }

        private void btnSalah_Click(object sender, EventArgs e)
        {
            t.Stop();
            s = 120;
            this.Close();
        }
    }
}
