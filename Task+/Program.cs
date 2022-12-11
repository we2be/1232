// Задача: Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] array1 = new string[4] {"Hello", "2", "world", ":-("};
string[] array2 = new string[array1.Length];
int count = 0;

for(int i = 0; i < array1.Length; i++)
{
    if(array1[i].Length <= 3)
    {
        array2[count] = array1[i];
        count++;
    }
}
Console.WriteLine(String.Join(" ", array2));