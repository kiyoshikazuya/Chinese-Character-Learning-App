using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.Runtime.InteropServices;    

namespace Kanjimusou.Lib
{
    public static class Sound
    {
        private static SoundPlayer sePlayer = new SoundPlayer();

        private static readonly Dictionary<String, String> fileDic = new Dictionary<string,string>();
        private const String path = "./resource/sound/";

        private static bool isPlayingBGM = false;

        [DllImport("winmm.dll")]
        public static extern uint mciSendString(string lpstrCommand,
            string lpstrReturnString, uint uReturnLength, uint hWndCallback);

        public static bool IsPlayingBGM
        {
            get { return isPlayingBGM; }
        }

        static Sound()
        {
            fileDic.Add("se_achievementfinish", "se_achievementfinish.wav");
            fileDic.Add("se_buttonclick", "se_buttonclick.wav");
            fileDic.Add("se_challenge_finish10hanzi", "se_challenge_finish10hanzi.wav");
            fileDic.Add("se_write", "se_write.wav");
            fileDic.Add("se_lose", "se_lose.wav");

            fileDic.Add("bgm_opening", "bgm_opening.mp3");
            fileDic.Add("bgm_challenge", "bgm_challenge.mp3");
            fileDic.Add("bgm_study", "bgm_study.mp3");
        }

        public static void PlaySE(String key)
        {
            sePlayer.SoundLocation = path + fileDic[key];
            sePlayer.Play();
        }

        public static void PlayBGM(String key)   
        {
            mciSendString("close song", "", 0, 0);
            mciSendString("open " + path + fileDic[key] + " alias song", "0", 0, 0);
            mciSendString("play song repeat", "0", 0, 0);

            isPlayingBGM = true;

        }    

        public static void StopBGM()
        {
            mciSendString("close song", "", 0, 0);
            isPlayingBGM = false;
        }
        
    }
}
