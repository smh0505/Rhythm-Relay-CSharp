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
                        var rValue = roulette.Split('-')[1].Replace(" ", "").Replace("\"", "");
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
            string option;
            if (rValue != "꽝")
                option = rValue.Split(null, 2)[1];
            else option = rValue;
            switch (option)
            {
                case "꽝":
                case "따뜻한 위로와 격려":
                    break;
                case "알파벳 랜덤으로 변경":
                    if (rouletteList.GetItemChecked(rouletteList.Items.Count - 1))
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
                child.Start();
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
        }
    }
}
