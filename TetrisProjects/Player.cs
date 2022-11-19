using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisProjects
{
    internal class Player
    {
        public Vector2 GetInput()
        {
            Vector2 vect;
            ConsoleKeyInfo input = Console.ReadKey();

            switch (input.Key)
            {
                case ConsoleKey.UpArrow:
                    vect = Vector2.Up;
                    break;
                case ConsoleKey.DownArrow:
                    vect = Vector2.Down;
                    break;
                case ConsoleKey.RightArrow:
                    vect = Vector2.Right;
                    break;
                case ConsoleKey.LeftArrow:
                    vect = Vector2.Left;
                    break;
                default:
                    vect = Vector2.Zero;
                    break;
            }    

            return vect;
        }

        public void SetPosition(Vector2 pos, char[,] grid)
        {
            grid[pos.x, pos.y] = GridGame.block;
        }
    }
}
