int lengthArr = int.Parse(ReadData("Input the array lenght:\n"));
Console.WriteLine("Input words, symbols, numbers and etc. via the Enter key:");
string[] array = GenArray(lengthArr);
Console.WriteLine("Source array:");
Print1DArr(array);
Console.WriteLine("Result array with elements are less or equal than 3 symbols:");
string[] arrayNew = SecondArray(array);
Print1DArr(arrayNew);

string ReadData(string msg)
{
    Console.Write(msg);
    return (Console.ReadLine() ?? "0");
}

string[] GenArray(int len)
{
    string[] arr = new string[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = ReadData("");
    }
    return arr;
}

string[] SecondArray(string[] arr)
{
    int count = 0;
    int controlNumber = 3;
    string[] newArr = new string[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= controlNumber)
        {
            newArr[count] = arr[i];
            count++;
        }
    }
    Array.Resize(ref newArr, count);
    return newArr;
}

void Print1DArr(string[] arr)
{
    if(arr.Length == 0)
	{
	    Console.WriteLine("[Array is empty]");
    }
    else
    {
        Console.Write("[");
        for (int i = 0; i < arr.Length - 1; i++)
        {
            Console.Write(arr[i] + ", ");
        }
        Console.WriteLine(arr[arr.Length - 1] + "]");
    }
    
}

