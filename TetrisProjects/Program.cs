#define Debug

using System.Numerics;

namespace TetrisProjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  DEBUG : TEST");

            GridGame gridGame = new GridGame(16, 16);
            gridGame.RenderGrid();

            GameLoop();
        }

        private static void GameLoop()
        {
            Player player = new Player();
            Vector2 pos;
            while (true)
            {
                pos = player.GetInput();

#if Debug
                Console.WriteLine($"{pos.x} {pos.y}");
#endif
            }
        }
    }
}