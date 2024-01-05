using EmployeeMgmtSystem.Models;
namespace Project.Controllers
using Microsoft.AspNetCore.Mvc;
{
    class StudentController : Controller
    {
        public readonly MyDbContext _studentDbContext;
        public StudentController(StudentDbContext studentDbContext) {
                _studentDbContext = studentDbContext;
        }

        [HttpGet]
        public IActionResult ViewStudent(int pg = 1) {
            //Lets assume that we have Student Table.
            List<StudentModel> studentData = _studentDbContext.Student?.ToList();
            //Set page size here.
            const int pageSize = 5;
            if (pg < 1)
            {
                pg = 1;
            }

            //Counting the length of data we have in database.
            int resCount = employeeData.Count();
            //Configuring pager using Pager class inside Models folder.
            var pager = new Pager(resCount, pg, pageSize);
            //We should skip current page.
            int resSkip = (pg - 1) * pageSize;
            //Now skipping the current page, make a list of the data.
            var data = employeeData.Skip(resSkip).Take(pager.PageSize).ToList();
            //Pass pager to razor view through pager.
            ViewBag.Pager = pager;
            //send paginated data to view.
            return View(data);
        }

    }
}