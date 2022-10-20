using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Quiz1 {
    class Converter {

        public string[] hexadecimalArray = {"A","B","C","D","E","F"};


        public string decimalToBinary(int number) {
            if (number == 0) {
                return "0";
            }

            string binary = "";
            while (number > 0) {
                int remainder = number % 2;
                binary = remainder.ToString() + binary;
                number /= 2;
            }

            return binary;
        }

        public string decimalToOctal(int number) {
            if (number == 0) {
                return "0";
            }
            string octal = "";
            while (number > 0) {
                int remainder = number % 8;
                octal = remainder.ToString() + octal;
                number /= 8;
            }

            return octal;
        }

        public string decimalToHexadecimal(int number) {
            if (number == 0) {
                return "0";
            }
            string hexadecimal = "";
            while (number > 0) {
                int remainder = number % 16;
                if ( remainder > 9) {
                    hexadecimal = hexadecimalArray[remainder-10] + hexadecimal;
                } else {
                    hexadecimal = remainder.ToString() + hexadecimal;
                }
                
                number /= 16;
            }

            return hexadecimal;
        }

        public void showValues(int number) {
            Console.WriteLine($"Binary of {number}: {decimalToBinary(number)}");
            Console.WriteLine($"Octal of {number}: {decimalToOctal(number)}");
            Console.WriteLine($"Hexadecimal of {number}: {decimalToHexadecimal(number)}");
        }

    }
}
