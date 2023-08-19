using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gertrude_bot.quotes
{
    public class MattieQuotes
    {
        private string[] quoteListM =
        {
            "\"I am not straight.\"\n- Mattie: Unknown Date",
            "\"I'm gonna make Eguy come with this fishing rod.\"\n- Mattie: Unknown Date",
            "\"Why did you put it innn...\"\n- Mattie: Unknown Date",
            "\"Yes, Sky, it's long.\"\n- Mattie: Sometime in 2019",
            "\"Can I pway with yuw on Fowtnite? ;3\"\n- Mattie: 02/29/2020",
            "\"I love you, Eguy.\"\n- Mattie: 03/31/2020",
            "\"I'm talking in my normal tone.\"\n- Mattie: Unknown Date",
            "\"I'ma' go shopping.\"\n- Mattie: Unknown Date",
            "\"My cow looks like a cow.\"\n- Mattie: 04/04/2020",
            "\"HOEEEEEE\"\n- Mattie: 04/04/2020",
            "\"I will and I will.\"\n- Mattie: 04/04/2020",
            "\"It's a part of your punishment. You don't get to come.\"\n- Mattie: 04/04/2020",
            "\"I'm PRETTY sure I like it.\"\n- Mattie: 04/06/2020",
            "\"Do you have a fridge that is a refrigerator and a fridge?\"\n- Mattie: 05/23/2020",
            "\"Can I dope? .-.\"\n- Mattie: 05/27/2020",
            "\"Have you had the Popeyes Chicken Sandmich?\"\n- Mattie: 06/06/2020",
            "\"It's fine.\"\n- Mattie: Various Dates",
            "\"NO I'M NOT, BAKA!\"\n- Mattie: 06/06/2020",
            "\"Ew, the water's dirty.\"\n- Mattie: 06/15/2020",
            "\"IT'S NOT EANGLISH!\"\n- Mattie: 06/16/2020",
            "\"You like that mawnlower outside?\"\n- Mattie: 06/28/2020",
            "\"Wait, aren't you allergic to eggs?\"\n- Mattie: 07/05/2020",
            "\"Wait, if you run and jump you can go faster?\"\n- Mattie: 07/07/2020",
            "\"Now I'm in the And.\"\n- Mattie: 07/24/2020",
            "\"This hurts my neck, this is a HORRIBLE position.\"\n- Mattie: 08/03/2020",
            "\"I can go more, but uh--\"\n- Mattie: 08/03/2020",
            "\"HA, I beat Eguy by a few centimeters!\"\n- Mattie: 08/27/2020",
            "\"Eguy: How do you spell OK?\nMattie: O, H, K, A, Y.\"\n- Mattie: 08/30/2020",
            "\"I couldn't even last a SECOND.\"\n- Mattie: 08/30/2020",
            "\"Genji's thiccer than D.Va.\"\n- Mattie: 09/08/2020",
            "\"But D.Va's thiccer.\"\n- Mattie: 09/08/2020",
            "\"I wake up in the morning and I still have stuff\non my face from last night.\"\n- Mattie: 09/24/2020",
            "\"I forgot Rippley has clothes.\"\n- Mattie: 09/26/2020",
            "\"Are there even such things as pumpkin seeds?\"\n- Mattie: 10/08/2020",
            "\"Isn't Day of the Dead of May 5th?\"\n- Mattie: 10/19/2020",
            "\"Is it salty?\"\n- Mattie: 11/16/2020",
            "\"Nyahhh~\"\n- Mattie: 11/18/2020",
            "\"Moooo.\"\n- Mattie: 11/30/2020",
            "\"I mean...it feels good sometimes.\"\n- Mattie: 12/03/2020",
            "\"I am work.\"\n- Mattie: 12/03/2020",
            "\"I was licking the stuff off my fingers.\"\n- Mattie: 12/04/2020",
            "\"D.Va is better than Sky.\"\n- Mattie: 12/06/2020",
            "\"Help, it's on my shirt...\"\n- Mattie: 12/08/2020",
            "\"You can fill me up~ >w<\"\n- Mattie: 12/16/2020",
            "\"Nerf me~ <3 UwU\"\n- Mattie: 12/17/2020",
            "\"What do you want me to do? Throw the black off the edge?\"\n- Mattie: 12/26/2020",
            "\"I gotta do math. I just finished math.\"\n- Mattie: 01/12/2021",
            "\"I act like a bottom, but I'm a top.\"\n- Mattie: 01/14/2021",
            "\"So far it feels kinda good.\"\n- Mattie: 01/14/2021",
            "\"YES, KEEP GOING, KEEP GOING!\"\n- Mattie: 01/15/2021",
            "\"My arm's really gonna hurt after this...\"\n- Mattie: 01/19/2021",
            "\"HISS. HISSSSSSSSSS\"\n- Mattie: 01/27/2021",
            "\"The number 110 doesn't exist.\"\n- Mattie: 02/06/2021",
            "\"Greetings, my acquaintance in which is made out of blood and muscle\nin a miraculous fashion that is partially from stardust.\"\n- Mattie: 02/22/2021",
            "\"Did you break Reinhardt's turret?\"\n- Mattie: 02/13/2021",
            "\"Is Italian even a language?\"\n- Mattie: 02/13/2021",
            "\"Oh boy, a whole kills worth of XPOI.\"\n- Mattie: 02/13/2021",
            "\"Oh, there's another thing my fingers are covered in.\"\n- Mattie: 02/13/2021",
            "\"The Holocaust was a good thing.\"\n- Mattie: 02/16/2021 [TO ITERATE: OPPOSITE DAY.]",
            "\"MEOW, MEOW, NYAHHH~\"\n- Mattie: 02/23/2021",
            "\"Why haven't they added a legendary assault rifle yet?\"\n- Mattie: 02/28/2021",
            "\"Nien means no in Russian.\"\n- Mattie: 03/06/2021",
            "\"8 out of 10, that's 100%!\"\n- Mattie: 03/07/2021",
            "\"Oh, it's everywhere.\"\n- Mattie: 03/21/2021",
            "\"Oh, I do know, but I just don't know.\"\n- Mattie: 03/27/2021",
            "\"1 + 1 = 65\"\n- Mattie: 03/27/2021",
            "\"I'm back, but I'm not back.\"\n- Mattie: 04/08/2021",
            "\"Good boy.\"\n- Mattie: 04/12/2021",
            "\"The brown cow should lay the brown egg.\"\n- Mattie: 06/28/2021",
            "\"Oh no... Your nails are pierced?\"\n- Mattie: 07/04/2021",
            "\"My Twitter is charging.\"\n- Mattie: 07/06/2021",
            "\"What comes after summer?\"\n- Mattie: 07/16/2021",
            "\"I'm going to sleep in 3 days.\"\n- Mattie: 09/05/2021",
            "\"Should I go for the cat ears?\"n- Mattie: 10/19/2021",
            "\"Sky, I have a more masculine voice than you.\"\n- Mattie: 10/27/2021",
            "\"Your aren't.\"\n- Mattie: 11/22/2021",
            "\"I'm thirsty...for Legion.\"\n- Mattie: 12/19/2021",
            "\"It's just a silly ruse.\"\n- Mattie: 12/21/2021",
            "\"Eguy: So now where are you?\nMattie: Semen Run.\"\n- Mattie: 02/19/2022",
            "\"It's 9:11, I'll be back.\"\n- Mattie: 05/18/2022",
            "\"I fingered your bee.\"\n- Mattie: 06/09/2022",
            "\"The litle tiepnsy! So adornale and cutest toosit...\nAww, like and double tap so it can the to live the cute! Happy kdb\"\n- Mattie: 08/27/2022",
            "\"I love their @'s.\"\n- Mattie: 08/28/2022",
            "\"Girthy pp.\"\n- Mattie: 11/07/2022",
            "\"I'm simping over Lilli's cat.\"\n- Mattie: 11/11/2022",
            "\"DREAM IS GOOD.\"\n- Mattie: 11/24/2022",
            "\"Women in suits make me collapse on the spot.\"\n- Mattie: 11/28/2022",
            "\"Lilli: Best food combo that's actually good, go.\nMattie: Probably a bad example, but cucumber + vinegar.\nAsani: MATTIE. THAT IS A PICKLE.\"\n- Mattie: 11/28/2022",
            "\"Yes, please, mommy Zero Point, grab me with your tentacles.\"\n- Mattie: 12/02/2022",
            "\"I WILL NOT CUM.\"\n- Mattie: 12/09/2022",
            "\"The sun sets in the north, right?\"\n- Mattie: 12/11/2022",
            "\"Basically, the \"cube colors\" don't really mean anything specific to the cubes themselves, it's moreso Zero Point energy. However, all of this energy seems to have a sort of \"bounciness\", as seen with all rift energy types, such as shockwave grenades, the cubes themselves, the Zero Point when it spits you out, etc. Excluding red energy, as that hasn't been seen before besides in mushrooms. The multicolor rift butterflies - or \"shatterflies\" likely appear around in a biome in which the Zero Point is purified, or purifying. The lotus blossom that was supposed to be created during the Zero Crisis event is an example of failed purification due to immense destabilization. The Zero Point - assuming it's sentient - needs protection. Constantly. It shields itself every chance it gets, and this causes it to stabilize to some extent. The Spire is an example of such protection, though the Zero Point needed the aid of The Foundation (whom can harness Zero Point energy somehow) to hold itself together long enough to begin stabilizing. After the Collision event, the Zero Point simply went dormant under Loot Lake, repairing itself, and literally pulsing away anything that came close. A reality tree was a direct result of the stabilization/purification succeeding, which lead to a whole biome being created. This entire idea of a lotus blossom representing purity is everywhere in culture and media, so it's safe to say this applies to the Zero Point as well.\n\nNow the main theory. Blue r--\"\n- Mattie: 03/28/2023",
            "\"So is 1 the only number that's singular?\"\n- Mattie: 04/12/2023",
            "\"Sky: *Do I have to lie to make my way in lifeeeee?~*\nMattie: EXACTLY!\nSky: But what are we lying about?\nMattie: Uhh... I didn't think that deep.\"\n- Mattie: 05/18/2023",
            "\"I wish Russia didn't exist so Zarya wouldn't exist.\"\n- Mattie: 05/22/2023",
            "\"Ingle-ish.\"\n- Mattie: 06/04/2023",
            "\"You can order 100 nuggets, and no one bats an eye, Batman...\nYou order 100 cookies, AND EVERYONE GOES WILD!\"\n- Mattie: 06/20/2023",
            "\"Oh wow, just like a real whale! It flops over and explodes.\"\n- Mattie: 07/01/2023",
            "\"Do you guys wanna watch Breaking Bad and cuddle again tomorrow? :3\"\n- Mattie: 07/09/2023"
        };

        public string SelectedQuoteM { get; set; }

        public MattieQuotes()
        {
            var quoteGenerator = new Random();

            int quoteIndexM = quoteGenerator.Next(0, quoteListM.Length);

            this.SelectedQuoteM = $"{quoteListM[quoteIndexM]}";
        }
    }
}