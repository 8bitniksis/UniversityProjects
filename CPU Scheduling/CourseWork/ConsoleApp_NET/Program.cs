using System;                             // загрузка необходимых библиотек
using System.Threading;              

namespace ConsoleApp_NET
{
    class Program
    {
        //===константы программы
        const int N_Thread = 5;                              //количество запускаемых потоков

        //===Основная функция программы
        static void Main(string[] args)
        {
            int critical_variable = 0;                       //критическая переменная
            object locker_object = new();                    // объект-заглушка
            bool Thread_Flag = true;                         //блокирующая переменнаяф
            //запуск пяти потоков
            for (int i = 1; i < N_Thread + 1; i++)
            {
                Thread Curr_Thread = new(Func_Show);         //создание очередного потока
                Curr_Thread.Name = $"Поток номер {i}";       // установка имени для каждого потока                
                Curr_Thread.Start();                         //старт очередного потока
            }

            //===Функция критической секции (вывод на экран значений счетчика)
            void Func_Show()
            {
                while (!Thread_Flag) { }                     //ожидание изменения значения блокирующей переменной
                lock (locker_object)                         //хазват критической секции
                {
                    Thread_Flag = false;                     //установка блокирующей переменной в значение 0 (занято)
                    critical_variable = 1;                   //сброс критической переменной
                    for (int i = 1; i < N_Thread + 1; i++)
                    {
                        Console.WriteLine($"{Thread.CurrentThread.Name}: {critical_variable}"); //вывод значения
                        critical_variable++;                 //инкремент критической переменной
                        Thread.Sleep(100);                   //задержка
                    }
                    Thread_Flag = true;                      //установка блокирующей переменной в значение 0 (свободно)
                }
            }
            Console.Read();
        }
    }
}
