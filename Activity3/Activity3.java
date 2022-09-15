import java.util.Scanner;
/**
 * Activity3
 */
public class Activity3 {

    public static void main(String[] args) {
        int eng, math, sci, map;
        
        Scanner s = new Scanner(System.in);

        System.out.print("English :");
        eng = s.nextInt();
        System.out.print("Math    :");
        math = s.nextInt();
        System.out.print("Science :");
        sci = s.nextInt();
        System.out.print("MAPEH   :");
        map = s.nextInt();

        int total = eng + math + sci + map;
        float average = total / 4;

        System.out.println("\nAverage  :" + average);

        if (average > 100)
        {
        System.out.println("Invalid Grade!");
        }
        else if(average >=98)
        {
        System.out.println("With Highest Honors!");
        }
        else if (average >=95)
        {
        System.out.println("With High Honors!");
        }
        else if (average >=90)
        {
        System.out.println("With Honors!");
        }
        else if (average >=75)
        {
        System.out.println("Passed!");
        }
        else if (average < 75)
        {
        System.out.println("Failed!");
        }
    }
}