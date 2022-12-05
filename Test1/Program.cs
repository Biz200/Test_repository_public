Console.Clear();

Console.WriteLine("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());

if (numberA > numberB)
            {
                Console.WriteLine("Первое число " + numberA + " больше чем второе " + numberB);
            }
            else
            {
                Console.WriteLine("Второе число " + numberB + " больше чем первое " + numberA);
            }
