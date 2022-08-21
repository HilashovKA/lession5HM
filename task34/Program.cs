int[] numbers = new int[10];

void FillArray(int[] array, int min, int max){
  for (int i = 0; i<array.Length; i++ ){
    array[i] = new Random().Next(min, max);
  }
}

void WriteArray(int[] array){
    for (int i = 0; i<array.Length; i++ ){
    Console.Write(array[i] + " ");
  }
  Console.WriteLine();
}

int NumbersPositive(int[] array){
    int num = 0;
    for (int i = 0; i<array.Length; i++ ){
    if (array[i] % 2 == 1)
    {
      num++;
    }
  }
  return num;
}

FillArray(numbers, 100, 1000);
WriteArray(numbers);
Console.WriteLine();

int num = NumbersPositive(numbers);
Console.WriteLine($"Количество чётных чисел в массиве: {num}");