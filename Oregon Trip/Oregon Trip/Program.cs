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
<<<<<<< HEAD
            int[] leprechaunarray = new int[6] { 0, 0, 0, 0, 4, 0 };
            int[] leprechaunstatchange = new int[6] { 0, 0, 0, 0, 0, 1 };
            Event Leprechaun = new Event();
<<<<<<< HEAD
            Leprechaun.set(leprechaunarray, leprechaunstatchange,"OMFG! You just noticed a leprechaun on the dashboard rocking out to “We Built This On Rock and Roll” you were quick enough to catch it and it gave you a lucky coin as a reward!", "You get the feeling you just missed out on something big, but whatevs, crank the tunes!");
=======
            Leprechaun.set_shit(leprechaunarray, leprechaunstatchange, "OMFG! You just noticed a leprechaun on the dashboard rocking out to “We Built This On Rock and Roll” you were quick enough to catch it and it gave you a lucky coin as a reward!", "You get the feeling you just missed out on something big, but whatevs, crank the tunes!");
>>>>>>> origin/master

            int[] rideinstylearray = new int[6] { 0, 0, 4, 0, 0, 5 };
            int[] rideinstylestatchange = new int[6] { 0, 0, 0, 0, 0, 0 };
            Event RideInStyle = new Event();
<<<<<<< HEAD
            RideInStyle.set(rideinstylearray, rideinstylestatchange, "While stopped at a gas station in the middle of nowhere, you notice that the band you were going to see is also stopped there. You approach them letting them know what big fans you guys are of the band. Charmed by your kind words, the band offers to let you ride with them all the way to Oregon! Rock on!", "You sense a disturbance in the force, as though you just missed out on the event of your life.");
=======
            RideInStyle.set_shit("While stopped at a gas station in the middle of nowhere, you notice that the band you were going to see is also stopped there. You approach them letting them know what big fans you guys are of the band. Charmed by your kind words, the band offers to let you ride with them all the way to Oregon! Rock on!", "You sense a disturbance in the force, as though you just missed out on the event of your life.", "", "", rideinstylearray, rideinstylestatchange);
>>>>>>> origin/master

            int[] deerarray = new int[6] { 0, 0, 0, 0, 3, 0 };
            int[] deerstatchange = new int[6] { -500, 0, 0, 0, 0, 0 };
            Event Deer = new Event();
<<<<<<< HEAD
            Deer.set( deerarray, none, "A deer just sauntered into the road, but you were quick enough to avoid it. Keep on truckin’", "You just hit a deer, and with no money to fix the car, it looks like you're hitchhiking back.", deerstatchange, "You hit a deer! It was an accident, but you still feel bad. Not to mention the cost this is going to be for repairs.");
=======
            Deer.set_shit(deerarray, none, "A deer just sauntered into the road, but you were quick enough to avoid it. Keep on truckin’", "You just hit a deer, and with no money to fix the car, it looks like you're hitchhiking back.", deerstatchange, "You hit a deer! It was an accident, but you still feel bad. Not to mention the cost this is going to be for repairs.");
