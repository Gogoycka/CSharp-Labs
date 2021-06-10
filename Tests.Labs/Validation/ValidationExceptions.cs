using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using CSharp_Labs;
using CSharp_Labs.Validation;

namespace Tests.Labs.Validation
{
    class ValidationExceptions
    {
        [TestCase("No more cookies", "I like cookies")]
        [TestCase("300 spartans", "300tans")]
        public void StringValidationsTests_IsEqual(string value1, string value2)
        {
            Assert.Throws<ValidationException>(() => Validations.IsEqual(value1, value2));
        }
        
        [TestCase("iphone 7", "iPhone X")]
        [TestCase("     Rust", "Iron     ")]
        public void StringValidationsTests_IsEqualNormalized(string value1, string value2)
        {
            Assert.Throws<ValidationException>(() => Validations.IsEqualNormalized(value1, value2));
        }
        
        [TestCase("test", "test")]
        [TestCase("     044", "    566   ")]
        public void StringValidationsTests_IsPalindrome(string value1, string value2)
        {
            Assert.Throws<ValidationException>(() => Validations.IsPalindrome(value1, value2));        
        }
        
        [TestCase("testmail")]
        [TestCase("zxcqwe@bk")]
        public void StringValidationsTests_IsEmail(string value1)
        {
            Assert.Throws<ValidationException>(() => Validations.IsEmail(value1));
        }
        
        [TestCase("test")]
        [TestCase("+458654sss444555")]
        public void StringValidationsTests_IsPhoneNumber(string value1)
        {
            Assert.Throws<ValidationException>(() => Validations.IsPhoneNumber(value1));
        }
        
        [TestCase("255.120.0.z")]
        [TestCase("102.106.5")]
        public void StringValidationsTests_IsIP(string value1)
        {
            Assert.Throws<ValidationException>(() => Validations.IsIP(value1));
        }
    }
}
