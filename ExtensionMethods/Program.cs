using System;
using ExtensionMethods.ExtensionMethods;
using ExtensionMethods.Model;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 42;
            int oneHundred = number.Add(58); //add fiftyeight
            Console.WriteLine(oneHundred);

            number = 42;
            int fortyThree = number.Increment(); //get a number that’s 1 higher
            Console.WriteLine(fortyThree);

            
            Person person1 = new Person() { FirstName ="Julia", LastName ="Roz", Email ="julia@roz.net"};
            string fullName = person1.GetFullName(); //returns "Julia Roz"
            string contactInfo = person1.GetContactInfo(); //returns "Julia Roz, email:julia@roz.net"

            string name = "joe larsson";
            string nameCapitalized = name.CapitalizeFirstLetter(); //returns "Joe Larsson"
            Console.WriteLine(name);

            name = "joe larsson is great a basketball";
            int wordCount = name.GetWordCount(); //returns 6
            Console.WriteLine("wordcount: " + wordCount);

            string message = "My password is ant42house13";
            Console.WriteLine("Message: " + message);
            string encodedMessage = message.ROT13(); //returns "Zl cnffjbeq vf nag42ubhfr13"
            Console.WriteLine("Encoded message: " + encodedMessage);
            string decodedMessage = encodedMessage.ROT13(); //returns "My password is ant42house13"
            Console.WriteLine("Decoded message: " + decodedMessage);



        }
    }
}
