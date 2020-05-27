using System;
using laba6;

class MyClass
{

    static void IncreaseReduce(IPv4 p)
    {
        Console.Clear();
        Console.Write("1.Увеличить размер пакета\n2.Уменьшить размер пакета\n0.Выйти из программы\n\n>>");
        var a = Console.ReadLine();
        if (a == "1")
        {
            Console.Clear();
            try
            {
              if (p.GetPckSize() == 32000)
                {
                    new WrongPackSizeException("---------\nУстановлен максимальный размер пакета\n---------");
                }
            }      
            catch
            {
                Console.ReadKey();
                Console.Clear();
            }
            
            Console.WriteLine(">>текущий размер = " + p.GetPckSize());
            Console.Write("Сколько будем добавлять?\n>>");
            try
            {
                p.PckIncrease(Console.ReadLine());
                Console.WriteLine("Размер сообщения = {0}\nРазмер пакета = {1}\nКоличество переданных пакетов = {2}", p.GetMsgSize(), p.GetPckSize(), p.GetPckAmount());

            }
            catch
            {
                Console.ReadKey();
            }


        }
        else if (a == "2")
        {
            Console.Clear();
            try
            {
                if (p.GetPckSize() <= 32)
                {
                    throw new WrongPackSizeException("---------\nУстановлен минимальный размер пакета\n---------");
                }
            }
            catch {
                Console.ReadKey();
                return;
                
            }
         
            
            Console.WriteLine(">>текущий размер = " + p.GetPckSize());
            Console.Write("На сколько будем уменьшать?\n>>");
            try
            {
                p.PckReduce(Console.ReadLine());
                Console.WriteLine("Размер сообщения = {0}\nРазмер пакета = {1}\nКоличество переданных пакетов = {2}", p.GetMsgSize(), p.GetPckSize(), p.GetPckAmount());

            }
            catch
            {
                Console.ReadKey();
                return;
            }
        }
        else if (a == "0")
        {
            return;
        }

    }
    static void Main()
    {

        IPv4 protocol = new IPv4() ;
        string Msgsize, Pcksize;
        string PckState = "(Размер пакета еще не задан)";
        while (1 > 0)
        {
            Console.Clear();
            Console.Write("\t\t\t\t\t\t\t-Main menu-\n\n\nТекущие значения:\n\tРазмер пакета: {0}\n\tРазмер сообщения: {1}\n\tКоличество переданных пакетов: {2}\n\n1.Задать размер пакета и сообщения\n2.Увеличить/Уменьшить текущий размер пакета {3}\n0.выйти из программы\n\n>>", protocol.GetPckSize(), protocol.GetMsgSize(),protocol.GetPckAmount() ,PckState);
            var a = Console.ReadLine();

            if (a == "1")
            {
                while (1 > 0)
                {
                    Console.Write("Введите размер передаваемого сообщения: ");
                    Msgsize = Console.ReadLine();
                    Console.Write("Введите размер пакета: ");
                    Pcksize = Console.ReadLine();

                    try
                    {
                        protocol = new IPv4(Msgsize, Pcksize);
                        if (protocol.GetPckSize() > 0)
                        {
                            PckState = "";
                        }
                        break;
                    }
                    catch
                    {
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
            }
            else if (a == "2")
            {

                try
                {
   
                    if(protocol.GetPckSize() == 0)
                    {
                        throw new WrongPackSizeException("---------\nРазмер пакета не может быть изменен, поскольку он не задан\n---------");
                    }
                    IncreaseReduce(protocol);
                }
                catch
                {
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            else if (a == "0")
            {
                return;
            }


            Console.Clear();
        }

    }

}