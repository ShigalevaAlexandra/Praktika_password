﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika_password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //описание работы программы
            Console.SetCursorPosition(0, 1);
            Console.Write("   Введите пароль:\r\n");

            //объявление переменных
            string input_password = "",           //вводимый пароль
                   true_password = "Донателло";   //верный пароль

            int number_att = 0,                   //номер попытки ввода пароля
                count_att = 3,                    //кол-во попыток
                position_y = 5;                   //позиция y
            

            //цикл для подсчета кол-ва попыток и проверки правильности вводимого пароля
            do
            {
                Console.WriteLine($"\r\n   --> Попыток {count_att}\r\n");
                Console.SetCursorPosition(3, position_y);
                input_password = Console.ReadLine();
                number_att++;
                count_att--;
                position_y += 4;

                //если осталась одна попытка, то предлагается подсказка
                if (number_att == 2 && input_password != true_password)
                {
                    Console.Write("\r\n   * Использовать подсказку? (да/нет) *\r\n");

                    Console.SetCursorPosition(3, position_y);
                    string get_clue = Console.ReadLine();
                    position_y += 4;

                    //если подсказка выбрана, то показывается вопрос
                    if (get_clue == "да")
                    {
                        Console.Write("\r\n   * Изобретатель в команде черепашек-ниндзя? *\r\n");
                        Console.SetCursorPosition(3, position_y);
                        input_password = Console.ReadLine();
                        number_att++;
                        count_att--;

                        //если попыток не осталось (с подсказкой)
                        if (count_att <= 0 && input_password != true_password)
                        {
                            Console.WriteLine("\r\n   Превышен лимит попыток!!\r\n   Повторите попытку позже\r\n\r\n");
                            break;
                        }
                    }
                }

                //если попыток не осталось (без подсказки)
                else if (count_att <= 0 && input_password != true_password)
                {
                    Console.WriteLine("\r\n   Превышен лимит попыток\r\n   Повторите попытку позже\r\n");
                    break;
                }
            }
            while (input_password != true_password);

            //вывод секретного сообщения
            if (input_password == true_password) Console.WriteLine("\r\n   Секретное сообщение:\r\n   последней пары не будет\r\n\r\n");
        }
    }
}