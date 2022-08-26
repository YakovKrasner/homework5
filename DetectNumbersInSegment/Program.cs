int NumbersCount = 123; // указываем количество чисел
int lowerBoundOfRandom = 1;
int upperBoundOfRandom = 300; // Указываем верхнюю и нижнюю границы отрезка в рамках которого будут генерироваться псевдолучайные числа 
int lowerBoundOfDetection = 10; 
int upperBoundOfDetection = 99; // Указываем верхнюю и нижнюю границы отрезка в рамках которого будем искать количество принадлежащих ему чисел 
int NumbersBetweenCount = 0;
int [] array = new int [NumbersCount];  // Создаем массив из NumbersCount элементов, затем заполняем его псевдослучайными числами
for (int Index = 0; Index<array.Length; Index++)
    {
        array [Index] = new Random().Next(lowerBoundOfRandom,upperBoundOfRandom+1); 
    }

for (int Index = 0; Index<array.Length; Index++)
    {
        if (array [Index] >=  lowerBoundOfDetection && array [Index] <= upperBoundOfDetection) // Проверяем псевдослучайные числа из массива Array на принадлежность отрезку [lowerBoundOfDetection,upperBoundOfDetection]
        {
            NumbersBetweenCount ++;
        }
    }
Console.WriteLine ();
Console.WriteLine (NumbersBetweenCount);