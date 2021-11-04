// Cформировать случайным образом целочисленный
//  массив A из натуральных двузначных чисел.
//  Создать на его основе масив B, отбрасывая те, которые

// нарушают порядок возрастания
// больше среднего арифметического элементов A
// чётные

int[] A = new int[10];
int index = 0;

while (index < 10)
{
    A[index] = new Random().Next(10, 100);
    index++;
}

index = 0;
while (index < 10)
{
    Console.WriteLine(A[index]);
    index++;
}
Console.WriteLine();

int B = 0;
index = 1;
int currentElement = A[0];
Console.WriteLine("Не нарушают порядок возрастания: " + currentElement);
while (index <= 9)
{
    if (A[index] > currentElement)
    {
        B = A[index];
        Console.WriteLine(B);
        currentElement = A[index];
    }
    index++;
}

int average = 0;
index = 0;
int sum = 0;
while (index < A.Length)
{
    sum += A[index];
    index++;
    average = sum / A.Length;

}
Console.WriteLine("Среднее арифметическое: " + average);

index = 0;
A[index] = A[0];
Console.WriteLine("Не превышает значения среднего арифметического: ");
while (index <= 9)
{
    if (A[index] <= average)
    {
        Console.WriteLine(A[index]);
    }
    index++;
}

index = 0;
A[index] = A[0];
Console.WriteLine("Нечётные: ");
while (index < 10)
{
    if (A[index] % 2 != 0)
    {
        Console.WriteLine(A[index]);
    }
    index++;
}
