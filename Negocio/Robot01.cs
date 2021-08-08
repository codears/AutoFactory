using Negocio.Modelo;
using Negocio.Negocio.Interfaces;
using System;
using System.Linq;

namespace Negocio
{
    public class Robot01 : IRobot01
    {
        readonly IFirstService _firstService;
        readonly ISecondService _secondService;

        public Robot01(IFirstService firstService, ISecondService secondService)
        {
            _firstService = firstService;
            _secondService = secondService;
        }
        public void Run()
        {
            Console.WriteLine("Run first robot");
            var models = _firstService.GetAll();
            foreach (var item in models)
            {
                FirstModel model = item as FirstModel;
                Console.WriteLine($"--- { model.Name }");
            }

            _firstService.Create(models.FirstOrDefault());
            SecondModel secondModel = _secondService.GetById(1) as SecondModel;
            Console.WriteLine($"=> second: {secondModel.Name}");

            secondModel.Name = "Pantera";
            _secondService.Update(secondModel);

            Console.WriteLine($"--- { secondModel.Name };");
        }
    }
}