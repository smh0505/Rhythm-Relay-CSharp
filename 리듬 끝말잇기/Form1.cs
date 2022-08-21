using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace 리듬_끝말잇기
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
            TopMost = true;

            Database = ReadData();
            ResetListBox();

            comboBox.SelectedIndex = 0;
            InitTitle();
        }

    // Methods

        // Initialization

        private void InitTitle()
        {
            marquee2.Items = new List<string>();
            ResetTitle();
            
            marquee1.Speed = 1;
            marquee1.Interval = 1000 / 60;
            marquee1.Y = 10;

            marquee2.Speed = 2;
            marquee2.Interval = 1000 / 30;
        }

        private List<Song> ReadData()
        {
            var list = new List<Song>();
            var stream = File.Open("songlist.xlsx", FileMode.Open, FileAccess.Read);
            var reader = ExcelReaderFactory.CreateReader(stream);

            reader.Read();
            while (reader.Read())
            {
                if (reader.GetValue(2) != null && reader.GetValue(3) != null)
                {
                    var s = new Song
                    {
                        name = reader.GetValue(1).ToString(),
                        start = reader.GetValue(2).ToString(),
                        end = reader.GetValue(3).ToString()
                    };
                    list.Add(s);
                }
            }

            return list;
        }

        // Reset

        private void ResetData()
        {
            foreach (var song in SongsPlayed) Database.Add(song);
            SongsPlayed.Clear();
            ResetListBox();
        }

        private void ResetListBox()
        {
            listBox.Items.Clear();
            foreach (var song in Database) listBox.Items.Add(song.name);
        }

        private void ResetTimer()
        {
            time.reset();
            timerText.Text = "00:00:00";
        }

        private void ResetTitle()
        {
            marquee1.Visible = false;
            label8.Visible = false;
            letterText.Visible = false;
            
            EyeCatchText.Visible = true;
            EyeCatchText.Text = "리듬\n끝말잇기";

            marquee2.Items.Clear();
            marquee2.UpdateItems();
        }

        // Update
        
        private void UpdateCount()
        {
            countText.Text = String.Format("{0}곡 남음", Count);
        }

        private void UpdateTitle()
        {
            if (!marquee1.Visible) marquee1.Visible = true;
            if (!label8.Visible) label8.Visible = true;
            if (!letterText.Visible) letterText.Visible = true;
            if (EyeCatchText.Visible) EyeCatchText.Visible = false;

            marquee1.Text = LastSong.name;
            letterText.Text = LastSong.end;
            marquee2.Items.Add(LastSong.name);
            marquee2.UpdateItems();
        }

        // Input Control

        private void EnableInput()
        {
            inputBox.Enabled = true;
            checkBox.Enabled = true;
            listBox.Enabled = true;
            if (listBox.SelectedIndex != -1) addButton.Enabled = true;
        }

        private void DisableInput()
        {
            inputBox.Enabled = false;
            checkBox.Enabled = false;
            comboBox.Enabled = false;
            listBox.Enabled = false;
            addButton.Enabled = false;
        }

        private void ResetInput()
        {
            inputBox.Text = "";
            checkBox.Checked = false;
            comboBox.SelectedIndex = 0;
            listBox.ClearSelected();
        }

        // Button Control

        private void EnableButtons()
        {
            pauseButton.Enabled = true;
            if (SongsPlayed.Count > 0) editButton.Enabled = true;
            forceAddButton.Enabled = true;
            plusButton.Enabled = true;
            minusButton.Enabled = true;
        }

        private void DisableButtons()
        {
            pauseButton.Enabled = false;
            editButton.Enabled = false;
            forceAddButton.Enabled = false;
            plusButton.Enabled = false;
            minusButton.Enabled = false;
        }

        // Game Control

        private void StartGame()
        {
            spinBox.Enabled = false;
            EnableInput();
            EnableButtons();
            EyeCatchText.Text = "첫곡을\n플레이해주세요!";
            EyeCatchText.Font = new Font("Kotra Leap", 24);
        }

        private void EndGame()
        {
            ResetInput();
            DisableInput();
            DisableButtons();
            PlayMusic();
        }

        private void ResetGame()
        {
            spinBox.Enabled = true;
            ResetData();

            Count = spinBox.Value;
            UpdateCount();
            StopMusic();
        }

        // Music Control

        private void PlayMusic()
        {
            if (OutputDevice == null)
            {
                OutputDevice = new WaveOutEvent();
                OutputDevice.PlaybackStopped += OnPlaybackStopped;
            }
            if (Reader == null)
            {
                Reader = new AudioFileReader("Didn\'t Fall! (You Win).mp3");
                OutputDevice.Init(Reader);
            }
            OutputDevice.Play();
        }

        private void StopMusic()
        {
            OutputDevice?.Stop();
        }

    // Structures and Variables

        // Structures

        private struct Song
        {
            public string name;
            public string start;
            public string end;

            public Song(string name, string start, string end)
            {
                this.name = name;
                this.start = start;
                this.end = end;
            }
        }

        private struct Time
        {
            public int hour;
            public int minute;
            public int second;

            public Time(int seconds) {
                hour = seconds / 3600;
                minute = (seconds / 60) % 60;
                second = seconds % 60;
            }

            public void reset()
            {
                hour = 0; minute = 0; second = 0;
            }
        }

        // Lists

        private readonly List<Song> Database;

        private readonly List<Song> SongsPlayed = new List<Song>();

        // Variables/Objects

        private Song LastSong;

        private decimal Count = 10;

        private Time time = new Time(0);

        private WaveOutEvent OutputDevice;

        private AudioFileReader Reader;

        public string LastAlpha { get; set; }

        public string LastTitle { get; set; }

    // Widget Controls

        private void SpinBox_ValueChanged(object sender, EventArgs e)
        {
            if (spinBox.Value == 0) spinBox.Value = 50;
            else if (spinBox.Value == 51) spinBox.Value = 1;

            Count = spinBox.Value;
            UpdateCount();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (startButton.Text == "출근")
            {
                StartGame();

                timer1.Start();
                startButton.Text = "퇴근";
            }
            else if (startButton.Text == "퇴근")
            {
                if (marquee2.Items.Count == 0)
                {
                    MessageBox.Show("아직 첫 곡을 플레이하지 않았습니다.\n첫 곡을 플레이 해주세요.", 
                        "리듬 끝말잇기 in C# Ver.1.0", MessageBoxButtons.OK);
                }
                else
                {
                    EndGame();

                    timer1.Stop();
                    startButton.Text = "리셋";
                    pauseButton.Text = "일시정지";
                }
            }
            else
            {
                ResetGame();

                ResetTimer();
                startButton.Text = "출근";

                ResetTitle();
            }
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            if (pauseButton.Text == "일시정지")
            {
                timer1.Stop();
                pauseButton.Text = "재개";

                DisableInput();
            }
            else
            {
                timer1.Start();
                pauseButton.Text = "일시정지";

                EnableInput();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (marquee2.Items.Count == 0) editButton.Enabled = true;
            foreach (var song in Database)
            {
                if (song.name == listBox.SelectedItem.ToString())
                {
                    LastSong = song;
                    if (int.TryParse(LastSong.end, out int x))
                    {
                        string alpha = "";
                        switch (x)
                        {
                            case 0: alpha = "0/O"; break;
                            case 1: alpha = "1/E"; break;
                            case 2: alpha = "2/O"; break;
                            case 3: alpha = "3/E"; break;
                            case 4: alpha = "4/R"; break;
                            case 5: alpha = "5/E"; break;
                            case 6: alpha = "6/X"; break;
                            case 7: alpha = "7/N"; break;
                            case 8: alpha = "8/T"; break;
                            case 9: alpha = "9/E"; break;
                        }
                        LastSong.end = alpha;
                    }
                    if (checkBox.Checked) LastSong.end = comboBox.SelectedItem.ToString();

                    ResetInput();
                    ResetListBox();

                    SongsPlayed.Add(song);
                    Database.Remove(song);
                    
                    inputBox.Text = LastSong.end;
                    UpdateTitle();

                    break;
                }
            }
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            Count++;
            UpdateCount();
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            Count--;
            UpdateCount();
            if (Count == 0)
            {
                EndGame();

                timer1.Stop();
                startButton.Text = "리셋";

                pauseButton.Enabled = false;
                pauseButton.Text = "일시정지";
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            time.second += 1;
            if (time.second == 60)
            {
                time.second = 0;
                time.minute += 1;
            }
            if (time.minute == 60)
            {
                time.minute = 0;
                time.hour += 1;
            }
            timerText.Text = String.Format("{0:00}:{1:00}:{2:00}", time.hour, time.minute, time.second);
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            comboBox.Enabled = checkBox.Checked;
        }

        private void InputBox_TextChanged(object sender, EventArgs e)
        {
            listBox.ClearSelected();
            listBox.Items.Clear();
            foreach (var song in Database)
            {
                if (song.name.IndexOf(inputBox.Text, StringComparison.OrdinalIgnoreCase) == 0)
                {
                    listBox.Items.Add(song.name);
                }
            }
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex != -1) addButton.Enabled = true;
            else addButton.Enabled = false;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            childWindow child = new childWindow(this)
            {
                SongTitle = LastSong.name,
                Curr_Alpha = LastSong.end.ToString()
            };

            if (child.ShowDialog() == DialogResult.OK)
            {
                LastSong.end = LastAlpha;
                letterText.Text = LastSong.end;
                inputBox.Text = LastSong.end;
            }
        }

        private void ForceAddButton_Click(object sender, EventArgs e)
        {
            childWindow2 child = new childWindow2(this);
            if (child.ShowDialog() == DialogResult.OK)
            {
                if (marquee2.Items.Count == 0)
                {
                    editButton.Enabled = true;
                    LastSong.start = "A";
                }
                else LastSong.start = LastSong.end;

                LastSong.name = LastTitle;
                LastSong.end = LastAlpha;

                ResetInput();
                ResetListBox();

                UpdateTitle();
                inputBox.Text = LastSong.end;
            }
        }

        private void OnPlaybackStopped(object sender, EventArgs e)
        {
            OutputDevice.Dispose();
            OutputDevice = null;
            Reader.Dispose();
            Reader = null;
        }
    }
}
