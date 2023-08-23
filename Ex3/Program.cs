void SetArray(int[] arr){
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++){
        arr[i] = rand.Next(0, 1000);
    }   
}

void PrintArray(int[] arr){
    for (int i = 0; i < arr.Length; i++){
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

int[] arr = new int[8];


SetArray(arr);
PrintArray(arr);