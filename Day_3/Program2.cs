using System.IO;

namespace Program2
{
    class Program2
    {
        static void Main(string[] args)
        {
            string oxygen = oxygenGeneratorMethod();
            Console.WriteLine("Oxy " + oxygen);
            string CO2 = CO2ScrubberMethod();
            Console.WriteLine("CO " + CO2);
            changeToInt(oxygen, CO2);


        }

        static void changeToInt(string oxygen, string CO2)
        {
            int lifeSupport = 0;
            long oxygenLong = Int64.Parse(oxygen);
            long CO2Long = Int64.Parse(CO2);

            int oxygenInt = Convert.ToInt32(oxygenLong.ToString(), 2);
            int CO2Int = Convert.ToInt32(CO2Long.ToString(), 2);

            lifeSupport = oxygenInt * CO2Int;

            Console.WriteLine("LifeSupport = " + lifeSupport);
        }

        static string oxygenGeneratorMethod()
        {

            // Add all the lines from input2.txt into an array
            StreamReader fileText = new StreamReader("input2.txt");
            string line;
            string[] inputs = new string[12];
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
            for (int i = 0; i < 5; i++)
            {
                // Check if the list element is 0 if it is skip the element
                int NumOf0 = 0;
                int NumOf1 = 0;

                for (int j = 0; j < 12; j++)
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
                if (NumOf0 < NumOf1 || NumOf0 == NumOf1)
                {
                    lesser = 48;
                }

                // Run through the list again finding which elements have the lesser character in that place

                for (int k = 0; k < 12; k++)
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

        static string CO2ScrubberMethod()
        {


            // Add all the lines from input2.txt into an array
            StreamReader fileText = new StreamReader("input2.txt");
            string line;
            string[] inputs = new string[12];
            int lineNum = 0;
            line = fileText.ReadLine();
            string CO2 = "null";

            while (line != null)
            {
                inputs[lineNum] = line;
                lineNum += 1;
                //Read the next line
                line = fileText.ReadLine();
            }
            fileText.Close();


            //For loop that runs 12 times
            for (int i = 0; i < 5; i++)
            {
                // Check if the list element is 0 if it is skip the element
                int NumOf0 = 0;
                int NumOf1 = 0;

                for (int j = 0; j < 12; j++)
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
                int lesser = 48;
                if (NumOf0 < NumOf1 || NumOf0 == NumOf1)
                {
                    lesser = 49;
                }

                // Run through the list again finding which elements have the lesser character in that place

                for (int k = 0; k < 12; k++)
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
                        CO2 = item;
                    }
                }

            }
            return CO2;

        }

    }
}