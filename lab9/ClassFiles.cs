using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace lab9
{
    public class ClassFiles 
    {
        public long lenght { get; set; }
        public string filename { get; set; }
        public string filename_ { get; set; }
        public string extension { get; set; }
        public string path { get; set; }
        public int day { get; set; }
        public string week { get; set; }
        public int month { get; set; }
        public DateTime fulldate { get; set; }
        public byte[] bytearr { get; set; }
        public BitmapMetadata metadata { get; set; }
        public ClassFiles(long lenght, string filesnames, string path, int day, string filename_, string extension, string week, int month, DateTime fulldate )
        {
            this.lenght = lenght;
            this.filename = filesnames;
            this.path = path;
            this.day = day;
            this.filename_ = filename_;
            this.extension = extension;
            this.week = week;
            this.month = month;
            this.fulldate = fulldate;

            FileStream fstream = File.OpenRead(path);
            this.bytearr = new byte[fstream.Length];
            fstream.Read(this.bytearr, 0, bytearr.Length);
            
        }
        ~ClassFiles()
        {
        }

        }
}
