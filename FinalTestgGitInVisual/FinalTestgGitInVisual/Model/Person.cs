using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalTestgGitInVisual.Model
{
    public class Person
    {
        int leg;
        int hand;
        string name;
        string age;

        public int Leg { get => leg; set => leg = value; }
        public int Hand { get => hand; set => hand = value; }
        public string Name { get => name; set => name = value; }
        //public string Age { get => age; set => age = value; }
    }
}
