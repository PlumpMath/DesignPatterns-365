namespace DesignPatterns.MazeGame
{
    public class MazeGame
    {
        public Maze CreateMaze()
        {
            var maze = new Maze();
            var room1 = new Room(1);
            var room2 = new Room(2);
            var theDoor = new Door(room1, room2);

            maze.AddRoom(room1);
            maze.AddRoom(room2);

            room1.SetSide(Direction.North, new Wall());
            room1.SetSide(Direction.East, theDoor);
            room1.SetSide(Direction.South, new Wall());
            room1.SetSide(Direction.West, new Wall());

            room2.SetSide(Direction.North, new Wall());
            room2.SetSide(Direction.East, new Wall());
            room2.SetSide(Direction.South, new Wall());
            room2.SetSide(Direction.West, theDoor);

            return maze;
        }
    }
}