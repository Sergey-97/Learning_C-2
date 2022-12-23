 Console.WriteLine("Введите 3 числа:");
            int num_1 = int.Parse(Console.ReadLine());
            int num_2 = int.Parse(Console.ReadLine());
            int num_3 = int.Parse(Console.ReadLine());

            int max = num_1;

            while (num_2 > max)
            {
                max = num_2;
            }

            while (num_3 > max)
            {
                max = num_3;
            }

            Console.WriteLine("Максимальное число -> " + max);