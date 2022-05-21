using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public ClassFiles(long lenght, string filesnames, string path, int day, string filename_, string extension)
        {
            this.lenght = lenght;
            this.filename = filesnames;
            this.path = path;
            this.day = day;
            this.filename_ = filename_;
            this.extension = extension;
        }
        ~ClassFiles()
        {
        }

        }
}
