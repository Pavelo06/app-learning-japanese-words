using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slowa_japonski_polski
{
    public class WordClass
    {
        public string inRomaji;
        public string inKanjiHiraganaKatakana;
        public string inEnglish;
        public string wordSet;
        public string soundOfWord;

        public WordClass(string inRomaji, string inKanjiHiraganaKatakana, string inEnglish, string soundOfWord, string wordSet) {
            this.inRomaji = inRomaji;
            this.inKanjiHiraganaKatakana = inKanjiHiraganaKatakana;
            this.inEnglish = inEnglish;
            this.soundOfWord = soundOfWord;
            this.wordSet = wordSet;
        }
    }
}
