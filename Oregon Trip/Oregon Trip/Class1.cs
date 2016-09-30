using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oregon_Trip
{
    class Driver1
    {
        public void Driver(Event theEvent)
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
    class NewEvent
    {

        string success;
        string fail_str;
        string alt_str1;
        string alt_str2;
        int[] stat_req = new int[6]; /*
                        Money 0
                        Intelligence 1
                        Charisma 2
                        Strength 3
                        Perception 4
                        Luck 5
                        [0,0,0,3,0,0] requires 3 strength, 0 all other stats
                         */
        int[] stat_change = new int[6];
        int[] alt_stat_change1 = new int[6];
        int[] alt_stat_Req1 = new int[6];
        int[] alt_stat_change2 = new int[6];
        int[] alt_stat_Req2 = new int[6];


        public void set(int[] Req1, int[] Change1, string Sucess, string Fail, int[] req2 = null, int[] Change2 = null, string alt1 = null, int[] Req3 = null, int[] Change3 = null, string alt2 = null)
        {
            this.Req1 = Req1;
            this.Change1 = Change1;
            this.Sucess = Sucess;
            this.Fail = Fail;
            this.Req2 = Req2;
            this.change2 = Change2;
            this.alt1 = alt1;
            this.req3 = Req3;
            this.change3 = Change3;
            this.alt2 = alt2;
        }
    }

}