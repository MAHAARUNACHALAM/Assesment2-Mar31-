﻿using System.Text.RegularExpressions;

/*Travelling through Europe one needs to pay attention to
how the license plate in the given country is displayed.
When crossing the border you need to park on the shoulder,
unscrew the plate, re-group the characters according to
the local regulations, attach it back and proceed with the journey.

Create a solution that can format the dmv number
into a plate number with correct grouping.
The function input consists of string s and group length n.
 The output has to be upper case characters and digits.
The new groups are made from right to left and connected by -.
 The original order of the dmv number is preserved.

Examples
LicensePlate("5F3Z-2e-9-w", 4) ➞ "5F3Z-2E9W"

LicensePlate("2-5g-3-J", 2) ➞ "2-5G-3J"

LicensePlate("2-4A0r7-4k", 3) ➞ "24-A0R-74K"

LicensePlate("nlj-206-fv", 3) ➞ "NL-J20-6FV"

*/

namespace Assesment2
{
   public class LicensePlate
    {
       public static String LicensePlateNumber(string licensePlate, int len)
        {
            //Removing all the other characters except alphabets and numbers in string licensePlate
            licensePlate = Regex.Replace(licensePlate, "[^a-zA-Z0-9]+", "");
            //Converting the string to upper case
            licensePlate = licensePlate.ToUpper();
            //Reversing the string (As it is Mentioned Right to Left)
            char[] charArray = licensePlate.ToCharArray();
            Array.Reverse(charArray);
            licensePlate = new string(charArray);
            //Adding - after every len characters
            for (int i = len; i < licensePlate.Length; i += len)
            {
                licensePlate = licensePlate.Insert(i, "-");
                i++;
            }
            //Reversing the string again (To Keep the Source Formatting)
            charArray = licensePlate.ToCharArray();
            Array.Reverse(charArray);
            licensePlate = new string(charArray);
            return licensePlate;

        }
        static void Main(string[] args)
        {
           /* LicensePlateNumber("5F3Z-2e-9-w", 4);
            LicensePlateNumber("2-5g-3-J", 2);
            LicensePlateNumber("2-4A0r7-4k", 3);
            LicensePlateNumber("nlj-206-fv", 3);*/
        }
    }
}