using System;
namespace ICT3101_Calculator
{
    public class Calculator
    {
        //IFileReader _fileReader;
        //public Calculator(IFileReader fileReader)
        //{
        //    _fileReader = fileReader;
        //}

        IFileReader _fileReader = new FileReader();

        public Calculator() {}

        public double DoOperation(double num1, double num2, string op)
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
                    result = Factorial(num1);
                    break;
                case "h":
                    result = AreaOfTriangle(num1, num2);
                    break;
                case "i":
                    result = AreaOfCircle(num1);
                    break;
                case "j":
                    result = GenMagicNum(num1, _fileReader);
                    break;
                // Return text for an incorrect option entry.
                default:
                    break;
            }
            return result;
        }
        public double Add(double num1, double num2)
        {
            return (num1 + num2);
        }
        public double AddBinary(double num1, double num2)
        {
            double n1 = Convert.ToInt32(num1.ToString(), 2);
            double n2 = Convert.ToInt32(num2.ToString(), 2);

            return n1 * 4 + n2;
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
            //if ((num1 == 0) && (num2 == 0))
            //{
            //    return 1;
            //}
            if ((num1 == 0) || (num2 == 0))
            {
                throw new ArgumentException();
            }
            else
            {
                return (num1 / num2);
            }
        }

        public double GherkinDivide(double num1, double num2)
        {
            if ((num1 == 0) && (num2 == 0))
            {
                return 1;
            }
            else if (Double.IsInfinity(num1 / num2))
            {
                return 0;
            }
            else if ((num1 == 0) && (num2 > 0))
            {
                return 0;
            }
            else
            {
                return (num1 / num2);
            }
        }

        public double Factorial(double num)
        {
            if (num <= 0)
            {
                throw new ArgumentException();
            }
            else
            {
                if (num == 1)
                {
                    return num;
                }
                else
                {
                    return num * Factorial(num - 1);
                }
            }
        }

        public double AreaOfTriangle(double num1, double num2)
        {
            return (0.5 * num1 * num2);
        }

        public double AreaOfCircle(double radius)
        {
            return (3.142 * radius * radius);
        }

        public double CalculateAvailability(double MTTF, double MTTR)
        {
            return (MTTF / (MTTF + MTTR)) * 100;
        }

        public double CurrentFailureIntensity(double IFI, double AF, double TF)
        {
            return (IFI * (1 - (AF / TF)));
        }

        public double AverageExpectedFailures(double IFI, double TF, double cpuHours)
        {
            return (TF * (1-Math.Exp(-(IFI/TF)*cpuHours)));
        }

        public double DefectDensity(double TD, double KLOC)
        {
            return TD / KLOC;
        }

        public double NewSSI(double prevSSI, double CSI, double changedCode)
        {
            return prevSSI + CSI - changedCode;
        }

        public double GenMagicNum(double input, IFileReader fileReader)
        {
            double result = 0;
            int choice = Convert.ToInt16(input);
            // Dependency
            // FileReader getTheMagic = new FileReader();
            // end

            string[] magicStrings = fileReader.Read("MagicNumbers.txt");

            if ((choice >= 0) && (choice < magicStrings.Length))
            {
                result = Convert.ToDouble(magicStrings[choice]);
            }
            result = (result > 0) ? (2 * result) : (-2 * result);
            return result;
        }
    }
}
