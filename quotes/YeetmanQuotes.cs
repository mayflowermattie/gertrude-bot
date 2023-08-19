using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gertrude_bot.quotes
{
    public class YeetmanQuotes
    {
        private string[] quoteListY =
        {
            "\"What is a heterosexual?\"\n- Yeetman: 07/18/2022",
            "\"Does that mean I like man?\"\n- Yeetman: 07/18/2022",
            "\"I'm stuped.\"\n- Yeetman: 08/05/2022"
        };

        public string SelectedQuoteY { get; set; }

        public YeetmanQuotes()
        {
            var random = new Random();

            int quoteIndexY = random.Next(0, quoteListY.Length);

            this.SelectedQuoteY = $"{quoteListY[quoteIndexY]}";
        }
    }
}
