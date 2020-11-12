using Microsoft.SmallBasic.Library;
namespace TurtleTraining
{
    class Program
    {
        static void T(int size)
        {
            Turtle.Angle = 0;
            Turtle.Move(size);
            Turtle.Turn(-90);
            Turtle.Move(size / 2);
            Turtle.Turn(180);
            Turtle.Move(size);
        }
        static void O(int size)
        {
            Turtle.Angle = 0;
            for (int i = 0; i < 4; i++)
            {
                Turtle.Move(size);
            }
        }
        static void P(int size)
        {
            Turtle.Move(size);
            O(60);
        }
        static void Main(string[] args)
        {
            Turtle.Speed = 10;
            Turtle.X = 100;
            Turtle.Y = 200;
            T(125);
            Turtle.X = 200;
            Turtle.Y = 200;
            O(100);
            Turtle.X = 350;
            Turtle.Y = 200;
            P(40);
            Turtle.X = 500;
            Turtle.Y = 200;
            T(100);
        }
    }
}