>>>>>>> origin/master

            int[] dysenteryarray = new int[6] { 0, 4, 0, 0, 2, 0 };
            int[] dysenterystatchange = new int[6] { 0, -1, -1, -1, 0, 0 };
            int[] none = new int[6] { 0, 0, 0, 0, 0, 0 };
            int[] doctorsfee = new int[6] { -2000, 0, 0, 0, 0, 0 };
            Event Dysentery = new Event();
            Dysentery.set(dysenteryarray, dysenterystatchange, "Your bro Steve got a case of Dysentery from some gas station sushi, luckily you were able to cure it with science or whatever.", "Steve almost died from dysentery and gave it to you! Nasty", doctorsfee, "Your bro Steve almost died of Dysentery, you had to pay a doctor mucho dinero to get that fixed, not to mention reupholstering the passenger seat, ugh.");

            int[] mirrorarray = new int[6] { 0, 3, 0, 0, 0, 0 };
            int[] mirrorstatchange = new int[6] { 0, 0, 0, 0, 0, -1 };
            Event Mirror = new Event();
            Mirror.set(mirrorarray, none, "You seem to have cracked a mirror, luckily some quick glass welding has lead to you getting it repaired quickly.", "Your mirror has broken, but that old superstition doesn’t apply to car mirrors. Does it?", none, mirrorstatchange);

            int[] mexicanstandoffarray = new int[6] { 2, 2, 2, 2, 2, 2 };
            int[] mexicanstandoffchange = new int[6] { 2000, 0, 0, 0, 0, 0 };
            Event MexicanStandoff = new Event();
            MexicanStandoff.set(mexicanstandoffarray, mexicanstandoffchange, "Entered into a Mexican Standoff, things looked bleak, but you kept a cool head and in the end you got the money.", "You were shot to death in a mexican standoff");

            int[] badgerarray = new int[6] { 0, 0, 0, 0, 0, 3 };
            int[] badgerchange = new int[6] { 5, 0, 0, 0, 0, 0 };
            Event Badger = new Event();
            Badger.set(badgerarray, badgerchange, "Steve found 5 bucks under the seat, sweet!", "OH LORD A BADGER! ALL IS LOST!");

            int[] hillfolkarray = new int[6] { 0, 0, 0, 0, 3, 4 };
            int[] hillfolkstatchange = new int[6] { 500, 0, 0, 0, 0, 0 };
            Event Hillfolk = new Event();
            Hillfolk.set(hillfolkarray, hillfolkstatchange, "You enter the shortcut, only to find that it is in fact a trap set by hillbillys! You back up as fast as you can accidentally hitting a tree, luckily for you the tree topples over and crushes the hillbillys. You steal their Pickup and continue your travels with mountains of hillbilly gold.", "Unfortunately the detour was a trap and your entire roadtrip crew is robbed by hillbillys. At least they didn’t eat you.");

            int[] carsickarray = new int[6] { 0, 3, 0, 0, 0, 0 };
            int[] carsickstatchange = new int[6] { 0, 0, -1, -1, 0, 0 };
            Event Carsick = new Event();
            Carsick.set(carsickarray, none, "The allure of staring out the side windows does not tempt you. You remain healthy.", "You were staring out the window for too long and got carsick, way to ruin your only shirt.", none, carsickstatchange);

            int[] ghostarray = new int[6] { 0, 0, 0, 0, 0, 3 };
            int[] ghostchange = new int[6] { 0, 1, 1, 1, 1, 1 };
            int[] ghostcurse = new int[6] { 0, 0, 0, 0, 0, -1 }; 
            Event Ghost = new Event();
            Ghost.set(ghostarray, ghostchange, "You pick up a hitchhiking ghost somewhere outside of Alabama, turns out he’s a pretty chill dude and imbues you with supernatural powers.", "You totally were going to pick up that hitchhiker, but then Keith was all like “NOOOO” and so now we’re cursed forever. Frickin’ Keith.", ghostcurse);

            int[] pulloverarray = new int[6] { 0, 0, 3, 0, 0, 0 };
            int[] pulloverfine = new int[6] { 300, 0, 0, 0, 0, 0 };
            int[] pulloverchange = new int[6] { -300, 0, 0, 0, 0, 0 };
            Event Pullover = new Event();
            Pullover.set(pulloverarray, none, "You get pulled over, but are let off with a warning. Good thing you’re so charming.", "Unable to pay a fine, your car is impounded, your journey ends here.", pulloverfine, pulloverchange, "You get pulled over for speeding, you try to explain that a bird flew into the car and that’s why, but the cop isn’t buying it.", none);

            int[] sportsarray = new int[6] { 0, 0, 0, 4, 0, 0 };
            int[] sportsarray2 = new int[6] { 0, 2, 4, 0, 0, 0 };
            int[] sportsstatchange = new int[6] { 0, 0, 1, 0, 0, 0 };
            int[] sportsstatchange2 = new int[6] { 150, 0, 0, 0, 0, 0 };
            Event Sports = new Event();
            Sports.set(sportsarray, sportsstatchange, "You are attacked by gang of fans that support your rival sports team, despite attacking you 4 to 1, you fight them off and become a hero to the fans of that sports team you support.", "You are jumped outside a gas station and beaten unconscious by a gang of rival sports fans, you try to fight back but they outnumber you 4 to 1. You wake up battered and bruised in the hospital, this roadtrip is over.", sportsarray2, sportsstatchange2, "You ambushed outside a convenience store by fans of your rival sports team, thinking quickly you distract them by claiming that “Go Sports Team!” bumper sticker on your car belongs to an aged man in a rocking chair. By the time they discover the ruse, you have looted their car and escaped.");

            int[] birdarray = new int[6] { 0, 0, 0, 0, 2, 0 };
            int[] birdstatchange = new int[6] { 0, 0, 0, 0, 0, 0 };
            Event Bird = new Event();
            Bird.set("A bird flies into the car, but your razor sharp focus allows you to keep control of the car while you travelling companions shoo out the bird.", "A bird flies into your car, unable to keep focus you freak out and drive the car off a gorge.", "", "", leprechaunarray, leprechaunstatchange);

            int[] alienarray = new int[6] { 0, 5, 0, 0, 2, 3 };
            int[] alienstatchange = new int[6] { 0, 0, -1, -1, 0, 0 };
            Event Alien = new Event();
            Alien.set("While driving along a Nevada Highway you notice a piece of wreckage alongside the road, thinking they might have had some sweet tunes, you naturally sift through the wreckage only to come across an alien! Performing a quick surgery using your shoelaces to connect what appears to be lungs. The alien is grateful and turns out to be the king of the universe on his way to the Oregon for the same concert you’re going to! As thanks for saving his life you are promised the Space Princess’ hand in marriage and are taken to the concert in the luxury of an Emperor Class Starship! Nice.", "While driving along a Nevada Highway you notice a piece of wreckage alongside the road, thinking they might have had some sweet tunes, you naturally sift through the wreckage only to come across an alien! You attempt to perform surgery on the alien, but you have no idea what you’re doing. The alien bloats up and explodes in your face. Nasty.", "", "", alienarray, alienstatchange);

            int[] gasarray = new int[6] { 0, 0, 0, 0, 4, 0 };
            int[] gasstatchange = new int[6] { -200, 0, 0, 0, 0, 0 };
            Event Gas = new Event();
