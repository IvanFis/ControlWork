
//Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []


internal class Program
{
    private static void Main(string[] args)
    {
        int FindOutLength(string message)

        {
            Console.Write(message);
            int elem = Convert.ToInt32(Console.ReadLine());
            return elem!;
        }


        void PrintArray(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }


        string[] InputArray(int leng)
        {
            string[] array = new string[leng];
            int index = 0;
            int count = leng - 1;
            while (count >= 0)
            {
                Console.Write($"Введите элемент под номером {leng - count}: ");
                count--;
                array[index] = Console.ReadLine();
                index++;
            }
            return array;
        }



        string[] CreateLastArray(int length, string[] arr)
        {
            string[] lastArray = new string[length];
            for (int i = 0; i < length; i++)
            {
                if (arr[i].Length <= 3)
                {
                    lastArray[i] = arr[i];
                }
            }
            return lastArray;

        }


        int leng = FindOutLength("Введите количество элементов в массиве: ");
        string[] array = InputArray(leng);
        PrintArray(array);
        Console.WriteLine();
        string[] array2 = CreateLastArray(leng, array);
        PrintArray(array2);
    }
}