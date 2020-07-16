using System.Collections.Generic;

namespace TSQLLint.Common
{
    public interface IConfigReader
    {
        bool IsConfigLoaded { get; }

        int CompatabilityLevel { get; }

        string ConfigFileLoadedFrom { get; }

        Dictionary<string, string> GetPlugins();

        Dictionary<string, RuleViolationSeverity> GetRules();

        RuleViolationSeverity GetRuleSeverity(string key);

        void ListPlugins();

        void LoadConfig(string configFilePath);
    }
}
