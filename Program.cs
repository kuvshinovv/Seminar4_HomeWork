//_________________________________________________________________________________________________________
/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16 */

/* void Stepen(int first, int second){
    int result = 1;
    for (int i = 1; i <= second; i++)
    {
        result = result * first;
    }
    Console.WriteLine($"Число {first} в степени {second} = {result}");
}
Console.WriteLine("Введите число: ");
int fst = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение степени, в которую будем возводить число: ");
int snd = Convert.ToInt32(Console.ReadLine());

Stepen(fst,snd);
 */



//_________________________________________________________________________________________________________
/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */


/* void Summa(int chislo){

        if (chislo >= 1 && chislo <= 9){
        Console.WriteLine("Сумма цифр в числе равна: " + chislo);
    }
    
    else if (chislo >= 10 && chislo <= 99){
        int first = chislo / 10;
        int second = chislo % 10;
        Console.WriteLine($"Сумма цифр в числе равна: {first} + {second} = {first+second}");
    }
    else if(chislo >= 100 && chislo <= 999){
        int first = chislo / 100;
        int secondtmp = chislo / 10;
        int second = secondtmp % 10;
        int threeth = chislo % 10;
        Console.WriteLine($"Сумма цифр в числе равна: {first} + {second} + {threeth} = {first+second+threeth}");
    }
    else if(chislo >= 1000 && chislo <= 9999){
        int first = chislo / 1000;
        int secondtmp = chislo / 100;
        int second = secondtmp % 10;
        int threethtmp = chislo / 10;
        int threeth = threethtmp % 10;
        int fourth = chislo % 10;
        Console.WriteLine($"Сумма цифр в числе равна: {first} + {second} + {threeth} + {fourth} = {first+second+threeth+fourth}");
    }
    else if(chislo >= 10000 && chislo <= 99999){
        int first = chislo / 10000;
        int secondtmp = chislo / 1000;
        int second = secondtmp % 10;
        int threethtmp = chislo / 100;
        int threeth = threethtmp % 10;
        int fourthtmp = chislo / 10;
        int fourth = fourthtmp % 10;
        int fifth = chislo % 10;
        Console.WriteLine($"Сумма цифр в числе равна: {first} + {second} + {threeth} + {fourth} + {fifth} = {first+second+threeth+fourth+fifth}");
    }
    else if(chislo >= 100000 && chislo <= 999999){
        int first = chislo / 100000;
        int secondtmp = chislo / 10000;
        int second = secondtmp % 10;
        int threethtmp = chislo / 1000;
        int threeth = threethtmp % 10;
        int fourthtmp = chislo / 100;
        int fourth = fourthtmp % 10;
        int fifthtmp = chislo / 10;
        int fifth = fifthtmp % 10;
        int sixth = chislo % 10;


        Console.WriteLine($"Сумма цифр в числе равна: {first} + {second} + {threeth} + {fourth} + {fifth} + {sixth} = {first+second+threeth+fourth+fifth+sixth}");
    }
    else if(chislo >= 1000000 && chislo <= 9999999){
        int first = chislo / 1000000;
        int secondtmp = chislo / 100000;
        int second = secondtmp % 10;
        int threethtmp = chislo / 10000;
        int threeth = threethtmp % 10;
        int fourthtmp = chislo / 1000;
        int fourth = fourthtmp % 10;
        int fifthtmp = chislo / 100;
        int fifth = fifthtmp % 10;
        int sixthtmp = chislo / 10;
        int sixth = sixthtmp % 10;
        int seventh = chislo % 10;

        Console.WriteLine($"Сумма цифр в числе равна: {first} + {second} + {threeth} + {fourth} + {fifth} + {sixth} + {seventh} = {first+second+threeth+fourth+fifth+sixth+seventh}");
    }
    else if(chislo >= 10000000 && chislo <= 99999999){
        int first = chislo / 10000000;
        int secondtmp = chislo / 1000000;
        int second = secondtmp % 10;
        int threethtmp = chislo / 100000;
        int threeth = threethtmp % 10;
        int fourthtmp = chislo / 10000;
        int fourth = fourthtmp % 10;
        int fifthtmp = chislo / 1000;
        int fifth = fifthtmp % 10;
        int sixthtmp = chislo / 100;
        int sixth = sixthtmp % 10;
        int seventhtmp = chislo / 10;
        int seventh = seventhtmp % 10;
        int eighth = chislo % 10;

        Console.WriteLine($"Сумма цифр в числе равна: {first} + {second} + {threeth} + {fourth} + {fifth} + {sixth} + {seventh} + {eighth} = {first+second+threeth+fourth+fifth+sixth+seventh+eighth}");
    }
    else if(chislo >= 100000000 && chislo <= 999999999){
        int first = chislo / 100000000;
        int secondtmp = chislo / 10000000;
        int second = secondtmp % 10;
        int threethtmp = chislo / 1000000;
        int threeth = threethtmp % 10;
        int fourthtmp = chislo / 100000;
        int fourth = fourthtmp % 10;
        int fifthtmp = chislo / 10000;
        int fifth = fifthtmp % 10;
        int sixthtmp = chislo / 1000;
        int sixth = sixthtmp % 10;
        int seventhtmp = chislo / 100;
        int seventh = seventhtmp % 10;
        int eighthtmp = chislo / 10;
        int eighth = eighthtmp % 10;
        int ninth = chislo % 10;

        Console.WriteLine($"Сумма цифр в числе равна: {first} + {second} + {threeth} + {fourth} + {fifth} + {sixth} + {seventh} + {eighth} + {ninth} = {first+second+threeth+fourth+fifth+sixth+seventh+eighth+ninth}");
    }
    else if(chislo >= 1000000000 && chislo <= 999999999){
        int first = chislo / 1000000000;
        int secondtmp = chislo / 100000000;
        int second = secondtmp % 10;
        int threethtmp = chislo / 10000000;
        int threeth = threethtmp % 10;
        int fourthtmp = chislo / 1000000;
        int fourth = fourthtmp % 10;
        int fifthtmp = chislo / 100000;
        int fifth = fifthtmp % 10;
        int sixthtmp = chislo / 1000;
        int sixth = sixthtmp % 10;
        int seventhtmp = chislo / 1000;
        int seventh = seventhtmp % 10;
        int eighthtmp = chislo / 100;
        int eighth = eighthtmp % 10;
        int ninthtmp = chislo / 10;
        int ninth = ninthtmp % 10;
        int tenth = chislo % 10;

        Console.WriteLine($"Сумма цифр в числе равна: {first} + {second} + {threeth} + {fourth} + {fifth} + {sixth} + {seventh} + {eighth} + {ninth} + {tenth} = {first+second+threeth+fourth+fifth+sixth+seventh+eighth+ninth+tenth}");
    }
  
} 
Console.WriteLine("Введите число: ");
int chislo = Convert.ToInt32(Console.ReadLine());
Summa(chislo);
 */

//  Второй вариант решение второй задачи___________________________________________________________
void function(string chislo){
    int result = 0;
    int length = chislo.Length;   // Задаем переменную и определяем длинну строки 
   for (int i = 0; i < length; i++)   // Проходимся по всей длинне строки в этом цикле
   {
    char ch = chislo[i];                 //каждый элемент строки присваиваем переменно в виде символа 
    int num = int.Parse(ch.ToString());  //погуглил и нашел способ как сонвертануть символ в int(число)
    Console.WriteLine(num);              // выводим на экран для проверки.. конвертанулось ли...
    result = result + num;               // ну и суммируем полученные цифры
     
   }
   Console.WriteLine("Сумма цифр введённого числа = " + result);            // выводим ответ.
   
}
Console.WriteLine("Введите число: ");   
string chislo = Console.ReadLine();   // Вводим число как строку...
function(chislo);







//_________________________________________________________________________________________________________
/* Задача 29: Напишите программу, которая задаёт массив из произвольного элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */