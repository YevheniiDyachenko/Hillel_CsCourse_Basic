namespace _14._1_PluginManager;

public class GreetingPlugin : IPlugin
{
    public void Execute()
    {
        Console.WriteLine("GreetingPlugin: Hello, welcome to the plugin application!");
    }
}