using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    /// <summary>
    /// MVCPattern Demo
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //fetch student record based on his roll no from the database
            Student model = retriveStudentFromDatabase();

            //Create a view : to write student details on console
            StudentView view = new StudentView();

            StudentController controller = new StudentController(model, view);

            controller.UpdateView();

            //update model data
            controller.SetStudentName("John");

            controller.UpdateView();
        }

        private static Student retriveStudentFromDatabase() => new Student("Robert", 10);
    }
}

// source: https://www.tutorialspoint.com/design_pattern/mvc_pattern.htm