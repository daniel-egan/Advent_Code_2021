using System.IO;

namespace Program2
{
    class Program2
    {
        static void Main(string[] args)
        {
            oxygenGeneratorMethod();

            CO2ScrubberMethod();

        }

        static void oxygenGeneratorMethod()
        {
            StreamReader fileText = new StreamReader("input.txt");
            string line;
            int NumOf0 = 0;
            int NumOf1 = 0;

            for (int i = 0; i < 12; i++)
            {
                NumOf0 = 0;
                NumOf1 = 0;
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
                //Close file and reopen to restart at first line
                fileText.Close();
                fileText = new StreamReader("input.txt");
            }

            //Check if NumOf0 is STRICTLY greater
            if (NumOf0 > NumOf1)
            {
                //If it is then remove all values that have a 1 in that place
            }
            else
            {
                //Else remove all values with a 0 in that place
            }

            //Start by only doing first character and removing those lines with it

        }
        static void CO2ScrubberMethod()
        {

        }
    }
}