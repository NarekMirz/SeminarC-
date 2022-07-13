Console.WriteLine("Укажите количество чисел, которое собираетесь ввести.");
int number = Convert.ToInt32(Console.ReadLine());


while (number <= 0)
{
    Console.WriteLine("Введите другое число");
    number = Convert.ToInt32(Console.ReadLine());
}


int[] array = new int[number];


void FillArray(int[] collection)
{
    int a = 1;      
    for (int index = 0; index < number; index++)
    {
    Console.WriteLine("Введите число " + a );
    collection[index] = Convert.ToInt32(Console.ReadLine());
    a++;
    }
}


int checkValue(int[] collection)
{
    int result = 0;

    for (int index = 0; index < number; index++)
    {
        if (collection[index] > 0) result++;
    }

    return result;
}

FillArray(array);


Console.WriteLine("Количество чисел которые больше  нуля: " + checkValue(array));