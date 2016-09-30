using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oregon_Trip
{
    class Driver1
    {
        public Driver1(int[] stat_reqs = new int[6], int[] state_changes = new int[6])
        {

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

}