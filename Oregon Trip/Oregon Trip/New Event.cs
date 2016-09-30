﻿using System;




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
