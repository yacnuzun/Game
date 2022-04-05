using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, BirhtYear = 1996,FirstName="Yalçın",LastName="Uzun",IdentityNumaber=1234 });
            Console.Read();
        }
    }
}
