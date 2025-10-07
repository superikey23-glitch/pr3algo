Console.WriteLine("Введите предложение");
string trap = Console.ReadLine();
char[] chars = trap.ToCharArray();
for (int i = 0; i < trap.Length; i += 2)
{
    chars[i] = char.ToUpper(chars[i]);
}
string resultatishe = new string(chars);
Console.WriteLine($"Результат: {resultatishe}");
Console.WriteLine("Нажмите любую клавишу, чтобы продолжить");
Console.ReadKey();


Console.WriteLine("Введите число от 0 до 1000");
int kosar = int.Parse(Console.ReadLine());
if (kosar <= 1000)
{
    for(int i = 0; i<=kosar; i++)
    {
        Console.WriteLine(i);
    } 
} else {
    Console.WriteLine("Ну я ж сказал от 0 до 1000");
}
Console.WriteLine("Нажмите любую клавишу, чтобы продолжить");
Console.ReadKey();



Console.WriteLine("Введите 5 элементов через пробел и прога их ЗадомНаПерёднет");
string archi = Console.ReadLine();
string[] massa = archi.Split(' ');
Console.WriteLine("Элементы задом на перёд:");
for (int i = massa.Length - 1; i >= 0; i--)
{
    Console.Write(massa[i] + " ");
}
Console.WriteLine("Теперь нажмите любую клавишу, чтобы закончить");
Console.ReadKey();