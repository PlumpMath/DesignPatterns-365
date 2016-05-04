using System;

namespace DesignPatterns.MazeGame
{
    public class Wall : MapSite
    {
        public override void Enter()
        {
            Console.WriteLine("Wall");
        }
    }
}