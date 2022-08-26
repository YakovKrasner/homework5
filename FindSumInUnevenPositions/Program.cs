int lowerBoundOfRandom = -10;
int upperBoundOfRandom = 50;
int NumbersCount = 6;
int [] array = new int [NumbersCount];  
int sumOfUneven = 0;
for (int Index = 0; Index<array.Length; Index++)
    {
        array [Index] = new Random().Next(lowerBoundOfRandom,upperBoundOfRandom+1); 
        Console.WriteLine (array[Index]);
    }
for (int Index = 0; Index<array.Length; Index++)
    {
       if (Index % 2 == 1) sumOfUneven = sumOfUneven + array[Index];
    }

Console.WriteLine (sumOfUneven);