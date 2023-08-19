using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gertrude_bot.quotes
{
    public class EguyQuotes
    {
        private string[] quoteListE =
        {
            "\"BEESECHURGER. DOT HOG. DOT CHOP. TRANGCK. NEESE NERG. KUNGUTZLE. DEEZ NURGER. AATERGADE. OREGON TRALO. REDBOOM. BAMCURGER. LOOT ON. KOORBOB. WIRCOMAVE. KNOG. KNOOGLE. NICKEN CHUGET. BUGGER OFF MATE, I'LL HAVE YOU KNO I HAVE A KNOOGLE BELT. SHILKMAK. STRANGK BUCKO BOB. PUIOY. I LIV IN BARD COATS BOX. DORA HAS ME MULTIPLE WANTED LISTS. MUS MAK MONEH. I HAV BOOTS IN THE BAG. I HAV HOSTAGE. BLOOGAH. BACO TELL. WESP QWERS. DAFFFAG. REUP. QWAP. QWAP! Okay, I'm done with strank.\"\n- Eguy: 12/28/2019",
            "\"Sky: Why are you very happy?\nEguy: Because I am.\nSky: Why?\nEguy: Chonk.\"\n- Eguy: 01/14/2021",
            "\"It just bounces right off of it?\"\n- Eguy: Unknown Date",
            "\"I'm laughing at how stupidly you sounded like.\"\n- Eguy: Unknown Date",
            "\"You look like an Asian when you smile.\"\n- Eguy: 01/26/2021",
            "\"Hey, it's me, Satan. You know, the guy in Hell?\"\n- Eguy: 02/18/2021",
            "\"I'm a sinful boy, what can I say?\"\n- Eguy: 03/05/2021",
            "\"Meow.\"\n- Eguy: 03/05/2021",
            "\"Ohhh, it's everywhere.\"\n- Eguy: 03/21/2021",
            "\"He looked at me funny, so I orphaned him.\"\n- Eguy: 04/16/2021",
            "\"I need a corna test...\"\n- Eguy: 04/21/2021",
            "\"I gave him a food of cat bowl.\"\n- Eguy: 04/24/2021",
            "\"(Looking at Roadhog:) Oh, look, it's Reinhardt.\"\n- Eguy: 05/01/2021",
            "\"Mattie: Do you know how long it took you to get that emote?\nEguy: Yeah, until Chapter 3.\"\n- Eguy: 06/16/2021",
            "\"Sky seems to be the only type of person to like the Mcdunald.\"\n- Eguy: 7/16/2021",
            "\"Anyways, I need to go bathe in the holy juice.\"\n- Eguy: 10/07/2021",
            "\"Don't start, crumpet boy.\"\n- Eguy: 11/19/2021",
            "\"DADPRO, MY BOY!\"\n- Eguy: 12/02/2021",
            "\"That's not a sniper-- Actually, I will take the other snig-\"\n- Eguy: 12/11/2021",
            "\"Pain achieved.\"\n- Eguy: 12/23/2021",
            "\"Safari called me invalid.\"\n- Eguy: 01/01/2022",
            "\"Mm, g.\"\n- Eguy: 01/09/2022",
            "\"I think racism is growing on me.\"\n- Eguy: 02/03/2022",
            "\"I'm so glad I gained like 7 inches.\"\n- Eguy: 02/09/2022",
            "\"I'm going straight to bed. Well, not *straight*.\"\n- Eguy: 03/20/2022",
            "\"Let me honk.\"\n- Eguy: 03/25/2022",
            "\"There's a girl in my potty.\"\n- Eguy: 04/24/2022",
            "\"You mean Leprechaun Day?\"\n- Eguy: 05/24/2022",
            "\"I wanted to get on top.\"\n- Eguy: 05/24/2022",
            "\"I literally have no glue. I mean clue.\nI have clue in my house. I MEAN GLUE.\"\n- Eguy: 06/06/2022",
            "\"What is this? *shows asexual flag*\"\n- Eguy: 06/06/2022",
            "\"I'm gay, but also attracted to women. So, it's bi.\"\n- Eguy: 06/09/2022",
            "\"If I'm ace, Dadpro is gay. That's all I have to say, an eye for an eye.\"\n- Eguy: 07/07/2022",
            "\"Women.\"\n- Eguy: 07/17/2022",
            "\"I love beating up LeBron James.\"\n- Eguy: 08/08/2022",
            "\"Punk rock core, is that what it's called? If it is, that called that...called that the... *melts*\"\n- Eguy: 10/04/2022",
            "\"If you are what you eat, then I'm a POWERXL 12-Quart with 7-in-1 Air Fryer Oven in Black Stainless Steel.\"\n- Eguy: 10/04/2022",
            "\"What am I going to do? Suck faster?\"\n- Eguy: 10/18/2022",
            "\"Eguy: Hey Craz, what's the nickname you have for me?\nMattie: egg.\nEguy: Yea? Oh, wait.\"\n- Eguy: 12/09/2022",
            "\"I was going to hammer you, until Doomfisted you.\"\n- Eguy: 02/24/2023",
            "\"Vulva? Is that a cake flavor?\"\n- Eguy: 03/04/2023",
            "\"(Profile pronouns: eguy777)\"\n- Eguy: 07/14/2023",
            "\"Don't question it and swallow.\"\n- Eguy: 08/01/2023",
            "\"Colon three c.\"\n- Eguy: 08/15/2023"
        };

        public string SelectedQuoteE { get; set; }

        public EguyQuotes()
        {
            var random = new Random();

            int quoteIndexE = random.Next(0, quoteListE.Length);

            this.SelectedQuoteE = $"{quoteListE[quoteIndexE]}";
        }
    }
}
