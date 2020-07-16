using System;

namespace TSQLLint.Common.Tests
{
    public class TestPlugin : IPlugin
    {

        public void PerformAction(IPluginContext context, IReporter reporter, IConfigReader configReader)
        {
            throw new NotImplementedException();
        }
    }
}
