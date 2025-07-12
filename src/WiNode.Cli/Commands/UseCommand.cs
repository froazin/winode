using System.ComponentModel;
using Spectre.Console.Cli;

namespace WiNode.Cli.Commands;

[Description("Set the active Node.js version so that it can be used in the current session.")]
public class UseCommand : Command<UseCommand.Settings>
{
  public class Settings : CommandSettings
  {
    [CommandArgument(0, "<VERSION>")]
    [Description("The version of Node.js to use. This must be a full or partial version number (e.g., '22', '20.1', '22.1.0').")]
    public string? Version { get; set; }

    [CommandOption("-d|--default")]
    [Description("Set the specified version as the default Node.js version.")]
    public bool? Default { get; set; }
  }

  public override int Execute(CommandContext context, Settings settings)
  {
    throw new NotImplementedException("This command is not yet implemented.");
  }
}
