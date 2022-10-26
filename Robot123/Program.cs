using Robot123;

// define grid dimension
string gridDim = Console.ReadLine().ToUpper();
// movement set
string moveSet = Console.ReadLine().ToUpper();

// initialize the grid
string[] words = gridDim.Split('X');
Grid marsPlateau = new Grid { X = int.Parse(words[0]), Y = int.Parse(words[1]) };

//Console.WriteLine($"Mars X: {marsPlateau.X}");
//Console.WriteLine($"Mars Y: {marsPlateau.Y}");

//Console.WriteLine($"Robot moveset: {moveSet}");

// initialize the robot
Robot myRobot = new Robot()
{
    X = 1,
    Y = 1,
    Forward = Robot.Direction.North,
    Grid = marsPlateau
};

myRobot.Move(moveSet);

Console.WriteLine($"{myRobot.X},{myRobot.Y},{myRobot.Forward}");