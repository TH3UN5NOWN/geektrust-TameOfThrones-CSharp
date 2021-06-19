using System;
using System.Collections.Generic;
using System.Text;

namespace TameOfThrones
{
    static class SeasarCipherDecryption
    {
        // Method to Decrypt an Seasar cipher encrypted string with a particular decryption order
        // Note: Since the emblems do not have more than 26 characters, the function does not include code in case of second potential second cycle
        public static string Decryption(int decryptionOrder, string s)
        {
            // The decryption is going to be performed by converting the string into lowercase
            string decryptedString = "";

            foreach (char letter in s.ToLower())
            {
                if (letter - decryptionOrder < 97)
                    decryptedString += Convert.ToChar(letter + 26 - decryptionOrder);
                else
                    decryptedString += Convert.ToChar(letter - decryptionOrder);
            }

            return decryptedString;
        }
    }
}
