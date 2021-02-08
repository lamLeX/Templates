namespace ApiTemplate
{
    using System.Reflection;

    public record AssemblyInformation(string Product, string Description, string Version)
    {
        public static readonly AssemblyInformation Current = new AssemblyInformation(typeof(AssemblyInformation).Assembly);

        public AssemblyInformation(Assembly assembly)
            : this(
                assembly.GetCustomAttribute<AssemblyProductAttribute>().Product,
                assembly.GetCustomAttribute<AssemblyDescriptionAttribute>().Description,
                assembly.GetCustomAttribute<AssemblyFileVersionAttribute>().Version)
        {
        }
    }
}