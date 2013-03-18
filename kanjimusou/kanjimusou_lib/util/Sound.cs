using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;

namespace Kanjimusou.Lib.util
{
    public static class Sound
    {
        private static SoundPlayer sePlayer = new SoundPlayer();
        private static SoundPlayer bgmPlayer = new SoundPlayer();

        private static readonly Dictionary<String, String> fileDic = new Dictionary<string,string>();
        private const String path = "./resource/sound/";

        static Sound()
        {
            fileDic.Add("se1","11.wav");
        }


        public static void PlaySE(String key)
        {
            sePlayer.SoundLocation = path + fileDic[key];
            sePlayer.Play();
        }

        public static void PlayBGM(String key)
        {
            bgmPlayer.SoundLocation = path + fileDic[key];
            bgmPlayer.PlayLooping();
        }


    }
}
