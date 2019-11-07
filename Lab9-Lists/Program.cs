using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Lab9_Lists
{
    class Program
    {

        public class StudentInfo
        {
            public string name;
            public string favoriteFood;
            public string favoriteColor;
            public string favoritePet;

            public StudentInfo(string name, string favoriteColor, string favoriteFood, string favoritePet)
            {
                this.name = name;
                this.favoriteColor = favoriteColor;
                this.favoriteFood = favoriteFood;
                this.favoritePet = favoritePet;
            }
        }
        static void Main(string[] args)
        {
            GetStudentInfo();
        }

        public static void GetStudentInfo()
        {
            List<StudentInfo> studentList = new List<StudentInfo>();
            studentList.Add(new StudentInfo("Alex", "yellow", "hot dogs", "dog"));
            studentList.Add(new StudentInfo("Bailey", "pink", "pizza", "dog"));
            studentList.Add(new StudentInfo("Cal", "orange", "garlic bread", "dog"));
            studentList.Add(new StudentInfo("Devin", "pink", "garlic bread", "turtle"));


            Console.WriteLine("Welcome to our class, here is a list of students.");
            foreach (var student in studentList)
            {
                Console.WriteLine(student.name);
            }

            Console.WriteLine("Would you like to add a new student? Y/N");
            string yesNoInput = Console.ReadLine();

            if (yesNoInput == "y")
            {
                yesNoInput.ToUpper();
            }

            Match acceptedInput = Regex.Match(yesNoInput, "Y?");
            bool repeat = acceptedInput.Success == true;

            while (repeat)
            {
                try
                {
                    if (yesNoInput.ToUpper() != "Y")
                    {
                        throw new NullOrEmptyInputException();
                    }
                    Console.WriteLine("Please enter a name");
                    string nameInput = Console.ReadLine();
                    bool nameEmpty = string.IsNullOrEmpty(nameInput);

                    if (nameEmpty == true) {
                        throw new NullOrEmptyInputException();
                    }

                    Console.WriteLine("Please enter a favorite color");
                    string colorInput = Console.ReadLine();
                    bool colorEmpty = string.IsNullOrEmpty(colorInput);

                    if (colorEmpty == true)
                    {
                        throw new NullOrEmptyInputException();
                    }

                    Console.WriteLine("Please enter a favorite food");
                    string foodInput = Console.ReadLine();
                    bool foodEmpty = string.IsNullOrEmpty(foodInput);

                    if (foodEmpty == true)
                    {
                        throw new NullOrEmptyInputException();
                    }


                    Console.WriteLine("Please enter a favorite pet");
                    string petInput = Console.ReadLine();
                    bool petEmpty = string.IsNullOrEmpty(petInput);

                    if (petEmpty == true)
                    {
                        throw new NullOrEmptyInputException();
                    }

                    studentList.Add(new StudentInfo(nameInput, colorInput, foodInput, petInput));

                    foreach (var student in studentList)
                    {
                        Console.WriteLine($"{student.name}'s favorite color is {student.favoriteColor}, favorite food is {student.favoriteFood}, and favorite pet is {student.favoritePet}.");
                    }
                    Console.WriteLine("Would you like to add another new student? Y/N");
                    string repeatInput = Console.ReadLine();

                    if (repeatInput == "n")
                    {
                        repeatInput.ToUpper();
                        repeat = false;
                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("Answer must be a word consisting of letter characters");
                    repeat = false;
                }
                catch (NullOrEmptyInputException)
                {
                    Console.WriteLine("Hmm. Seems like you entered \"n\" or an empty value.");
                    repeat = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"There was an error with your input: {e}");
                }
            }

        }
    }
}
