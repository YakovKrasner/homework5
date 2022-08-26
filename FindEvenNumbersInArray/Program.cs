int lowerBoundOfRandom = 100;
int upperBoundOfRandom = 999;
int NumbersCount = 6;
int [] array = new int [NumbersCount];  
int CountOfEvenNumbers = 0;
for (int Index = 0; Index<array.Length; Index++)
    {
        array [Index] = new Random().Next(lowerBoundOfRandom,upperBoundOfRandom+1); 
    }
for (int Index = 0; Index<array.Length; Index++)
    {
       if (array [Index] % 2 == 0) CountOfEvenNumbers ++;
    }

Console.WriteLine (CountOfEvenNumbers);