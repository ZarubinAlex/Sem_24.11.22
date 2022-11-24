// 4)Напишите программу, которая выводит массив из 8 элементов, заполненный нулями
// и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


int[] FillArray(){

    int[] NullAndOne = new int[8];
    for (int i=0; i < 8 ; i++){

        NullAndOne[i] = new Random().Next(0,2);
    }
    return NullAndOne;
}

void PrintArray(int[] Array){
    for (int i=0; i < 8 ; i++){

        Console.Write($"{Array[i]} ");
    }
}

int[] Arr = FillArray();
PrintArray(Arr);
