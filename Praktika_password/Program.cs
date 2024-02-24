using System;
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
            Console.Write("Введите пароль:\r\n");

            //объявление переменных
            string input_password = "",           //вводимый пароль
                   true_password = "Донателло";   //верный пароль

            int number_att = 0,                   //номер попытки ввода пароля
                count_att = 3;                    //кол-во попыток

            //цикл для подсчета кол-ва попыток и проверки правильности вводимого пароля
            do
            {
                Console.WriteLine($"\r\nПопыток {count_att}\r\n");
                input_password = Console.ReadLine();
                number_att++;
                count_att--;

                //если осталась одна попытка, то предлагается подсказка
                if (number_att == 2 && input_password != true_password)
                {
                    Console.Write("\r\nИспользовать подсказку? (да/нет)\r\n");
                    string get_clue = Console.ReadLine();

                    //если подсказка выбрана, то показывается вопрос
                    if (get_clue == "да")
                    {
                        Console.Write("\r\nИзобретатель в команде черепашек-ниндзя\r\n");
                        input_password = Console.ReadLine();
                        number_att++;
                        count_att--;

                        //если попыток не осталось (с подсказкой)
                        if (count_att <= 0 && input_password != true_password)
                        {
                            Console.Write("\r\nПревышен лимит попыток\r\nПовторите попытку позже\r\n");
                            break;
                        }
                    }
                }

                //если попыток не осталось (без подсказки)
                else if (count_att <= 0 && input_password != true_password)
                {
                    Console.Write("\r\nПревышен лимит попыток\r\nПовторите попытку позже\r\n");
                    break;
                }
            }
            while (input_password != true_password);

            //вывод секретного сообщения
            if (input_password == true_password) Console.Write("\r\nСекретное сообщение:\r\nпоследней пары не будет\r\n\r\n");
        }
    }
}