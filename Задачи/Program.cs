//Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.

void Zadacha54()
{
    Random random = new Random();
    int rows = random.Next(3,4);
    int columns = random.Next(3,4);
    int [,] numbers = new int [rows,columns];
    FillArray (numbers);
    Console.WriteLine("Задан массив:");  
    PrintArray (numbers);
    SelectionSort(numbers);
    Console.WriteLine();
    Console.WriteLine("Упорядочили массив по убыванию элементов в строке:");
    PrintArray (numbers);


}   

//Zadacha54();


//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.


void Zadacha56()
{
Random random = new Random();
int rows = random.Next(3,4);
int columns = random.Next(3,4);
int [,] numbers = new int [rows,columns];
FillArray (numbers);
Console.WriteLine("Задан массив:");  
PrintArray (numbers);

Console.WriteLine();
Console.WriteLine($"Нашли строку с наименьшей суммой элементов:{FindArray (numbers)}");

}
//Zadacha56();

//Задача 58: Напишите программу, которая заполнит спирально массив 4 на 4.

void Zadacha58()
{
int n = 4;
int [,] numbers = new int [n,n];
for(int k=0;k<n-2;k++)
{
    for(int j=k; j<n-k; j++)
    {
        if(j<1)
        numbers[k,j]=numbers[k,j]+1;
        else
        {
        numbers[k,j]=numbers[k,j-1]+1;   
        }
    }
    for(int ik=k+1; ik<n-k; ik++)
    {
        numbers[ik,n-(k+1)]=numbers[ik-1,n-(k+1)]+1;
    }
    for(int jk=k+1; jk<n-k; jk++)
    {
        numbers[n-1-k,n-(k+1)-jk+k]=numbers[n-1-k,n-jk]+1;
    }
    if(k<1)
    {
    for(int i=1; i<n-1; i++)
    {
        numbers[n-i-1,k]=numbers[n-i,k]+1;
    }
    }
}
PrintArray (numbers);
}
//Zadacha58();








void FillArray (int[,] numbers)
{
    Random random = new Random();
    for (int i=0; i< numbers.GetLength(0); i++)
    {
        for(int j=0; j<numbers.GetLength(1); j++)
        {
            numbers[i,j] = random.Next (1, 10);
           
            

           
        }
    }
}

void PrintArray (int[,] numbers)
{   
    Random random = new Random();
    for (int i=0; i< numbers.GetLength(0); i++)
    {
        for(int j=0; j< numbers.GetLength(1); j++)
        {
           Console.Write(numbers[i,j]+ "\t");
        }
        Console.WriteLine();
    }
} 

void SelectionSort (int [,] numbers)
{
    int size = numbers.GetLength(1);
    int i =0;
    int j = 0;
    while (i<numbers.GetLength(0))
    {
        size = numbers.GetLength(1);
        while (size>0)
        {
        int min = numbers[i,j];
        int minPosition = 0;
            while (j<size)
        {
            
            if(numbers[i,j]<min)
            {
                min=numbers[i,j];
                minPosition=j;
            }
            j++;
        }
            int temp = numbers[i,size-1];
            numbers[i,size-1] = min;
            numbers[i,minPosition] = temp;
            size=size-1;
            j = 0;  
        }
        i++;
    }
} 

int FindArray (int [,] numbers)
{
    int sum = 0;
    int minSum = numbers.GetLength(1)*10;
    int i=0;
    int st = 0;
    int j=0;
    int result;
    while (i< numbers.GetLength(0)) 
    {
        
        while(j<numbers.GetLength(1))
        {
            sum = sum + numbers[i,j];
            j++;
        }
        if (sum < minSum)
        {
            minSum = sum;
            st = i;
        }
        sum = 0;
        j = 0;
        i++;
    }
    result = st +1;
    return result;

}