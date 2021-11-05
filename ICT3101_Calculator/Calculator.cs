using System;
using System.Collections.Generic;
using System.Text;

/*ICT3101: Lab 4
Prepared by: Jerone Poh
*/

namespace ICT3101_Calculator
{
    public class Calculator
    {
        private FileReader getTheMagic;
        public Calculator() {
            // Lab 4 Q4
            getTheMagic = new FileReader();
        }
        public double DoOperation(double num1, double num2, double num3, string op)
        {
            double result = double.NaN; // Default value
            // Use a switch statement to do the math.
            switch (op)
            {
                case "a":
                    result = Add(num1, num2);
                    break;
                case "s":
                    result = Subtract(num1, num2);
                    break;
                case "m":
                    result = Multiply(num1, num2);
                    break;
                case "d":
                    // Ask the user to enter a non-zero divisor.
                    result = Divide(num1, num2);
                    break;
                case "f":
                    // Get factorial of first number entered
                    result = Factorial(num1);
                    break;
                case "aot":
                    // Get area of triangle
                    result = AreaOfTriangle(num1, num2);
                    break;
                case "aoc":
                    // Get area of circle
                    result = AreaOfCircle(num1);
                    break;
                case "ufa":
                    // Get result of Unknown Function A
                    //result = UnknownFunctionA(num1, num2);
                    break;
                case "ufb":
                    // Get result of Unknown Function B
                    //result = UnknownFunctionB(num1, num2);
                    break;
                case "mtbf":
                    // Get result of MTBF
                    result = MTBF(num1, num2);
                    break;
                case "availability":
                    // Get result of Availability
                    result = Availability(num1, num2);
                    break;
                case "cfi":
                    // Get result of current failure intensity using Basic Musa Model
                    result = CurrentFailureIntensity(num1, num2, num3);
                    break;
                case "nef":
                    // Get result of average number of expected failures using Basic Musa Model
                    result = AverageNumberofExpectedFailures(num1, num2, num3);
                    break;
                case "dd":
                    // Get result of defect density 
                    result = DefectDensity(num1, num2);
                    break;
                case "ssi":
                    // Get result of SSI for second release
                    result = SSISecondRelease(num1, num2, num3);
                    break;
                case "magic":
                    // Get magic number
                    //result = GenMagicNum(num1);

                    result = GenMagicNum(num1, getTheMagic);
                    break;
                // Return text for an incorrect option entry.
                default:
                    break;
            }
            return result;
        }
        // Lab 2.1 Q8: normal add
        /*public double Add(double num1, double num2)
        {
            return (num1 + num2);
        }*/

        // Lab 2.1 Q10: Add with zero as special cases
        public double Add(double num1, double num2)
        {
            string bin1 = num1.ToString();
            bin1 = bin1 + "00";

            string bin2 = num2.ToString();

            double finalNum1 = Convert.ToDouble(Convert.ToInt32(bin1, 2));
            double finalNum2 = Convert.ToDouble(Convert.ToInt32(bin2, 2));
            return (finalNum1 + finalNum2);
        }
        public double Subtract(double num1, double num2)
        {
            return (num1 - num2);
        }
        public double Multiply(double num1, double num2)
        {
            return (num1 * num2);
        }
        public double Divide(double num1, double num2)
        {
            // Normal divide from Lab 1
            /*if (num1 == 0 || num2 == 0)
            {
                throw new ArgumentException();
            }
            return (num1 / num2);*/

            // Lab 2.1 Q12: Divide for Lab 2
            double result;
            if (num1 == 0 && num2 == 0)
            {
                result = 1;
            }
            else
            {
                result = (num1 / num2);
            }
            return result;
        }

        public double Factorial(double num1)
        {
            // Lab 1-2.1
            /*double result = 1;
            if (num1 < 0)
            {
                throw new ArgumentException();
            } else
            {
                while (num1 != 0)
                {
                    result *= num1;
                    num1--;
                }
                if (result > Int32.MaxValue)
                {
                    throw new ArgumentException();
                }
                return result;
            }*/

            // Lab 2.2 Q16
            double result = 1;
            while (num1 != 0)
            {
                result *= num1;
                num1--;
            }
            return result;
        }

        // Area of Triangle
        public double AreaOfTriangle(double num1, double num2)
        {
            if (num1 <= 0 || num2 <= 0)
            {
                throw new ArgumentException();
            }
            return (0.5 * num1 * num2);
        }

        // Area of Circle
        public double AreaOfCircle(double num1)
        {
            if (num1 <= 0)
            {
                throw new ArgumentException();
            }
            return (Math.PI * num1 * num1);
        }

        // Unknown Function A
        /*public double UnknownFunctionA(double num1, double num2)
        {
            return Divide(Factorial(num1), Factorial(Subtract(num1, num2)));
        }

        // Unknown Function B
        public double UnknownFunctionB(double num1, double num2)
        {
            return Divide(Factorial(num1), Multiply(Factorial(num2), Factorial(Subtract(num1, num2))));
        }*/

        // Lab 2.2 Q17
        public double MTBF(double MTTF, double MTTR)
        {
            return MTTF + MTTR;
        }

        public double Availability(double MTTF, double MTBF)
        {
            return (MTTF / MTBF);
        }

        // Lab 2.2 Q18
        public double CurrentFailureIntensity(double num1, double num2, double num3)
        {
            return (Multiply(num1, 1 - Divide(num2, num3)));
        }
        public double AverageNumberofExpectedFailures(double num1, double num2, double num3)
        {
            return (Multiply(num1, 1 - Math.Pow(Math.E, Divide(Multiply(-num2, num3), num1))));
        }

        // Lab 2.3 Q22
        public double DefectDensity(double defects, double CSI)
        {
            return (defects / CSI);
        }

        public double SSISecondRelease(double SSIOld, double CSI, double changedCode)
        {
            return (Subtract((SSIOld + CSI), changedCode));
        }

        // Lab 4 Q4
        public double GenMagicNumBase(double input)
        {
            double result = 0;
            int choice = Convert.ToInt16(input);

            // Lab 4 Q4
            //Dependency------------------------------
            FileReader getTheMagic = new FileReader();
            //----------------------------------------
            string[] magicStrings = getTheMagic.Read(@"MagicNumbers.txt");

            if ((choice >= 0) && (choice < magicStrings.Length))
            {
                result = Convert.ToDouble(magicStrings[choice]);
            }
            result = (result > 0) ? (2 * result) : (-2 * result);
            return result;
        }

        // Lab 4 Q8
        public double GenMagicNum(double input, IFileReader fileReader)
        {
            double result = 0;
            int choice = Convert.ToInt16(input);

            // Lab 4 Q8
            string[] magicStrings = fileReader.Read(@"MagicNumbers.txt");
            if ((choice >= 0) && (choice < magicStrings.Length))
            {
                result = Convert.ToDouble(magicStrings[choice]);
            }
            result = (result > 0) ? (2 * result) : (-2 * result);
            return result;
        }
    }
}
