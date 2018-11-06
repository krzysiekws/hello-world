using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Manage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a width of new rectangle: ");
            string width = Console.ReadLine();
            double w = ValueValidator.Validate(width);

            Console.WriteLine("and height: ");
            string height = Console.ReadLine();
            double h = ValueValidator.Validate(height);
            
            Rectangle rectangle = new Rectangle();
            rectangle.SetObjectDetails(w, h);
            rectangle.ShowObjectInfo();
            Console.ReadLine();
        }

        class ValueValidator
        {
            internal static double Validate(string width)
            {
                try
                {
                    return Convert.ToDouble(width.Replace('.', ','));
                }
                catch (Exception)
                {
                    Console.WriteLine("Convert error, set 0 value");
                    return 0;
                }
            }
        }

        class Rectangle
        {
            private double Width { get; set; } = 1;
            private double Height { get; set; } = 1;
            private double RectangleArea { get; set; }

            internal void SetObjectDetails(double width, double heigth)
            {
                Width = width;
                Height = heigth;                
            }

            internal void ShowObjectInfo()
            {
                Console.WriteLine($"Width is {Width}");
                Console.WriteLine($"Height is {Height}");
                Console.WriteLine($"Area is {GetRectangleArea().ToString()}");
            }

            private double GetRectangleArea()
            {
                return Width * Height;
            }
        }
    }


}
