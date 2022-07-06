namespace Home_Lesson_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\GB_Home\OOP_Lesson_3\Home_Lesson_3\Home_Lesson_3\names.txt";
            string text = File.ReadAllText(path);

            //Тест метода по поиску email
            SearchMail(ref text);

            string fileName = "emails.txt";
            File.AppendAllText(fileName, text);



            //Тест переворота строки
            Console.WriteLine($"Перевернутая строка: {ReverseStr("Привет")}");

        }
        /// <summary>
        /// Метод по поиску email
        /// </summary>
        /// <param name="str"></param>
        static void SearchMail(ref string text)
        {
            string[] subs = text.Split(' ');
            text = "";
            for (int i = 4; i < subs.Length; i += 5) // Слегка туповато, зато быстро работает :)
            {
                if (i < subs.Length)
                {
                    text += subs[i] + " ";
                }
            }
            text = text.TrimEnd(); // Обрезаем пробел в конце
        }
        /// <summary>
        /// Переворот строки
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        static string ReverseStr(string str)
        {
            Console.WriteLine($"Изначальная строка: {str}");
            char[] charArr = str.ToCharArray();
            Array.Reverse(charArr);
            return new string(charArr);
        }
    }
}
