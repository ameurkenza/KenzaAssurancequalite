using System;
using System.Collections.Generic;

namespace QualitelogicielUA3
{
    class Program
    {
        // Listes pour stocker les données des étudiants, des cours et des notes.
        static List<Student> students = new List<Student>();
        static List<Course> courses = new List<Course>();
        static Dictionary<int, List<Grade>> studentGrades = new Dictionary<int, List<Grade>>();

        static void Main(string[] args)
        {
            // Remplissage initial des données avec des exemples pour le test.
            PreFillData();

            // Boucle pour afficher le menu principal.
            bool showMainMenu = true;
            while (showMainMenu)
            {
                Console.WriteLine("\nSelect an option:");
                Console.WriteLine("1. List students");
                Console.WriteLine("2. List courses");
                Console.WriteLine("3. Print student transcript");
                Console.WriteLine("0. Exit");
                string option = Console.ReadLine();

                // Traitement du choix de l'utilisateur.
                switch (option)
                {
                    case "1":
                        ListStudents();
                        break;
                    case "2":
                        ListCourses();
                        break;
                    case "3":
                        RequestStudentNumberForTranscript();
                        break;
                    case "0":
                        // Arrête la boucle et termine le programme.
                        showMainMenu = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }

        static void PreFillData()
        {
            
                // Ajout d'exemples d'étudiants.
                students.Add(new Student(1, "Ameur", "Kenza"));
                students.Add(new Student(2, "Boudjema", "Maysa"));
                students.Add(new Student(3, "Fah", "Steave"));
                students.Add(new Student(4, "Smith", "Anna"));
                students.Add(new Student(5, "Bettar", "Nassim"));

                // Ajout d'exemples de cours.
                courses.Add(new Course(101, "INF101", "Programmation orientée objet en C#"));
                courses.Add(new Course(102, "MAT102", "Bases de données"));
                courses.Add(new Course(103, "STA103", "Statistiques"));
                courses.Add(new Course(104, "WEB104", "Programmation web client"));
                courses.Add(new Course(105, "AND105", "Développement d'Applications pour Android"));

                // Ajout d'exemples de notes pour les étudiants.
                AddGrade(1, 101, 90.0f);
                AddGrade(1, 102, 85.5f);
                AddGrade(1, 103, 10.0f);
                AddGrade(1, 104, 99.5f);
                AddGrade(1, 105, 88.0f);

                AddGrade(2, 101, 85.5f);
                AddGrade(2, 102, 100.0f);
                AddGrade(2, 103, 85.5f);
                AddGrade(2, 104, 90.0f);
                AddGrade(2, 105, 93.5f);

                AddGrade(3, 101, 98.0f);
                AddGrade(3, 102, 80.5f);
                AddGrade(3, 103, 97.0f);
                AddGrade(3, 104, 80.5f);
                AddGrade(3, 105, 97.0f);

                AddGrade(4, 101, 100.5f);
                AddGrade(4, 102, 76.0f);
                AddGrade(4, 103, 87.5f);
                AddGrade(4, 104, 80.0f);
                AddGrade(4, 105, 93.5f);

                AddGrade(5, 101, 97.5f);
                AddGrade(5, 102, 86.0f);
                AddGrade(5, 103, 86.5f);
                AddGrade(5, 104, 97.0f);
                AddGrade(5, 105, 93.5f);
        


        }

        static void ListStudents()
        {
            // Affichage de la liste des étudiants.
            Console.WriteLine("\nList of Students:");
            foreach (Student student in students)
            {
                Console.WriteLine($"Student Number: {student.NumeroEtudiant}, Name: {student.Nom}, Surname: {student.Prenom}");
            }
            // Affiche les options pour gérer les étudiants.
            StudentMenuOptions();
        }

        static void ListCourses()
        {
            // Affichage de la liste des cours.
            Console.WriteLine("\nList of Courses:");
            foreach (Course course in courses)
            {
                Console.WriteLine($"Course Number: {course.NumeroCours}, Code: {course.Code}, Title: {course.Titre}");
            }
            // Affiche les options pour gérer les cours.
            CourseMenuOptions();
        }

        static void RequestStudentNumberForTranscript()
        {
            // Demande le numéro d'étudiant pour afficher son relevé de notes.
            Console.WriteLine("Enter the student number:");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int studentNumber))
            {
                PrintTranscript(studentNumber);
            }
            else
            {
                Console.WriteLine("Invalid number entered.");
            }
            // Retour au menu principal après l'affichage du relevé de notes.
            MainMenuOptions();
        }

