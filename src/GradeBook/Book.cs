using System;
using System.Collections.Generic;
namespace GradeBook

{
    public class Book
    {
        //Making a constructor so that the instance is not assigned to NULL value
        // Public methods and variables can also be accessed outside the class
        public Book(string name)
        {
            this.grades = new List<double>();
            this.Name = name;
        }
        public void UpdateName(string name)
        {
            this.Name = name;
        }
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
        public void Addgrade(double grade)
        {
            if (grade < 0 || grade > 100)
            {
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }
            else
            {
                this.grades.Add(grade);
            }
        }
        public void ShowName()
        {
            Console.WriteLine($"The Name of this Book is {this.Name}");
        }
        public void compute_statistics()
        {
            if(this.grades.Count == 0)
            {
                Console.WriteLine("No Grades found in this book");
            }
            else
            {
                this.sum = 0.0;
                foreach (var item in this.grades)
                {
                    this.sum += item;
                }
                this.average = this.sum / this.grades.Count;
                this.max = Book.Max(this.grades);
                this.min = Book.Min(this.grades);
            }
        }
        public void show_statistics()
        {
            
            if(this.grades.Count == 0)
            {
                Console.WriteLine("No Grades found in this book");
            }
            else
            {
                compute_statistics();
                Console.WriteLine($"Average of this class is {this.average}");
                Console.WriteLine($"Maximum Value in grades are {this.max}");
                Console.WriteLine($"Minimum Value in grades are {this.min}");
            }
        }
        public Statistics get_statistics()
        {
            var newstats = new Statistics();
            if (this.grades.Count == 0)
            {
                Console.WriteLine("No Grades found in this book");
            }
            else
            {
                compute_statistics();
                newstats.average = this.average;
                newstats.max = this.max;
                newstats.min = this.min;
            }
            return newstats;
        }
        // Static function can be called only class itself not by its instance
        static public double Max(List<double> grades)
        {
            var max_value = double.MinValue;
            foreach (var item in grades)
            {
                max_value = Math.Max(max_value, item);
            }
            return max_value;
        }
        static public double Min(List<double> grades)
        {
            var min_value = double.MaxValue;
            foreach (var item in grades)
            {
                min_value = Math.Min(min_value, item);
            }
            return min_value;
        }
        // Private Methods and variables can be accessed only inside the class 
        public string Name ;
        // Can be accessed outside of the class 
        public List<double> grades;
        private double average, max, min,sum;
    }
}