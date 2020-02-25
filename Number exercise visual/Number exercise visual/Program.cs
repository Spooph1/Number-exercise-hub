using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_exercise_visual
{
    class Program
    {
        static void Main(string[] args)
        {
            //The first here is a more flexible way with arrays
            /*int i;
            int quantity;
            int[] numberArray = new int[100];
            Console.Write("Type in different numbers and I will put them i reverse order");
            Console.Write("\nHow many numbers will you type in?\n");
            quantity = Convert.ToInt32(Console.ReadLine());

            Console.Write("Write {0} numbers:\n", quantity);
            for (i = 0; i < quantity; i++)
            {
                Console.Write("Element - {0}: ", i);
                numberArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nThe values stored in the array are: \n ");
            for (i = 0; i < quantity; i++)
            {
                Console.Write("{0} ", numberArray[i]);
            }

            Console.Write("\nThe numbers in reverse are:\n");
            for (i = quantity-1; i >= 0; i--)
            {
                Console.Write("{0} ", numberArray[i]);
            }
            Console.ReadLine();*/


            //The second one makes use of the "Stack"-method we learned about i class
            int quantity;
            int i;
            int firstEntry;
            int secondEntry;
            int prediction;
            Stack st = new Stack();

            Console.Write("Write some numbers");
            Console.WriteLine("\nHow many numbers will you write?");
            quantity = Convert.ToInt32(Console.ReadLine());

            Console.Write("Write {0} numbers:\n", quantity);
            for (i = 0; i < quantity; i++)
            {
                Console.Write("Element - {0}: ", i);
                st.Push(Console.ReadLine());
            }

            Console.Write("\nThe values in reversed order are: \n");
            while(st.Count>0)
            {
                Console.Write(st.Pop()+" ");
            }

            Console.Write("\n\n Press Enter to be part of a magictrick!!\n");
            Console.ReadLine();
            Console.Write("\n Welcome to this amazing magictrck, where i will make a prediction af a random 8-digit number. ");
            Console.Write("\n The prediction is here ******** but i will first reveal it at the end of the trick.");
            Console.Write("\n First you will type in a random 4-digit number, lets say the first four digits of your phone number,");
            Console.Write("\n because there is no way i could kknow that: ");
            firstEntry = Convert.ToInt32(Console.ReadLine());
            prediction = firstEntry * 80;
            Console.Write("\n I have now mulitplayed your number by 80: " + prediction);
            Console.ReadLine();
            prediction = prediction + 1;
            Console.Write("\n To make it more random i will now add 1 to the number, so now the number are: " + prediction);
            Console.ReadLine();
            prediction = prediction * 250;
            Console.Write("\n To make the number 8-digit we will have to multiply it by 250, so lets do that:");
            Console.ReadLine();
            Console.Write((prediction / 250) + " * 250 = " + prediction);
            Console.ReadLine();
            Console.Write("\n Now it begins to look like something, but try and add the last four digits of your phone number: "+ prediction + "+ ");
            secondEntry = Convert.ToInt32(Console.ReadLine());
            prediction = prediction + secondEntry;
            Console.Write("\n =" + prediction);
            Console.Write("\n And to make it even more random try and add the last four digits of your phone number again: " + prediction + "+ ");
            secondEntry = Convert.ToInt32(Console.ReadLine());
            prediction = prediction + secondEntry;
            Console.Write("\n =" + prediction);
            Console.ReadLine();
            prediction = prediction - 250;
            Console.Write("\n We are nearing the end, but I think are gonna subtract 250 this time, insted of multiplaying it: " + (prediction + 250) + " - 250");
            Console.ReadLine();
            Console.Write("\n =" + prediction);
            Console.ReadLine();
            prediction = prediction / 2;
            Console.Write("\n And now for the final, I think number is to big, so we will divide it by 2: " + (prediction * 2) + " / 2");
            Console.ReadLine();
            Console.Write("\n The totally random number created by bits of your phone number are: " + prediction);
            Console.Write("\n And my prediction was ********");
            Console.ReadLine();
            Console.Write(prediction);
            Console.ReadLine();
            Console.Write("\n Waow, this was hectic and in the end my prediction was right.. pheew.");
            Console.Write("\n And if you don't believe I did all the math, you are welcome to look at the code. Thanks for now!");
            Console.ReadLine();






        }
    }
}
