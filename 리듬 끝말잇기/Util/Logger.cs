using System;
using System.IO;
using System.Text;

namespace 리듬_끝말잇기
{
    public class Logger
    {
        private FileStream fs;

        public void Start(int SongCount)
        {
            if (fs != null) Close();
            if (!Directory.Exists("Log")) Directory.CreateDirectory("Log");
            fs = File.Create("Log\\" + DateTime.Now.ToString("yyyy-dd-MM_HH-mm-ss") + ".log");
            Write("START " + SongCount.ToString());
        }

        public void NewSong(string songName) {
            Write("SONG " + songName);
        }

        public void NewRoulette(string option)
        {
            Write("ROULETTE " + option);
        }

        public void Pause()
        {
            Write("PAUSE");
        }

        public void Continue()
        {
            Write("CONTINUE");
        }

        public void SetAlpha(string alpha)
        {
            Write("SET " + alpha);
        }

        public void AddSongCount()
        {
            Write("ADD");
        }

        public void SubSongCount()
        {
            Write("SUB");
        }

        public void NextRoulette()
        {
            Write("NextRoulette");
        }

        public void Write(string str)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(DateTime.Now.ToString("[HH:mm:ss]") + ": " + str + '\n');
            fs.Write(bytes, 0, bytes.Length);
            fs.Flush();
        }

        public void Close()
        {
            fs.Close();
        }

        public void AddTime(int sec)
        {
            Write("ADDTIME " + sec.ToString());
        }
    }
}
