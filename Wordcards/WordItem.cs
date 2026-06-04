using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordcards
{
    public class WordItem : object
    {
        public string Word { get; set; }
        public string Phonogram { get; set; }
        public string SoundPath { get; set; }
        public string Explain { get; set; }

        /// <summary>
        /// 建構子，從 TSV 字串建立 WordItem 物件
        /// </summary>
        /// <param name="str"></param>
        public WordItem(string str)
        {
            string[] strLists = str.Split('\t');
            if (strLists.Length >= 3)
            {
                Word = strLists[0];
                Phonogram = strLists[1];
                SoundPath = strLists[2];
                Explain = string.Join(Environment.NewLine, strLists.Skip(3));
            }
        }

        /// <summary>
        /// 覆寫 ToString() 可將物件自動轉換為字串
        /// </summary>
        /// <returns>單字</returns>
        public override string ToString()
        {
            return this.Word;
        }

        /// <summary>
        /// 將 WordItem 物件轉換為字串
        /// 格式為 "Word\tPhonogram\tSoundPath\tExplain"
        /// </summary>
        /// <returns>字串，格式為 "Word\tPhonogram\tSoundPath\tExplain"</returns>
        public string ToLineString()
        {
            // 將 Explain 屬性中的換行符號替換為\t，以便在字串中顯示。
            string strExplain = Explain.Replace(Environment.NewLine, "\t");
            // 將 WordItem 物件轉換為字串
            return $"{Word}\t{Phonogram}\t{SoundPath}\t{strExplain}";
        }


    }


}
