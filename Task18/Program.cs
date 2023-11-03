#region task1
//int num1 = 3;
//int num2 = 27;
//int count = 0;
//string result(int x, int y, int count)
//{
//    for (int i = x; i < y; i++)
//    {
//        if (i % 2 == 1)
//        {
//            count += i;
//        }
//    }
//    return ($"Cavab : {count}");
//}
//Console.WriteLine(result(num1, num2, count));
#endregion

#region task2
//int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 21, 44, 52, 71 };
//int count2 = 0;

//string result(int[] numbers, int count)
//{
//    foreach (int n in numbers)
//    {
//        if (n % 2 == 1)
//        {
//            count += n;
//        }
//    }
//    return ($"Cavab : {count}");
//}
//Console.WriteLine(result(numbers, count2));
#endregion

#region task3
//int[] numbers2 = { 1, 2, 4, 5, 6, 7, 11, 9, 19, 13, 22, 37, 44 };
//int count3 = 0;
//string result(int[] numbers, int stage)
//{
//    foreach (int n in numbers)
//    {
//        if (n % 2 == 0)
//        {
//            stage++;

//        }
//    }
//    return ($"Cavab: {stage} ");
//}
//Console.WriteLine(result(numbers2, count3));
#endregion

#region task4
//int num = 44;
//int count4 = 0;
//void sadeveyamurekkeb(int num1, int stage)
//{
//    for (int i = 1; i < num1; i++)
//    {
//        if (num1 % i == 0)
//        {
//            stage++;
//        }
//    }
//    if (stage > 2)
//    {
//        Console.WriteLine("Murekkebdir..");
//    }
//    else
//    {
//        Console.WriteLine("Sadedir..");
//    }
//}
//sadeveyamurekkeb(num, count4);
#endregion

#region task5
//int num3 = 44;
//bool result = true;
//void result2(int num)
//{
//    if (num < 0)
//    {

//    }
//    else
//    {
//        while (num > 1)
//        {
//            if (num % 2 != 0)
//            {
//                result = false;
//                break;
//            }
//            num /= 2;

//        }
//    }

//    if (result)
//    {
//        Console.WriteLine("Eded 2nin quvvetidir..");
//    }
//    else
//    {
//        Console.WriteLine("Eded 2 nin quvveti deyil..");
//    }
//}
//result2(num3);
#endregion

#region task6  
//int[] numbers3 = { 4, 7, 9, 22, 29 };
//int count5 = 1;
//string result(int[] numbers3, int stage)
//{
//    foreach (int num3 in numbers3)
//    {
//        if (num3 <= 20)
//        {
//            stage *= num3;
//        }
//    }
//    return ($"Cavab : {stage}");
//}
//Console.WriteLine(result(numbers3, count5));
#endregion 

#region task7
//int[] numbers4 = { 1, 2, 3, 4, 5, 10, 16, 11 }; //cut ededleri cemleyib, alinan neticeni kvadrata yukseldirik
//int count6 = 0;
//int result(int[] numbers, int stage)
//{
//    foreach (int num in numbers)
//    {
//        if (num % 2 == 0)
//        {

//            stage += num;
//        }
//    }
//    return stage * stage;
//}

//Console.WriteLine(result(numbers4, count6));
#endregion

#region task8
//int[] Numbers7 = { -2, 3, -4, 5, -6, 7, -8 }; 

//void result(int[] numbers)
//{
//    for (int i = 0; i < numbers.Length; i++)
//    {
//        if (numbers[i] < 0)
//        {
//            numbers[i] *= -1;
//            Console.WriteLine(numbers[i]);
//        }
//    }
//}
//result(Numbers7);
#endregion
