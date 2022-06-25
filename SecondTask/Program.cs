void binary(int num){

    int counter = 0;
    int temp = num;

        while (temp != 0){
        temp = temp /2;
        counter++;
    }

    int[] arr = new int[counter];

    for(int i = arr.Length - 1; i >= 0; i--){
        arr[i] = num % 2;
        num = num /2;
    }

    for( int  i = 0; i < arr.Length; i++){
        Console.Write(arr[i]);
    }

}
int number = Convert.ToInt32(Console.ReadLine());

binary(number);