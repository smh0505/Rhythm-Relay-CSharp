using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace 리듬_끝말잇기
{
    public partial class RouletteWindow : Form
    {
        private readonly mainWindow parent = null;

        public RouletteWindow(mainWindow window)
        {
            InitializeComponent();
            TopMost = true;
            parent = window;

            InitTitle();
        }

        // Initialization

        private void InitTitle()
        {
            OptionName.Speed = 1;
            OptionName.Interval = 1000 / 60;
            OptionName.Y = 8;
            OptionName.Text = "옵션 없음";

            songNameMarquee.Speed = 1;
            songNameMarquee.Interval = 1000 / 60;
            songNameMarquee.Y = 10;

            songsUsedList.Items = new List<string>();
            songsUsedList.Speed = 2;
            songsUsedList.Interval = 1000 / 30;

            ResetTitle();
        }

        // Reset

        public void ResetTitle()
        {
            songNameMarquee.Visible = false;
            label8.Visible = false;
            letterText.Visible = false;

            EyeCatchText.Visible = true;
            EyeCatchText.Text = "리듬\n끝말잇기";

            songsUsedList.Items.Clear();
            songsUsedList.UpdateItems();
        }

        // Update

        public void UpdateCount(decimal c)
        {
            countText.Text = String.Format("{0}곡 남음", c);
        }

        public void UpdateTitle(string name, string end)
        {
            if (!songNameMarquee.Visible) songNameMarquee.Visible = true;
            if (!label8.Visible) label8.Visible = true;
            if (!letterText.Visible) letterText.Visible = true;
            if (EyeCatchText.Visible) EyeCatchText.Visible = false;

            songNameMarquee.Text = name;
            letterText.Text = end;
            songsUsedList.Items.Add(name);
            songsUsedList.UpdateItems();
        }

        // I/O

        public string EyeCatch
        {
            set { EyeCatchText.Text = value; }
        }

        public string EndLetter
        {
            set { letterText.Text = value; }
        }

        public string LabelText
        {
            set { countLabel.Text = value; }
        }

        public string OptionText
        {
            set { OptionName.Text = value; }
        }

        public int SongsUsedListCount
        {
            get { return songsUsedList.Items.Count; }
        }

        // Timer

        private struct Time
        {
            public int hour;
            public int minute;
            public int second;

            public Time(int seconds)
            {
                hour = seconds / 3600;
                minute = (seconds / 60) % 60;
                second = seconds % 60;
            }

            public void Reset()
            {
                hour = 0; minute = 0; second = 0;
            }

            public override string ToString()
            {
                return string.Format("{0:00}:{1:00}:{2:00}", hour, minute, second);
            }
        }

        private Time time = new Time(0);

        public void ResetTimer()
        {
            time.Reset();
            timerText.Text = time.ToString();
        }

        public void StartTimer()
        {
            timer1.Start();
        }

        public void StopTimer()
        {
            timer1.Stop();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            time.second++;
            if (time.second == 60)
            {
                time.second = 0;
                time.minute++;
            }
            if (time.minute == 60)
            {
                time.minute = 0;
                time.hour++;
            }
            timerText.Text = time.ToString();
        }

        // Closed

        private void RouletteWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Close();
        }


        public void Recover(Recoverer recoverer, bool time, bool song, bool leftSongCount)
        {
            if (time)
            {
                this.time = new Time(recoverer.GetSpentTime());
                timerText.Text = this.time.ToString();
                parent.GetLogger().AddTime(recoverer.GetSpentTime());
            }
            if (song)
            {
                foreach (string songName in recoverer.GetSongHistory())
                {
                    UpdateTitle(songName, recoverer.GetAlpha());
                    parent.GetLogger().NewSong(songName);
                }
                parent.GetLogger().SetAlpha(recoverer.GetAlpha());
            }
            if (leftSongCount)
            {
                UpdateCount(recoverer.GetLeftSongCount());
                parent.GetLogger().Write("START " + recoverer.GetLeftSongCount().ToString());
            }
        }
    }
}
