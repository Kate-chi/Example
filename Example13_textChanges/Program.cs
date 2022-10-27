string text = "Не все вокруг подвластно глазам, " +
              "Сделать свой выбор должен ты сам, " +
              "Верь в свою судьбу быть " +
              "Шаманом Королем, " +
              "Всех Шаманов Королем " +
              "Если дух твой силен " +
              "Быть Шаманом Королем!";

string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;
    int lenght = text.Length;

    for(int i = 0; i < lenght; i++)
    {
        if(text[i] == oldValue)
        {
            result += $"{newValue}";
        }
        else result += $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '.');
Console.WriteLine(newText);

Console.WriteLine();

newText = Replace(newText, '.', ' ');
Console.WriteLine(newText);