Console.Write("Введите количество элементов массива: ");
int numberMassive = Convert.ToInt32(Console.ReadLine()); 

int RandomNumbers(int numberMassive, int min, int max)
  {
  int[] randomNumbers = new int[numberMassive];
  int sumMassive = 0;
  Console.Write("Получившийся массив: ");

    for (int i = 0; i <randomNumbers.Length; i++ ){
      randomNumbers[i] = new Random().Next(min, max);
      Console.Write(randomNumbers[i] + " ");
      if (i % 2 != 1)
      {
        sumMassive = sumMassive + randomNumbers[i];
      }
    }
  return sumMassive;
  }

int randomNumbers =  RandomNumbers(numberMassive, 1, 10);

Console.WriteLine($"\nСумма элементов, стоящих на нечётных позициях: {randomNumbers}");
