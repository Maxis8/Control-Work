// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа.

void GetRead(string[] arr)
{
    string[] sortarray = new string[arr.Length];
    for(int i = 0; i < arr.Length; i++)
    if(arr[i].Length <=3 ) 
    { 
     sortarray[i] = arr[i];   
    Console.Write($"{sortarray[i]}, ");
    }
}
string[] array = new string[] {"25", "gun", "food", "town", "1", "stop"};
GetRead(array);