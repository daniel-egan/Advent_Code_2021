using System.IO;

namespace Program2
{
    class Program2
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
            //Close file and reopen to restart at first line
            fileText.Close();
            fileText = new StreamReader("input.txt");
            // Create Array with size numOfLines
            int[] fileInput = new int[numOfLines];
            // Create string for the final value. This will be appended to before the for loop restarts to get the most common bit of each line
            string gammaRate = "";

            //Check the first character add one to the corresponding int for 1 or 0
            //Go to next line
            //Do for all 12 characters

            for (int i = 0; i < 12; i++)
            {
                int NumOf0 = 0;
                int NumOf1 = 0;
                line = fileText.ReadLine();

                while (line != null)
                {
                    //Split the line into characters 
                    char[] characters = line.ToCharArray();
                    //Add one to the int for 1(49) or 0(48)
                    if (characters[i] == 48)
                    {
                        NumOf0 += 1;
                    }

                    else if (characters[i] == 49)
                    {
                        NumOf1 += 1;
                    }

                    //Read the next line
                    line = fileText.ReadLine();
                }

                //Check which is more value is more common

                if (NumOf0 < NumOf1)
                {
                    gammaRate += "1";
                }
                else
                {
                    gammaRate += "0";
                }


                //Close file and reopen to restart at first line
                fileText.Close();
                fileText = new StreamReader("input.txt");
            }

            //Calculate epsilon rate by flipping 1 to 0 and 0 to 1
            string epsilonRate = "";

            char[] gammaRateArray = gammaRate.ToCharArray();

            for (int i = 0; i < 12; i++)
            {
                int flipValue = gammaRateArray[i];
                if (flipValue == 49)
                {
                    epsilonRate += "0";
                }
                else
                {
                    epsilonRate += "1";
                }
            }

            //Create powerConsumption int
            int powerConsumption = 0;

            //Convert into binary long's
            long gammaRateLong = Int64.Parse(gammaRate);
            long epsilonRateLong = Int64.Parse(epsilonRate);

            //Convert binary numbers into decimals
            int gammaRateInt = Convert.ToInt32(gammaRateLong.ToString(), 2);
            int epsilonRateInt = Convert.ToInt32(epsilonRateLong.ToString(), 2);

            //Multiply numbers together to get powerConsumption
            powerConsumption = gammaRateInt * epsilonRateInt;

            Console.WriteLine(powerConsumption);
        }
    }
}