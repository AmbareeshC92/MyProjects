using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GettingStarted.Controllers
{
    public class StudentController
    {
        public IActionResult StudentBio()
        {
            Debug.WriteLine(nameof(StudentBio));
            return new ViewResult() 
            {
                ViewName = nameof(StudentBio)
            };
        }
    }
}
