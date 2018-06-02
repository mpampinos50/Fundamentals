namespace Fundamentals.Inheritance
{
    /// <summary>
    /// 
    /// </summary>
    public class Person
    {
        /// <summary>
        /// 
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual string Greet()
        {
            return "Hello";
        }
    }
}
