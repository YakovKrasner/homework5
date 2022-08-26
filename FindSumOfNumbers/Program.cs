int CountOfNumbers = 9;
int [] array = new int [CountOfNumbers];
int lowerBoundOfRandom = 1;
int upperBoundOfRandom = 10; // Указываем верхнюю и нижнюю границы отрезка в рамках которого будут генерироваться псевдолучайные числа 

for (int index = 0; index<array.Length; index ++)
    { 
        array[index] = new Random().Next(lowerBoundOfRandom,upperBoundOfRandom+1);
        Console.Write ($" {array[index]}");
    }
Console.WriteLine ();
for (int index = 0; index<=((array.Length -1) - index); index ++)
    {
        if (index == ((array.Length - 1) - index)) Console.Write ($" {array[index]}");
        else Console.Write ($" {array[index] + array[(array.Length - 1) - index]}");
    }
Console.WriteLine ();