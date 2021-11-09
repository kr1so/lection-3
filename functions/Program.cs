//Виды функций

//1 вид (void метод)
//Ничего не принимает,
//Ничего не возвращает

//2 вид (void метод)
//Что-то принимает
//Ничего не возвращает

//3 вид (например, генерирует случайные данные)
//Ничего не принимает
//Что-то возвращает

//4 вид
//Что-то принимает
//Что-то возвращает

//1 вид (ничего не принимает, ничего не возвращает)
//как пишется, пример
/* void Method1()
{
    System.Console.WriteLine("Автор:");
} */
//как вызываются:
//Method1();

//2 вид (что-то принимает, ничего не возвращает)
//как пишется, пример
//void->ключевое слово->идентификатор->кол-во аргументов
/* void Method2(string msg)
{
System.Console.WriteLine(msg);
} */
//как вызываются:
//Method2("Надо любить жизнь больше, чем смысл жизни.");

/* void Method2_1(string msg, int count)
{
    int i = 0;
    while (i<count)
    {
         System.Console.WriteLine(msg);
         i++;
    }
    
} */
//Method2_1(msg:, count:);
//Method2_1("Надо любить жизнь больше, чем смысл жизни.", 4);

//Вид 3 (ничего не принимает, что-то возвращает)
/*  int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
System.Console.WriteLine(year);  */

//Вид 4 (что-то принимает, что-то возвращает)
/* string Method4(int count, string text)
{
int i = 0;
string result = string.Empty;
while (i<count)
 {
    result = result + text;
     i++;
 }
return result;
}
string res = Method4(2, "Если ты направился к цели и станешь дорогою останавливаться, чтобы швырять камни во всякую лающую на тебя собаку, то никогда не дойдешь до цели.");
System.Console.WriteLine(res); */


