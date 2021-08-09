using Autofac;
using AutoFactory.Config;
using Services;
using System;

namespace AutoFactory
{
    class Program
    {
        static void Main(string[] args)
        {            
            var container = ContainerConfig.Configure();
            using (var scope = container.BeginLifetimeScope()) 
            {
                var robo = scope.Resolve<IRobot01>();
                robo.Run();
                Console.ReadLine();
            }
        }
    }
}