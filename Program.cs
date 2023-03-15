using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Alxe", 3, new Zachet());
            student.Move();
            student.movable = new Zachet();
            student.Move();
            Student student1 = new Student("Plume", 4, new Exam());
            student1.Move();
            student1.movable = new Exam();
            student1.Move();

            Console.ReadLine();
        }
        public interface IMovable
        {
            void Move();
        }
        public class Zachet : IMovable
        {
            public void Move()
            {
                Console.WriteLine("Диффиринцированный зачёт");
            }
        }
        public class Exam : IMovable
        {
            public void Move()
            {
                Console.WriteLine("Сдача экзамена");
            }
        }
        class Student
        {
            public string Name; /*{ get; set; }*/
            public int sredniy_ball; /*{ get; set; }*/
            public IMovable Movable { get; set; }
            public string GetFullName()
            {
                return string.Format("Имя: {0}, Средний балл: {1}", Name, sredniy_ball);
            }
            public Student(string name, int sred_ball, IMovable move)
            {
                this.Name = name;
                this.sredniy_ball = sred_ball;
                movable = move;
            }
            public void ocenka()
            {
                Random rnd = new Random();
                sredniy_ball = rnd.Next(2, 5);
            }
            public IMovable movable { private get; set; }
            public void Move()
            {
                movable.Move();
            }
        }
        public interface IStrategy
        {
            void EX();
        }
        public class strat1 : IStrategy
        {
            public void EX()
            {

            }
        }
        public class strat2 : IStrategy
        {
            public void EX()
            {

            }
        }
        //public class Exams : Student
        //{
        //    public Exams(string name, int sredn_ball)
        //        : base(name, sredn_ball)
        //    {
        //        Movable = new Exam();
        //    }
        //}
        //public class _Zachet : Student
        //{
        //    public _Zachet(string name, int sredn_ball)
        //        : base(name, sredn_ball)
        //    {

        //    }
        //}
        public class Session
        {
            public IStrategy Strategy { get; set; }
            public Session(IStrategy strategy)
            {
                Strategy = strategy;
            }
            public void Vivod()
            {
                Strategy.EX();
            }
        }
    } 
}
