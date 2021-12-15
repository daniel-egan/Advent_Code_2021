using System.IO;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
           string line;
           int numOfLines = 0;
           //Pass the file path and file name to the StreamReader constructor
           StreamReader fileText = new StreamReader("input.txt");
            //Read the first line of text
            line = fileText.ReadLine();

            while (line != null)
            {
                //Read the next line
                line = fileText.ReadLine();
                //Add one to the numOfLines
                numOfLines += 1;
            }

            Console.WriteLine(numOfLines);

        }
    }
}