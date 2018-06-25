using ProjectDB.DAL;
using ProjectDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDB
{
    public class ProjectCLI
    {
        const string Command_AllDepartments = "1";
        const string Command_AllEmployees = "2";
        const string Command_EmployeeSearch = "3";
        const string Command_EmployeesWithoutProjects = "4";
        const string Command_ProjectList = "5";
        const string Command_CreateDepartment = "6";
        const string Command_UpdateDepartment = "7";
        const string Command_CreateProject = "8";
        const string Command_AssignEmployeeToProject = "9";
        const string Command_RemoveEmployeeFromProject = "10";
        const string Command_Quit = "q";
        const string DatabaseConnection = "";

        public void RunCLI()
        {
            PrintHeader();
            PrintMenu();

            while (true)
            {
                string command = Console.ReadLine();

                Console.Clear();

                switch (command.ToLower())
                {
                    case Command_AllDepartments:
                        GetAllDepartments();
                        break;

                    case Command_AllEmployees:
                        GetAllEmployees();
                        break;

                    case Command_EmployeeSearch:
                        EmployeeSearch();
                        break;

                    case Command_EmployeesWithoutProjects:
                        GetEmployeesWithoutProjects();
                        break;

                    case Command_ProjectList:
                        GetAllProjects();
                        break;

                    case Command_CreateDepartment:
                        CreateDepartment();
                        break;

                    case Command_UpdateDepartment:
                        UpdateDepartment();
                        break;

                    case Command_CreateProject:
                        CreateProject();
                        break;

                    case Command_AssignEmployeeToProject:
                        AssignEmployeeToProject();
                        break;

                    case Command_RemoveEmployeeFromProject:
                        RemoveEmployeeFromProject();
                        break;

                    case Command_Quit:
                        Console.WriteLine("Thank you for using the project organizer");
                        return;

                    default:
                        Console.WriteLine("The command provided was not a valid command, please try again.");
                        break;

                }

                PrintMenu();
            }
        }

        private void RemoveEmployeeFromProject()
        {
            int projectId = CLIHelper.GetInteger("Which project id is the employee removed from:");
            int employeeId = CLIHelper.GetInteger("Which employee is getting removed:");

            ProjectSqlDAL dal = new ProjectSqlDAL(DatabaseConnection);
            bool result = dal.RemoveEmployeeFromProject(projectId, employeeId);

            if (result)
            {
                Console.WriteLine("*** SUCCESS ***");
            }
            else
            {
                Console.WriteLine("*** DID NOT CREATE ***");
            }

        }

        private void AssignEmployeeToProject()
        {
            int projectId = CLIHelper.GetInteger("Which project id is the employee assigned to:");
            int employeeId = CLIHelper.GetInteger("Which employee is getting added:");

            ProjectSqlDAL dal = new ProjectSqlDAL(DatabaseConnection);
            bool result = dal.AssignEmployeeToProject(projectId, employeeId);

            if (result)
            {
                Console.WriteLine("*** SUCCESS ***");
            }
            else
            {
                Console.WriteLine("*** DID NOT CREATE ***");
            }
        }

        private void CreateProject()
        {
            string projectName = CLIHelper.GetString("Provide a name for the project:");
            DateTime startDate = CLIHelper.GetDateTime("Provide a start date for the project:");
            DateTime endDate = CLIHelper.GetDateTime("Provide an end date for the project");

            Project newProj = new Project()
            {
                Name = projectName,
                StartDate = startDate,
                EndDate = endDate
            };

            ProjectSqlDAL dal = new ProjectSqlDAL(DatabaseConnection);
            bool result = dal.CreateProject(newProj);

            if (result)
            {
                Console.WriteLine("*** SUCCESS ***");
            }
            else
            {
                Console.WriteLine("*** DID NOT CREATE ***");
            }
        }

        private void UpdateDepartment()
        {
            int departmentId = CLIHelper.GetInteger("Which department are you updating?");
            string updatedName = CLIHelper.GetString("Provide the new name:");
            Department updatedDepartment = new Department
            {
                Id = departmentId,
                Name = updatedName
            };
            DepartmentSqlDAL dal = new DepartmentSqlDAL(DatabaseConnection);
            bool result = dal.UpdateDepartment(updatedDepartment);

            if (result)
            {
                Console.WriteLine("*** SUCCESS ***");
            }
            else
            {
                Console.WriteLine("*** DID NOT UPDATE ***");
            }
        }

        private void CreateDepartment()
        {
            string departmentName = CLIHelper.GetString("Provide a name for the new department:");
            Department newDept = new Department
            {
                Name = departmentName
            };
            DepartmentSqlDAL dal = new DepartmentSqlDAL(DatabaseConnection);

            bool result = dal.CreateDepartment(newDept);

            if (result)
            {
                Console.WriteLine("*** SUCCESS ***");
            }
            else
            {
                Console.WriteLine("*** DID NOT CREATE ***");
            }
        }

        private void GetAllDepartments()
        {
            DepartmentSqlDAL dal = new DepartmentSqlDAL(DatabaseConnection);
            List<Department> departments = dal.GetDepartments();

            if (departments.Count > 0)
            {
                foreach (Department dept in departments)
                {
                    Console.WriteLine(dept.Id.ToString().PadRight(10) + dept.Name.PadRight(40));
                }
            }
            else
            {
                Console.WriteLine("**** NO RESULTS ****");
            }
        }

        private void GetAllEmployees()
        {
            EmployeeSqlDAL dal = new EmployeeSqlDAL(DatabaseConnection);
            List<Employee> employees = dal.GetAllEmployees();

            if (employees.Count > 0)
            {
                foreach (Employee emp in employees)
                {
                    Console.WriteLine(emp.EmployeeId.ToString().PadRight(5) + (emp.LastName + ", " + emp.FirstName).PadRight(30) + emp.JobTitle.PadRight(30) + emp.Gender.PadRight(3) + emp.BirthDate.ToShortDateString().PadRight(10));
                }                
            }
            else
            {
                Console.WriteLine("**** NO RESULTS ****");
            }
        }

        private void EmployeeSearch()
        {
            string firstname = CLIHelper.GetString("Enter the first name:");
            string lastname = CLIHelper.GetString("Enter the last name:");

            EmployeeSqlDAL dal = new EmployeeSqlDAL(DatabaseConnection);
            List<Employee> employees = dal.Search(firstname, lastname);

            if (employees.Count > 0)
            {
                foreach (Employee emp in employees)
                {
                    Console.WriteLine(emp.EmployeeId.ToString().PadRight(5) + (emp.LastName + ", " + emp.FirstName).PadRight(30) + emp.JobTitle.PadRight(30) + emp.Gender.PadRight(3) + emp.BirthDate.ToShortDateString().PadRight(10));
                }
            }
            else
            {
                Console.WriteLine("**** NO RESULTS ****");
            }
        }

        private void GetEmployeesWithoutProjects()
        {
            EmployeeSqlDAL dal = new EmployeeSqlDAL(DatabaseConnection);
            List<Employee> employees = dal.GetEmployeesWithoutProjects();

            if (employees.Count > 0)
            {
                foreach (Employee emp in employees)
                {
                    Console.WriteLine(emp.EmployeeId.ToString().PadRight(5) + (emp.LastName + ", " + emp.FirstName).PadRight(30) + emp.JobTitle.PadRight(30) + emp.Gender.PadRight(3) + emp.BirthDate.ToShortDateString().PadRight(10));
                }
            }
            else
            {
                Console.WriteLine("**** NO RESULTS ****");
            }
        }

        private void GetAllProjects()
        {
            ProjectSqlDAL dal = new ProjectSqlDAL(DatabaseConnection);
            List<Project> projects = dal.GetAllProjects();

            if (projects.Count > 0)
            {
                foreach (Project proj in projects)
                {
                    Console.WriteLine(proj.ProjectId.ToString().PadRight(5) + proj.Name.PadRight(20) + proj.StartDate.ToShortDateString().PadRight(10) + proj.EndDate.ToShortDateString().PadRight(10));
                }
                
            }
            else
            {
                Console.WriteLine("**** NO RESULTS ****");
            }
        }

        private void PrintHeader()
        {
            Console.WriteLine(@" ______                 _                           _____           _           _       _____  ____  ");
            Console.WriteLine(@"|  ____|               | |                         |  __ \         (_)         | |     |  __ \|  _ \ ");
            Console.WriteLine(@"| |__   _ __ ___  _ __ | | ___  _   _  ___  ___    | |__) | __ ___  _  ___  ___| |_    | |  | | |_) |");
            Console.WriteLine(@"|  __| | '_ ` _ \| '_ \| |/ _ \| | | |/ _ \/ _ \   |  ___/ '__/ _ \| |/ _ \/ __| __|   | |  | |  _ < ");
            Console.WriteLine(@"| |____| | | | | | |_) | | (_) | |_| |  __/  __/   | |   | | | (_) | |  __/ (__| |_    | |__| | |_) |");
            Console.WriteLine(@"|______|_| |_| |_| .__/|_|\___/ \__, |\___|\___|   |_|   |_|  \___/| |\___|\___|\__|   |_____/|____/ ");
            Console.WriteLine(@"                 | |             __/ |                            _/ |                               ");
            Console.WriteLine(@"                 |_|            |___/                            |__/                                ");
            Console.WriteLine();
            Console.WriteLine();
        }

        private void PrintMenu()
        {
            Console.WriteLine("Main Menu Please type in a command");
            Console.WriteLine(" 1 - Show all departments");
            Console.WriteLine(" 2 - Show all employees");
            Console.WriteLine(" 3 - Employee search by first and last name");
            Console.WriteLine(" 4 - Get employees without projects");
            Console.WriteLine(" 5 - Get all projects");
            Console.WriteLine(" 6 - Create Department");
            Console.WriteLine(" 7 - Update Department Name");
            Console.WriteLine(" 8 - Create Project");
            Console.WriteLine(" 9 - Assign Employee to Project");
            Console.WriteLine("10 - Remove Employee from Project");

            Console.WriteLine(" Q - Quit");
            Console.WriteLine();

        }

    }
}
