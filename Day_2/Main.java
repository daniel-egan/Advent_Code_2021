package Day_2;
import java.io.*;

class Main {
    public static void main(String[] args) throws IOException{

      File f = new File("input.txt");
      String filePath = f.getCanonicalPath();

      filePath = filePath.substring(0, filePath.length() - 9);
      filePath = filePath + "Day_2/input.txt";

      BufferedReader fileInput = new BufferedReader(new FileReader(filePath));
        for (String line; (line = fileInput.readLine()) != null;) {
            String split[] = line.split(" ", 0);
            System.out.println("Direction :");
            System.out.println(split[0]);
            System.out.println("Distance :");
            System.out.println(split[1]);

        }
      

      

    }
  }