using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

using TameOfThrones.CustomExceptions;

namespace TameOfThrones
{
    class AllyCheck
    {
        // A Dictionary containing the names of 6 kingdoms with their emblems
        static readonly Dictionary<string, string> kingdomEmblems = new Dictionary<string, string> {
            {"SPACE", "gorilla"},
            {"LAND", "panda"},
            {"WATER", "octopus"},
            {"ICE", "mammoth"},
            {"AIR", "owl"},
            {"FIRE", "dragon"}
        };

        // Method to check if a kingdom is an ally of SPACE kingdom based on the message sent to the kingdom
        public static bool IsAllie(string kingdom, string message)
        {
            if (!kingdomEmblems.TryGetValue(kingdom, out string emblemSymbol))
                throw new KingdomNotFoundException("Kingdom Name is invalid. Please give valid input");

            if (!ValidateMessage(message))
                throw new InvalidMessageException("Message does not contain only letters. Please give valid input");

            string decryptedmessage = SeasarCipherDecryption.Decryption(emblemSymbol.Length, message);

            Dictionary<char, int> SymbolLettersWithCount = LettersCount(emblemSymbol);
            int count = 0;
            foreach (var item in SymbolLettersWithCount)
            {
                if (item.Value <= decryptedmessage.Count(x => (x == item.Key)))
                    count++;
                    
            }

            if (count == SymbolLettersWithCount.Count)
                return true;
            return false;
        }

        // A method to validate a message to check if it contains only letters
        static bool ValidateMessage(string message) => Regex.IsMatch(message, @"^[a-zA-Z]+$");

        // A method to return a dictionary containing all the letters present in a string with it's frequency
        static Dictionary<char, int> LettersCount(string s)
        {
            var LettersWithCount = new Dictionary<char, int>();

            var linqQuery = s.GroupBy(x => x)
                             .Select(group => new {
                                     key = group.Key,
                                     count = group.Count()
                            });

            foreach (var item in linqQuery)
            {
                LettersWithCount.Add(item.key, item.count);
            }

            return LettersWithCount;
        }
    }
}
