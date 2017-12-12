using System;
using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class FullNameImmutableShould
    {
        [TestMethod]
        public void Still_have_a_parameterless_constructor()
        {
            var fullName = new FullNameImmutable();

            Console.WriteLine("First: " + fullName.First);
            Console.WriteLine("Middle: " + fullName.Middle);
            Console.WriteLine("Last: " + fullName.Last);
        }

        [TestMethod]
        public void Use_the_parameter_constructor()
        {
            var fullName = new FullNameImmutable("John", "Q", "Public");

            Console.WriteLine("First: " + fullName.First);
            Console.WriteLine("Middle: " + fullName.Middle);
            Console.WriteLine("Last: " + fullName.Last);
        }

        /// <summary>
        /// This will not compile. Uncomment to see that
        /// first name is inaccessible.
        /// </summary>
        //[TestMethod]
        //public void Not_allow_a_value_to_change()
        //{
        //    var fullName = new FullNameImmutable("John", "Q", "Public");

        //    fullName.First = "Fred";

        //    Console.WriteLine("First: " + fullName.First);
        //    Console.WriteLine("Middle: " + fullName.Middle);
        //    Console.WriteLine("Last: " + fullName.Last);
        //}
    }
}
