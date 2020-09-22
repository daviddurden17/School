using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
	class Person
	{
		protected internal int age;
		public void Greet()
		{
			Console.WriteLine("Hello");
		}
		public void SetAge(int n)
		{
			age = n;
		}
	}

	class Student : Person
	{
		
		public void GoToClasses()
		{
			Console.WriteLine("I'm going to class.");
		}

		public void ShowAge()
		{
			Console.WriteLine("My age is: " + age + " years old.");
		}
	}

	class Teacher : Person
	{
		
		private string subject;
		public void Explain()
		{
			Console.WriteLine("Explanation begins");
		}
	}

	class StudentAndTeacherTest
	{
		static void Main(string[] args)
		{
			Person John = new Person();
			John.Greet();

			Student David = new Student();
			David.age = 21;
			David.Greet();
			David.ShowAge();

			Teacher Taylor = new Teacher();
			Taylor.age = 30;
			Taylor.Greet();
			Taylor.Explain();
		}
	}
}
