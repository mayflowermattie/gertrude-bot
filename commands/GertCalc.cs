using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace gertrude_bot.commands
{
    public class GertCalc : BaseCommandModule
    {
        [Command("add")]
        [Aliases("addition", "plus", "+")]
        public async Task Add(CommandContext context, decimal num1, decimal num2)
        {
            if (context.Guild.Id == 615673301184020505 && context.Channel.Id == 1142230984889225327)
            {
                decimal addResult = num1 + num2;

                if (addResult < 0)
                {
                    await context.Channel.SendMessageAsync($"Sorry, hun. I can't do negative numbers - at least...not yet, haha!");
                }
                else
                {
                    await context.Channel.SendMessageAsync($"{num1} + {num2}, honey? Why, that's {addResult}!");
                }
            }
            else
            {
                return;
            }
        }

        [Command("subtract")]
        [Aliases("subtraction","sub", "minus", "-")]
        public async Task Subtract(CommandContext context, decimal num1, decimal num2)
        {
            if (context.Guild.Id == 615673301184020505 && context.Channel.Id == 1142230984889225327)
            {
                decimal subResult = num1 - num2;

                if (subResult < 0)
                {
                    await context.Channel.SendMessageAsync($"Sorry, hun. I can't do negative numbers - at least...not yet, haha!");
                }
                else
                {
                    await context.Channel.SendMessageAsync($"{num1} - {num2}, honey? Why, that's {subResult}!");
                }
            }
            else
            {
                return;
            }
        }

        [Command("multiply")]
        [Aliases("multiplication", "times", "x", "*")]
        public async Task Multiply(CommandContext context, decimal num1, decimal num2)
        {
            if (context.Guild.Id == 615673301184020505 && context.Channel.Id == 1142230984889225327)
            {
                decimal multiResult = num1 * num2;

                if (multiResult < 0)
                {
                    await context.Channel.SendMessageAsync($"Sorry, hun. I can't do negative numbers - at least...not yet, haha!");
                }
                else
                {
                    await context.Channel.SendMessageAsync($"{num1} * {num2}, honey? Why, that's {multiResult}!");
                }
            }
            else
            {
                return;
            }
        }
        
        [Command("divide")]
        [Aliases("division", "/", "divideby")]
        public async Task Divide(CommandContext context, decimal num1, decimal num2)
        {
            if (context.Guild.Id == 615673301184020505 && context.Channel.Id == 1142230984889225327)
            {
                try
                {
                    decimal divideResult = num1 / num2;

                    if (divideResult < 0)
                    {
                        await context.Channel.SendMessageAsync($"Sorry, hun. I can't do negative numbers - at least...not yet, haha!");
                    }
                    else
                    {
                        await context.Channel.SendMessageAsync($"{num1} divided by {num2}, honey? Why, that's {divideResult}!");
                    }
                }
                catch (DivideByZeroException)
                {
                    await context.Channel.SendMessageAsync($"Why, I can't divide by zero, honey!");
                }
            }
            else
            {
                return;
            }
        }

        [Command("findremainder")]
        [Aliases("remainder", "modulo", "%")]
        public async Task FindRemainder(CommandContext context, decimal num1, decimal num2)
        {
            if (context.Guild.Id == 615673301184020505 && context.Channel.Id == 1142230984889225327)
            {
                try
                {
                    decimal moduloResult = num1 % num2;
                    decimal divideResult02 = num1 / num2;

                    if (moduloResult < 0 || divideResult02 < 0)
                    {
                        await context.Channel.SendMessageAsync($"Sorry, hun. I can't do negative numbers - at least...not yet, haha!");
                    }
                    else
                    {
                        await context.Channel.SendMessageAsync($"{num1} divided by {num2}, AND you're trying to find a remainder, doodlebug? Why, that's simple! The remainder is {moduloResult}! In case you were wondering, honey, the result by dividing is also {divideResult02}.");
                    }
                }
                catch (DivideByZeroException)
                {
                    await context.Channel.SendMessageAsync($"Why, I can't divide by zero, honey!");
                }
            }
            else
            {
                return;
            }
        }
    }
}
