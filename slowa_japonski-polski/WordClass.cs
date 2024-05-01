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
        public string inHiraganaOrKatakana;
        public string inEnglish;
        public string wordSet;
        //public string soundOfWord;

        public WordClass(string inRomaji, string inHiraganaOrKatakana, string inEnglish, string wordSet) {
            this.inRomaji = inRomaji;
            this.inHiraganaOrKatakana = inHiraganaOrKatakana;
            this.inEnglish = inEnglish;
            this.wordSet = wordSet;
        }
    }
}
