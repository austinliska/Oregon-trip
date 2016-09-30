using System;




using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oregon_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            Event StoryTime = new Event();
            int[] StoryTimeReq = new int[6] { 0, 0, 0, 0, 0, 4 };
            int[] StoryTimeChange = new int[6] { 0, 0, 0, 0, 0, -1 };
            StoryTime.set_shit("The car has been quiet for some time now, and everyone seems a bit bored. To help liven things up you tell an embarrassing story from your past. It brings the conversation back to life and every is a little happier.", "The car has been quiet for some time now, and everyone seems a bit bored. To help liven things up you tell an embarrassing story from your past. No one seems to like it or even react at all. Now there's an awkward silence filling the car.", "", "", StoryTimeReq, StoryTimeChange, false);

            Event TvDistraction = new Event();
            int[] T;






        }
    }
    class Event
    {
        string start_str; //started event, passed requirements
        string missed_str; //insufficient stats
        string fail_str; //failure by chance, not stats
        string end_str; //success
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
        bool has_choices;

        public void set_shit(string start_str, string missed_str, string fail_str, string end_str, int[] stat_req, int[] stat_change, bool has_choices = false)
        {
            this.start_str = start_str;
            this.missed_str = missed_str;
            this.fail_str = fail_str;
            this.end_str = end_str;
            this.stat_req = stat_req;
            this.stat_change = stat_change;
            this.has_choices = has_choices;
        }
        public void get_shit(string request)
        {
            if (request == start_str)
            {

            }
        }
    }

    



}
