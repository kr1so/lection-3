//Продолжение функций
//Упорядочить массив

/* Алгоритм сортировки методом выбора. Другие его названия:
Алгоритм сортировки min/max 
Выбор min/max /  и т.д. */

/* Дана последовательность чисел:
6 8 3 2 1 4 5 7
Задача:
Выбрать самый 1-й элемент и в оставшейся части определить min. Поменять текущий на min. И так с другими. */

/* int[]arr={6,8,3,2,1,4,5,7,2,4};
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < array.Length; i++)
     {
     System.Console.Write($"{array[i]} ");
     }
    Console.WriteLine();
}
void SelectionSort(int[] array)
{
  for (int i = 0; i < array.Length -1; i++)
  {
    int minPosition = i;
    //int maxPosition = i;
    for (int j+1 = 0; j < array.Length; j++) 
    {
        if (array[j]>array[minPosition]) minPosition = j;
     //if (array[j]>array[maxPosition]) maxPosition = j;
    }
    int temporary = array[i];
    array[i] = array[minPosition];
    //array[i] = array[maxPosition];
    array[minPosition] = temporary;
    //array[maxPosition] = temporary;
  }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr); */