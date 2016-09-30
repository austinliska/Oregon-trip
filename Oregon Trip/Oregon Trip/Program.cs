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
            Leprechaun.set_shit("OMFG! You just noticed a leprechaun on the dashboard rocking out to “We Built This On Rock and Roll” you were quick enough to catch it and it gave you a lucky coin as a reward!", "You get the feeling you just missed out on something big, but whatevs, crank the tunes!", "", "", leprechaunarray, leprechaunstatchange);

            int[] rideinstylearray = new int[6] { 0, 0, 4, 0, 0, 5 };
            int[] rideinstylestatchange = new int[6] { 0, 0, 0, 0, 0, 0 };
            Event RideInStyle = new Event();
            RideInStyle.set_shit("While stopped at a gas station in the middle of nowhere, you notice that the band you were going to see is also stopped there. You approach them letting them know what big fans you guys are of the band. Charmed by your kind words, the band offers to let you ride with them all the way to Oregon! Rock on!", "You sense a disturbance in the force, as though you just missed out on the event of your life.", "", "", rideinstylearray, rideinstylestatchange);

            int[] deerarray = new int[6] { 0, 0, 0, 0, 3, 0 };
            int[] deerstatchange = new int[6] { -500, 0, 0, 0, 0, 0 };
            Event Deer = new Event();
            Deer.set_shit("A deer just sauntered into the road, but you were quick enough to avoid it. Keep on truckin’", "You just hit a deer, and man did you have to pay", "", "", deerarray, deerstatchange);

            int[] dysenteryarray = new int[6] { 0, 4, 0, 0, 2, 0 };
            int[] dysenterystatchange = new int[6] { 0, -1, -1, -1, 0, 0 };
            Event Dysentery = new Event();
            Dysentery.set_shit("Your bro Steve got a case of Dysentery from some gas station sushi, luckily you were able to cure it with science or whatever.", "Steve almost died from dysentery and gave it to you! Nasty", "", "", dysenteryarray, dysenterystatchange);

            int[] mirrorarray = new int[6] { 0, 3, 0, 0, 0, 0 };
            int[] mirrorstatchange = new int[6] { 0, 0, 0, 0, 0, -1 };
            Event Mirror = new Event();
            Mirror.set_shit("You seem to have cracked a mirror, luckily some quick glass welding has lead to you getting it repaired quickly.", "Your mirror has broken, but that old superstition doesn’t apply to car mirrors. Does it?", "", "", mirrorarray, mirrorstatchange);

            int[] mexicanstandoffarray = new int[6] { 2, 2, 2, 2, 2, 2 };
            int[] mexicanstandoffchange = new int[6] { 2000, 0, 0, 0, 0, 0 };
            Event MexicanStandoff = new Event();
            MexicanStandoff.set_shit("Entered into a Mexican Standoff, things looked bleak, but you kept a cool head and in the end you got the money.", "You were shot to death in a mexican standoff", "", "", mexicanstandoffarray, mexicanstandoffchange);

            int[] badgerarray = new int[6] { 0, 0, 0, 0, 0, 3 };
            int[] badgerchange = new int[6] { 5, 0, 0, 0, 0, 0 };
            Event Badger = new Event();
            Badger.set_shit("Steve found 5 bucks under the seat, sweet!", "OH LORD A BADGER! ALL IS LOST!", "", "", badgerarray, badgerchange);

            int[] hillfolkarray = new int[6] { 0, 0, 0, 0, 3, 4 };
            int[] hillfolkstatchange = new int[6] { 500, 0, 0, 0, 0, 0 };
            Event Hillfolk = new Event();
            Hillfolk.set_shit("You enter the shortcut, only to find that it is in fact a trap set by hillbillys! You back up as fast as you can accidentally hitting a tree, luckily for you the tree topples over and crushes the hillbillys. You steal their Pickup and continue your travels with mountains of hillbilly gold.", "Unfortunately the detour was a trap and your entire roadtrip crew is robbed by hillbillys. At least they didn’t eat you.", "", "", hillfolkarray, hillfolkstatchange);

            int[] carsickarray = new int[6] { 0, 3, 0, 0, 0, 0 };
            int[] carsickstatchange = new int[6] { 0, 0, -1, -1, 0, 0 };
            Event Carsick = new Event();
            Carsick.set_shit("The allure of staring out the side windows does not tempt you. You remain healthy.", "You were staring out the window for too long and got carsick, way to ruin your only shirt.", "", "", carsickarray, carsickstatchange);

            int[] ghostarray = new int[6] { 0, 0, 0, 0, 0, 3 };
            int[] ghostchange = new int[6] { 0, 1, 1, 1, 1, 1 };
            Event Ghost = new Event();
            Ghost.set_shit("You pick up a hitchhiking ghost somewhere outside of Alabama, turns out he’s a pretty chill dude and imbues you with supernatural powers.", "You totally were going to pick up that hitchhiker, but then Keith was all like “NOOOO” and so now we’re cursed to live in Alabama forever. Frickin’ Keith.", "", "", ghostarray, ghostchange);

            int[] pulloverarray = new int[6] { 0, 0, 3, 0, 0, 0 };
            int[] pulloverchange = new int[6] { -300, 0, 0, 0, 0, 0 };
            Event Pullover = new Event();
            Pullover.set_shit("You get pulled over, but are let off with a warning. Good thing you’re so charming.", "You get pulled over for speeding, you try to explain that a bird flew into the car and that’s why, but the cop isn’t buying it.", "", "", leprechaunarray, leprechaunstatchange);

            int[] sportsarray = new int[6] { 0, 0, 0, 4, 0, 0 };
            int[] sportsstatchange = new int[6] { 150, 0, 1, 0, 0, 0 };
            Event Sports = new Event();
            Sports.set_shit("You are attacked by gang of fans that support your rival sports team, despite attacking you 4 to 1, you fight them off and become a hero to the fans of that sports team you support.", "You are jumped outside a gas station and beaten unconscious by a gang of rival sports fans, you try to fight back but they outnumber you 4 to 1. You wake up battered and bruised in the hospital, this roadtrip is over.", "", "", sportsarray, sportsstatchange);

            int[] birdarray = new int[6] { 0, 0, 0, 0, 2, 0 };
            int[] birdstatchange = new int[6] { 0, 0, 0, 0, 0, 0 };
            Event Bird = new Event();
            Bird.set_shit("A bird flies into the car, but your razor sharp focus allows you to keep control of the car while you travelling companions shoo out the bird.", "A bird flies into your car, unable to keep focus you freak out and drive the car off a gorge.", "", "", leprechaunarray, leprechaunstatchange);

            int[] alienarray = new int[6] { 0, 5, 0, 0, 2, 3 };
            int[] alienstatchange = new int[6] { 0, 0, -1, -1, 0, 0 };
            Event Alien = new Event();
            Alien.set_shit("While driving along a Nevada Highway you notice a piece of wreckage alongside the road, thinking they might have had some sweet tunes, you naturally sift through the wreckage only to come across an alien! Performing a quick surgery using your shoelaces to connect what appears to be lungs. The alien is grateful and turns out to be the king of the universe on his way to the Oregon for the same concert you’re going to! As thanks for saving his life you are promised the Space Princess’ hand in marriage and are taken to the concert in the luxury of an Emperor Class Starship! Nice.", "While driving along a Nevada Highway you notice a piece of wreckage alongside the road, thinking they might have had some sweet tunes, you naturally sift through the wreckage only to come across an alien! You attempt to perform surgery on the alien, but you have no idea what you’re doing. The alien bloats up and explodes in your face. Nasty.", "", "", alienarray, alienstatchange);

            int[] gasarray = new int[6] { 0, 0, 0, 0, 4, 0 };
            int[] gasstatchange = new int[6] { -200, 0, 0, 0, 0, 0 };
            Event Gas = new Event();
            Gas.set_shit("You have run out of gas, luckily your knowledge of science or whatever allows you to hastily create some fuel using fast food bags, a megaphone, and a full tank of gas you found on the side of the road.", "You have run out of gas on the side of the road, and have to wait an hour in the hot sun for roadside assistance to show up. They really marked up the price for Aloe.", "", "", gasarray, gasstatchange);
            //=======
            int[] req1 = new int[6] { 0, 0, 0, 0, 4, 0 };
            int[] req2 = new int[6] { 0, 0, 0, 0, 0, 0 };







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
