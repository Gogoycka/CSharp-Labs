using System;
using System.Collections.Generic;
using System.Text;
using CSharp_Labs.Validation;

namespace CSharp_Labs.MenuItems
{
    public class MenuItemStringsValidation : MenuItemCore
    {
        public override string Title { get { return "Strings"; } }

        public override void Execute(IOUtils IOClass)
        {
            string FirstString, SecondString;
            FirstString = IOClass.ReadString("First string", "Enter first string:");
            SecondString = IOClass.ReadString("Second string", "Enter second string:");

            CatchIsEqual(FirstString, SecondString);
            CatchIsEqualNormalized(FirstString, SecondString);
            CatchIsPalindrome(FirstString, SecondString);
            CatchIsEmail(FirstString);
            CatchIsEmail(SecondString);
            CatchIsPhoneNumber(FirstString);
            CatchIsPhoneNumber(SecondString);
            CatchIsIP(FirstString);
            CatchIsIP(SecondString);
        }
        public void CatchIsEqual(string FirstString, string SecondString)
        {
            try
            {
                Validations.IsEqual(FirstString, SecondString);
                IOUtils.WriteString("Strings are equal.");
            }
            catch (ValidationException ex)
            {
                IOUtils.WriteString(ex.Message);
            }
        }

        public void CatchIsEqualNormalized(string FirstString, string SecondString)
        {
            try
            {
                Validations.IsEqualNormalized(FirstString, SecondString);
                IOUtils.WriteString("Normalized strings are equal.");
            }
            catch (ValidationException ex)
            {
                IOUtils.WriteString(ex.Message);
            }
        }

        public void CatchIsPalindrome(string FirstString, string SecondString)
        {
            try
            {
                Validations.IsPalindrome(FirstString, SecondString);
                IOUtils.WriteString("Strings are palindromes.");
            }
            catch (ValidationException ex)
            {
                IOUtils.WriteString(ex.Message);
            }
        }

        public void CatchIsEmail(string FirstString)
        {
            try
            {
                Validations.IsEmail(FirstString);
                IOUtils.WriteString(string.Format("String {0} contains E-mail", FirstString));
            }
            catch (ValidationException ex)
            {
                IOUtils.WriteString(ex.Message);
            }
        }

        public void CatchIsPhoneNumber(string FirstString)
        {
            try
            {
                Validations.IsPhoneNumber(FirstString);
                IOUtils.WriteString(string.Format("String {0} contains phone number", FirstString));
            }
            catch (ValidationException ex)
            {
                IOUtils.WriteString(ex.Message);
            }
        }

        public void CatchIsIP(string FirstString)
        {
            try
            {
                Validations.IsIP(FirstString);
                IOUtils.WriteString(string.Format("String {0} contains IP", FirstString));
            }
            catch (ValidationException ex)
            {
                IOUtils.WriteString(ex.Message);
            }
        }
    }
}
