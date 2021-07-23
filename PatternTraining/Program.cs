using PatternTraining.CommandPattern;
using PatternTraining.CommandPattern.Commands;
using PatternTraining.FactoryPattern;
using PatternTraining.MediatorPattern.Example;
using PatternTraining.MediatorPattern.Implementation;
using PatternTraining.MediatorPattern.Interfaces;
using PatternTraining.ObserverPattern;
using PatternTraining.StatePattern;
using PatternTraining.StrategyPattern;
using System;
using System.Text;

namespace PatternTraining {
    class Program {

        static void Main(string[] args) {
            Console.OutputEncoding = Encoding.UTF8;

            ObserverTest();

            Console.ReadKey();
        }


        private static void MediatorPatternTest() {
            IMediator mediator = new Mediator();
            IRequest<Ping> ping = new Ping();
            IRequestHandler<Ping> pong = new Pong();
            mediator.AddHandler(pong);
            mediator.Send(ping);
            IRequest<Din, string> din = new Din();
            IRequestHandler<Din, string> don = new Don();
            mediator.AddHandler(don);
            var dindon = mediator.Send(din);
            Console.WriteLine(dindon);
        }

        private static void CommandPatternTest() {
            var character = new CommandPattern.Character("Niko");
            var manager = new CommandManager();
            manager.Commands.Add(CommandType.GoUp, new GoUp(character));
            manager.Commands.Add(CommandType.GoDown, new GoDown(character));
            manager.Commands.Add(CommandType.GoLeft, new GoLeft(character));
            manager.Commands.Add(CommandType.GoRight, new GoRight(character));
            character.Show();

            while (true) {
                Console.WriteLine("wasd - for move");
                Console.WriteLine("z - for undo");
                Console.WriteLine("q - for quit");
                var keyChar = Console.ReadKey().KeyChar;
                switch (keyChar) {
                    case 'q': return;
                    case 'w':
                        manager.Execute(CommandType.GoUp);
                        break;
                    case 's':
                        manager.Execute(CommandType.GoDown);
                        break;
                    case 'a':
                        manager.Execute(CommandType.GoLeft);
                        break;
                    case 'd':
                        manager.Execute(CommandType.GoRight);
                        break;
                    case 'z':
                        manager.Undo();
                        break;
                }
                character.Show();
            }

        }

        private static void StatePatternTest() {
            var car = new Car("Toyota", null);
            while (true) {
                var input = Console.ReadKey().KeyChar;
                switch (input) {
                    case 'q': return;
                    case 'w':
                        car.Forward();
                        break;
                    case 's':
                        car.Reverse();
                        break;
                }
                Console.WriteLine();
            }
        }

        private static void ObserverTest() {
            var rnd = new Random();
            var character = new ObserverPattern.Character(100);
            var healthUi = new HealthUI();
            var jumpUi = new JumpCounterUI();
            character.AddObserver(healthUi);
            character.AddObserver(jumpUi);

            void Damage() {
                character.HealthChange(-rnd.Next(10, 20));
            }

            void Healing() {
                character.HealthChange(20);
            }


            while (true) {
                var keyChar = Console.ReadKey().KeyChar;
                switch (keyChar) {
                    case 'q': return;
                    case 'd':
                        Damage();
                        break;
                    case 'h':
                        Healing();
                        break;
                    case 'j':
                        character.Jump();
                        break;
                }
            }
        }

        private static void StrategyTest() {
            var me = new Man() { Name = "Nikolay", Age = 27 };

            me.PutInGlass(new Tea()).Drink();
            me.PutInGlass(new Beer()).Drink();
        }

        private static void FactoryTest() {
            var comfortableFunitureFactory = new ComfortableFunitureFactory("Фабрика комфортной мебели");
            var officeFurnitureFactory = new OfficeFurnitureFactory("Фабрика мебели для офиса");

            var officeChair = officeFurnitureFactory.CreateChair();
            var officeTable = officeFurnitureFactory.CreateTable();

            var comfortChair = comfortableFunitureFactory.CreateChair();
            var comfortTable = comfortableFunitureFactory.CreateTable();
        }
    }
}
