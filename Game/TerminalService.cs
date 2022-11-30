using System;
namespace Seeker.Game
{

    public class TerminalService
    {

        public TerminalService()
        {
        }
        //READS INPUT AND WRITES OUTPUT
        public int ReadNumber(string prompt)
        {
            string rawValue = ReadText(prompt);
            return int.Parse(rawValue, System.Globalization.CultureInfo.InvariantCulture);
        }

        public string ReadText(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        public void WriteText(string text)
        {
            Console.WriteLine(text);
        }
    }
}