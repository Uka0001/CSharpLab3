// See https://aka.ms/new-console-template for more information
/*3. ОДНОВИМІРНІ МАСИВИ
 Задания на максимальную оценку "удовлетворительно"
 З одновимірного цілочисельного масиву переписати 
 всі числа в другий масив так, щоб спочатку йшли парні елементи, потім нулі, потім непарні елементи. 
 */
//TODO 1st task
/*
int[] array = { 3, 4, 5, 6, 70, 45, 56, 75, 0, 45, 5, 34, 655, 87, 0 };
int[] result = new int[array.Length];
int temp = 0;
foreach (int number in array)
{
    if (number % 2 == 0 & number != 0)
    {
        result[temp] = number;
        temp++;
    }
}

foreach (int number in array)
{
    if (number == 0)
    {
        result[temp] = number;
        temp++;
    }
}

foreach (int number in array)
{
    if (number % 2 != 0)
    {
        result[temp] = number;
        temp++;
    }
}

Console.WriteLine("Input array is: ");
Array.ForEach(array, Console.WriteLine);
Console.WriteLine("Result array is: ");
Array.ForEach(result, Console.WriteLine);*/

/*Задания на максимальную оценку "отлично"
 2, 8	Дано два масиви, що не убувають, х і y. Знайти їх з'єднання,
  тобто масив z, що також не убуває та містить всі їх елементи,
   причому кожен елемент повинен входити в масив z стільки разів,
    скільки разів він входить в масиви х і y.*/
//TODO 2nd task

int[] array1 = { 1, 2, 2, 3, 3, 3, 100 };
int[] array2 = { 0, 2, 2, 3, 6, 8, 8, 9, 10, 11, 12 };
int count1 = array1.Length;
int count2 = array2.Length;
int[] arrayResult = new int[count1 + count2];

int a = 0, b = 0;   // indexes in origin arrays
int i = 0;          // index in result array

// first part
while (a < count1 && b < count2)
{
    if (array1[a] <= array2[b])
    {
        // element in first array at current index 'a'
        // is less or equals to element in second array at index 'b'
        arrayResult[i++] = array1[a++];
    }
    else
    {
        arrayResult[i++] = array2[b++];
    }
}

// tail
if (a < count1)
{
    // fill tail from first array
    for (int j = a; j < count1; j++)
    {
        arrayResult[i++] = array1[j];
    }
}
else
{
    // fill tail from second array
    for (int j = b; j < count2; j++)
    {
        arrayResult[i++] = array2[j];
    }
}

// print result
Console.WriteLine("Result array is: ");
Array.ForEach(arrayResult, Console.WriteLine);