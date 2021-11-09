//Циклы
//Цикл For (цикл со счетчиком)
//собирает всё в одном месте в кучу
//чистовой пример:
/*/for (int i = 0; i < length; i++)
{
    System.Console.WriteLine(i);
} */
/* string Method5(int count, string text)
{
   string result = string.Empty;
   for (int i = 0; i < count; i++)
   {
        result = result + text;
   }
return result;
}
string res = Method5 (2, " В истинно любящем сердце или ревность убивает любовь, или любовь убивает ревность.");
System.Console.WriteLine(res); */

// ! все циклы взаимозаменяемы
// 95% задач легко решаются при помощи цикла For


//Цикл в цикле 
//Чистовой пример

/* for (int i = 0; i < length; i++)

{
    for (int j = 0; j < length; j++)
    {
        System.Console.WriteLine(i*j);
    }
    System.Console.WriteLine();
} */

/* for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        System.Console.WriteLine($"{i}*{j} = {i*j}");
    }
    // сделали искуственный разрыв для красивго вида
    System.Console.WriteLine(); 
} */

/* Задача:
Дан текст.
В тексте нужно:
все пробелы заменить чёрточками,
маленькие буквы "к" заменить большими "К",
большие буквы "С" заменить на маленькие "с". */

/* Вопросы для ТЗ:
1. Где и кто источник текста,
2. Что конкретно обозначают "черточки",
3. Какой алфавит использовать. */

//каждую строку текста заключает в кавычки!
/* string text =  "Первую ночь в пустыне я спал прямо на песке."
               + "На рассвете меня разбудил голос:"
               + "—  Ты не нарисуешь мне барашка? Пожалуйста!"
               + "Я вскочил на ноги и увидел удивительного мальчишку."; */

/* ВНИМАНИЕ
следующие примеры не работают (ошибка 86 строка) */

//тип данных string
// наименование Replace
// аргумент и имя (н-р, string text)
/* string Replace(string text, char oldValue, char newValue)
{    //пустая строка
    string result = string.Empty;
    // ввели размерность
    int length=text.Length;
    //цикл для замены и заполнения
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
// ввод нового текста
string newText = Replace(text, " ", "-");
// вывод нового текста на консоль
System.Console.WriteLine(newText); */

 string Replace(string text, char oldValue, char newValue)
 {
    string result = string.Empty;
    int length=text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
 }
string newText = Replace(text, " ", "-");
System.Console.WriteLine();
string newText = Replace(text, "к", "К");
System.Console.WriteLine();
string newText = Replace(text, "С", "с");
System.Console.WriteLine(newText);