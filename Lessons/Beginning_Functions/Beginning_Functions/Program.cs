/*****************************************************************************
 * Author:          Jeffrey Clark
 * Program:         Functions
 * Purpose:         To show the concept of Functions/Libraries
 ****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginning_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*********************Find the average of some numbers Without Functions***********************
            string name = "";
            int number = 0;
            int curve = 0;
            int count = 0;

            Console.WriteLine("Enter your name:");
            name = Console.ReadLine();
            Console.WriteLine("Nice to meet you {0}!", name);

            Console.WriteLine("How many numbers would you like to average?: ");
            count = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter a Number:");
                number = number + Convert.ToInt32(Console.ReadLine());
            }
        
            number = number / 5;

            Console.WriteLine("How much of a curve to grade on?: ");
            curve = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The average of the numbers entered is {0}. With a curve of {1} is {2}", number, curve, number + curve);
            */

            /*********************Find the average of some numbers With Functions***********************/

            AverageStuffForMe avgProgram = new AverageStuffForMe();

            avgProgram.Intro();
            avgProgram.GetNumbers();
            avgProgram.DisplayResult();

            
        }









        public class AverageStuffForMe
        {
            //Data Members (Variables)
            private int count = 0;          //Used to count many numbers are to be entered
            private string name = "";       //Name of the person entering the numbers
            private int number = 0;         //Used to keep track of the added amounts
            private int curve = 0;          //How much to add onto the average at the end

            //Display the introduction, and get the amount of numbers to average, and the curve
            public void Intro()
            {
                Console.WriteLine("Enter your name:");
                name = Console.ReadLine();
                Console.WriteLine("Nice to meet you {0}!", name);

                Console.WriteLine("How many numbers would you like to average?: ");
                count = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("How much of a curve to grade on?: ");
                curve = Convert.ToInt32(Console.ReadLine());
            }

            //Prompt for inputs
            public void GetNumbers()
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("Enter a Number:");
                    number += Convert.ToInt32(Console.ReadLine());
                }
                
            }

            //Display the result
            public void DisplayResult()
            {
                number = number / count;
                number = number + curve;
                Console.WriteLine("The average of the numbers entered is {0}. With a curve of {1} is {2}", number, curve, number + curve);
            }

        }
    }

}




namespace Bleh
{
    
    
    
}