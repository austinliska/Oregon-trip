using System;




using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oregon_Trip
{
    class Program2
    {
        static void NotMain(string[] args)
        {
            Event StoryTime = new Event();
            int[] StoryTimeReq = new int[6] { 0, 0, 4, 0, 0, 0 };
            int[] StoryTimePass = new int[6] { 0, 0, 1, 0, 0, 0 };
            int[] StoryTimeFail = new int[6] { 0, 0, -1, 0, 0, 0 };
            StoryTime.set_shit("The car has been quiet for some time now, and everyone seems a bit bored. To help liven things up you tell an embarrassing story from your past. It brings the conversation back to life and every is a little happier.", "The car has been quiet for some time now, and everyone seems a bit bored. To help liven things up you tell an embarrassing story from your past. No one seems to like it or even react at all. Now there's an awkward silence filling the car.", "", "", StoryTimeReq, StoryTimePass, false);

            Event TvDistraction = new Event();
            int[] TvDistractionReq = new int[6] {0,0,0,0,3,0};
            int[] TVDistractionChange = new int[6] {0,0,0,0,0,1};
            TvDistraction.set_shit("While mindlessly staring at the highway your eyes catch an animated show playing in the minivan parallel to your car. As you start to focus more on the show than your driving a car quickly merges lanes and pumps their brakes.Luckily your ninja - like reflexes kick in and you manage not to crash.", "While mindlessly staring at the highway your eyes catch an animated show playing in the minivan parallel to your car. As you start to focus more on the show than your driving a car quickly merges lanes and pumps their brakes. You’re senses have been dulled by the drive too much for you to notice. As you slam into the car’s bumper, the semi behind you crushes your car like a toy. ", "", "", TvDistractionReq, TVDistractionChange, false);

            Event FightInBackseat = new Event();
            int[] FightInBackseatReq1 = new int[6] { 0, 3, 3, 0, 0, 0 };
            int[] FightInBackseatReq2 = new int[6] { 0, 0, 3, 0, 0, 0 };
            int[] FightInBackseatChange1 = new int[6] { 0, 0, 0, 0, 0, 0 };
            int[] FightInBackseatChange2 = new int[6] { -100, 0, 0, 0, 0, 0 };
            FightInBackseat.set_shit("You hear two people bickering behind you and it’s starting to get heated. Good thing you read all those books for this exact situation. Within seconds you manage to calm everyone down. Way to go champ!", "You hear two people bickering behind you and it’s starting to get heated. You don’t really know how to fix it, so you end up getting elbowed in the back of the head.", "", "", FightInBackseatReq1, FightInBackseatChange1, false);
            FightInBackseat.set_shit("You hear two people bickering behind you and it’s starting to get heated. You don’t really know how to fix it, so you negotiate to pay them fifty dollars each if it will solve this whole situation.", "You hear two people bickering behind you and it’s starting to get heated. You don’t really know how to fix it, so you end up getting elbowed in the back of the head.", "", "", FightInBackseatReq2, FightInBackseatChange2, false);

            Event FlatTire = new Event();
            int[] FlatTireReq1 = new int[6] { 0, 3, 0, 0, 0, 0 };
            int[] FlatTireReq2 = new int[6] { 300, 0, 0, 0, 0, 0 };
            int[] FlatTireChange1 = new int[6] { 0, 0, 0, 0, 0, 0 };
            int[] FlatTireChange2 = new int[6] { -300, 0, 0, 0, 0, 0 };
            FlatTire.set_shit("You’re cruising down the highway when suddenly you hear a loud POP! Good thing you both have a spare and know how to put it on. This is only a minor hiccup in your road trip as you continue on in a few minutes.", "You’re cruising down the highway when suddenly you hear a loud POP! Too bad you didn’t remember to pack a spare and you’re too poor to afford a new one. Looks like this is the end of the road.", "", "", FlatTireReq1, FlatTireChange1, false);
            FlatTire.set_shit("You’re cruising down the highway when suddenly you hear a loud POP! Too bad you didn’t remember to pack a spare. You have to hire a guy to come out and put a new tire on, hope you didn’t want that $300.", "You’re cruising down the highway when suddenly you hear a loud POP! Too bad you didn’t remember to pack a spare and you’re too poor to afford a new one. Looks like this is the end of the road.", "", "", FlatTireReq2, FlatTireChange2, false);





        }
    }
    class OldEvent
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
