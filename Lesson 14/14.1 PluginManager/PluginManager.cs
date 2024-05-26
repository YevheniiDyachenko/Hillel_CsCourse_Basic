namespace _14._1_PluginManager;

public class PluginManager
{

    public void LoadPlugin(IPlugin plugin)
    {
            plugin.Execute();
    }
}