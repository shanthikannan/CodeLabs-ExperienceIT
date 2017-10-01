using System.Collections.Generic;
using System;

namespace DataTypesAndVariables.Excercise1
{
    public class Loops
    {
        public static void Main(string[] args)
        {
            //do while loop

            //Write a program that uses a do while statement. Inside the loop, a kid is asking "are we there yet"
            //Then ask the user for input. The loop ends when we have arrived and then print to the console that "We're here!"

            do
            {
                // Write to console Are we there at
                Console.WriteLine("Are we there yet");
                //get for user input
                string input = Console.ReadLine();
                bool result = input.Equals("yes", StringComparison.OrdinalIgnoreCase);
                //if input is equal to "YES" or "yes" 
                if (result)
                {
                    //end the loop use break
                    break;
                }

            } while (true);

            //print We are here..
            Console.WriteLine ("We're here!");
            Console.ReadKey();

            Console.WriteLine("----------------------");

            //while loops

            //Write a program using a while loop that counts by 5's up to 100 starting at 5
            //Ex 5 10 15 20 25 30 etc


            //Define an integer called result
            int sumof5 = 0;
            while (sumof5 < 100) //If that reuslt is <= 100
            {
                    //add 5 to the result
                    sumof5 += 5;
                //print the result
                Console.WriteLine($"{sumof5}");
            }
            Console.ReadKey();

            Console.WriteLine("----------------------");

            //for loops
            //Write a program that uses a for loop to count down from 30 to 0, by 3's
            //Ex 30 27 24 21 18 etc


            //Define an integer called countDownBy3
            //initialize countDownBy3 to 30
            //Write a for loop
            //Inside the for loop, print countDownBy3

         
            
            for(int countDownBy3 = 30 ; countDownBy3 >=0; countDownBy3 -= 3)
            {
                Console.WriteLine(countDownBy3);
            }
            Console.ReadKey();

            Console.WriteLine("----------------------");

            //post and pre increment

            //write a program that uses a for loop with a pre incrementing counter and stops at <= 10 and increases by 1 each time
            //what is the final number printed?
            
            for(int a = 1; ++a <= 10; ) {

                Console.WriteLine($"{a}");
            }
            Console.ReadKey();

            Console.WriteLine("----------------------");

            //write a program that us a for loop with a post incrementing counter and stops at <= 10 and increases by 1 each time
            //what is the final number printed?

            for (int a = 1; a++ <= 10; )
            {

                Console.WriteLine($"{a}");
            }
            Console.ReadKey();
            
            Console.WriteLine("----------------------");

            //foreach

            int[] numbers = new int[] { 1, 3, 2, 4, 9, 20, 83, 88, 10, -2, -3 };
            //use a foreach loop to go over this list of numbers and only print the even numbers, not the odd

            //FOR EACH LOOP
            //INSIDE THE LOOP, CHECK IF THE NUMBER IS EVEN
            //IF SO, PRINT IT

            foreach( int a in numbers) {
                int reminder = a % 2;
                  if ( reminder == 0){
                    Console.WriteLine($"{a} is Even");
                       
                 }else {                    Console.WriteLine($"{a}  is Odd");
                 }
            }
               
            Console.ReadKey();
           

        }
    }

}
