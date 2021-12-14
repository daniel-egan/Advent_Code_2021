package Day_2;
import java.io.*;

class Main {
    public static void main(String[] args) throws IOException{

      File f = new File("input.txt");
      String filePath = f.getCanonicalPath();

      filePath = filePath.substring(0, filePath.length() - 9);
      filePath = filePath + "Day_2/input.txt";

      String split[];
      int vertical = 0;
      int horizontal = 0;

      try (BufferedReader fileInput = new BufferedReader(new FileReader(filePath))) {
        for (String line; (line = fileInput.readLine()) != null;) {
            split = line.split(" ", 0);
            if (split[0].equals("up")){
              int subtraction = Integer.parseInt(split[1]);
              vertical = vertical - subtraction;
            }
            else if (split[0].equals("down")){
              int addition = Integer.parseInt(split[1]);
              vertical = vertical + addition;
            }
            else if (split[0].equals("forward")){
              int addition = Integer.parseInt(split[1]);
              horizontal = horizontal + addition;
            }
            else{
              System.out.println(split[0]);
              break;
            }
        }
      } catch (NumberFormatException e) {
        // TODO Auto-generated catch block
        e.printStackTrace();
      }
        System.out.println("Vertical = " + vertical);
        System.out.println("Horizontal = " + horizontal);

        int multiplication = vertical * horizontal;

        System.out.println("Multiplication = " + multiplication);
      

    }
  }