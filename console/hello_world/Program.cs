using System;

namespace hello_world
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");

			Person person = new Person ("Minh");
			person.PrintMyName ();
			person.DivideMyAge (0);
		}
	}

	class Person
	{
		public string Name { get; set; }
		public int Age { get; set; }

		public Person(string name)
		{
			this.Name = name;
		}

		public void PrintMyName() 
		{
			Console.WriteLine ("My name is: " + this.Name);
		}

		public void DivideMyAge(int number)
		{
			try {
				this.Age = this.Age / number;
				Console.WriteLine("My age is : " + this.Age);
			}
			catch (Exception ex) {
				Console.Write ("Error:" + ex.Message);
			}
		}
	}
}
