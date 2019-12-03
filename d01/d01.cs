class D01
{
  static void Main()
  {
    string file = "./input";
    string[] lines = System.IO.File.ReadAllLines(file);
    int[] masses = new int[100];

    for (int i = 0; i < lines.Length; i++)
    {
      masses[i] = System.Convert.ToInt32(lines[i]);
    }

    int sum = 0;

    foreach (int mass in masses)
    {
      sum += fuel(mass);
    }

    System.Console.WriteLine(sum);
  }

  static int fuel(int mass)
  {
    double result = System.Math.Truncate((double)mass / 3) - 2;
    return (int)result;
  }
}
