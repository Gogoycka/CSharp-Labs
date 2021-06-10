using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using CSharp_Labs;
using CSharp_Labs.Validation;

namespace Tests.Labs.MenuItemsTests
{
    class MenuItemStringsValidationTests
    {
        [TestCase("Plus", "Plus", true)]
        [TestCase("89996584336", "89996584336", true)]
        [TestCase("No more cookies", "I like cookies", false)]
        [TestCase("300 spartans", "300tans", false)]
        
        public void StringValidationsTests_IsEqual(string value1, string value2, bool expected)
        {
            if (expected)
            {
                Validations.IsEqual(value1, value2);
            }
            else
            {
                Assert.That(() => Validations.IsEqual(value1, value2),
                    Throws.TypeOf<ValidationException>());
            }
        }

        [TestCase("  Testing", "TeStInG  ", true)]
        [TestCase("89996584336", "89996584336", true)]
        [TestCase("iphone 7", "iPhone X", false)]
        [TestCase("     Rust", "Iron     ", false)]
        public void StringValidationsTests_IsEqualNormalized(string value1, string value2, bool expected)
        {
            if (expected)
            {
                Validations.IsEqualNormalized(value1, value2);
            }
            else
            {
                Assert.That(() => Validations.IsEqualNormalized(value1, value2),
                    Throws.TypeOf<ValidationException>());
            }
        }

        [TestCase("zxc", "cxz", true)]
        [TestCase("aboba", "aboba", true)]
        [TestCase("test", "test", false)]
        [TestCase("     044", "    566   ", false)]
        public void StringValidationsTests_IsPalindrome(string value1, string value2, bool expected)
        {
            if (expected)
            {
                Validations.IsPalindrome(value1, value2);
            }
            else
            {
                Assert.That(() => Validations.IsPalindrome(value1, value2),
                    Throws.TypeOf<ValidationException>());
            }
        }

        [TestCase("man@mail.ru", true)]
        [TestCase("gogoycka@gmail.com", true)]
        [TestCase("testmail", false)]
        [TestCase("zxcqwe@bk", false)]
        public void StringValidationsTests_IsEmail(string value1, bool expected)
        {
            if (expected)
            {
                Validations.IsEmail(value1);
            }
            else
            {
                Assert.That(() => Validations.IsEmail(value1),
                    Throws.TypeOf<ValidationException>());
            }
        }

        [TestCase("+79996584336", true)]
        [TestCase("89996584336", true)]
        [TestCase("test", false)]
        [TestCase("+458654sss444555", false)]
        public void StringValidationsTests_IsPhoneNumber(string value1, bool expected)
        {
            if (expected)
            {
                Validations.IsPhoneNumber(value1);
            }
            else
            {
                Assert.That(() => Validations.IsPhoneNumber(value1),
                    Throws.TypeOf<ValidationException>());
            }
        }

        [TestCase("127.0.0.1", true)]
        [TestCase("192.168.1.1", true)]
        [TestCase("255.120.0.z", false)]
        [TestCase("102.106.5", false)]
        public void StringValidationsTests_IsIP(string value1, bool expected)
        {
            if (expected)
            {
                Validations.IsIP(value1);
            }
            else
            {
                Assert.That(() => Validations.IsIP(value1),
                    Throws.TypeOf<ValidationException>());
            }
        }
    }
}
