using System;

namespace Task_5_Grade_Calculator_Program
{    
    /* Pseudocode
     
     *Define a class "Student".
     
       *Inside the class, declare variables for marks of Maths, Physics, Chemistry, and Computer Science.
       *Define a Function "CalculateAverage" that calculates and returns the average marks.
       *Define a Function "CalculateGrade" that returns the grade based on the average marks.
     
     In the Main method:

       *Use a try-catch block to handle exceptions.
       *Prompt the user to enter marks for four subjects.
       *Create an instance of the Student class and assign the marks.
       *Call the CalculateAverage Function to get the average.
       *Call the CalculateGrade Fethod to get the grade.
       *Use a switch statement to print the appropriate remarks based on the grade.*/

    class Student

    {   //Declaring Variables
        public int maths, physics, chemistry, computerScience;

        // function to calculate average marks
        public double CalculateAverage()
        {
            return (maths + physics + chemistry + computerScience) / 4.0;
        }

        // function to calculate grade based on average marks
        public string CalculateGrade(double average)
        {
            if (average >= 80)
                return "A";
            else if (average >= 70)
                return "B";
            else if (average >= 60)
                return "C";
            else if (average >= 50)
                return "D";
            else
                return "F";
        }
        // function to set marks
        public void SetMarks(int maths, int physics, int chemistry, int computerScience)
        {
            this.maths = maths;
            this.physics = physics;
            this.chemistry = chemistry;
            this.computerScience = computerScience;
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                try
                {
                    // Create a new Student object
                    Student student = new Student();

                    // Input marks
                    Console.WriteLine("Enter marks for Maths (out of 100):");
                    int maths = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter marks for Physics (out of 100):");
                    int physics = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter marks for Chemistry (out of 100):");
                    int chemistry = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter marks for Computer Science (out of 100):");
                    int computerScience = int.Parse(Console.ReadLine());

                    // Set marks
                    student.SetMarks(maths, physics, chemistry, computerScience);

                    // Calculate average
                    double average = student.CalculateAverage();
                    Console.WriteLine($"Average Marks: {average}");

                    // Calculate grade
                    string grade = student.CalculateGrade(average);

                    // Print remarks using switch statement
                    switch (grade)
                    {
                        case "A":
                            Console.WriteLine("Excellent! Your grade is A");
                            break;
                        case "B":
                            Console.WriteLine("Good! Your grade is B");
                            break;
                        case "C":
                            Console.WriteLine("Satisfactory. Your grade is C");
                            break;
                        case "D":
                            Console.WriteLine("Pass. Your grade is D");
                            break;
                        case "F":
                            Console.WriteLine("Fail. Your grade is F");
                            break;
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter numeric values.");
                }
                Console.ReadLine();

            }
        }
    }
}