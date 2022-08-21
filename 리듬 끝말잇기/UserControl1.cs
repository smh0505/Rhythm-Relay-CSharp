using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 리듬_끝말잇기
{
    public partial class Marquee : UserControl
    {
        public Marquee()
        {
            InitializeComponent();
            timer1.Start();
        }

        public int Speed { get; set; }
        public int Interval { get { return timer1.Interval; } set { timer1.Interval = value; } }
        public int Y { get; set; }
        public override string Text { get { return label1.Text; } set { label1.Text = value; } }

        private void DefLocation()
        {
            var x = (Width - label1.Width) / 2;
            var y = Y;
            label1.Location = new Point(x, y);
        }

        private void MovLocation()
        {
            var x = label1.Location.X;
            var y = Y;
            x -= Speed;
            if (x < 0 && Math.Abs(x) >= label1.Width) x = Width;
            label1.Location = new Point(x, y);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (label1.Width >= Width) MovLocation();
            else DefLocation();
        }
    }
}
