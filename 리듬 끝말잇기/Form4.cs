using System;
using System.Windows.Forms;

namespace 리듬_끝말잇기
{
    public partial class TimerWindow : Form
    {
        private readonly mainWindow parent = null;

        public TimerWindow(mainWindow window)
        {
            InitializeComponent();
            TopMost = true;

            parent = window;
        }

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

        private void ResetTimer()
        {
            time.Reset();
            timerText.Text = time.ToString();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (startButton.Text == "출근")
            {
                parent.StartGame();
                timer1.Start();
                startButton.Text = "퇴근";

                pauseButton.Enabled = true;
            }
            else if (startButton.Text == "퇴근")
            {
                if (!parent.FirstSongPlayed)
                {
                    MessageBox.Show("아직 첫 곡을 플레이하지 않았습니다.\n첫 곡을 플레이해주세요.",
                        "리듬 끝말잇기", MessageBoxButtons.OK);
                }
                else
                {
                    parent.EndGame();
                    timer1.Stop();
                    startButton.Text = "리셋";

                    pauseButton.Enabled = false;
                    pauseButton.Text = "일시정지";
                }
            }
            else
            {
                parent.ResetGame();
                ResetTimer();
                startButton.Text = "출근";
                parent.ResetTitle();
            }
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            if (pauseButton.Text == "일시정지")
            {
                timer1.Stop();
                pauseButton.Text = "재개";
                parent.DisableInput();
                parent.DisableButtons();
            }
            else
            {
                timer1.Start();
                pauseButton.Text = "일시정지";
                parent.EnableInput();
                parent.EnableButtons();
            }
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

        private void TimerWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Close();
        }
    }
}
