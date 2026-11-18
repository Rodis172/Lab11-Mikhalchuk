// int[] recordBooks = { 1042, 1058, 1071, 1093, 1105 };
// int target = 1075;
// bool found = false;

// foreach (int number in recordBooks)
// {
//     if (number == target)
//     {
//         found = true;
//         break;
//     }
// }

// Console.WriteLine(found ? "Студент найден" : "Студент не найден");


// int variant = 5;
// bool isPrime = true;

// if (variant < 2)
// {
//     Console.WriteLine("Номер варианта не является ни простым, ни составным");
//     return;
// }

// for (int divisor = 2; divisor < variant; divisor++)
// {
//     if (variant % divisor == 0)
//     {
//         isPrime = false;
//         break;
//     }
// }
// Console.WriteLine(isPrime ? "Номер варианта простой" : "Номер варианта составной");



// int[] pointsPerLab = { 8, -1, 10, 9, -1, 7 };
// int sum = 0;
// int cn = 0;
// foreach (int point in pointsPerLab)
// {
//     if (point < 0)
//     {
//         continue;
//     }
//     cn += 1;
//     sum += point;
// }
// Console.WriteLine($"Работ сдано: {cn}");
// Console.WriteLine($"Сумма баллов за сданные работы: {sum}");





// int[] groupIds = { 101, 104, 107, 104, 110 };
// bool hasDuplicates = false;

// for (int i = 0; i < groupIds.Length; i++)
// {
//     for (int j = i + 1; j < groupIds.Length; j++)
//     {
//         if (groupIds[i] == groupIds[j])
//         {
//             Console.WriteLine($"Совпали номера зачётки: {groupIds[i]} и {groupIds[j]}");            
//             hasDuplicates = true;
//             break;
//         }
//     }
// }

// if (!hasDuplicates)
// {
//     Console.WriteLine("Все номера уникальны");
// }





// int days = 5;
// int lessonsPerDay = 6;
// bool found = false;

// for (int day = 1; day <= days && !found; day++)
// {
//     for (int lesson = 1; lesson <= lessonsPerDay; lesson++)
//     {
//         bool isFree = (day == 7 && lesson == 4);
//         if (isFree)
//         {
//             Console.WriteLine($"Свободный слот: день {day}, урок {lesson}");
//             found = true;
//             break;
//         }
//     }
// }

// if (!found)
// {
//     Console.WriteLine("Свободных слотов нет");
// }





// //Задача А

// int[] num = { 2, 4, 8, 1, 77, 32, 9 };
// int target = 2;
// int index = 0;
// bool flag = false;

// foreach(int n in num)
// {
//     if (n == target)
//     {
//         flag = true;
//         break;
//     }
//     index += 1;
// }

// Console.WriteLine(flag ? $"Индекс найден: {index}" : "Его нет");



// // //Задача Г
// int[] list = { 5, 55, 1, 98, 2, 6, 3, 6 };

// for(int i = 0; i < list.Length; i++)
// {
//     for(int j = i + 1; j < list.Length; j++)
//     {
//         if(list[i] == list[j])
//         {
//             Console.WriteLine($"Повторяющийся элемент: {list[i]}");                     
//             break;
//         }
//     }
// }






// //Индивидуальный вариант ★★
// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname)) {
//     Console.WriteLine("Фамилия не введена. Завершение работы.");
//     return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
//     .OrderBy(_ => rnd.Next())
//     .Take(2)
//     .OrderBy(x => x)
//     .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");



// //Вариант 6.
int[] array = { 1, 3, 5, 5, 8, 10 };
bool isSorted = true;

for (int i = 0; i < array.Length - 1; i++)
{
    if (array[i] > array[i + 1])
    {
        isSorted = false;
        break;
    }
}

Console.WriteLine(isSorted ? "Массив отсортирован по возрастанию" : "Массив не отсортирован");