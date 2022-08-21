using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace 리듬_끝말잇기
{
    public partial class Marquee2 : UserControl
    {
        public Marquee2()
        {
            InitializeComponent();
            timer1.Start();
            label1.Text = "";
        }

        public List<string> Items { get; set; }
        public int Speed { get; set; }
        public int Interval { get { return timer1.Interval; } set { timer1.Interval = value; } }

        public void UpdateItems()
        {
            /*
            string text;
            if (Items.Count != 0) text = string.Join("\n", Items.ToArray());
            else text = "";
            */
            var text = string.Join("\n", Items.ToArray());
            label1.Text = text;
        }

        private void DefLocation()
        {
            var x = (Width - label1.Width) / 2;
            var y = 0;
            label1.Location = new Point(x, y);
        }

        private void MovLocation()
        {
            var x = (Width - label1.Width) / 2;
            var y = label1.Location.Y;
            y -= Speed;
            if (y < 0 && Math.Abs(y) >= label1.Height) y = Height;
            label1.Location = new Point(x, y);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (label1.Height >= Height) MovLocation();
            else DefLocation();
        }
    }
}
