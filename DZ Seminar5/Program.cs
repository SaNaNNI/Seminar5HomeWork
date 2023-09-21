// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// // [345, 897, 568, 234] -> 2


// Random random = new Random();

// int[] numbers = new int[4]; 

//     for (int i = 0; i < numbers.Length; i++)
//    {
//     numbers[i] = random.Next(100, 1000); 
//    }

// int evenCount = 0;
// foreach (int number in numbers)
//     {
//         if (number % 2 == 0)
//         {
//             evenCount++;
//         }
//     }

// Console.WriteLine("Массив случайных трехзначных чисел:");
//     foreach (int number in numbers)
//     {
//         Console.WriteLine(number);
//     }
    
// Console.WriteLine($"Количество четных чисел: {evenCount}");





// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// Random random = new Random();

// int[] numbers = new int[4]; 
       
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = random.Next(-100, 100); 
//     }
        
// int sum = 0;
// for (int i = 1; i < numbers.Length; i += 2)
//     {
//         sum += numbers[i];
//     }

// Console.WriteLine("Массив случайных чисел:");
//     foreach (int number in numbers)
//     {
//         Console.WriteLine(number);
//     }
// Console.WriteLine($"Сумма элементов на нечетных позициях: {sum}");




// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] numbers = { 3.22, 4.2, 1.15, 77.15, 65.2 };


double min = numbers[0];
double max = numbers[0];

for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] < min)
    {
        min = numbers[i];
    }
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
}

double difference = max - min;


Console.WriteLine("Массив вещественных чисел:");
foreach (double number in numbers)
{
    Console.WriteLine(number);
}

Console.WriteLine($"Разница между максимальным и минимальным элементами: {difference}");
