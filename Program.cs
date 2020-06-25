using System;
using System.Text.RegularExpressions;

namespace GrandCircusVacationDecisions
{
    class Program
    {
        static void Main(string[] args)


        {


            // Type in the type of trip and press enter
            Console.WriteLine("What kind of trip would you like to go on, musical, tropical, or adventurous?");

            // Create a string variable for vacation type and get user input from the keyboard and store it in the variable
            string vacationType = Console.ReadLine();


            // Type in group size and press enter
            Console.WriteLine("How many people are in your group?");
            // Create a integer variable for group size and get user input from the keyboard and store it in the variable
            int groupSize = Convert.ToInt32(Console.ReadLine());

            if (vacationType == "musical" && groupSize <= 2)
            {
                string result11 = "Since you’re a group of" + " " + groupSize + " " + "going on a" + " " + vacationType + " " + ", " +
                "you should take a First Class trip to New Orleans";

                Console.WriteLine(result11);
            }

            else if (vacationType == "musical" && groupSize <= 5)
            {
                string result12 = "Since you’re a group of" + " " + groupSize + " " + "going on a" + " " + vacationType + " " + ", " +
                                "you should take a helicopter to New Orleans";

                Console.Write(result12);
            }
            else if (vacationType == "musical" && groupSize >= 6)
            {
                string result13 = "Since you’re a group of" + " " + groupSize + " " + "going on a" + " " + vacationType + " " + ", " +
                "you should take a charter flight to New Orleans";

                Console.WriteLine(result13);
            }


            if (vacationType == "tropical" && groupSize <= 2)
            {

                string result21 = "Since you’re a group of" + " " + groupSize + " " + "going on a" + " " + vacationType + " " + ", " +
                "you should take a First Class trip to a Beach Vacation";

                Console.WriteLine(result21);
            }

            else if (vacationType == "tropical" && groupSize <= 5)
            {
                string result22 = "Since you’re a group of" + " " + groupSize + " " + "going on a" + " " + vacationType + " " + ", " +
               "you should take a helicopter to Beach Vacation";


                Console.WriteLine(result22);

            }
            else if (vacationType == "tropical" && groupSize >= 6)
            {
                string result23 = "Since you’re a group of" + " " + groupSize + " " + "going on a" + " " + vacationType + " " + ", " +
                "you should take a charter flight to ";


                Console.WriteLine(result23);
            }





            if (vacationType == "adventurous" && groupSize <= 2)
            {

                string result31 = "Since you’re  a group of" + " " + groupSize + " " + "going on a" + " " + vacationType + " " + ", " +
                "you should take a First Class trip to Whitewater Rafting the Grand Canyon";



                Console.WriteLine(result31);
            }

            else if (vacationType == "adventurous" && groupSize <= 5)
            {

                string result32 = "Since you’re a group of" + " " + groupSize + " " + "going on a" + " " + vacationType + " " + ", " +
               "you should take a helicopter to Whitewater Rafting the Grand Canyon ";


                Console.WriteLine(result32);


            }
            else if (vacationType == "adventurous" && groupSize >= 6)
            {

                string result33 = "Since you’re a group of" + " " + groupSize + " " + "going on a" + " " + vacationType + " " + ", " +
                "you should take a charter flight to Whitewater Rafting the Grand Canyon ";

                Console.WriteLine(result33);
            }










        }
    }
}
