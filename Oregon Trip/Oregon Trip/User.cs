using System;

public class User
{
    int Money;
    int Intelligence;
    int Charisma;
    int Strength;
    int Perception;
    int Luck;
    int[] stats = new int[6];
    public User()
	{
        
        int num;
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
        stats[0] = Money;
        stats[1] = Intelligence;
        stats[2] = Charisma;
        stats[3] = Strength;
        stats[4] = Perception;
        stats[5] = Luck;
	}
    public int[] get_stats()
    {
        return stats;
    }
    public void set_stats(int[] change)
    {
        foreach (int i in change)
        {
            stats[i] += change[i];
        }
    }

}
