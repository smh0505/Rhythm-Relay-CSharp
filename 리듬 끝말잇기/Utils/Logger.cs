using System;
using System.IO;
using System.Text;

namespace 리듬_끝말잇기
{
    public class Logger
    {
        private FileStream fs = null;

        public bool Start(int songCount, string filenameSuffix)
        {
            if (fs != null) Close();
            if (!Directory.Exists("Log")) Directory.CreateDirectory("Log");
            fs = File.Create(String.Format("Log\\{0}_{1}.log", DateTime.Now.ToString("yyyy-dd-MM_HH-mm-ss"), filenameSuffix));
            return Write("START " + songCount.ToString());
        }

        public bool NewSong(string songName)
        {
            return Write("SONG " + songName);
        }

        public bool NewRoulette(string option)
        {
            return Write("ROULETTE " + option);
        }

        public bool Pause()
        {
            return Write("PAUSE");
        }

        public bool Continue()
        {
            return Write("CONTINUE");
        }

        public bool SetAlpha(string alpha)
        {
            return Write("SET " + alpha);
        }

        public bool AddSongCount()
        {
            return Write("ADD");
        }

        public bool SubSongCount()
        {
            return Write("SUB");
        }

        public bool NextRoulette()
        {
            return Write("NextRoulette");
        }

        public bool Write(string str)
        {
            if (fs == null) return false;
            byte[] bytes = Encoding.UTF8.GetBytes(String.Format(DateTime.Now.ToString("[HH:mm:ss]: {0}\n"), str));
            fs.Write(bytes, 0, bytes.Length);
            fs.Flush();
            return true;
        }

        public void Close()
        {
            fs.Close();
            fs = null;
        }

        public bool AddTime(int sec)
        {
            return Write("ADDTIME " + sec.ToString());
        }
    }
}