using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisProjects
{
    internal class GridGame
    {
        Vector2 GridSize;
        char[,] gameGrid;

        public static char border = '#',
            block = 'O', 
            clear = ' ';
                    

        public GridGame(int size_x, int size_y)
        {
            GridSize = new Vector2(size_y, size_x);

            gameGrid = new char[GridSize.x, GridSize.y];

            Init();
        }

        private void Init()
        {
            for (int x = 0; x < GridSize.x; x++)
            {
                for (int y = 0; y < GridSize.y; y++)
                {
                    gameGrid[x, y] = clear;
                    if (x == 0 || x == GridSize.x - 1)
                    {
                        gameGrid[x, y] = border;
                    }
                }

                gameGrid[x, 0] = border;
                gameGrid[x, GridSize.y - 1] = border;
            }
        }

        public void RenderGrid()
        {
            for (int x = 0; x < GridSize.x; x++)
            {
                for (int y = 0; y < GridSize.y; y++)
                {
                
                    Console.Write(gameGrid[x, y]);
                }

                Console.WriteLine();
            }
        }
    }
}
