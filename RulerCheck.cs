using System;
using System.Collections.Generic;
using System.Text;

using TameOfThrones.CustomExceptions;

namespace TameOfThrones
{
    class RulerCheck
    {
        // Function to check if the messages convey if the SPACE kingdom can become the ruler 
        public static void CheckForRuler(List<string> messages)
        {
            var allies = new List<string>();
            foreach (string line in messages)
            {
                string[] splitmessage = line.Split(' ', 2);

                if (!(splitmessage.Length == 2))
                    throw new InvalidInputFormatException("Input is not in the desired format. Please provide proper input");

                string kingdom = splitmessage[0];
                string message = splitmessage[1].Replace(" ", String.Empty);

                if (AllyCheck.IsAllie(kingdom, message))
                    if (!allies.Contains(kingdom))
                        allies.Add(kingdom);
            }

            DisplayOutput(allies);
        }

        static void DisplayOutput(List<string> allies)
        {
            if (allies.Count >= 3)
                Console.WriteLine($"SPACE {String.Join(' ', allies)}");
            else
                Console.WriteLine("None");
        }
    }
}
