using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coba
{
    class Program
    {
        public int findMax(int num1,int num2) {
            int result;

            if (num1 > num2)
                result = num1;
            else
                result = num2;
            
            return result;
        }

        public int findMin(int num1, int num2)
        {
            int result;

            if (num1 < num2)
                result = num1;
            else
                result = num2;

            return result;
        }

        static void Main(string[] args)
        {
            String userInput;
            int num1, num2, ret;
            Program p = new Program();
            Console.WriteLine("Simple Program for find Max number\n");
            Console.Write("Number 1 : ");
            userInput = Console.ReadLine();
            num1 = Convert.ToInt32(userInput);
            Console.Write("Number 2 : ");
            userInput = Console.ReadLine();
            num2 = Convert.ToInt32(userInput);
            ret = p.findMax(num1,num2);
            Console.WriteLine("Max value is : '{0}' x",ret);
            Console.ReadKey();

        }
    }
}
