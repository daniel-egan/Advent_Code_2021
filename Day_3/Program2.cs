using System.IO;

namespace Program2
{
    class Program2
    {
        static void Main(string[] args)
        {
            string oxygen = oxygenGeneratorMethod();
        }

        static string oxygenGeneratorMethod(){
            
            // Add all the lines from input.txt into an array
            StreamReader fileText = new StreamReader("input.txt");
            string line;
            string[] inputs = new string[1000];
            int lineNum = 0;
            line = fileText.ReadLine();
            string oxygen = "null";

            while (line != null)
            {
                inputs[lineNum] = line;
                lineNum += 1;
                //Read the next line
                line = fileText.ReadLine();
            }
            fileText.Close();


            //For loop that runs 12 times
            for (int i = 0; i < 12; i++)
            {
                // Check if the list element is 0 if it is skip the element
                int NumOf0 = 0;
                int NumOf1 = 0;

                for (int j = 0; j < 1000; j++)
                {
                    //Split the array element into characters 
                    char[] characters = inputs[j].ToCharArray();
                    //Add one to the int for 1(49) or 0(48)
                    if (characters.Length != 1)
                    {
                        if (characters[i] == 48)
                        {
                            NumOf0 += 1;
                        }

                        else if (characters[i] == 49)
                        {
                            NumOf1 += 1;
                        }
                    }
                }

                // Find lesser value
                int lesser = 49;
                if (NumOf0 < NumOf1)
                {
                    lesser = 48;
                }

                // Run through the list again finding which elements have the lesser character in that place

                for (int k = 0; k < 1000; k++)
                {
                    char[] characters = inputs[k].ToCharArray();
                    if (characters.Length != 1)
                    {
                        // Change them to 0 
                        if (characters[i] == lesser)
                        {
                            inputs[k] = "0";
                        }
                    }
                }

                // Set oxygen to value
                foreach (string item in inputs)
                {
                    if (item.Equals("0"))
                    {
                    }
                    else
                    {
                        oxygen = item;
                    }
                }

            }

        return oxygen;
        }
    }
}