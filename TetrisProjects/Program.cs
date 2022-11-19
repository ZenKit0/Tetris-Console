namespace TetrisProjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  DEBUG : TEST");


            GridGame gridGame = new GridGame(16, 16);
            gridGame.RenderGrid();
        }
    }
}