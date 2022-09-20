﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ExcelDataReader;
using NAudio.Wave;

namespace 리듬_끝말잇기
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
            TopMost = true;

            TimerWindow timerWindow = new TimerWindow(this);
            timerWindow.Show();

            RouletteWindow rouletteWindow = new RouletteWindow(this);
            rouletteWindow.Show();

            Database = ReadData();
            ResetListBox();

            comboBox.SelectedIndex = 0;
            InitTitle();

            OutputDevice.PlaybackStopped += OnPlaybackStopped;
            OutputDevice.Init(Reader);
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

        public void ResetTitle()
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

        public void EnableInput()
        {
            inputBox.Enabled = true;
            checkBox.Enabled = true;
            listBox.Enabled = true;
            if (listBox.SelectedIndex != -1) addButton.Enabled = true;
        }

        public void DisableInput()
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

        public void EnableButtons()
        {
            if (SongsPlayed.Count > 0) editButton.Enabled = true;
            forceAddButton.Enabled = true;
            plusButton.Enabled = true;
            minusButton.Enabled = true;
        }

        public void DisableButtons()
        {
            editButton.Enabled = false;
            forceAddButton.Enabled = false;
            plusButton.Enabled = false;
            minusButton.Enabled = false;
        }

        // Game Control

        public void StartGame()
        {
            spinBox.Enabled = false;
            EnableInput();
            EnableButtons();
            EyeCatchText.Text = "첫곡을\n플레이해주세요!";
            EyeCatchText.Font = new Font("Kotra Leap", 24);
        }

        public void EndGame()
        {
            ResetInput();
            DisableInput();
            DisableButtons();
            PlayMusic();

            letterText.Text = "끝";
        }

        public void ResetGame()
        {
            spinBox.Enabled = true;
            ResetData();

            Count = spinBox.Value;
            UpdateCount();
            StopMusic();

            FirstSongPlayed = false;
        }

        // Music Control

        private void PlayMusic()
        {
            OutputDevice.Play();
        }

        private void StopMusic()
        {
            OutputDevice.Stop();
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

        // Lists

        private readonly List<Song> Database;

        private readonly List<Song> SongsPlayed = new List<Song>();

        // Variables/Objects

        public bool FirstSongPlayed = false;

        private Song LastSong;

        private decimal Count = 10;

        private WaveOutEvent OutputDevice = new WaveOutEvent();

        private AudioFileReader Reader = new AudioFileReader("Didn\'t Fall! (You Win).mp3");

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

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (marquee2.Items.Count == 0)
            {
                editButton.Enabled = true;
                FirstSongPlayed = true;
            }
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
            if (Count < 0) Count = 0;
            UpdateCount();
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
                    FirstSongPlayed = true;
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

        private void TrackBar_Scroll(object sender, EventArgs e)
        {
            numericUpDown1.Value = trackBar1.Value;
            OutputDevice.Volume = trackBar1.Value / 100f;
        }

        private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            trackBar1.Value = (int)numericUpDown1.Value;
            OutputDevice.Volume = trackBar1.Value / 100f;
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
