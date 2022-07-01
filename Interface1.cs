using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra_HW_05
{
    public interface ICourseServices
    {
        List<Student> roll();
    }
    public interface IPersonService
    {
        int age();
        int salary();
        List<string> address();

    }
    public interface IIDepartmentService
    {
        string departmentHead();
        int budget();
        List<string> coursesOffered(); 
    }
    public interface IStudentService: IPersonService
    {
        List<String> coursesTaking();
        decimal GPA();
        char grade();
    }
    public interface IInstructorService: IPersonService
    {
        string department();
        bool isDepartmentHead();
        int yearsHired();

    }

}
