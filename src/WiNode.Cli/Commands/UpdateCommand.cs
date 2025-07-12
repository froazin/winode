using System.ComponentModel;
using Spectre.Console.Cli;

namespace WiNode.Cli.Commands;

[Description("Update Node.js to the latest matching version.")]
public class UpdateCommand : Command<UpdateCommand.Settings>
{
  public class Settings : CommandSettings
  {
    [CommandArgument(0, "[VERSION]")]
    [Description("The version of Node.js to update. This must be a full or partial version number (e.g., '22', '20.1', '22.1.0'). If not specified, the command will update the currently active version.")]
    public string? Version { get; set; }

    [CommandOption("-a|--all")]
    [Description("Update all installed versions of Node.js to the latest matching version. If this option is used, the VERSION argument is ignored.")]
    public bool? All { get; set; }
  }

  public override int Execute(CommandContext context, Settings settings)
  {
    throw new NotImplementedException("This command is not yet implemented.");
  }
}
