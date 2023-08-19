using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gertrude_bot.quotes
{
    public class DadproQuotes
    {
        private string[] quoteListD =
        {
            "\"I'M NOT BRI'ISH!\"\n- Dadpro: 10/26/2021",
            "\"No gay.\"\n- Dadpro: 11/01/2021",
            "\"You want me to walk 7 kilometers?\"\n- Dadpro: 11/26/2021",
            "\"Oh, body pillow? Oh, that got my attention.\"\n- Dadpro: 12/19/2021",
            "\"Sticky fingers just f--cked me.\"\n- Dadpro: 01/05/2022",
            "\"What is this Koloombo?\"\n- Dadpro: 03/19/2022",
            "\"Does Fortnite have a competitive mode?\"\n- Dadpro: 04/02/2022",
            "\"Dadpro: What are you eating?\nMattie: Lasagna.\nDadpro: What is that?\"\n- Dadpro: 06/04/2022"
        };

        public string SelectedQuoteD { get; set; }

        public DadproQuotes()
        {
            var random = new Random();

            int quoteIndexD = random.Next(0, quoteListD.Length);

            this.SelectedQuoteD = $"{quoteListD[quoteIndexD]}";
        }
    }
}
