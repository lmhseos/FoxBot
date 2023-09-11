using System.Threading.Tasks;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;

namespace FoxBot.commands
{
    public class GenericCommands : BaseCommandModule
    {
        [Command("Test")]
        public async Task TestCommand(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("Hello");
        }
    }
}