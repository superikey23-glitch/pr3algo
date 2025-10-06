using System;

namespace IBezTebyaZnau 
{
    class Class2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("КалькУлятор");
            Console.WriteLine("Выберите действие (номер действия)");
            Console.WriteLine("1. Сложение");
            Console.WriteLine("2. Вычитание");
            Console.WriteLine("3. Умножение");
            Console.WriteLine("4. Деление");
            Console.WriteLine("5. Степень");
            Console.WriteLine("6. Корень");
            Console.WriteLine("7. Деление с остатком");
            Console.WriteLine("8. Квадратное уравнение");
            int input = Convert.ToInt16 (Console.ReadLine());
            switch (input)
            {
                case 1:
                    Console.WriteLine("Сложение");
                    Console.WriteLine("Введите первое слагаемое");
                    double ps = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе слагаемое");
                    double vs = Convert.ToDouble(Console.ReadLine());
                    double ress = ps + vs;
                    Console.WriteLine($"Ответ: {ress}");
                    break;

                case 2:
                    Console.WriteLine("Вычитание");
                    Console.WriteLine("Введите уменьшаемое");
                    double pu = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите вычитаемое");
                    double vv = Convert.ToDouble(Console.ReadLine());
                    double resv = pu - vv;
                    Console.WriteLine($"Ответ: {resv}");
                    break;
                case 3:
                    Console.WriteLine("Умножение");
                    Console.WriteLine("Введите первый множитель");
                    double pm = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второй множитель");
                    double vm = Convert.ToDouble(Console.ReadLine());
                    double resu = pm * vm;
                    Console.WriteLine($"Ответ: {resu}");
                    break;
                case 4:
                    Console.WriteLine("Деление");
                    Console.WriteLine("Введите делимое");
                    double pd = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите делитель");
                    double vd = Convert.ToDouble(Console.ReadLine());
                    double resd = pd / vd;
                    Console.WriteLine($"Ответ: {resd}");
                    break;
                case 5:
                    Console.WriteLine("Степень");
                    Console.WriteLine("Введите число");
                    double chds = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите степень");
                    double s = Convert.ToDouble(Console.ReadLine());
                    double resst = Math.Pow(chds, s);
                    Console.WriteLine($"Ответ: {resst}");
                    break;
                case 6:
                    Console.WriteLine("Степень");
                    Console.WriteLine("Введите число");
                    double k = Convert.ToDouble(Console.ReadLine());
                    double resk = Math.Sqrt(k);
                    Console.WriteLine($"Ответ: {resk}");
                    break;
                case 7:
                    Console.WriteLine("Деление с остатком");
                    Console.WriteLine("Введите делимое");
                    double pdso = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите делитель");
                    double vdso = Convert.ToDouble(Console.ReadLine());
                    double reso = pdso % vdso;
                    Console.WriteLine($"Ответ: остаток {reso}");
                    break;
                case 8:
                    Console.WriteLine("Квадратное уравнение ax^2+bx+c=0");
                    Console.WriteLine("Введите a");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите b");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите c");
                    double c = Convert.ToDouble(Console.ReadLine());
                    double d = 4 * a * c;
                    if (d >= 0)
                    {
                        double resdesp = (Math.Pow(-b, 2) + d) / (2 * a);
                        double resdesm = (Math.Pow(-b, 2) - d) / (2 * a);
                        Console.WriteLine($"Ответ: первый корень {resdesp}, второй корень {resdesm}");
                            } else {
                                Console.WriteLine("Выражение не имеет корней");
                            };                    
                    break;
            }

        }
    }
}