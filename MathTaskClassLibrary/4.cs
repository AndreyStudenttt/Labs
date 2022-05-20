using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace MathTaskClassLibrary
{
    public class Fourth
    {
        public bool Mail(string text)
        {
            if (text == null)
            {
                throw new ArgumentNullException("text");
            }
            Regex regex = new Regex(@"^([a-zA-Z0-9]{2,})@([a-z]{2,})\.([a-z]{2,})$");
            return regex.IsMatch(text);
        }
    }
}
