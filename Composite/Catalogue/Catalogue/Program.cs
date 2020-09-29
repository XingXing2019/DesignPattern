using System;

namespace Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            Component root = new Composite("Catalogue");
            
            Component music = new Composite("Music");
            Component knowledge = new Composite("Knowledge");
            Component life = new Composite("Life");

            root.Add(music);
            root.Add(knowledge);
            root.Add(life);

            Component science = new Composite("Science");
            Component tech = new Composite("Technology");

            knowledge.Add(science);
            knowledge.Add(tech);

            Component scienceArticle1 = new Leaf("ScienceArticle1");
            Component scienceArticle2 = new Leaf("ScienceArticle2");

            science.Add(scienceArticle1);
            science.Add(scienceArticle2);

            Component shoot = new Composite("Shoot");
            Component program = new Composite("Program");
            Component english = new Composite("English");

            tech.Add(shoot);
            tech.Add(program);
            tech.Add(english);

            Component shootArticle = new Leaf("ShootArticle");
            Component lifeArticle1 = new Leaf("LifeArticle1");
            Component lifeArticle2 = new Leaf("LifeArticle2");

            shoot.Add(shootArticle);
            life.Add(lifeArticle1);
            life.Add(lifeArticle2);

            root.Display(0);
            Console.WriteLine($"Article Number: {root.CountArticles()}");
        }
    }
}
