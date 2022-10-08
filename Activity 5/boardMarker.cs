using System;

namespace CMSC308_activity5
{
    public struct boardMarker
    {
        public string inkColor;
        public int inkContent;

        public void write(string msg)
        {
            inkContent -= 10;
            Console.WriteLine(msg);
            Console.WriteLine("Remaining ink: " + inkContent);
        }

        public void refill()
        {
            inkContent = 20;
            Console.WriteLine("Remaining ink: " + inkContent);
        }

        public void changeColor(string userColor)
        {
            inkColor = userColor;

            switch (inkColor)
            {
                case "Black":
                    inkColor = "black";
                    break;
                case "Blue":
                    inkColor = "blue";
                    break;
                case "Red":
                    inkColor = "red";
                    break;
            }
        }

        public void note()
        {
            Console.WriteLine("Note: You cannot change the color if the ink is not empty");
            Console.WriteLine("Ink Content: " + inkContent);
        }

        public void noInk()
        {
            Console.WriteLine("There's no more ink please Refill...");
            Console.ReadKey();
        }
    }
}
