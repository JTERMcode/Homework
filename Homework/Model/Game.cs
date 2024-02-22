using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Model
{
    internal class Games
    {
        public string Name { get; set; }

        public int Price {  get; set; }

        public void introduceself()
        {
            Console.WriteLine($"Welcome to {Name} this game cost {Price} dollars");
        }


    }
}
