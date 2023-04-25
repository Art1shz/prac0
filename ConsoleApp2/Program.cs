using System.Text;
Console.WriteLine("Выберите: \r\n 1 - Типы данных \r\n 2 - Вес сообщений");  int choose = Convert.ToInt32(Console.ReadLine());
if (choose == 1)
{
    Console.WriteLine($"Тип данных {typeof(byte)} в диапозоне от {byte.MinValue} до {byte.MaxValue} размер {sizeof(byte)} byte/s ");
    Console.WriteLine($"Тип данных {typeof(int)} в диапозоне от {int.MinValue} до {int.MaxValue} размер {sizeof(int)} byte/s ");
    Console.WriteLine($"Тип данных {typeof(decimal)} в диапозоне от {decimal.MinValue} до {decimal.MaxValue} размер {sizeof(decimal)} byte/s ");
    Console.WriteLine($"Тип данных {typeof(sbyte)} в диапозоне от {sbyte.MinValue} до {sbyte.MaxValue} размер {sizeof(sbyte)} byte/s ");
    Console.WriteLine($"Тип данных {typeof(uint)} в диапозоне от {uint.MinValue} до {uint.MaxValue} размер {sizeof(uint)} byte/s ");
    Console.WriteLine($"Тип данных {typeof(short)} в диапозоне от {short.MinValue} до {short.MaxValue} размер {sizeof(short)} byte/s ");
    Console.WriteLine($"Тип данных {typeof(double)} в диапозоне от {double.MinValue} до {double.MaxValue} размер {sizeof(double)} byte/s ");
    Console.WriteLine($"Тип данных {typeof(ushort)} в диапозоне от {ushort.MinValue} до {ushort.MaxValue} размер {sizeof(ushort)} byte/s ");
    Console.WriteLine($"Тип данных {typeof(float)} в диапозоне от {float.MinValue} до {float.MaxValue} размер {sizeof(float)} byte/s ");
    Console.WriteLine($"Тип данных {typeof(long)} в диапозоне от {long.MinValue} до {long.MaxValue} размер {sizeof(long)} byte/s ");
    Console.WriteLine($"Тип данных {typeof(ulong)} в диапозоне от {ulong.MinValue} до {ulong.MaxValue} размер {sizeof(ulong)} byte/s ");
    Console.WriteLine($"Тип данных {typeof(char)} в диапозоне от {char.MinValue} до {char.MaxValue} размeр {sizeof(char)} byte/s ");
    Console.WriteLine($"Тип данных {typeof(bool)} в диапозоне от False до True размер {sizeof(bool)} byte/s");
    Console.WriteLine($"Тип данных {typeof(object)} в диапозоне от - до - размер - byte/s ");
}
if (choose == 2)
{
    string str = "Объект – категория, выражающая то, что противостоит субъекту в его предметно-практической и познавательной деятельности.";
    Console.WriteLine($" ASCII {Encoding.ASCII.GetByteCount(str)}");
    Console.WriteLine($" UTF-7 {Encoding.UTF7.GetByteCount(str)}");
    Console.WriteLine($" UTF-8 {Encoding.UTF8.GetByteCount(str)}");
    Console.WriteLine($" UTF-32 {Encoding.UTF32.GetByteCount(str)}");
}