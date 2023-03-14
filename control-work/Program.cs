Console.Clear();

string[] array = {"итоговая", "проверочная", "работа", "1", "три"};

Console.WriteLine($"[{string.Join(", ", array)}]");

string result = String.Empty;

for (int i = 0; i < array.Length - 1; i++)
    {if (array[i].Length < 4)
    result = result + $"{array[i]}\n";};

if (array[array.Length - 1].Length < 4)
    result = result + $"{array[array.Length - 1]}";


string[] finishArr = result.Split('\n');

Console.WriteLine($"[{string.Join(", ", finishArr)}]");