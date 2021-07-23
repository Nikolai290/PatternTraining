using System;

namespace PatternTraining.CommandPattern {
    public class Character {
        public string Name { get; set; }
        public Coord Coord { get; set; }

        public Character(string name) {
            Name = name;
            Coord = new Coord(0, 0);
        }

        public void Show() {
            Console.Clear();
            Console.WriteLine(Name);
            Console.WriteLine("Координаты ( {0} ; {1} )", Coord.X, Coord.Y);
        }

    }
}