<<<<<<< HEAD
            Gas.set("You have run out of gas, luckily your knowledge of science or whatever allows you to hastily create some fuel using fast food bags, a megaphone, and a full tank of gas you found on the side of the road.", "You have run out of gas on the side of the road, and have to wait an hour in the hot sun for roadside assistance to show up. They really marked up the price for Aloe.", "", "", gasarray, gasstatchange);

            Event StoryTime = new Event();
            int[] StoryTimeReq = new int[6] { 0, 0, 0, 0, 0, 4 };
            int[] StoryTimeChange = new int[6] { 0, 0, 0, 0, 0, -1 };
            StoryTime.set("The car has been quiet for some time now, and everyone seems a bit bored. To help liven things up you tell an embarrassing story from your past. It brings the conversation back to life and every is a little happier.", "The car has been quiet for some time now, and everyone seems a bit bored. To help liven things up you tell an embarrassing story from your past. No one seems to like it or even react at all. Now there's an awkward silence filling the car.", "", "", StoryTimeReq, StoryTimeChange, false);
=======
            Gas.set_shit("You have run out of gas, luckily your knowledge of science or whatever allows you to hastily create some fuel using fast food bags, a megaphone, and a full tank of gas you found on the side of the road.", "You have run out of gas on the side of the road, and have to wait an hour in the hot sun for roadside assistance to show up. They really marked up the price for Aloe.", "", "", gasarray, gasstatchange);
            //=======//
            int[] deadreq1 = new int[6] { 0, 0, 0, 0, 4, 0 };
            int[] deadreq2 = new int[6] { 0, 0, 0, 0, 0, 4 };
            int[] deadchange2 = new int[6] { 2500, 0, 0, 0, 0, 0 };
            Event Deaddrop = new Event();
            Deaddrop.set(deadreq1, null, "You needed to pull over and take a leak on the side of the road. While making shapes in the ground with wizz, your stream trickled over a black suitcase. Upon opening the case you find out it’s a dead drop filled with cash. Take the money?", "You needed to pull over and take a leak on the side of the road. You make shapes in the ground with your pee before getting back in the car. That sure was fun.", deadreq2, deadchange2, "You take the money from the suitcase and drive off without even batting an eye.",req3, change3, "You go to grab the money when suddenly a black SUV pulls up beside your car. Two men with guns step out and shoot you on the spot. Good try kid.");







>>>>>>> origin/master



>>>>>>> origin/master
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
