using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace donation_tracker
{
    class Program
    {
        static void Main(string[] args)
        {
            string donorName;
            string donorEmail;
            int fiscalYear;
            float donationAmount;

            Console.WriteLine("What is the donor's name?");
            donorName = Console.ReadLine();
            //Console.WriteLine(donorName); -- testing variable catch

            Console.WriteLine("What is the donor's email address?");
            donorEmail = Console.ReadLine();

            Console.WriteLine("Current fiscal year?");
            fiscalYear = int.Parse(Console.ReadLine());

            Console.WriteLine("Donations are received in hundreds, fifties, twenties, tens, fives, ones, and quarters.");
            Console.WriteLine("How many hundreds would you like to donate?");
            int numHundreds = int.Parse(Console.ReadLine()) * 100;

            Console.WriteLine("How many fifties would you like to donate?");
            int numFifties = int.Parse(Console.ReadLine()) * 50;

            Console.WriteLine("How many twenties would you like to donate?");
            int numTwenties = int.Parse(Console.ReadLine()) * 20;

            Console.WriteLine("How many tens would you like to donate?");
            int numTens = int.Parse(Console.ReadLine()) * 10;

            Console.WriteLine("How many fives would you like to donate?");
            int numFives = int.Parse(Console.ReadLine()) * 5;

            Console.WriteLine("How many ones would you like to donate?");
            int numOnes = int.Parse(Console.ReadLine());

            Console.WriteLine("How many quarters would you like to donate?");
            double numQuarters = int.Parse(Console.ReadLine()) *.25;

            double totalDonation = numHundreds + numFifties + numTwenties + numTens + numFives + numOnes + numQuarters;

            Console.WriteLine("The total donation is $" +totalDonation+ ". Is that correct?");

            Console.ReadKey();
        }
    }
}
