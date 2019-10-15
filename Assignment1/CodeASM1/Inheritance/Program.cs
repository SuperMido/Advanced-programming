﻿using System;

namespace Inheritance
{
    class Persons
    {
        private string name;
        private int age;

        private string phone;

        public virtual string Name
        {
            get { return name;}
            set { name = value;}
        }

        public virtual int Age
        {
            get {return age;}
            set {age = value;}
        }

        public virtual string Phone
        {
            get{return phone;}
            set{phone = value;}
        }

        public Persons(string name, int age, string phone)
        {
            this.Name = name;
            this.Age = age;
            this.Phone = phone;
        }
    }

    class Student : Persons
    {
        private double score;
        private int grade;

        public Student(string name, int age, string phone) : base(name,age,phone)
        {
            score = 0;
            grade = 0;
        }

        public Student(string name, int age, string phone, double score) : base(name,age,phone)
        {
            this.score = score;
        }

        public Student(string name, int age, string phone, double score, int grade) : base(name,age,phone)
        {
            this.score = score;
            this.grade = grade;
        }

        public void status()
        {
            if (score >=5)
                Console.Write($"Infomation of student {Name}:\n\tAge: {Age}\n\tPhone Number: {Phone}\n\tScore: {score}\n\tMove to next grade({grade} => {grade+1})\n\n");
                else Console.Write($"Infomation of student {Name}:\n\tAge: {Age}\n\tPhone Number: {Phone}\n\tScore: {score}\n\tCant move to next grade({grade} => {grade+1})\n\n");
        }
    }

    class Teacher : Persons
    {
        private double salary;
        private int workhours;

        public Teacher(string name, int age, string phone) : base(name,age,phone)
        {
            salary = 0;
            workhours =0;
        }

        public Teacher(string name, int age, string phone, double salary) : base(name,age,phone)
        {
            this.salary = salary;
            workhours =0;
        }

        public Teacher(string name, int age, string phone, double salary, int workhours) : base(name,age,phone)
        {
            this.salary = salary;
            this.workhours = workhours;
        }

        public int CalSalary(int workhours)
        {
            return 10*workhours;
        }

        public void status()
        {
                Console.Write($"Infomation of teacher {Name}:\n\tAge: {Age}\n\tPhone Number: {Phone}\n\tSalary: {salary}\n\tWork hours: {workhours}\n\tSalary get: {CalSalary(workhours)}\n");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student myStudent1 = new Student("Quang Huy",24,"0795541090",9,10);
            Student myStudent2 = new Student("Hieu Nguyen",20,"012333232",4,10);

            Teacher myTeacher1 = new Teacher("Vinh Hoang",28,"0987654321",400,48);

            myStudent1.status();
            myStudent2.status();
            myTeacher1.status();

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
