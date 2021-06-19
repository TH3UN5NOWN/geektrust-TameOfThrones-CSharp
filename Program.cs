using System;
using System.IO;
using System.Collections.Generic;

namespace TameOfThrones
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = args[0];
            var fileStream = new FileStream(filename, FileMode.Open);
            string line;

            var messages = new List<string>();
            using (var reader = new StreamReader(fileStream))
            {
                while ((line = reader.ReadLine()) != null)
                    messages.Add(line);
            }

            RulerCheck.CheckForRuler(messages);
        }
    }
}
