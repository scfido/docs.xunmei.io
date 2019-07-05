using Volo.Abp.Settings;

namespace Xunmei.Docs.Settings
{
    public class DocsSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(DocsSettings.MySetting1));
        }
    }
}
