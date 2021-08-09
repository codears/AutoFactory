using Infra.Model;
using Services.Interfaces;
using System;
using System.Linq;

namespace Services
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
            var firsts = _firstService.GetAll().GetAwaiter().GetResult();
            foreach (var item in firsts)
            {
                FirstModel model = item as FirstModel;
                Console.WriteLine($"--- { model.Name }");
            }

            if (!firsts.Any())
                firsts.Add(new FirstModel { Name = "Arley", ExpirationDate = DateTime.Now, Id = Guid.NewGuid() });

            _firstService.Create(firsts.FirstOrDefault());

            /// simulando outro tipo de acesso à base de dados
            SecondModel secondModel = _secondService.GetById(1) as SecondModel;            
            Console.WriteLine($"=> second: {secondModel.Name}");
            secondModel.Name = "Pantera";
            _secondService.Update(secondModel);
            Console.WriteLine($"--- { secondModel.Name };");
        }
    }
}