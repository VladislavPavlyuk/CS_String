/*

*/


namespace Program
{
    class Task1
    { 
		public void task()
        {
            try
            {

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }	
    }

    class Task2
    {
        public void task()
        {
            try
            {

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
    class Task3
    {
        public void task()
        {
            try
            {

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }

    class MainClass
    {
        static void Main()
        {
            string answer;
            do
            {
                Console.Clear();

                Console.WriteLine("\nЗАДАНИЯ :" +
                    "\r\n\n1. \r\n2. \r\n3. " +
                    "\r\n\n0. Выход");

                Console.Write("Введите номер задания: ");

                string str = Console.ReadLine();

                switch (str)
                {
                    case "1":
                        Console.WriteLine("1. Задание");

                        Task1 obj1 = new Task1();
                        
                        obj1.task();

                        break;

                    case "2":
                        Console.WriteLine("2. Задание");

                        Task2 obj2 = new Task2();

                        obj2.task();

                        break;

                    case "3":
                        Console.WriteLine("3. Задание");

                        Task3 obj3 = new Task3();

                        obj3.task();

                        break;

                    case "0":
                        Console.WriteLine("Спасибо!");
                        break;

                    default:
                        Console.WriteLine("Такого задания нет!");
                        break;
                }
                Console.WriteLine("Ещё раз? д/н");

                answer = Console.ReadLine();

            } while (answer == "д" || answer == "Д");
        }
    }


}