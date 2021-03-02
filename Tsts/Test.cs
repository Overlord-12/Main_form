using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Test
{
    public class Test
    {
        // Запись файлов на диск.
        static void RecordFile(string[] array, string adressFile)
        {
            string fileName = adressFile;
            using (StreamWriter sw = new StreamWriter(new FileStream(fileName, FileMode.Create, FileAccess.Write)))
            {
                for (int k = 0; k < array.Length; k++)
                {
                    sw.WriteLine(array[k]);
                }
            }
        }
        // Перемешивание массива.
        static void Answer(string[] array)
        {
            Random rand = new Random();
            for (int k = array.Length - 1; k >= 1; k--)
            {
                int j = rand.Next(k + 1);

                string tmp = array[j];
                array[j] = array[k];
                array[k] = tmp;
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"\n {i + 1}. {array[i]} ");
            }
        }
        // Проверка ответов.
        static string[] checkAnswer(string[] Answer, string[] user, int nubmerAnswer, int numberQuestion)
        {
            user[numberQuestion - 1] = Answer[nubmerAnswer - 1];
            return user;
        }

        // Перезапись ответов.
        static string[] newAnswer(string[] Answer)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine($"Ответ №{j + 1}");
                Answer[j] = Console.ReadLine();
            }
            return Answer;
        }

       public static void Main()
        {
            Console.WriteLine("Вы хотите использовать свои библиотеку? \n 1.Да \n 2.Нет");
            int number = 0;

            string[] Question = { "Как передавать данные к компьютеру? ", "Программировать роботов сложно?", "На каком языке основан язык VEX?",
        "На какой стороне должен распологаться красный провод при подключении?", "Нужно ли быть программистома, чтобы написать программу для робота? ", "Есть ли циклы в языке VEX? ", "Можно ли самостоятельно писать функции?",
            "Как называется интерфейс предназначенный для новичков","Собрать робота сложно?","Как называется язык на котором программируется робот?"};

            string[] CorrectAnswer = { "Через USB", "Нет", "C", "С левой",
                "Нет", "Да","Да", "drag-and-drop", "Нет", "VEX" };

            string[] CorrectAnswer1 = { "Через USB", "Через HDM", "Не знаю" };
            string[] CorrectAnswer2 = { "Да", "Нет", "Не знаю" };
            string[] CorrectAnswer3 = { "C", "C++", "Не знаю" };
            string[] CorrectAnswer4 = { "С левой", "С правой", "Не знаю" };
            string[] CorrectAnswer5 = { "Да", "Нет", "Не знаю" };
            string[] CorrectAnswer6 = { "Да", "Нет", "Не знаю" };
            string[] CorrectAnswer7 = { "Да", "Нет", "Не знаю" };
            string[] CorrectAnswer8 = { "drag-and-drop", "new-and-old", "Не знаю" };
            string[] CorrectAnswer9 = { "Да", "Нет", "Не знаю" };
            string[] CorrectAnswer10 = { "Vex", "Hex", "Не знаю" };
            string[] userAnswer = new string[10];
            number = Convert.ToInt32(Console.ReadLine());
            if (number == 1)
            {
                Question = File.ReadAllLines("C:\\Users\\Question.txt");
                CorrectAnswer = File.ReadAllLines("C:\\Users\\Answer.txt");
                CorrectAnswer1 = File.ReadAllLines("C:\\Users\\Answer1.txt");
                CorrectAnswer2 = File.ReadAllLines("C:\\Users\\Answer2.txt");
                CorrectAnswer3 = File.ReadAllLines("C:\\Users\\Answer3.txt");
                CorrectAnswer4 = File.ReadAllLines("C:\\Users\\Answer4.txt");
                CorrectAnswer5 = File.ReadAllLines("C:\\Users\\Answer5.txt");
                CorrectAnswer6 = File.ReadAllLines("C:\\Users\\Answer6.txt");
                CorrectAnswer7 = File.ReadAllLines("C:\\Users\\Answer7.txt");
                CorrectAnswer8 = File.ReadAllLines("C:\\Users\\Answer8.txt");
                CorrectAnswer9 = File.ReadAllLines("C:\\Users\\Answer9.txt");
                CorrectAnswer10 = File.ReadAllLines("C:\\Users\\Answer10.txt");
            }

            int number_answer;

            int check = 0;
            int percent = 0;
            int itog = 0;
            Console.WriteLine("Выберите режим использования программы:\n 1.Режим редактирования вопросов \n 2.Режим тестирования");
            number = Convert.ToInt32(Console.ReadLine());
            if (number == 1)
            {
                for (int i = 0; i < Question.Length; i++)
                {
                    Console.WriteLine("\n" + (i + 1) + "." + Question[i]);
                }
                Console.WriteLine("11.Выйти из редактора вопросов");

                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine("\n Выберите вопрос, который хотите редактировать.");
                    number = Convert.ToInt32(Console.ReadLine());
                    if (number == 1)
                    {
                        Console.WriteLine($"Ваш вопрос выглядит так: \n {Question[number - 1]}");
                        Console.WriteLine("Введите свой вопрос");
                        Question[number - 1] = Console.ReadLine();
                        Console.WriteLine("Введите правильный вариант ответа");
                        CorrectAnswer[number - 1] = Console.ReadLine();
                        Console.WriteLine("Введите 3 варианта ответа");
                        CorrectAnswer1 = newAnswer(CorrectAnswer1);

                    }
                    if (number == 2)
                    {
                        Console.WriteLine($"Ваш вопрос выглядит так: \n {Question[number - 1]}");
                        Console.WriteLine("Введите свой вопрос");
                        Question[number - 1] = Console.ReadLine();
                        Console.WriteLine("Введите правильный вариант ответа");
                        CorrectAnswer[number - 1] = Console.ReadLine();
                        Console.WriteLine("Введите 3 варианта ответа");
                        CorrectAnswer2 = newAnswer(CorrectAnswer2);

                    }
                    if (number == 3)
                    {
                        Console.WriteLine($"Ваш вопрос выглядит так: \n {Question[number - 1]}");
                        Console.WriteLine("Введите свой вопрос");
                        Question[number - 1] = Console.ReadLine();
                        Console.WriteLine("Введите правильный вариант ответа");
                        CorrectAnswer[number - 1] = Console.ReadLine();
                        Console.WriteLine("Введите 3 варианта ответа");
                        CorrectAnswer3 = newAnswer(CorrectAnswer3);

                    }
                    if (number == 4)
                    {
                        Console.WriteLine($"Ваш вопрос выглядит так: \n {Question[number - 1]}");
                        Console.WriteLine("Введите свой вопрос");
                        Question[number - 1] = Console.ReadLine();
                        Console.WriteLine("Введите правильный вариант ответа");
                        CorrectAnswer[number - 1] = Console.ReadLine();
                        Console.WriteLine("Введите 3 варианта ответа");
                        CorrectAnswer4 = newAnswer(CorrectAnswer4);

                    }
                    if (number == 5)
                    {
                        Console.WriteLine($"Ваш вопрос выглядит так: \n {Question[number - 1]}");
                        Console.WriteLine("Введите свой вопрос");
                        Question[number - 1] = Console.ReadLine();
                        Console.WriteLine("Введите правильный вариант ответа");
                        CorrectAnswer[number - 1] = Console.ReadLine();
                        Console.WriteLine("Введите 3 варианта ответа");
                        CorrectAnswer1 = newAnswer(CorrectAnswer5);

                    }
                    if (number == 6)
                    {
                        Console.WriteLine($"Ваш вопрос выглядит так: \n {Question[number - 1]}");
                        Console.WriteLine("Введите свой вопрос");
                        Question[number - 1] = Console.ReadLine();
                        Console.WriteLine("Введите правильный вариант ответа");
                        CorrectAnswer[number - 1] = Console.ReadLine();
                        Console.WriteLine("Введите 3 варианта ответа");
                        CorrectAnswer6 = newAnswer(CorrectAnswer6);

                    }
                    if (number == 7)
                    {
                        Console.WriteLine($"Ваш вопрос выглядит так: \n {Question[number - 1]}");
                        Console.WriteLine("Введите свой вопрос");
                        Question[number - 1] = Console.ReadLine();
                        Console.WriteLine("Введите правильный вариант ответа");
                        CorrectAnswer[number - 1] = Console.ReadLine();
                        Console.WriteLine("Введите 3 варианта ответа");
                        CorrectAnswer7 = newAnswer(CorrectAnswer7);

                    }
                    if (number == 8)
                    {
                        Console.WriteLine($"Ваш вопрос выглядит так: \n {Question[number - 1]}");
                        Console.WriteLine("Введите свой вопрос");
                        Question[number - 1] = Console.ReadLine();
                        Console.WriteLine("Введите правильный вариант ответа");
                        CorrectAnswer[number - 1] = Console.ReadLine();
                        Console.WriteLine("Введите 3 варианта ответа");
                        CorrectAnswer8 = newAnswer(CorrectAnswer8);

                    }
                    if (number == 9)
                    {
                        Console.WriteLine($"Ваш вопрос выглядит так: \n {Question[number - 1]}");
                        Console.WriteLine("Введите свой вопрос");
                        Question[number - 1] = Console.ReadLine();
                        Console.WriteLine("Введите правильный вариант ответа");
                        CorrectAnswer[number - 1] = Console.ReadLine();
                        Console.WriteLine("Введите 3 варианта ответа");
                        CorrectAnswer9 = newAnswer(CorrectAnswer9);

                    }

                    if (number == 10)
                    {
                        Console.WriteLine($"Ваш вопрос выглядит так: \n {Question[number - 1]}");
                        Console.WriteLine("Введите свой вопрос");
                        Console.WriteLine("Введите правильный вариант ответа");
                        CorrectAnswer[number - 1] = Console.ReadLine();
                        Question[number - 1] = Console.ReadLine();
                        Console.WriteLine("Введите 3 варианта ответа");
                        CorrectAnswer10 = newAnswer(CorrectAnswer10);

                    }
                    if (number == 11)
                    {
                        Console.WriteLine("Данные которые вы ввели будут сохранены \n Чтобы пройти тестирование перезайдите в программу");
                        string fileName = "C:\\Users\\Question.txt";
                        RecordFile(Question, fileName);
                        string fileName1 = "C:\\Users\\Answer.txt";
                        RecordFile(CorrectAnswer, fileName1);
                        string fileName2 = "C:\\Users\\Answer1.txt";
                        RecordFile(CorrectAnswer1, fileName2);
                        string fileName3 = "C:\\Users\\Answer2.txt";
                        RecordFile(CorrectAnswer2, fileName3);
                        string fileName4 = "C:\\Users\\Answer3.txt";
                        RecordFile(CorrectAnswer3, fileName4);
                        string fileName5 = "C:\\Users\\Answer4.txt";
                        RecordFile(CorrectAnswer4, fileName5);
                        string fileName6 = "C:\\Users\\Answer5.txt";
                        RecordFile(CorrectAnswer5, fileName6);
                        string fileName7 = "C:\\Users\\Answer6.txt";
                        RecordFile(CorrectAnswer6, fileName7);
                        string fileName8 = "C:\\Users\\Answer7.txt";
                        RecordFile(CorrectAnswer7, fileName8);
                        string fileName9 = "C:\\Users\\Answer8.txt";
                        RecordFile(CorrectAnswer8, fileName9);
                        string fileName10 = "C:\\Users\\Answer9.txt";
                        RecordFile(CorrectAnswer9, fileName10);
                        string fileName11 = "C:\\Users\\Answer10.txt";
                        RecordFile(CorrectAnswer10, fileName11);

                        break;
                    }
                }

            }

            if (number == 2)
            {
                for (int i = 0; i < Question.Length; i++)
                {
                    Console.WriteLine("\n" + (i + 1) + "." + Question[i]);
                }
                Console.WriteLine("11.Сдать и завершить тест");

                for (int i = number; number < 1000; i++)
                {
                    Console.WriteLine("\n Выберите вопрос");
                    number = Convert.ToInt32(Console.ReadLine());
                    if (number == 1)
                    {
                        Console.WriteLine(Question[number - 1]);
                        Answer(CorrectAnswer1);
                        Console.WriteLine("\n Напишите правильный вариант ответа");
                        number_answer = Convert.ToInt32(Console.ReadLine());
                        checkAnswer(CorrectAnswer1, userAnswer, number_answer, number);

                    }
                    if (number == 2)
                    {
                        Console.WriteLine(Question[number - 1]);
                        Answer(CorrectAnswer2);
                        Console.WriteLine("\n Напишите правильный вариант ответа");
                        number_answer = Convert.ToInt32(Console.ReadLine());
                        checkAnswer(CorrectAnswer2, userAnswer, number_answer, number);

                    }
                    if (number == 3)
                    {
                        Console.WriteLine(Question[number - 1]);
                        Answer(CorrectAnswer3);
                        Console.WriteLine("\n Напишите правильный вариант ответа");
                        number_answer = Convert.ToInt32(Console.ReadLine());
                        checkAnswer(CorrectAnswer3, userAnswer, number_answer, number);


                    }
                    if (number == 4)
                    {
                        Console.WriteLine(Question[number - 1]);
                        Answer(CorrectAnswer4);
                        Console.WriteLine("\n Напишите правильный вариант ответа");
                        number_answer = Convert.ToInt32(Console.ReadLine());
                        checkAnswer(CorrectAnswer4, userAnswer, number_answer, number);


                    }
                    if (number == 5)
                    {
                        Console.WriteLine(Question[number - 1]);
                        Answer(CorrectAnswer5);
                        Console.WriteLine("\n Напишите правильный вариант ответа");
                        number_answer = Convert.ToInt32(Console.ReadLine());
                        checkAnswer(CorrectAnswer1, userAnswer, number_answer, number);

                    }
                    if (number == 6)
                    {
                        Console.WriteLine(Question[number - 1]);
                        Answer(CorrectAnswer6);
                        Console.WriteLine("\n Напишите правильный вариант ответа");
                        number_answer = Convert.ToInt32(Console.ReadLine());
                        checkAnswer(CorrectAnswer1, userAnswer, number_answer, number);

                    }
                    if (number == 7)
                    {
                        Console.WriteLine(Question[number - 1]);
                        Answer(CorrectAnswer7);
                        Console.WriteLine("\n Напишите правильный вариант ответа");
                        number_answer = Convert.ToInt32(Console.ReadLine());
                        checkAnswer(CorrectAnswer1, userAnswer, number_answer, number);

                    }
                    if (number == 8)
                    {
                        Console.WriteLine(Question[number - 1]);
                        Answer(CorrectAnswer8);
                        Console.WriteLine("\n Напишите правильный вариант ответа");
                        number_answer = Convert.ToInt32(Console.ReadLine());
                        checkAnswer(CorrectAnswer6, userAnswer, number_answer, number);

                    }
                    if (number == 9)
                    {
                        Console.WriteLine(Question[number - 1]);
                        Answer(CorrectAnswer9);
                        Console.WriteLine("\n Напишите правильный вариант ответа");
                        number_answer = Convert.ToInt32(Console.ReadLine());
                        checkAnswer(CorrectAnswer1, userAnswer, number_answer, number);


                    }
                    if (number == 10)
                    {
                        Console.WriteLine(Question[number - 1]);
                        Answer(CorrectAnswer10);
                        Console.WriteLine("\n Напишите правильный вариант ответа");
                        number_answer = Convert.ToInt32(Console.ReadLine());
                        checkAnswer(CorrectAnswer5, userAnswer, number_answer, number);

                    }
                    if (number == 11)
                    {
                        Console.WriteLine("Ваши ответы на вопросы");
                        for (int j = 0; j < CorrectAnswer.Length; j++)
                        {
                            Console.Write($"\n На вопрос {j + 1}. {Question[j]}  Вы ответили:  {userAnswer[j]}");
                        }


                        Console.WriteLine("\n Чтобы отправить ответы, введите еще раз 11.");
                        Console.WriteLine("\n Чтобы исправить ответ, нажмите любую цифру, а затем выберите номер вопроса.");
                        itog = Convert.ToInt32(Console.ReadLine());

                        if (itog == 11)
                        {
                            for (int l = 0; l < CorrectAnswer.Length; l++)
                            {
                                if (userAnswer[l] == CorrectAnswer[l])
                                    check++;

                                percent = (check * 100) / Question.Length;

                            }
                            break;
                        }
                        else if (itog != 11)
                        {
                            continue;
                        }

                    }



                }


                if (number <= 0)
                {
                    Console.WriteLine("Такого вопроса не существует");
                }

                Console.WriteLine($"Вы дали {check} правильных ответов, это составляет {percent}%");


                string fileName = "C:\\Users\\Result.txt";
                if (File.Exists(fileName) != true)
                {
                    using (StreamWriter sw = new StreamWriter(new FileStream(fileName, FileMode.Create, FileAccess.Write)))
                    {
                        sw.WriteLine($"Вы дали {check} правильных ответов, это составляет {percent}%");
                    }
                }
                else
                {
                    using (StreamWriter sw = new StreamWriter(new FileStream(fileName, FileMode.Open, FileAccess.Write)))
                    {
                        (sw.BaseStream).Seek(0, SeekOrigin.End);
                        sw.WriteLine($"Вы дали {check} правильных ответов, это составляет {percent}%");
                    }
                }

            }



            Console.ReadLine();
        }
    }
}


