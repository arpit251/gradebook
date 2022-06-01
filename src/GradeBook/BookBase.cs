namespace GradeBook
{
    public class BookBase
    {
        public void Addgrade(char x)
        {
            switch (x)
            {
                case 'A':
                    grades.Add(100);
                    break;
                case 'B':
                    grades.Add(80);
                    break;
                case 'C':
                    grades.Add(60);
                    break;
                case 'D':
                    grades.Add(40);
                    break;
                case 'F':
                    grades.Add(0);
                    break;
                default:
                    Console.WriteLine("Please enter a valid grade");
                    break;
            }
        }
    }
}