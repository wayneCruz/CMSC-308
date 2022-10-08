using System;

namespace CMSC308_activity5
{
    class mainProgram
    {
        public static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;

            boardMarker marker = new boardMarker();

            int choice = 0;
            string msg = string.Empty;
            string userColor = string.Empty;

            marker.inkColor = "black";
            marker.inkContent = 20;

            while (true)
            {
                switch (marker.inkColor)
                {
                    case "blue":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case "red":
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case "black":
                        Console.ForegroundColor = ConsoleColor.Black;
                        break;
                }

                Console.Clear();
                Console.WriteLine("==MENU==");
                Console.WriteLine("1. Display Info");
                Console.WriteLine("2. Change Color");
                Console.WriteLine("3. Refill");
                Console.WriteLine("4. Write");
                Console.Write("\nEnter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Clear();

                        Console.WriteLine("Ink Content: " + marker.inkContent);
                        Console.WriteLine("Ink Color: " + marker.inkColor);
                        Console.WriteLine("\nPress Enter to Return to MENU...");
                        Console.ReadKey();
                        Console.Write("\n");
                        break;

                    case 2:
                        if (marker.inkContent != 0)
                        {
                            Console.Clear();
                            marker.note();
                            Console.WriteLine("\nPress Enter to Return to MENU...");

                            Console.ReadKey();
                        }

                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Choose from: Black, Blue and Red");
                            Console.Write("New Color: ");
                            userColor = Console.ReadLine();
                            marker.changeColor(userColor);
                            Console.WriteLine("Ink Color = " + marker.inkColor);
                            Console.WriteLine("\nPress Enter to Return to MENU...");
                            Console.ReadKey();
                        }
                        break;

                    case 3:

                        Console.Clear();
                        marker.refill();
                        Console.WriteLine("\nPress Enter to Return to MENU...");
                        Console.ReadKey();

                        break;

                    case 4:

                        if (marker.inkContent == 0)
                        {
                            marker.noInk();
                        }
                        else
                        {
                            Console.Write("Write: ");
                            msg = Console.ReadLine();
                            Console.Write("\n");
                            Console.Write("Message: ");
                            marker.write(msg);
                            Console.Write("\n");
                            Console.WriteLine("\nPress Enter to Return to MENU...");
                            Console.ReadKey();
                        }
                        break;
                }
            }
        }
    }
}
