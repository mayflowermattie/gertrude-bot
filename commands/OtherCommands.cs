using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using gertrude_bot.quotes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gertrude_bot.commands
{
    public class OtherCommands : BaseCommandModule
    {
        [Command("help")]

        public async Task Help(CommandContext context)
        {
            var helpEmbed = new DiscordEmbedBuilder
            {
                Title = "Command List:",
                Description = $"``!help``: Produces a list of all commands.\n\n**-------------------------------------------**\n\n``!hello``: Say hello to Meemaw.\n(ALTERNATE ALIASES: ``!hi``, ``!greeting``, ``!greetings``)\n\n``!quotemattie``: Produces a quote recorded in Mattie's quote channel.\n(ALTERNATE ALIASES: ``!quote-eguy``, ``!quoteegg``, ``!quote-egg``)\n\n``!quotesky``: Produces a quote recorded in Sky's quote channel.\n(ALTERNATE ALIASES: ``!quote-sky``, ``!quoteski``, ``!quote-ski``)\n\n``!quotedadpro``: Produces a quote recorded in Dadpro's quote channel.\n(ALTERNATE ALIASES: ``!quote-dadpro``, ``!quoteidioter``, ``!quote-idioter``, ``!quotebritish``, ``!quote-british``)\n\n``!quoteyeetman``: Produces a quote recorded in Yeetman's quote channel.\n(ALTERNATE ALIASES: ``!quote-yeetman``, ``!quoteyeet``, ``!quote-yeet``)\n\n``!add [num 1] [num 2]``: Adds two numbers of the user's choosing. (Works with decimals!)\n(ALTERNATE ALIASES: ``!addition``, ``!plus``, ``!+``)\n\n``!subtract [num 1] [num 2]``: Subtracts two numbers of the user's choosing. (Works with decimals!)\n(ALTERNATE ALIASES: ``!subtraction``, ``!sub``, ``!minus``, ``!-``)\n\n``!multiply [num 1] [num 2]``: Multiplies two numbers of the user's choosing. (Works with decimals!)\n(ALTERNATE ALIASES: ``!multiplication``, ``!times``, ``!x``, ``!*``)\n\n``!divide [num 1] [num 2]``: Divides two numbers of the user's choosing. (Works with decimals!)\n(ALTERNATE ALIASES: ``!division``, ``!divideby``, ``!/``)\n\n``!findremainder [num 1] [num 2]``: Divides and finds the remainder of two numbers of the user's choosing. (Works with decimals!)\n(ALTERNATE ALIASES: ``!remainder``, ``!modulo``, ``!%``)\n",
                Color = DiscordColor.Grayple
            };
            
            await context.Channel.SendMessageAsync(embed: helpEmbed);
        }




        [Command("hello")]
        [Aliases("hi","greeting","greetings")]
        public async Task SayHello(CommandContext context)
        {
            if (context.Guild.Id == 615673301184020505 && context.Channel.Id == 1142230984889225327)
            {
                await context.Channel.SendMessageAsync($"Hey, honeybun {context.User.Username}, how are 'ya? Ol' Gerty misses you very much. Be sure to stay in touch love ya xoxo");
            }
            else
            {
                return;
            }
        }

        [Command("quoteMattie")]
        [Aliases("quote-mattie","quoteidiot","quote-idiot")]

        public async Task QuoteMattie(CommandContext context)
        {
            if (context.Guild.Id == 615673301184020505 && context.Channel.Id == 1142230984889225327)
            {
                var selectedMattieQuote = new MattieQuotes();
                await context.Channel.SendMessageAsync($"Here 'ya go, bug!");

                var selectedMattieQuoteEmbed = new DiscordEmbedBuilder
                {
                    Title = $"{selectedMattieQuote.SelectedQuoteM}",
                    Color = DiscordColor.Aquamarine
                };

                await context.Channel.SendMessageAsync(embed: selectedMattieQuoteEmbed);
            }
            else
            {
                return;
            }
            
        }

        [Command("quoteEguy")]
        [Aliases("quote-eguy","quoteegg","quote-egg")]

        public async Task QuoteEguy(CommandContext context)
        {
            if (context.Guild.Id == 615673301184020505 && context.Channel.Id == 1142230984889225327)
            {
                var selectedEguyQuote = new EguyQuotes();
                await context.Channel.SendMessageAsync($"Here 'ya go, bug!");

                var selectedEguyQuoteEmbed = new DiscordEmbedBuilder
                {
                    Title = $"{selectedEguyQuote.SelectedQuoteE}",
                    Color = DiscordColor.Red
                };

                await context.Channel.SendMessageAsync(embed: selectedEguyQuoteEmbed);
            }
            else
            {
                return;
            }
        }

        [Command("quoteSky")]
        [Aliases("quote-sky","quoteski","quote-ski")]

        public async Task QuoteSky(CommandContext context)
        {
            if (context.Guild.Id == 615673301184020505 && context.Channel.Id == 1142230984889225327)
            {
                var selectedSkyQuote = new SkyQuotes();
                await context.Channel.SendMessageAsync($"Here 'ya go, bug!");

                var selectedSkyQuoteEmbed = new DiscordEmbedBuilder
                {
                    Title = $"{selectedSkyQuote.SelectedQuoteS}",
                    Color = DiscordColor.CornflowerBlue
                };

                await context.Channel.SendMessageAsync(embed: selectedSkyQuoteEmbed);
            }
        }

        [Command("quoteDadpro")]
        [Aliases("quote-dadpro","quoteidioter","quote-idioter","quote-british","quotebritish")]

        public async Task QuoteDadpro(CommandContext context)
        {
            if (context.Guild.Id == 615673301184020505 && context.Channel.Id == 1142230984889225327)
            {
                var selectedDadproQuote = new DadproQuotes();
                await context.Channel.SendMessageAsync($"Here 'ya go, bug!");

                var selectedDadproQuoteEmbed = new DiscordEmbedBuilder
                {
                    Title = $"{selectedDadproQuote.SelectedQuoteD}",
                    Color = DiscordColor.Purple
                };

                await context.Channel.SendMessageAsync(embed: selectedDadproQuoteEmbed);
            }
            else
            {
                return;
            }
        }

        [Command("quoteYeetman")]
        [Aliases("quote-yeetman","quoteyeet","quote-yeet")]

        public async Task QuoteYeetman(CommandContext context)
        {
            if (context.Guild.Id == 615673301184020505 && context.Channel.Id == 1142230984889225327)
            {
                var selectedYeetmanQuote = new YeetmanQuotes();
                await context.Channel.SendMessageAsync($"Here 'ya go, bug!");

                var selectedYeetmanQuoteEmbed = new DiscordEmbedBuilder
                {
                    Title = $"{selectedYeetmanQuote.SelectedQuoteY}",
                    Color = DiscordColor.Cyan
                };

                await context.Channel.SendMessageAsync(embed: selectedYeetmanQuoteEmbed);
            }
            else
            {
                return;
            }
        }

    }
}
