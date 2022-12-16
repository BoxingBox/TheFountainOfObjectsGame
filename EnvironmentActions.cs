using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//status info
//0 fountain position
//1 empty room


namespace TheFountainOfObjects
{
    internal class EnvironmentActions
    {
        DateTime StartTime = DateTime.Now;       
        public int _X_Fountain_;
        public int _Y_Fountain_;
        public bool IsTurnedOn;
        public EnvironmentActions(int X_Fountain_Coordinate, int Y_Fountain_Coordinate, int X_Max_Size, int Y_Max_Size)
        {
            _X_Fountain_ = X_Fountain_Coordinate;
            _Y_Fountain_ = Y_Fountain_Coordinate;

            int[,] map = new int[X_Max_Size, Y_Max_Size];
            map[X_Fountain_Coordinate,Y_Fountain_Coordinate] = 0;

        }

        public void FountainProximityNotification(int XCurrentPosition, int YCurrentPosition)
        {
            if((XCurrentPosition==1 || XCurrentPosition==3) && (YCurrentPosition==1 || YCurrentPosition==0))
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.White;
            }
            if ((XCurrentPosition == 1 || XCurrentPosition == 2 || XCurrentPosition == 3) && (YCurrentPosition==1))
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("You can faintly hear the sounds of rushing water. You are near the fountain!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            if( XCurrentPosition == 2 && YCurrentPosition == 0  )
            {
                Console.ForegroundColor=ConsoleColor.Cyan;
                Console.WriteLine("You hear water dripping in this room. The fountain is here! You have stumbled upon the fountain of objects!");
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1: Turn On");
                Console.WriteLine("2: Turn Off");
                Console.ForegroundColor = ConsoleColor.White;
                int input = Convert.ToInt32(Console.ReadLine());
                switch(input)
                {
                    case 1: TurnFountainOn(); 
                        DateTime EndTime = DateTime.Now;
                        var TotalTime = StartTime - EndTime;
                        Console.WriteLine("You have turned the fountain on in " + -TotalTime.TotalSeconds+ " seconds");
                        break;

                    case 2: TurnFountainOff(); break;
                    
                }
            }
        }
        public bool TurnFountainOn()
        {
            IsTurnedOn = true;
            Console.WriteLine("The Fountain is now turned on!");
            return IsTurnedOn;
        }
        public bool TurnFountainOff()
        {
            IsTurnedOn = false;
            Console.WriteLine("The Fountain is now turned off!");
            return IsTurnedOn;
        }


    }
}
