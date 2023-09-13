using Microsoft.AspNetCore.Mvc;
using VilarITELEC1C.Models;

namespace VilarITELEC1C.Controllers
{
    public class InstructorController : Controller
    {
        List<Instructor> InstructorList = new List<Instructor>
            {
                new Instructor()
                {
                    Id= 1,FirstName = "Gabriel",LastName = "Montano", Rank = Rank.Instructor, HiringDate = DateTime.Parse("2022-08-26"), IsTenured = "Yes"
                },
                new Instructor()
                {
                    Id= 2,FirstName = "Zyx",LastName = "Montano", Rank = Rank.AssistantProf, HiringDate = DateTime.Parse("2022-08-07"), IsTenured = "No"
                },
                new Instructor()
                {
                    Id= 3,FirstName = "Aerdriel",LastName = "Montano", Rank = Rank.Prof, HiringDate = DateTime.Parse("2020-01-25"), IsTenured = "Yes"
                }
            };
        public IActionResult Index()
        {

            return View(InstructorList);
        }

        public IActionResult ShowDetails(int id)
        {
            //Search for the INSTRUCTOR whose id matches the given id
            Instructor? instructor = InstructorList.FirstOrDefault(st => st.Id == id);

            if (instructor != null)//was an instructor found?
                return View(instructor);

            return NotFound();
        }

    }
}
