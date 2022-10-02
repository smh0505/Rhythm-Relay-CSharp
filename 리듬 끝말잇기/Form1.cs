using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader;
using NAudio.Wave;
using Websocket.Client;

namespace 리듬_끝말잇기
{
    public partial class mainWindow : Form
    {
        private readonly Logger logger = null;
        private readonly RouletteWindow rw = null;

        public mainWindow()
        {
            InitializeComponent();
            TopMost = true;
            rw = new RouletteWindow(this);
            rw.Show();

            Database = ReadData();
            ResetListBox();

            comboBox.SelectedIndex = 0;

            rouletteThread = new Thread(new ThreadStart(Connect));
            logger = new Logger();
        }

    // Methods

        // Initialization

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
                    if (SongNames.IndexOf(s.name) == -1) SongNames.Add(s.name);
                }
            }

            return list;
        }

        // Reset

        private void ResetData()
        {
            foreach (var song in SongsPlayed) Database.Add(song);
            SongsPlayed.Clear();

            foreach (var song in Database)
                if (SongNames.IndexOf(song.name) == -1) SongNames.Add(song.name);
            SongNames.Sort();

            ResetListBox();
        }

        private void ResetListBox()
        {
            listBox.Items.Clear();
            listBox.Items.AddRange(SongNames.ToArray());
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

        private void WeakResetInput()
        {
            checkBox.Checked = false;
            comboBox.SelectedIndex = 0;
            listBox.ClearSelected();
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
            if (SongsPlayed.Count > 0) editButton.Enabled = true;
            forceAddButton.Enabled = true;
            plusButton.Enabled = true;
            minusButton.Enabled = true;
        }

        private void DisableButtons()
        {
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
            rw.EyeCatch = "첫 곡을\n플레이해주세요!";
            logger.Start(Convert.ToInt32(spinBox.Value), "");
        }

        private void EndGame()
        {
            ResetInput();
            DisableInput();
            DisableButtons();
            PlayMusic();

            rw.EndLetter = "끝";
        }

        private void ResetGame()
        {
            spinBox.Enabled = true;
            ResetData();

            Count = spinBox.Value;
            rw.UpdateCount(Count);
            StopMusic();

            FirstSongPlayed = false;
            rw.LabelText = "퇴근까지 앞으로";
        }

        // Music Control

        private void PlayMusic()
        {
            OutputDevice = new WaveOutEvent();
            Reader = new AudioFileReader("Didn\'t Fall! (You Win).mp3");
            OutputDevice.Init(Reader);
            OutputDevice.Play();
        }

        private void StopMusic()
        {
            OutputDevice.Stop();
            OutputDevice.Dispose();
            OutputDevice = null;
            Reader.Dispose();
            Reader = null;
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

        private List<string> SongNames = new List<string>();

        // Variables/Objects

        private bool FirstSongPlayed = false;

        private Song LastSong;

        private decimal Count = 10;

        private WaveOutEvent OutputDevice;

        private AudioFileReader Reader;

        public string LastAlpha { get; set; }

        public string LastTitle { get; set; }

        private string payload;

        private readonly Thread rouletteThread;

    // Widget Controls

        // Input

        private void SpinBox_ValueChanged(object sender, EventArgs e)
        {
            if (spinBox.Value == 0) spinBox.Value = 50;
            else if (spinBox.Value == 51) spinBox.Value = 1;

            Count = spinBox.Value;
            rw.UpdateCount(Count);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (rw.SongsUsedListCount == 0)
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

                    WeakResetInput();
                    SongNames.Remove(song.name);

                    SongsPlayed.Add(song);
                    Database.Remove(song);
                    
                    inputBox.Text = LastSong.end;
                    rw.UpdateTitle(LastSong.name, LastSong.end);
                    logger.NewSong(LastSong.name);
                    logger.SetAlpha(LastSong.end);

                    break;
                }
            }
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            Count++;
            rw.UpdateCount(Count);
            logger.AddSongCount();
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            Count--;
            if (Count < 0) Count = 0;
            else logger.SubSongCount();
            rw.UpdateCount(Count);
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            comboBox.Enabled = checkBox.Checked;
        }

        private void InputBox_TextChanged(object sender, EventArgs e)
        {
            listBox.ClearSelected();
            listBox.Items.Clear();

            List<string> namesAfterSearch = new List<string>();
            foreach (var song in SongNames)
            {
                if (song.IndexOf(inputBox.Text, StringComparison.OrdinalIgnoreCase) == 0)
                {
                    namesAfterSearch.Add(song);
                }
            }
            listBox.Items.AddRange(namesAfterSearch.ToArray());
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
                rw.EndLetter = LastSong.end;
                inputBox.Text = LastSong.end;
                logger.SetAlpha(LastSong.end);
            }
        }

        private void ForceAddButton_Click(object sender, EventArgs e)
        {
            childWindow2 child = new childWindow2(this);
            if (child.ShowDialog() == DialogResult.OK)
            {
                if (rw.SongsUsedListCount == 0)
                {
                    editButton.Enabled = true;
                    LastSong.start = "A";
                    FirstSongPlayed = true;
                }
                else LastSong.start = LastSong.end;

                LastSong.name = LastTitle;
                LastSong.end = LastAlpha;

                WeakResetInput();

                rw.UpdateTitle(LastSong.name, LastSong.end);
                inputBox.Text = LastSong.end;
                logger.NewSong(LastTitle);
                logger.SetAlpha(LastSong.end);
            }
        }

        // Sound Control

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

        // Game Control

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (startButton.Text == "출근")
            {
                StartGame();
                rw.StartTimer();
                startButton.Text = "퇴근";
                pauseButton.Enabled = true;
                recoverButton.Enabled = false;
                logger.Start(Convert.ToInt32(spinBox.Value), "");
                foreach (string roulette in rouletteList.Items)
                {
                    logger.NewRoulette(roulette);
                }
            }
            else if (startButton.Text == "퇴근")
            {
                if (!FirstSongPlayed)
                {
                    MessageBox.Show("아직 첫 곡을 플레이하지 않았습니다.\n" +
                        "첫 곡을 플레이해주세요.",
                        "리듬 끝말잇기");
                }
                else
                {
                    EndGame();
                    rw.StopTimer();
                    startButton.Text = "리셋";
                    pauseButton.Enabled = false;
                    pauseButton.Text = "일시정지";
                    logger.Close();
                }
            }
            else
            {
                ResetGame();
                rw.ResetTimer();
                startButton.Text = "출근";
                rw.ResetTitle();
                recoverButton.Enabled = true;
            }
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            if (pauseButton.Text == "일시정지")
            {
                rw.StopTimer();
                pauseButton.Text = "재개";
                DisableInput();
                DisableButtons();
                logger.Pause();
            }
            else
            {
                rw.StartTimer();
                pauseButton.Text = "일시정지";
                EnableInput();
                EnableButtons();
                logger.Continue();
            }
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            rouletteThread.Abort();
            logger.Start(10, "ExitProgram");  // Arg is not important
            foreach (string roulette in rouletteList.Items)
            {
                logger.NewRoulette(roulette);
            }
            logger.Close();
        }

        // Toonation Client

        private delegate void rouletteInvoker(string rValue);
        
        private async Task LoadPayload(string url)
        {
            HttpClient client = new HttpClient();
            using (var response = await client.GetAsync(url))
            {
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var body = await response.Content.ReadAsStringAsync();
                    Match match = Regex.Match(body, @".payload.:.[\w]*.");
                    Match match1 = Regex.Match(match.Value, @"[\w]{8,}");
                    payload = match1.Value;
                }
            }
        }

        private void Connect()
        {
            Uri uri = new Uri("wss://toon.at:8071/" + payload);
            var exitEvent = new ManualResetEvent(false);

            using (WebsocketClient client = new WebsocketClient(uri))
            {
                client.MessageReceived.Subscribe(msg =>
                {
                    if (msg.ToString().Contains("roulette"))
                    {
                        var roulette = Regex.Match(msg.ToString(), "\"message\":\"[^\"]* - [^\"]*\"").Value.Substring(10);
                        var rValue = roulette.Split('-')[1].Replace("\"", "");
                        rouletteList.BeginInvoke(new rouletteInvoker(ReadRoulette), rValue);
                    }
                });
                client.Start();
                exitEvent.WaitOne();
            }
        }

        private void ReadRoulette(string rValue)
        {
            string option = rValue.Substring(1);
            if (!option.Contains("꽝"))
                option = option.Substring(option.IndexOf(']') + 2);

            switch (option)
            {
                case "꽝":
                case "따뜻한 위로와 격려":
                    break;
                case "알파벳 랜덤으로 변경":
                    if (rouletteList.Items.Count == 0)
                        rouletteList.Items.Add("옵션 없음", true);
                    else if (rouletteList.GetItemChecked(rouletteList.Items.Count - 1))
                        rouletteList.Items.Add("옵션 없음", true);
                    else rouletteList.SetItemChecked(rouletteList.Items.Count - 1, true);
                    logger.NewRoulette(option);
                    break;
                case "처음부터 다시하기":
                    rw.LabelText = "경) 태초마을 (축";
                    break;
                default:
                    var x = rouletteList.Items.IndexOf("옵션 없음");
                    if (x != -1)
                    {
                        rouletteList.Items.RemoveAt(x);
                        rouletteList.Items.Insert(x, option);
                        rouletteList.SetItemChecked(x, true);
                    }
                    else rouletteList.Items.Add(option, false);
                    logger.NewRoulette(option);
                    break;
            }
            if (!nextButton.Enabled) nextButton.Enabled = true;
        }

        private void KeyInput_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(keyInput.Text)) connectButton.Enabled = false;
            else connectButton.Enabled = true;
        }

        private async void ConnectButton_Click(object sender, EventArgs e)
        {
            keyInput.Enabled = false;
            connectButton.Enabled = false;
            await LoadPayload("https://toon.at/widget/alertbox/" + keyInput.Text);
            if (!string.IsNullOrEmpty(payload))
            {
                rouletteThread.Start();
                MessageBox.Show(this, "투네이션 연결에 성공했습니다.",
                    "리듬 끝말잇기");
            }
            else
            {
                MessageBox.Show(this, "투네이션 연결에 실패했습니다.\n" +
                    "다시 시도해주세요.", "리듬 끝말잇기");
                keyInput.Text = "";
                keyInput.Enabled = true;
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (rouletteList.Items.Count > 0)
            {
                var option = rouletteList.Items[0].ToString();
                if (rouletteList.GetItemChecked(0)) option += " + 알파벳 리롤";
                rw.OptionText = option;
                rouletteList.Items.RemoveAt(0);
            }
            else
            {
                rw.OptionText = "옵션 없음";
                nextButton.Enabled = false;
            }
            logger.NextRoulette();
        }

        private void RecoverButton_Click(object sender, EventArgs e)
        {
            RecoverForm recoverForm = new RecoverForm(this);
            recoverForm.ShowDialog();
        }

        public void Recover(Recoverer recoverer, bool time, bool roulette, bool song, bool leftSongCount)
        {
            StartGame();
            recoverButton.Enabled = false;
            rw.Recover(recoverer, time, song, leftSongCount);
            if (roulette)
            {
                // 초기화
                rouletteList.Items.Clear();
                
                // 불러온 옵션들을 형식에 맞게 재나열
                List<(string, bool)> options = new List<(string, bool)>();
                foreach (string option in recoverer.GetRouletteHistory())
                {
                    if (option == "알파벳 랜덤으로 변경")
                    {
                        if (options.Count == 0) options.Add(("옵션 없음", true));
                        else if (options[options.Count - 1].Item2) options.Add(("옵션 없음", true));
                        else
                        {
                            options.Insert(options.Count - 1, (options[options.Count - 1].Item1, true));
                            options.RemoveAt(options.Count - 1);
                        }
                    }
                    else
                    {
                        var x = options.IndexOf(("옵션 없음", true));
                        if (x != -1)
                        {
                            options.RemoveAt(x);
                            options.Insert(x, (option, true));
                        }
                        else options.Add((option, false));
                    }
                }

                // 재나열된 옵션들 중 이미 소화한 것들을 제거
                // 이 때, 전부 소화했다면 리스트를 비움
                if (options.Count > recoverer.GetRouletteIdx())
                    options.RemoveRange(0, recoverer.GetRouletteIdx());
                else options.RemoveRange(0, options.Count);

                // 남은 옵션이 있다면 전부 업데이트
                foreach (var option in options)
                {
                    ReadRoulette(" ] " + option.Item1);
                    if (option.Item2) ReadRoulette(" ] 알파벳 랜덤으로 변경");
                }
            }
            if (song)
                FirstSongPlayed = (recoverer.GetSongHistory().Count != 0);
            rw.StartTimer();
            startButton.Text = "퇴근";
            pauseButton.Enabled = true;
            recoverButton.Enabled = false;
        }
        
        public Logger GetLogger() { return logger; }
    }
}
