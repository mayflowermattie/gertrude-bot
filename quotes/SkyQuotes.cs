using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gertrude_bot.quotes
{
    public class SkyQuotes
    {
        private string[] quoteListS =
        {
            "\"Hi, guys!\"\n- Sky: 2019",
            "\"I don't need Nemesis earraping me while he is raping me.\"\n- Sky: 10/03/2021",
            "\"I'm so glad Stephen Hawking taught me that-- *Wii crash sound*\"\n- Sky: 10/03/2021",
            "\"That's good to know, but when are you coming out?\"\n- Sky: 10/06/2021",
            "\"Spit on me vommy mommy, SEE IF I CARE.\"\n- Sky: 10/09/2021",
            "\"Put Odyssey in his place. Put :clap: the :clap: dog :clap: in :clap: the :clap: kennel :clap:.\"\n- Sky: 10/25/2021",
            "\"Why is Dwight always sucking his fingers? He should be sucking me instead.\"\n- Sky: 10/25/2021",
            "\"The PS5 is the most attractive console.\"\n- Sky: 12/19/2021",
            "\"I don't want to be milked. Don't milk me.\"\n- Sky: 01/04/2022",
            "\"But if it's a fat girl... Mmm, eat more please.\"\n- Sky: 01/15/2022",
            "\"That's not the only thing I want to put in Leon's mouth.\"\n- Sky: 01/20/2022",
            "\"No, he's too crusty to be trans.\"\n- Sky: 01/21/2022",
            "\"YOUR BALLS AREN'T MATURE ENOUGH.\"\n- Sky: 02/02/2022",
            "\"Do you know what they should've named her instead? S'more.\"\n- Sky: 02/02/2022",
            "\"Force feeding is hot.\"\n- Sky: 03/02/2022",
            "\"Andrew Garfield is the 18th President.\"\n- Sky: 03/25/2022",
            "\"I love breeding, it's so much fun.\"\n- Sky: 04/22/2022",
            "\"Ugh, you vored me.\"\n- Sky: 05/24/2022",
            "\"If it breathes, I can probably think of devious things I'd like to do to it.\"\n- Sky: 06/06/2022",
            "\"9 * 9 = 31, right?\"\n- Sky: 06/13/2022",
            "\"340 + 30 = 360.\"\n- Sky: 06/18/2022",
            "\"Go retrieve the ball for me.\"\n- Sky: 06/28/2022",
            "\"I don't CARE if you were 6, you should be getting that bag.\"\n- Sky: 07/10/2022",
            "\"See, look at that Dark Bomber's grape-flavored cake.\"\n- Sky: 07/10/2022",
            "\"Egirls are better than Eminors.\"\n- Sky: 07/10/2022",
            "\"FORCE YOURSELF. ASSAULT HER.\"\n- Sky: 08/16/2022",
            "\"So basically, it [the water cooler] had a dent in it. And I was like, \"Hm, let me try to squish it back in place.\" And what it did was it squirted more water into the white part where the water gets cooled. And I found it hot?? Like how I was forcing the water to come out???\"\n- Sky: 08/16/2022",
            "\"If the food wasn't poisonous, it would be really good.\"\n- Sky: 09/04/2022",
            "\"The first time I ever read a book was in 5th Grade.\"\n- Sky: 10/18/2022",
            "\"Lúcio, wanna jump on the point? How about you jump on my LAP.\"\n- Sky: 10/28/2022",
            "\"When they become fat, they become hot.\"\n- Sky: 11/16/2022",
            "\"I'm putting all my trust into my Urethra.\"\n- Sky: 12/23/2022",
            "\"Donald: I want it all.\nSky: Fortnite vore. Force feeding hot. Donald wants it all.\"\n- Sky: 01/23/2023",
            "\"(Referring to the creak of a DBD generator) Hear me out... It's kinda hot.\"\n- Sky: 01/23/2023",
            "\"SILENCE YOUR INCOMPETENT INSOLENCE. I WILL NOT TOLERATE THAT WHICH YOU ARE SOLICITING TO ME.\"\n- Sky: 02/16/2023",
            "\"Oh my god, Daddy, I'm coming.\"\n- Sky: 03/09/2023",
            "\"OSCAR, GERTRUDE, QUICK. WE NEED TO POP ORISA SO SHE DOESN'T GET THE RICKLE JAR AND USE HER JUNKER SCREAM.\"\n- Sky: 03/26/2023",
            "\"KIRIKA-DOODLE-DOO!!\"\n- Sky: 04/16/2023",
            "\"Oliver: Why is everyone here wearing funny clothes?\nDrippy: You’re the funny one around here Ollie-boy! We’ve got to get you some propa' clothes, innit? We’ve gotta visit the Hot Topic!\nRandom goth girl: Welcome to Hot Topic. :rolling_eyes:\"\n- Sky: 04/25/2023",
            "\"What's Mount Rushmore?\"\n- Sky: 04/28/2023",
            "\"Morty: Aww, jeez, Rick, I don't wanna live in the Rickety Rack Shack!\nRick: It's the best we can do in the U.S. economy, Morty! We gotta live in the Rickety Rack Shack!\"\n- Sky: 05/20/2023",
            "\"Sigma looked hungry, so I gave his gaping hole some food.\"\n- Sky: 05/23/2023",
            "\"I love vore!\"\n- Sky: 05/28/2023",
            "\"ORIZZA.\"\n- Sky: 05/28/2023",
            "\"STIMETTRA.\"\n- Sky: 05/28/2023",
            "\"That's the autism speaking, girlie. :nail_care:\"\n- Sky: 05/31/2023",
            "\"Show me your dogs.\"\n- Sky: 06/04/2023",
            "\"I love when people get on their hands and knees for me after I give them the most toe-curling grippy-grip.\"\n- Sky: 06/17/2023",
            "\"I literally tried the-the leaf? I don't know what it's called-- The lettuce?\"\n- Sky: 07/14/2023",
            "\"Wanna see how big my balls are?\"\n- Sky: 08/05/2023",
            "\"I want willy. :pleading_face:\"\n- Sky: 08/13/2023"
        };
        
        public string SelectedQuoteS { get; set; }

        public SkyQuotes()
        {
            var random = new Random();

            int quoteIndexS = random.Next(0, quoteListS.Length);

            this.SelectedQuoteS = $"{quoteListS[quoteIndexS]}";
        }
    }
}
