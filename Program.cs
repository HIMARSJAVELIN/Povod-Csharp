using System.Text;

internal class Program

{
    private static void Main(string[] args)
    {
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        var enc1251 = Encoding.GetEncoding(1251);

        System.Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Console.InputEncoding = enc1251;

        Console.Write("Please enter the number: ");

        double number = double.Parse(Console.ReadLine());

        if (number > 7)
            Console.WriteLine("Привет");


        Console.Write("Please enter the name: ");

        string name = Console.ReadLine();

        switch (name)
        {
            case "Вячеслав":
                Console.WriteLine("Привет, " + name);
                break;

            default:
                Console.WriteLine("Нет такого имени");
                break;
        }

        Console.Write("Введите количество элементов массива: \t");

        int elementsCount = int.Parse(Console.ReadLine());

        int[] myArray = new int[elementsCount];

        for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write($"\nВведите целое число от 0 до 100 - {i + 1}-й элемент массива: ");
            myArray[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nНаш массив выглядит следующим образом: ");

        for (int i = 0; i < myArray.Length; i++)
        {
            Console.WriteLine(myArray[i]);
        }

        int a = 3;

        Console.WriteLine("\nЭлементы массива кратные " + a);

        for (int i = 0; i < myArray.Length; i++)
        {
            if (myArray[i] % a == 0)
            {
                Console.Write($"{myArray[i]} ");
            }
        }

        Console.ReadKey();
    }
    
}
        
    
