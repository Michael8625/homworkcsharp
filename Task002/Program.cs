// Console.Write("Видите размер масива:");
 int size = 10;
        int[] array = new int[size];
        Random rand = new Random();

        int g = 0;
        Console.WriteLine("Размер массива: " + size);

        // Заполнение массива случайными числами от 1 до 100
        for (int i = 0; i < size; i++)
        {
            array[i] = rand.Next(1, 100);
        }

        // Подсчет чисел в диапазоне [20, 90]
        for (int i = 0; i < size; i++)
        {
            if (array[i]%2 == 0)
            {
                g = g + 1;
            }
        }

        // Вывод массива
        Console.Write("Массив: ");
        for (int i = 0; i < size; i++)
        {
            Console.Write(array[i] + " ");
        }

        // Вывод результата подсчета
        Console.WriteLine("\nКоличество четных чисел в массиве " + g);