using System;

namespace PatternTraining.CommandPattern {
    public class Coord {
        public int X { get; set; }
        public int Y { get; set; }

        public Coord(int x, int y) {
            X = x;
            Y = y;
        }

        public (int, int) Get() => (X, Y);


    }

    public static class CoordExtension {
        public static bool IsAvaibleToMove(this Coord from, Coord to) {
            if (Math.Abs(from.X - to.X) > 1) return false;
            if (Math.Abs(from.Y - to.Y) > 1) return false;
            if (Math.Abs(from.Y - to.Y) == 1 && Math.Abs(from.X - to.X) == 1) return false;
            return true;
        }

        public static Coord MoveUp(this Coord coord) {
            coord.Y++;
            return coord;
        }

        public static Coord MoveDown(this Coord coord) {
            coord.Y--;
            return coord;
        }

        public static Coord MoveRight(this Coord coord) {
            coord.X++;
            return coord;
        }

        public static Coord MoveLeft(this Coord coord) {
            coord.X--;
            return coord;
        }
    }
}
