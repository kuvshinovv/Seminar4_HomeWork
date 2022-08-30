//Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

/* void Numbers(int num){
    int result = 0;
    for (int curr = 1; curr <= num; curr++){
        result += curr;   // result = result + curr;
    }
    Console.WriteLine($"Сумма чисел от 1 до {num} равна {result}");
}
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Numbers(number); */



// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N

/* void Numbers (int num){
    int result = 1;
    for (int curr = 1; curr < num + 1; curr++){
        result = result * curr;
    }
    Console.WriteLine($"Произведение исел от 1 до {num} равно {result} ");
}
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Numbers(number); */




//  Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе


/* void Program(int a){
    int result = 0;
    if (a == 0) {
        Console.WriteLine("В числе 1 знак");
    }
    else{
        for(int i = a; i != 0; i /= 10 ){
            result++;       
        }
        Console.WriteLine($"В числе {a} - {result} цифры");
    }
}   
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Program(number); */





// Напишите программу , которая находит в последовательности от  1 до N все не чётные числа

/* void Number(int number){
    for (i = 1; i<=number; i++){
        i+=2;
    }
} */



//____МАССИВЫ_____________________________________________________________________________________________________


// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// Например [1,0,1,1,0,1,0,0]


int[] CreateRandomArray(int size){
    int[] array = new int[size];
    for (int i = 0; i < size; i++){
        array[i] = new Random().Next(0,2);
    }
    return array; 
}

void Sowarray(int[] array){
    Console.Write("[ ");
    for(int i=0; i<array.Length; i++){
        Console.Write(array[i]+" ");
    }
    Console.Write("]");
}

Console.WriteLine("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Sowarray(CreateRandomArray(size));




















