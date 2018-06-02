namespace Fundamentals
{
    using System;

    /// <summary>
    /// 
    /// </summary>
    public class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            var adam = new Inheritance.Person() {
                Age = 1,
                FirstName = "Adam",
                LastName = "Firstofhiskind"
            };

            Console.WriteLine(adam.Greet());
            Console.WriteLine(adam.GetFullName());

            // Adam is now older, a teenager
            var adamTeenager = new Inheritance.Teenager() {
                Age = 15,
                FirstName = "Adam",
                LastName = "Firstofhiskind"
            };

            // Adam as a teenager now. He still
            // communicates his full name and greets people
            Console.WriteLine(adamTeenager.Greet());
            Console.WriteLine(adamTeenager.GetFullName());

            // but now he has to go to school
            adamTeenager.GoToShool();

            // and he rides motorbikes when his mom
            // is not looking.
            adamTeenager.RideMotorbikes();

            // Adam is a fully grown man now.
            // He has an identification number for
            // paying his taxes
            var adamAdult = new Inheritance.Adult() {
                Age = 35,
                FirstName = "Adam",
                LastName = "Firstofhiskind"
            };

            Console.WriteLine(adamAdult.VatNumber);

            // Adam as an adult also greets people in a
            // different way, and thus overriding what is 
            // considered as an standard behaviour
            Console.WriteLine(adamAdult.Greet());
        }
    }
}
