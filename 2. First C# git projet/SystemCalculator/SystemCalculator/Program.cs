using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj system oryginalny (2, 4, 8, 16, 10 itd)");
            var oldSystem = Console.ReadLine();
            Console.WriteLine("Podaj system dcelowy");
            var newSystem = Console.ReadLine();
            Console.WriteLine("Podaj wartość");
            var valueToCalculate = Console.ReadLine();
        }

    }

    public class SystemCalc
    {
        public int OldSys { get; set; }
        public int NewSystem { get; set; }
        public int ValueToCalc { get; set; }

        public SystemCalc(int oldSystem, int newSystem, int valueToCalc)
        {
            this.OldSys = oldSystem;
            this.NewSystem = newSystem;
            this.ValueToCalc = valueToCalc;
        }

        public string Calculate()
        {
            switch (NewSystem)
            {
                case 2:
                    return CalcStandardMethod();
                case 7:
                    return CalcStandardMethod();
                case 16:
                        throw new NotImplementedException();
                default:
                        throw new Exception("Not implemeted system");
            }
        }

        public string CalcStandardMethod()
        {            
            string returnValue = null;
            int loopValue = ValueToCalc;

            while (loopValue > 0)
            {
                returnValue = loopValue % NewSystem + returnValue;
                loopValue = loopValue / NewSystem;
            }

            return returnValue;
        }
    }

}
