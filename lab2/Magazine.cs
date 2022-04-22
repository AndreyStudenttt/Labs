using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Magazine : List<Article>
    {
        private string namezh;
        private Frequency frequencyzh;
        private System.DateTime datezh;
        private int tzh;
        private Article[] stats = new Article[1];

        public Magazine(string NameZh, Frequency FrequencyZh, DateTime DateZh, int TZh)
        {
            namezh = NameZh;
            frequencyzh = FrequencyZh;
            datezh = DateZh;
            tzh = TZh;
        }
        public Magazine()
        {
            namezh = "Новости";
            frequencyzh = Frequency.Monthly;
            datezh = new DateTime(2013, 12, 2);
            tzh = 1000;
            stats[0] = new Article();
        }
        public string NameZh
        {
            get
            {
                return namezh;
            }
        }
        public Frequency FrequencyZh
        {
            get
            {
                return frequencyzh;
            }
        }
        public DateTime DateZh
        {
            get
            {
                return datezh;
            }
        }
        public int TZh
        {
            get
            {
                return tzh;
            }
        }
        private int _addedArticleCount;
        public void AddArticle(Article a)
        {

            stats[_addedArticleCount] = a;
            _addedArticleCount++;
            if (_addedArticleCount == stats.Length)
            {
                Array.Resize(ref stats, _addedArticleCount + 1);
            }
        }
       
        public string Write(params Article[] article)
        {
            string result = "";
            for ( int i = 0; i < stats.Length; i++)
            {
                if (stats[i] != null)
                {
                    result += stats[i].ToString() + Environment.NewLine+ Environment.NewLine; ;
                }
                
            }
            return result;
            
        }

       
        public override string ToString()
        {
            return $"Название журнала: {namezh}{Environment.NewLine}" +
                $"Периодичность выхода журнала: {frequencyzh}{Environment.NewLine}" +
                $"Дата выхода журнла: {datezh}{Environment.NewLine}" +
                $"Тираж журнала {tzh}{Environment.NewLine}" +
                $"Статьи:{Environment.NewLine} " +
                $"{Write()}";
        }
    }
}