        static void PrintTranscript(int studentNumber)
        {
            // Recherche et affiche le relevé de notes de l'étudiant spécifié.
            var student = students.Find(s => s.NumeroEtudiant == studentNumber);
            if (student != null)
            {
                Console.WriteLine($"\nTranscript for Student {studentNumber}: {student.Nom} {student.Prenom}");
                if (studentGrades.TryGetValue(studentNumber, out List<Grade> grades))
                {
                    foreach (Grade grade in grades)
                    {
                        var course = courses.Find(c => c.NumeroCours == grade.NumeroCours);
                        Console.WriteLine($"Course: {course?.Titre ?? "Unknown"}, Grade: {grade.Note}");
                    }
                }
                else
                {
                    Console.WriteLine("No grades found for this student.");
                }
            }
            else
            {
                Console.WriteLine("No student found with this number.");
            }
        }

        static void StudentMenuOptions()
        {
            // Options pour ajouter un étudiant ou retourner au menu principal.
            Console.WriteLine("4. Add student");
            Console.WriteLine("5. Return to main menu");
            Console.WriteLine("0. Exit");
            string option = Console.ReadLine();
            switch (option)
            {
                case "4":
                    // Ajoute un nouvel étudiant à la liste.
                    AddStudent();
                    break;
                case "5":
                    // Rien à faire, le programme retourne automatiquement au menu principal.
                    break;
                case "0":
                    // Quitte le programme.
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }

        static void CourseMenuOptions()
        {
            // Options pour ajouter un cours ou retourner au menu principal.
            Console.WriteLine("6. Add course");
            Console.WriteLine("5. Return to main menu");
            Console.WriteLine("0. Exit");
            string option = Console.ReadLine();
            switch (option)
            {
                case "6":
                    // Ajoute un nouveau cours à la liste.
                    AddCourse();
                    break;
                case "5":
                    // Rien à faire, le programme retourne automatiquement au menu principal.
                    break;
                case "0":
                    // Quitte le programme.
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }

        static void MainMenuOptions()
        {
            // Options pour retourner au menu principal ou quitter le programme.
            Console.WriteLine("5. Return to main menu");
            Console.WriteLine("0. Exit");
            string option = Console.ReadLine();
            if (option == "0")
            {
                // Quitte le programme.
                Environment.Exit(0);
            }
            // Pas d'action nécessaire pour l'option "5" car le programme retourne au menu principal.
        }

        static void AddStudent()
        {
            // Permet à l'utilisateur d'ajouter un nouvel étudiant.
            Console.WriteLine("Enter student's number:");
            int studentNumber = int.Parse(Console.ReadLine()); // TODO: Ajouter la gestion des erreurs.

            Console.WriteLine("Enter student's first name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter student's last name:");
            string lastName = Console.ReadLine();

            // Création et ajout d'un nouvel étudiant à la liste.
            Student newStudent = new Student(studentNumber, firstName, lastName);
            students.Add(newStudent);

            Console.WriteLine($"Student {firstName} {lastName} added successfully.");
        }

        static void AddCourse()
        {
            // Permet à l'utilisateur d'ajouter un nouveau cours.
            Console.WriteLine("Enter the course number:");
            int courseNumber;
            while (!int.TryParse(Console.ReadLine(), out courseNumber))
            {
                Console.WriteLine("Invalid input. Please enter a valid course number:");
            }

            Console.WriteLine("Enter the course code:");
            string courseCode = Console.ReadLine();

            Console.WriteLine("Enter the course title:");
            string courseTitle = Console.ReadLine();

            // Création et ajout d'un nouveau cours à la liste.
            Course newCourse = new Course(courseNumber, courseCode, courseTitle);
            courses.Add(newCourse);

            Console.WriteLine($"Course {courseCode} - {courseTitle} added successfully.");
        }
        static void AddGrade(int studentId, int courseId, float note)
        {
            if (!studentGrades.ContainsKey(studentId))
            {
                studentGrades[studentId] = new List<Grade>();
            }
            studentGrades[studentId].Add(new Grade(studentId, courseId, note));
        }
    }

   
}
