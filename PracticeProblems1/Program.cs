using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems1
{
    class Program
    {
        static void Main(string[] args)
        {

            /* 
             * week one, day one 
             
             * Use variables to write your name, favorite car, and favorite comic book character
             

            string fullName = "Ashley Hoobler";
            string favoriteCar = "DeLorean";
            string favoriteComic = "Groo";

            Console.WriteLine(fullName);
            Console.WriteLine(favoriteCar);
            Console.WriteLine(favoriteComic);
            */



            //// week one, day two
            //    // can use 'valueOne and valueTwo as variables to cut down the number of variables 
            //    // can makee every data type a double
            //    // c# will delete a zero after the decimal point 

            //// Lisa's cookies 7-2=5

            //int flourNeed = 7;
            //int flourUsed = 2;

            //Console.WriteLine(flourNeed - flourUsed);


            //// Mike's tab 13/3

            //int people = 3;
            //double bill = 13;

            //Console.WriteLine(bill / people);

            //// Diapers 40/8

            //int diapers = 40;
            //double cost = 8;


            //Console.WriteLine(diapers/ cost);

            //// Trevon's money 41-29

            //int startMoney = 41;
            //double endMoney = 29;


            //Console.WriteLine(startMoney - endMoney);

            //// Julia miles 47, Pranav miles 47-30

            //int juliaMiles = 47;
            //int miles = 30;


            //Console.WriteLine(juliaMiles- miles);

            //// envelopes 12/3

            //int boxes = 3;
            //double price = 13;


            //Console.WriteLine(price / boxes);

            //// Norachi salad 27.10 + 5.12


            //endMoney = 27.10;
            //double change = 5.12;


            //Console.WriteLine(endMoney + change);


            // Week One, Day Three


            
            Console.WriteLine("Please enter your name");
            string userName = Console.ReadLine();

            Console.WriteLine("Name one of your friends");
            string friendOne = Console.ReadLine();

            Console.WriteLine("Name a second friend");
            string friendTwo = Console.ReadLine();

            Console.WriteLine("Name a thrid friend");
            string friendThree = Console.ReadLine();

            Console.WriteLine("Who are you faster than?");
            string runner = Console.ReadLine();

            // Lisa's cookies, one person

            double valueOne = 7;
            double valueTwo = 2;
            double valueThree = valueOne - valueTwo;
            //Console.WriteLine(valueOne - valueTwo);

            Console.WriteLine("{0} needs to add {1} cups of sugar.", userName, valueThree);

            //Mike and three friends, 4 people
            valueOne = 13;
            valueTwo = 4;
            valueThree = valueOne * valueTwo;
            //Console.WriteLine(valueOne * valueTwo);

            Console.WriteLine("The total cost for {0}, {1}, {2}, and {3} would be {4} dollars.", userName, friendOne, friendTwo, friendThree, valueThree);

            //Diapers, one person
            valueOne = 40;
            valueTwo = 8;
            valueThree = valueOne / valueTwo;
            // Console.WriteLine(valueOne / valueTwo);

            Console.WriteLine("{0} can buy {1} boxes of diapers with $40.", userName, valueThree);

            //Trevon's chores, one person
            valueOne = 41;
            valueTwo = 29;
            valueThree = valueOne - valueTwo;
            //Console.WriteLine(valueOne - valueTwo);

            Console.WriteLine("{0} recieved {1} dollars for cleaning the attic.", userName, valueThree);

            //Julia runs, two people
            valueOne = 47;
            valueTwo = 30;
            valueThree = valueOne - valueTwo;
            //Console.WriteLine(valueOne - valueTwo);

            Console.WriteLine("{0} ran 47 miles, while {1} only ran {2} miles.", userName, runner, valueThree);

            // envelopes, one person
            valueOne = 12;
            valueTwo = 3;
            valueThree = valueOne / valueTwo;
            //Console.WriteLine(valueOne / valueTwo);

            Console.WriteLine("{0} is able to buy {1} box of envelopes with $12 dollars.", userName, valueThree);

            //Norachi's salad, one person
            valueOne = 27.10;
            valueTwo = 5.12;
            valueThree = valueOne + valueTwo;
            // Console.WriteLine(valueOne + valueTwo);

            Console.WriteLine("Before buying salad, " + userName + " had " + valueThree + " dollars.");
            

            /*
            // MadLib Game


            Console.WriteLine("Enter the name of a country");
            string inputOne = Console.ReadLine();

            Console.WriteLine("Enter an adverb");
            string inputTwo = Console.ReadLine();

            Console.WriteLine("Enter an adjective");
            string inputThree = Console.ReadLine();

            Console.WriteLine("Enter a type of animal");
            string inputFour = Console.ReadLine();

            Console.WriteLine("Enter ta verb ending in 'ing'");
            string inputFive = Console.ReadLine();

            Console.WriteLine("Enter a verb");
            string inputSix = Console.ReadLine();

            Console.WriteLine("Enter ta verb ending in 'ing'");
            string inputSeven = Console.ReadLine();

            Console.WriteLine("Enter an adverb");
            string inputEight = Console.ReadLine();

            Console.WriteLine("Enter an adjective");
            string inputNine = Console.ReadLine();

            Console.WriteLine("Enter a place");
            string inputTen = Console.ReadLine();

            Console.WriteLine("Enter a type of liquid");
            string inputEleven = Console.ReadLine();

            Console.WriteLine("Enter a part of the body");
            string inputTwelve = Console.ReadLine();

            Console.WriteLine("Enter a verb");
            string inputThirteen = Console.ReadLine();


            Console.WriteLine("How to cross a piranha-infested river");

            Console.WriteLine("If you are traveling in {0} and find yourself having to cross a piranha-filled river, here's how to do it {1}", inputOne, inputTwo);
            Console.WriteLine("Piranhas are more {0} at during the day, so cross the river at night.", inputThree);
            Console.WriteLine("Avoid areas with netted {0} traps. Piranhas may be {1} there looking to {2} them!", inputFour, inputFive, inputSix);
            Console.WriteLine("When {0} the river, swim {1}. You don't want to wake them up and make them {2}!", inputSeven, inputEight, inputNine);
            Console.WriteLine("Whatever you do, if you have an open wound, try to find another way to get back to the {0}.", inputTen);
            Console.WriteLine("Piranhas are attracted to fresh {0} and will most likely take a bite out of your {1} if you {2} in the water!", inputEleven, inputTwelve, inputThirteen);
*/

        }
    }
}
