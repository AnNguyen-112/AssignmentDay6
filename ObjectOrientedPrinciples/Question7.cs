using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay6.ObjectOrientedPrinciples
{
    internal class Question7
    {
    }

    public class Color
    {
        private int _red;
        private int _green;
        private int _blue;
        private int _alpha;

        // Properties with validation
        public int Red
        {
            get => _red;
            set => _red = ValidateColorValue(value);
        }

        public int Green
        {
            get => _green;
            set => _green = ValidateColorValue(value);
        }

        public int Blue
        {
            get => _blue;
            set => _blue = ValidateColorValue(value);
        }

        public int Alpha
        {
            get => _alpha;
            set => _alpha = ValidateColorValue(value);
        }

        public Color(int red, int green, int blue, int alpha)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }

        public Color(int red, int green, int blue) : this(red,green, blue, 255)
        {
            
        }
        

        public double GrayScale (int red, int green, int blue)
        {
            return (red + green + blue) / 3.0;
        }

        private static int ValidateColorValue(int value)
        {
            if (value < 0 || value > 255)
            {
                throw new ArgumentOutOfRangeException(nameof(value), "Color values must be between 0 and 255.");
            }
            return value;
        }
      
    }

    public class Ball
    {
        private int _size;

        private Color _color;

        private int _throwCount;

        public int Size => _size;
        public Color Color => _color;  
        public int ThrowCount => _throwCount;


        public Ball(int size, Color color)
        {
            if (size < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(size), "Size cannot be negative.");
            }

            _size = size;
            _color = color;
            _throwCount = 0;
        }

        public void Pop()
        {
            _size = 0;
        }

        public void Throw()
        {
            if (_size > 0)
            {
                _throwCount++;
            }
            else
            {
                Console.WriteLine("Can not throw a popped ball");
            }

        }

        public int GetThrowCount()
        {
            return _throwCount;
        }

    }

    class Program
    {
        public static void Main(string[] args)
        {
            // Create a Color instance
            Color redColor = new Color(255, 0, 0, 255);

            // Create a Ball instance
            Ball ball = new Ball(10, redColor);

            // Throw the ball
            ball.Throw();
            ball.Throw();
            Console.WriteLine($"The ball has been thrown {ball.GetThrowCount()} times.");

            // Pop the ball
            ball.Pop();
            Console.WriteLine($"Ball size after popping: {ball.Size}");

            // Attempt to throw a popped ball
            ball.Throw();
            Console.WriteLine($"The ball has been thrown {ball.GetThrowCount()} times.");
        }
    }
}
