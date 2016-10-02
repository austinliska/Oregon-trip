using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oregon_Trip
{
    class Driver1
    {
        public static void Driver(Event theEvent, User a)
        /*
        Function requires an int array of all stat requirements, an int array of the positive and negative changes to all stats
        Optional - the amount of money to start
        */
        {
            int use_path = 0;
            
            bool can_proceed = true;
            foreach (int i in theEvent.req1)
            {
                if (a.get_stats()[i] < theEvent.req1[i])
                {
                    can_proceed = false;
                } else
                {
                    use_path = 1;
                }
            }
            if (!can_proceed & theEvent.req2 != null)
            {
                foreach (int i in theEvent.req2)
                {
                    if (a.get_stats()[i] < theEvent.req2[i])
                    {
                        can_proceed = false;
                    }
                    else
                    {
                        use_path = 2;
                        can_proceed = true;
                    }
                }
            }
            if (!can_proceed & theEvent.req3 != null)
            {
                foreach (int i in theEvent.req3)
                {
                    if (a.get_stats()[i] < theEvent.req3[i])
                    {
                        can_proceed = false;
                    }
                    else
                    {
                        use_path = 3;
                        can_proceed = true;
                    }
                }
            }
            if (!can_proceed)
            {
                Console.WriteLine(theEvent.fail);
            }
            else if (use_path == 1)
            {
                Console.WriteLine(theEvent.success);
                a.set_stats(theEvent.change1);
            }
            else if (use_path == 2)
            {
                Console.WriteLine(theEvent.alt1);
                a.set_stats(theEvent.change2);
            }
            else if (use_path == 3)
            {
                Console.WriteLine(theEvent.alt2);
                a.set_stats(theEvent.change3);
            }

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
}
class NewEvent
{

    string success;
    string fail;
    string alt1;
    string alt2;
    int[] req1 = new int[6]; /*
                        Money 0
                        Intelligence 1
                        Charisma 2
                        Strength 3
                        Perception 4
                        Luck 5
                        [0,0,0,3,0,0] requires 3 strength, 0 all other stats
                         */
    int[] req2 = new int[6];
    int[] req3 = new int[6];
    int[] change1 = new int[6];
    int[] change2 = new int[6];
    int[] change3 = new int[6];


    public void set(int[] req1, int[] change1, string success, string fail, int[] req2 = null, int[] change2 = null, string alt1 = null, int[] req3 = null, int[] change3 = null, string alt2 = null)
    {
        this.req1 = req1;
        this.change1 = change1;
        this.success = success;
        this.fail = fail;
        this.req2 = req2;
        this.change2 = change2;
        this.alt1 = alt1;
        this.req3 = req3;
        this.change3 = change3;
        this.alt2 = alt2;
    }
    
}