namespace _14._1_PluginManager
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 4. Create an instance of PluginManager
            PluginManager pluginManager = new PluginManager();

            // 5.  Download both plugins
            IPlugin greetingPlugin = new GreetingPlugin();
            IPlugin calculatorPlugin = new CalculatorPlugin();

            // 6. Call the Execute method on each plugin
            pluginManager.LoadPlugin(greetingPlugin);
            pluginManager.LoadPlugin(calculatorPlugin);
        }
    }
}