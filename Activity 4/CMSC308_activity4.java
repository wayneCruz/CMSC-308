import java.util.Scanner;
/**
 * CMSC308_activity4
 */
class CMSC308_activity4 {

    public static void main(String[] args) throws Exception {
        Scanner scan = new Scanner(System.in);

        boolean done = false;

        do{
            System.out.print("No. of tes cases: ");
            int testCases = scan.nextInt();

            if ( 1 <= testCases && testCases <= 10){
                String inputs[] = new String[testCases];

                for (int i = 0; i < testCases; i++){
                    scan = new Scanner(System.in);
                    inputs[i] = scan.nextLine(); 
                }

                System.out.println("\nResult: ");
                System.lineSeparator();

                for (String input : inputs)
                System.out.println(processInput(input));

                done = true;
            }else{
                System.out.println("Enter numbers from 1-10 only!");
            }
        }while (!done);
        scan.close();
    }

    private static String processInput(String input){
        
        String[] inputs = input.split("\\s+");

        if(inputs.length != 2)
        return "INVALID INPUT";

        try{
            int uber = Integer.parseInt(inputs[0]);
            int grab = Integer.parseInt(inputs[1]);

            if (uber < 1 || uber > 1000
                || grab < 1 || grab > 1000)
                    return "INVALID INPUT!";
            if (uber < grab )
                return "FIRST";    
            else if (uber > grab)
                return "SECOND";
            else
                return "ANY";
        }
        catch(Exception e){
            return "INVALID INPUT!";
        }
    }
}
