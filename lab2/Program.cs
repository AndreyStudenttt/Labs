using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public enum Frequency { Weekly, Monthly, Yearly };
    class Program
    {
        static void Main()
        {
          Person kirill = new Person("Кирилл", "Сергеивич", new DateTime(1995, 12, 1));
            Person andrey = new Person();
            Person dima = new Person("Дима", "Петров", new DateTime(1997, 4, 10));

           Article war = new Article();
            Article world = new Article(kirill,"Мир",13.5);
            Article newgames = new Article(dima,"Новый шутер", 15.1);

            Magazine wizard = new Magazine();
            Magazine games = new Magazine("Игры", Frequency.Weekly, new DateTime(2014, 11, 4), 5432 );

            wizard.AddArticle(world);
            wizard.AddArticle(war);
            games.AddArticle(newgames);

            Console.WriteLine(wizard.ToString());
            Console.WriteLine($"\n{games.ToString()}");
            return;

            
        }
    }
}
