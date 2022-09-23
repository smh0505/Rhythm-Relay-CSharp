using System;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Websocket.Client;

namespace 리듬_끝말잇기
{
    public partial class RouletteWindow : Form
    {
        private readonly mainWindow parent = null;
        private string payload;
        private readonly Thread child;

        public RouletteWindow(mainWindow window)
        {
            InitializeComponent();
            TopMost = true;
            parent = window;
            child = new Thread(new ThreadStart(Connect));

            OptionName.Speed = 1;
            OptionName.Interval = 1000 / 60;
            OptionName.Y = 10;
            OptionName.Text = "옵션 없음";
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
                    MessageBox.Show("아직 첫 곡을 플레이하지 않았습니다.\n" +
                        "첫 곡을 플레이해주세요.",
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
            Console.WriteLine(string.IsNullOrEmpty(payload));
        }

        private delegate void rouletteInvoker(string rValue);

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
                    break;
                case "처음부터 다시하기":
                    parent.Header = "경) 태초마을 (축";
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
                child.Start();
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
                OptionName.Text = rouletteList.Items[0].ToString();
                if (rouletteList.GetItemChecked(0)) OptionName.Text += " + 알파벳 리롤";
                rouletteList.Items.RemoveAt(0);
            }
            else
            {
                OptionName.Text = "옵션 없음";
                nextButton.Enabled = false;
            }
        }

        private void RouletteWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Close();
            child.Abort();
        }
    }
}
