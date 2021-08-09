using Autofac;
using Infra.Data;
using Infra.Data.Interfaces;
using Infra.Model;
using Infra.Model.Interfaces;
using Microsoft.EntityFrameworkCore;
using Negocio.Context;
using Services;
using Services.Interfaces;

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
            builder.RegisterType<BaseModel>().As<IBaseModel>();
            builder.RegisterType<DbContextOptionsBuilder>().AsSelf();

            builder.RegisterType<SimpleContext>().AsSelf();

            return builder.Build();
        }
    }
}