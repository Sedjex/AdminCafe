using System;

namespace AdminCafe
{
    class Program
    {
        static void Main(string[] args)
        {
            Table[] tables = { new Table(1, 5), new Table(2, 10), new Table(3, 20) };

            bool isOpen = true;

            while (isOpen)
            {
                Console.WriteLine("Адміністрування кафе\n");
                for (int i = 0; i < tables.Length; i++)
                {
                    tables[i].ShowInfo();
                }

                Console.Write("\nВведіть номер стола:");
                int userTable = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.Write("\nВведіть кількість місць:");
                int userPlace = Convert.ToInt32(Console.ReadLine());

                bool isReserve = tables[userTable].Reserve(userPlace);

                if (isReserve)
                {
                    Console.WriteLine("Броювання успішне");
                }
                else
                {
                    Console.WriteLine("Помилка бронювання");
                }

                Console.ReadKey();
                Console.Clear();
            }
        }

        class Table
        {
            private int _number;
            private int _maxPlace;
            private int _freePlace;

            public Table(int number, int maxPlace)
            {
                _number = number;
                _maxPlace = maxPlace;
                _freePlace = maxPlace;
            }

            public void ShowInfo()
            {
                Console.WriteLine("Стіл - " + _number + " вільно місць - " + _freePlace + " / " + _maxPlace);
            }

            public bool Reserve(int place)
            {
                bool isReserve;
                isReserve = _freePlace >= place;

                if (isReserve)
                {
                    _freePlace -= place;
                    return isReserve;
                }
                else
                {
                    return isReserve;
                }
            }
        }
    }
}
