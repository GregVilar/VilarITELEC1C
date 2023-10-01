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
                    Id= 1,FirstName = "Gabriel",LastName = "Montano", Rank = Rank.Instructor, HiringDate = DateTime.Parse("2022-08-26"), IsTenured = IsTenured.True
                },
                new Instructor()
                {
                    Id= 2,FirstName = "Zyx",LastName = "Montano", Rank = Rank.AssistantProf, HiringDate = DateTime.Parse("2022-08-07"), IsTenured = IsTenured.False
                },
                new Instructor()
                {
                    Id= 3,FirstName = "Aerdriel",LastName = "Montano", Rank = Rank.Prof, HiringDate = DateTime.Parse("2020-01-25"), IsTenured = IsTenured.True
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
        [HttpGet]
        public IActionResult AddInstructor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddInstructor(Instructor newInstructor)
        {
            InstructorList.Add(newInstructor);
            return View("Index", InstructorList);
        }

        [HttpGet]
        public IActionResult UpdateInstructor(int id)
        {
            //Search for the INSTRUCTOR whose id matches the given id
            Instructor? instructor = InstructorList.FirstOrDefault(st => st.Id == id);

            if (instructor != null)//was an instructor found?
                return View(instructor);

            return NotFound();

        }

        [HttpPost]
        public IActionResult UpdateInstructor(Instructor instructorChanges)
        {
            Instructor? instructor = InstructorList.FirstOrDefault(st => st.Id == instructorChanges.Id);

            if (instructor != null)
            {
                instructor.FirstName = instructorChanges.FirstName;
                instructor.LastName = instructorChanges.LastName;
                instructor.IsTenured = instructorChanges.IsTenured;
                instructor.HiringDate = instructorChanges.HiringDate;
                instructor.Rank = instructorChanges.Rank; 
            }
            return View("Index", InstructorList);
        }

        [HttpGet]
        public IActionResult DeleteInstructor(int id)
        {

            Instructor? instructor = InstructorList.FirstOrDefault(inst => inst.Id == id);

            if (instructor != null)//was an instructor found?
                return View(instructor);

            return NotFound();


        }
        [HttpPost]
        public IActionResult DeleteInstructor(Instructor newInstructor)
        {
            Instructor? instructor = InstructorList.FirstOrDefault(inst => inst.Id == newInstructor.Id);
            if (instructor != null)
            {
                InstructorList.Remove(instructor);
            }
            return View("Index", InstructorList);
        }
    }
}