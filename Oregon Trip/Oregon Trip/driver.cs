using System;

public class Driver
{
	public Driver(int[] stat_reqs = new int[5], int[] stat_change = new int[5], int money_req = 0)
        /*
        Function requires an int array of all stat requirements, an int array of the positive and negative changes to all stats
        Optional - the amount of money to start
        */
    {
        Console.WriteLine("The text of the adventure, would you like to begin? (Y/N): ");
        string pq = Console.ReadLine().ToString().Trim().ToLower();
        if (pq == "y")
        {
            //user said yes
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
