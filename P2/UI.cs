using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2
{
    class UI
    {
        Training Training;
        Detection Detection;

        public UI(Training training, Detection detection)
        {
            this.Training = training;
            this.Detection = detection;
        }

        public void Start()
        {
            ConsoleMenu mainMenu = new ConsoleMenu();

            mainMenu.PreText = "Take a pick";

            mainMenu.Add("Training", TrainingAction);
            mainMenu.Add("Detection", DetectionAction);

            mainMenu.Render();
        }

        public void Stop()
        {
            Environment.Exit(1);
        }

        void TrainingAction()
        {
            Console.Clear();
            Console.Write("input epsilon: ");
            Training.Run(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Detection.Run();
        }

        void DetectionAction()
        {
            Detection.Run();
        }
    }

    class ConsoleMenu
    {
        int selected = 0;
        List<ConsoleMenuItem> menu = new List<ConsoleMenuItem>();

        public string PreText = null;
        public string PostText = null;

        public void Add(string text, Action action)
        {
            menu.Add(new ConsoleMenuItem(text, action));
        }

        public void Render()
        {
            Console.Clear();

            if (PreText != null)
            {
                Console.WriteLine(PreText);
            }

            foreach (ConsoleMenuItem item in menu)
            {
                if (item.ID == selected)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                }

                Console.WriteLine("\t\t{0}\t\t", item.Text);

                Console.ResetColor();
            }

            if (PostText != null)
            {
                Console.WriteLine(PostText);
            }

            ParseInput();
        }

        void ParseInput()
        {
            ConsoleKeyInfo cki = Console.ReadKey();

            if (cki.Key == ConsoleKey.UpArrow)
            {
                if (selected > 0)
                {
                    selected--;
                }
            }

            if (cki.Key == ConsoleKey.DownArrow)
            {
                if (selected < menu.Count - 1)
                {
                    selected++;
                }
            }

            if (cki.Key == ConsoleKey.Enter)
            {
                menu[selected].Action();

                return;
            }

            Render();
        }
    }

    class ConsoleMenuItem
    {
        static int increment = 0;

        public int ID;
        public string Text;
        public Action Action;

        public ConsoleMenuItem(string text, Action action)
        {
            this.ID = increment++;
            this.Text = text;
            this.Action = action;
        }
    }
}
