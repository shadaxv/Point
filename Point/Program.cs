using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Implementing all required numbers
            /// </summary>
            Console.Write("Specify the X coordinate: ");
            string enteredNumberX = Console.ReadLine();
            if (!Int32.TryParse(enteredNumberX, out int coordinateX))
            {
                Console.WriteLine("{0}The wrong number was given{0}", Environment.NewLine);
                Console.WriteLine("Press any key to continue . . .");
                Console.ReadKey();
                return;
            }

            Console.Write("Specify the Y coordinate: ");
            string enteredNumberY = Console.ReadLine();
            if (!Int32.TryParse(enteredNumberY, out int coordinateY))
            {
                Console.WriteLine("{0}The wrong number was given{0}", Environment.NewLine);
                Console.WriteLine("Press any key to continue . . .");
                Console.ReadKey();
                return;
            }

            /// <summary>
            /// New object of Point class
            /// </summary>
            Point coord = new Point(coordinateX, coordinateY);

            Console.Write("What value do you want to move point X? ");
            string enteredNumberMoveX = Console.ReadLine();
            if (!Int32.TryParse(enteredNumberMoveX, out int moveCoordinateX))
            {
                Console.WriteLine("{0}The wrong number was given{0}", Environment.NewLine);
                Console.WriteLine("Press any key to continue . . .");
                Console.ReadKey();
                return;
            }

            Console.Write("What value do you want to move point Y? ");
            string enteredNumberMoveY = Console.ReadLine();
            if (!Int32.TryParse(enteredNumberMoveY, out int moveCoordinateY))
            {
                Console.WriteLine("{0}The wrong number was given{0}", Environment.NewLine);
                Console.WriteLine("Press any key to continue . . .");
                Console.ReadKey();
                return; 
            }

            /// <summary>
            /// Moving the coordinates
            /// </summary>
            coord.Move(moveCoordinateX, moveCoordinateY);

            /// <summary>
            /// Showing the coordinates
            /// </summary>
            coord.Show();
        }
    }
}
