using System.IO;

namespace Program2
{
    class Program2
    {
        static void Main(string[] args)
        {
            // Add all the lines from input.txt into an array
            StreamReader fileText = new StreamReader("input.txt");
            string line;
            string[] inputs = new string[1000];
            int lineNum = 0;
            line = fileText.ReadLine();

            while (line != null)
            {
                inputs[lineNum] = line;
                lineNum += 1;
                //Read the next line
                line = fileText.ReadLine();
            }

            //For loop that runs 12 times
for (int i = 0; i < 12; i++)
{
   // Check if the list element is 0 if it is skip the element
                    // Run through the 'i' character from each element in the array
                        // Add to NumOf0 or NumOf1
                

                // Run through the list again finding which elements have the lesser character in that place

                // Change them to 0 
}
        }
    }
}