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
            if (array[i] > 20 && array[i] < 90)
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
        Console.WriteLine("\nКоличество элементов массива, значения которых лежат в отрезке [20, 90]: " + g);
