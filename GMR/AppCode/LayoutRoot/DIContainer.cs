using Autofac;
using System.Linq;

namespace GMR.AppCode.LayoutRoot
{
    internal static class DIContainer
    {
        public static ILifetimeScope Scope { get; set; }

        public static T Resolve<T>(params Parameter[] args) => Scope.Resolve<T>(args.Select(_ => new NamedParameter(_.Name, _.Value)));
    }
}
