using System.ComponentModel;
using Spectre.Console.Cli;

namespace WiNode.Cli.Commands;

[Description("Uninstall a specific version of Node.js")]
public class UninstallCommand : Command<UninstallCommand.Settings>
{
  public class Settings : CommandSettings
  {
    [CommandArgument(0, "<VERSION>")]
    [Description("The version of Node.js to uninstall. This must be a full or partial version number (e.g., '22', '20.1', '22.1.0').")]
    public string? Version { get; set; }

    [CommandOption("-f|--force")]
    [Description("Force the uninstallation. Use with caution.")]
    public bool? Force { get; set; }

    [CommandOption("--scope")]
    [Description("Specify the scope of the uninstallation. Options are 'user' or 'machine'. Default is 'user'.")]
    public string? Scope { get; set; }
  }

  public override int Execute(CommandContext context, Settings settings)
  {
    throw new NotImplementedException("This command is not yet implemented.");
  }
}
