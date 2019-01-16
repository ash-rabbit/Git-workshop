using System;

namespace git_workshop_app
{
    class Program
    {
        public enum MenuChoice
        {
            Quit = 0,
            Rectangle = 1,
            Triangle = 2
        }

        static void Main(string[] args)
        {
            MenuChoice choice = MenuChoice.Triangle;
            while ((choice = GetChoice()) != MenuChoice.Quit)
            {
                ShapeArea shape = null;

                switch (choice)
                {
                    case MenuChoice.Triangle:
                        shape = CreateTriangle();
                        break;
                    case MenuChoice.Rectangle:
                        shape = CreateRectangle();
                        break;
                    default:
                        break;
                }

                Console.WriteLine("The area of the {0} is {1}", choice, shape.Area);
                Console.WriteLine();
            }

            Console.ReadKey(true);
        }

        public static MenuChoice GetChoice()
        {
            Console.WriteLine("Choose which shape you would like to calculate the area for:");
            Console.WriteLine("\t{0} - Rectangle", (int)MenuChoice.Rectangle);
            Console.WriteLine("\t{0} - Triangle", (int)MenuChoice.Triangle);
            Console.WriteLine("\t{0} - Quit", (int)MenuChoice.Quit);
            Console.Write("Choice: ");
            string value = Console.ReadLine();

            MenuChoice choice;
            if (!Enum.TryParse(value, out choice) || !Enum.IsDefined(typeof(MenuChoice), choice))
            {
                Console.WriteLine("Invalid choice, please enter a valid choice.");
                return GetChoice();
            }

            return choice;
        }

        private static int GetInt(string prompt)
        {
            bool isValid = false;
            int value = 0;

            while (!isValid)
            {
                Console.Write(prompt);
                isValid = int.TryParse(Console.ReadLine(), out value);
            }

            return value;
        }

        private static Triangle CreateTriangle()
        {
            int baseWidth = GetInt("Base Width: ");
            int height = GetInt("Height: ");
            return new Triangle() { BaseWidth = baseWidth, Height = height };
        }

        private static Rectangle CreateRectangle()
        {
            int width = GetInt("Width: ");
            int height = GetInt("Height: ");
            return new Rectangle() { Width = width, Length = height };
        }
    }
}
