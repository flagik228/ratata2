using bibla;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Сумма: "+ BiblaClass.add( 5, 3));

        Console.WriteLine("Разница: "+ BiblaClass.subtract( 10, 4));

        int result = BiblaClass.multiply( 7, 2);
        Console.WriteLine("Умножение: "+ result);

        result = BiblaClass.divide( 20, 5);
        Console.WriteLine("Деление: "+ result);

        result = BiblaClass.power( 2, 3);
        Console.WriteLine("Возведение в степень: " + result);

        Console.ReadLine();
    }
}