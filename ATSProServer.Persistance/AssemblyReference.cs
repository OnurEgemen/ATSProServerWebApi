using System.Reflection;

namespace ATSProServer.Persistance
{
    public static class AssemblyReference
    {
        public static readonly Assembly Assembly = typeof(Assembly).Assembly;
    }
}
