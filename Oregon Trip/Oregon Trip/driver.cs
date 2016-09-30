using System;

public class Driver
{
    int num;
    int Money;
    int Intelligence;
    int Charisma;
    int Strength;
    int Perception;
    int Luck;
    public Driver(int[] stat_reqs, int[] stat_change, int money_req = 0)
    /*
    Function requires an int array of all stat requirements, an int array of the positive and negative changes to all stats
    Optional - the amount of money to start
    */
    {
        Console.WriteLine("The text of the adventure, would you like to begin? (Y/N): ");
        string pq = Console.ReadLine().ToString().Trim().ToLower();
        if (pq == "y")
        {
            Console.WriteLine("/nSelect your class /n 1. Jock /n 2. Cheerleader /n 3. Nerd /n 4. Metalhead /n 5.Stoner");
            num = Convert.ToInt32(Console.ReadLine());
            if (num == 1)
            {
                Money = 1000;
                Intelligence = 1;
                Charisma = 3;
                Strength = 5;
                Perception = 4;
                Luck = 3;
            }

            else if (num == 2)
            {
                Money = 2500;
                Intelligence = 1;
                Charisma = 5;
                Strength = 3;
                Perception = 1;
                Luck = 3;
            }

            else if (num == 3)
            {
                Money = 2000;
                Intelligence = 5;
                Charisma = 2;
                Strength = 2;
                Perception = 2;
                Luck = 3;
            }
            else if (num == 4)
            {
                Money = 500;
                Intelligence = 4;
                Charisma = 3;
                Strength = 4;
                Perception = 3;
                Luck = 3;
            }

            else if (num == 5)
            {
                Money = 1500;
                Intelligence = 3;
                Charisma = 3;
                Strength = 3;
                Perception = 3;
                Luck = 3;
            }
        }
        else if (pq == "n")
        {
            //user said no
        }
        else
        {
            //invalid input
        }
    }
}