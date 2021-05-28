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
    public partial class s49 : Form
    {
        public s49()
        {
            InitializeComponent();
        }

        public int benar = 0;
        System.Timers.Timer t;
        int m = 0, s = 60;

        private void s49_Load(object sender, EventArgs e)
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
                tbTimer.Text = string.Format("{0}:{1}", m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
            }));
        }

        private void btnBenar_Click(object sender, EventArgs e)
        {
            t.Stop();
            s = 60;
            this.benar = 1;
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
            this.benar = 2;
        }
    }
}
