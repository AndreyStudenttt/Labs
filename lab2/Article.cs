using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Article
    {
      
        public Person Author { get; set; } //в котором хранятся данные автора статьи;
        public String Name { get; set; } //для названия статьи;
        public double Rating { get; set; } //для рейтинга статьи.
        public Article (Person author, string name, double rating)
        {
            Author = author;
            Name = name;
            Rating = rating;
        }
       
        public Article()
        {
            Author = new Person();
            Name = "Война";
            Rating = 12.3;
        }
        
        public override string ToString()
        {
            return $"Автор: {Author}{Environment.NewLine} Название статьи: { Name}\n Реитинг статьи: {Rating}";
        }
    }
}
