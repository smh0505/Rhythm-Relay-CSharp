using System;
using System.IO;
using System.Collections.Generic;

namespace 리듬_끝말잇기
{
    public class Recoverer
    {
        List<string> SongHistory = new List<string>();
        List<string> RouletteHistory = new List<string>();
        string Alpha = "NULL";
        int SongCount, TimeSpent, RouletteIdx = 0;

        public void Recover(String path)
        {
            StreamReader sr = new StreamReader(path);
            string[] Tmp;
            int PrvTime = -1, CurrentTime;
            bool Pause = false;


            while (!sr.EndOfStream)
            {
                Tmp = Parse(sr.ReadLine());
                CurrentTime = StrToSec(Tmp[0]);
                if (PrvTime != -1 && !Pause)
                    TimeSpent += (CurrentTime - PrvTime + 24 * 60 * 60) % (24 * 60 * 60);
                PrvTime = CurrentTime;

                switch (Tmp[1])
                {
                    case "START":
                        SongCount = Convert.ToInt32(Tmp[2]);
                        break;
                    case "SONG":
                        SongHistory.Add(Tmp[2]);
                        break;
                    case "ROULETTE":
                        RouletteHistory.Add(Tmp[2]);
                        break;
                    case "PAUSE":
                        Pause = true;
                        break;
                    case "CONTINUE":
                        Pause = false;
                        break;
                    case "SET":
                        Alpha = Tmp[2];
                        break;
                    case "ADD":
                        SongCount += 1;
                        break;
                    case "SUB":
                        SongCount -= 1;
                        break;
                    case "NextRoulette":
                        RouletteIdx++;
                        break;
                    case "ADDTIME":
                        TimeSpent += Convert.ToInt32(Tmp[2]);
                        break;
                }
            }
        }

        private string[] Parse(string Str)
        {
            string[] Tmp = { "", "", "" };
            int Idx = 0;
            for (int i = 0; i < Str.Length; i++)
            {
                if ((Idx != 0) || (Str[i] != '[' && Str[i] != ']'))
                {
                    if (Str[i] == ' ' && Idx < 2) Idx++;
                    else Tmp[Idx] += Str[i];
                }
            }
            return Tmp;
        }

        private int StrToSec(string Time)
        {
            int Idx = 0;
            string[] ParsedTime = { "", "", "" };

            for (int i = 0; i < Time.Length; i++)
            {
                if (Time[i] == ':') Idx++;
                else ParsedTime[Idx] += Time[i];
            }
            return 60 * 60 * Convert.ToInt32(ParsedTime[0]) + 60 * Convert.ToInt32(ParsedTime[1]) + Convert.ToInt32(ParsedTime[2]);
        }

        public List<string> GetSongHistory() { return SongHistory; }

        public List<string> GetRouletteHistory() { return RouletteHistory; }

        public int GetRouletteIdx() { return RouletteIdx; }

        public int GetLeftSongCount() { return SongCount; }

        public string GetAlpha() { return Alpha; }

        public int GetSpentTime() { return TimeSpent; }
    }
}