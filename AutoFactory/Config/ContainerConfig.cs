using Autofac;
using Negocio;
using Negocio.Dados;
using Negocio.Dados.Interfaces;
using Negocio.Negocio;
using Negocio.Negocio.Interfaces;

namespace AutoFactory.Config
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Robot01>().As<IRobot01>();

            builder.RegisterType<Repository>().As<IRepository>();
            builder.RegisterType<FirstRepository>().As<IFirstRepository>();
            builder.RegisterType<SecondRepository>().As<ISecondRepository>();
            builder.RegisterType<FirstService>().As<IFirstService>();
            builder.RegisterType<SecondService>().As<ISecondService>();
            builder.RegisterType<DataAccess>().As<IDataAccess>();

            //builder.RegisterAssemblyTypes(Assembly.Load(nameof(Negocio)))
            //    .Where(n => n.Namespace.Contains("Modelo"))
            //    .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == $"I{t.Name}"));

            return builder.Build();
        }
    }
}