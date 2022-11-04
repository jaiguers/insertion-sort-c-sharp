internal class Program
{
  private static void Main(string[] args)
  {
    int[] arr = { 8, 3, 9, 5, 0, 1, 5 };
    InsertionSort(arr);
    PrintArray(arr);
  }

  static void InsertionSort(int[] arr)
  {
    for (int i = 1; i < arr.Length; i++)
    {
      int key = arr[i];
      int j = i - 1;

      while (j >= 0 && arr[j] > key)
      {
        arr[j + 1] = arr[j];
        j = j - 1;
      }
      arr[j + 1] = key;
    }
  }

  static void PrintArray(int[] arr)
  {
    for (int i = 0; i < arr.Length; i++)
      Console.Write(arr[i] + " ");
  }
}