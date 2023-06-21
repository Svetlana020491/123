int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Recursion(int count, int numberB)
{

    if (count > numberB) return count;
    if (count % 3 == 0)
        Console.Write($"{count}  ");
    count++;
    return Recursion(count, numberB);

}

int SumRecursion(int numberB, int count, int sum)
{                   //  8             4        30
    if (count > numberB) return count;
    sum += count++;
    Console.Write($"{sum} ");
    return SumRecursion(numberB, count, sum);

}

int Akkerman(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return Akkerman(n - 1, 1);
    else
        return Akkerman(n - 1, Akkerman(n, m - 1));
}

void Task64()
{
    // Задайте значения M и N. Напишите рекурсивный метод, который выведет 
    // все натуральные числа кратные 3-ём в промежутке от M до N.
    // 
    int numberA = Input("Введите первое число:  ");
    int numberB = Input("Введите второе число:  ");
    int count = numberA;
    Recursion(count, numberB);
}

void Task66()
{
    // Задайте значения M и N. 
    // Напишите рекурсивный метод, который найдёт сумму 
    // натуральных элементов в промежутке от M до N.
    int numberA = Input("Введите первое число:  ");
    int numberB = Input("Введите второе число:  ");
    int sum = 0;
    int count = numberA;
    Console.WriteLine($"Сумма чисел в промежутке от {numberA} до {numberB} равна:    ");
    SumRecursion(numberB, count, sum);


    // Введите первое число:  1
    // Введите второе число:  15
    // Сумма чисел в промежутке от 1 до 15 равна:    
    // 1 3 6 10 15 21 28 36 45 55 66 78 91 105 120 

    //120 ответ верный, но не могу сообразить как вывести в ответе только его
}

void Task68()
{
    // Напишите программу вычисления функции Аккермана с помощью рекурсии. 
    // Даны два неотрицательных числа m и n.
    // m = 2, n = 3->A(m, n) = 9
    // m = 3, n = 2->A(m, n) = 29

    int n = 2;
    int m = 3;
    Console.WriteLine(Akkerman(m, n));

//Признаюсь, эту задачу взяла из интернета. 


}

Console.Clear();
Task68();
