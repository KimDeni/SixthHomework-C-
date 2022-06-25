int [] createArrey(){
    Console.WriteLine("Сколько чисел хотите ввести? ");
    int sizeArr = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int [sizeArr];

    return arr;
}

int[] fillArrey(int[] arr){
        for(int i = 0; i < arr.Length; i++){
        arr[i] =  Convert.ToInt32(Console.ReadLine());;
    }
    return arr;
}

//void showArrey(int[] arr){
//     for(int i = 0; i < arr.Length; i++){
//         Console.Write($"{arr[i]} {" "}");
//     }
// }

int posNum(int[] arr){
    int counter = 0;
        for(int i = 0; i < arr.Length; i++){
        if (arr[i] > 0){
            counter++;
        }
    }

    return counter; 
}

int[]arr = createArrey();
fillArrey(arr);
//showArrey(arr);
Console.WriteLine();
Console.WriteLine($"{"Положительных чисел: "} {posNum(arr)}");
