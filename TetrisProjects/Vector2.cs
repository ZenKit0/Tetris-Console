using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisProjects
{
    internal class Vector2
    {
        public static Vector2 Zero { get; set; } = new Vector2();
        public static Vector2 Up { get; set; } = new Vector2(0, -1);
        public static Vector2 Down { get; set; } = new Vector2(0, 1);
        public static Vector2 Left { get; set; } = new Vector2(-1, 0);
        public static Vector2 Right { get; set; } = new Vector2(1, 0);


        public int x { get; set; }
        public int y { get; set; }

        public Vector2(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Vector2(int var)
        {
            this.x = var;
            this.y = var;
        }

        public Vector2()
        {
            this.x = 0;
            this.y = 0;
        }

        public static Vector2 operator +(Vector2 left, Vector2 right)
        {
            Vector2 vect = new Vector2();
            vect.x = left.x + right.x;
            vect.y = left.y + right.y;
            return vect;
        }

        public static Vector2 operator -(Vector2 left, Vector2 right)
        {
            Vector2 vect = new Vector2();
            vect.x = left.x - right.x;
            vect.y = left.y - right.y;
            return vect;
        }

        public static bool operator ==(Vector2 left, Vector2 right)
        {
            return left.x == right.x && left.y == right.y;
        }

        public static bool operator !=(Vector2 left, Vector2 right)
        {
            return left.x != right.x && left.y != right.y;
        }
    }
}
