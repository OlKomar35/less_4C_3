// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int PromptText(string msg){
    Console.Write($"Введите {msg} = ");
    return Convert.ToInt32(Console.ReadLine());
}

bool LengthValid(int length){
    bool isValid =true;
    if (length<=0){
        Console.WriteLine("Ошибка: длина массива отрицательна или равна нулю");
        isValid =false;
    }
    return isValid;
}
 int [] CreateArray(int length, int minRandom, int maxRandom){
    int [] array = new int[length];
    for(int i=0;i<length;i++){
        array[i] = new Random().Next(minRandom,maxRandom);
    }
    return array;
 }

 void PrintArray(int [] array){
    Console.Write("[");
    for(int i=0;i<array.Length;i++){
        if(i==0){
            Console.Write($"{array[i]}");
        }else{
             Console.Write($", {array[i]}");
        }
    }
    Console.Write("]");
    Console.WriteLine();
 }


int length=PromptText("кол-во элементов массива");
while(!LengthValid(length)){
    length = PromptText("кол-во элементов массива");
}
int min = PromptText("минимальный элемент");
int max = PromptText("максимальный элемент");

if (min > max) {
    Console.WriteLine("Введиные значения max меньше чем значение min,теперь max и min поменяем меситами");
     int temp =min;
     min = max;
     max = temp;
}

int [] arr = CreateArray(length,min,max);
PrintArray(arr);



