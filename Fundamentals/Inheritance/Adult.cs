namespace Fundamentals.Inheritance
{
    /// <summary>
    /// An adult is a Person with additional properties
    /// and interactions with the world
    /// </summary>
    public class Adult : Person
    {
        /// <summary>
        /// 
        /// </summary>
        public string VatNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string Greet()
        {
            return "Greetings sir/madame";
        }
    }
}
