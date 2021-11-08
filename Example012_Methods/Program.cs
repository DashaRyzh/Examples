// ======Работа с текстом======
// Дан текст. В нём нужно заменить все пробелы черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

// string text = "Крупные ИТ-компании создают настолько привлекательные условия труда, "
//             + "что уже стали законодателями мод среди работодателей. "
//             + "В ИТ совершенно нормально рассчитывать на современный офис, "
//             + "который больше похож на развлекательный центр: "
//             + "с кафе, безлимитным кофе, вкусняшками, свежими фруктами, "
//             + "тренажерным залом, штатным массажистом, "
//             + "просторными переговорными комнатами со всевозможными мягкими зонами. "
//             + "А также на помощь в релокации, доступ к корпоративной библиотеке, "
//             + "приветственные наборы и подарки на праздники — от канцелярских "
//             + "принадлежностей до термокружек, пауэрбанков и даже ноутбуков.";

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;

//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }

//     return result;
// }
// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'С', 'с');


// int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};
// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;
//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if(array[j] < array[minPosition]) minPosition = j;
//         }

//         int temporary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;
//     }
// }

// PrintArray(arr);
// SelectionSort(arr);
// PrintArray(arr);

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        for(int j = i + 1; j < array.Length; j++)
        {
            if(array[j] > array[maxPosition])
            {
                maxPosition = j;
            }
        }    
    
    int temporary = array[i];
    array[i] = array[maxPosition];
    array[maxPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);