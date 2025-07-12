using System.ComponentModel;
using Spectre.Console.Cli;

namespace WiNode.Cli.Commands;

[Description("List available Node.js versions")]
public sealed class ListCommand : Command<ListCommand.Settings>
{
  public sealed class Settings : CommandSettings
  {
    [CommandArgument(0, "[QUERY]")]
    [Description("The query to filter the Node.js versions. This must be a full or partial version number (e.g., '22', '20.1', '22.1.0').")]
    public string? Query { get; set; }

    [CommandOption("-o|--online")]
    [Description("Check online for available Node.js versions. If not specified, only local versions are listed.")]
    public bool? Online { get; set; }
  }

  public override int Execute(CommandContext context, Settings settings)
  {
    throw new NotImplementedException("This command is not yet implemented.");
  }
}
