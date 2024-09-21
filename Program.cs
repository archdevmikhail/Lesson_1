namespace Lesson_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string lesson = "Сегодня урок "; // переменная строкового типа

            int number = 1; // переменная integer (целое число, целочисленная)

            string place = " в Большом Зале"; // переменная строкового типа

            string message = $"{lesson}{number}{place}"; // мы положиди в переменную message значения трёх переменных
            Console.ForegroundColor = ConsoleColor.DarkCyan; // тут мы задаём цвет текста консоли, меняем стандартный Grey на DarkCyan
            Console.WriteLine(message); // вывод значения переменной message

            Console.WriteLine(lesson + number + place); //конкатенация
            Console.WriteLine($"{lesson}{number}{place}"); //интерполяция
            Console.WriteLine($"Добро пожаловать! {lesson}{number}{place}, его ведёт Вера Ивановна"); //интерполяция с текстовыми значениями
            Console.WriteLine("Добро пожаловать! " + lesson + number + place + ", его ведёт Вера Ивановна"); //конкатенация с текстовыми значениями
            Console.WriteLine(string.Format("{0}{1}{2}", lesson, number, place)); // метод string.Format, который принимает три параметра: lesson, number и place.

            Console.ReadKey(); // окно консоли не закроется, пока не нажмёте любую клавишу.
                               // При этом поставьте галочку: Отладка -> Параметры -> Общие -> "Автоматически закрыть консоль при остановки отладки"
        }
    }
}
