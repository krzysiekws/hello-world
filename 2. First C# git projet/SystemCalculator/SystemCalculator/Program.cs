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

        public string OldSys { get; set; }
        public int NewSystem { get; set; }
        public string ValueToCalc { get; set; }

        public SystemCalc(string oldSystem, int newSystem, string valueToCalc)
        {
            this.OldSys = oldSystem;
            this.NewSystem = newSystem;
            this.ValueToCalc = valueToCalc;
        }

        public string Calculate()
        {
            if (NewSystem >= 2 && NewSystem <= 16) 
            {
                return CalcStringMethod();
            }
            else
            {
                throw new Exception("Please, choose a system between 2 and 16");
            }
        }

        private string CalcStringMethod()
        {
            string characters = "0123456789ABCDEFG";
                        
            string returnValue = null;
            int newSystem = NewSystem;
            int loopValue = Convert.ToInt32(ValueToCalc);

            while (loopValue > 0)
            {
                returnValue = characters[loopValue % newSystem] + returnValue;
                loopValue = loopValue / newSystem;
            }

            return returnValue;
        }

        /// <summary>
        /// work only for 2-10 system
        /// </summary>
        /// <returns></returns>
        [Obsolete]
        public string CalcStandardMethod()
        {            
            string returnValue = null;
            int newSystem = Convert.ToInt32(NewSystem);
            int loopValue = Convert.ToInt32(ValueToCalc);

            while (loopValue > 0)
            {
                returnValue = loopValue % newSystem + returnValue;
                loopValue = loopValue / newSystem;
            }

            return returnValue;
        }
    }

}
