double upperBoundOfRandom = 50.0;
int NumbersCount = 6;
double [] array = new double [NumbersCount];  

for (int Index = 0; Index<array.Length; Index++)
    {
        array [Index] = new Random().NextDouble()*upperBoundOfRandom; 
        Console.WriteLine (array[Index]);
    }
double Max = array [0];
double Min = array [0];
for (int Index = 0; Index<array.Length; Index++)
    {
        if (array[Index] < Min) Min = array[Index];
        if (array[Index] > Max) Max = array[Index];
    }

Console.WriteLine ($"Разность между максимальным и минимальным элементами массива равна {Max - Min}"); 