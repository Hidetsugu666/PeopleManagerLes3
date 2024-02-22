using Microsoft.AspNetCore.Mvc;
using PeopleManager.Ui.Mvc.Models;

namespace PeopleManager.Ui.Mvc.Controllers
{
    public class PeopleController : Controller
    {
        public IActionResult Index()
        {
            var people = GetPeople();
            return View(people);
        }

        public IList<Person> GetPeople()
        {
           return new List<Person>
        {
            new Person { FirstName = "John", LastName = "Smith", Email = "john.smith@example.com" },
            new Person { FirstName = "Alice", LastName = "Johnson", Email = "alice.johnson@example.com" },
            new Person { FirstName = "Bob", LastName = "Williams", Email = "bob.williams@example.com" },
            new Person { FirstName = "Emma", LastName = "Jones", Email = "emma.jones@example.com" },
            new Person { FirstName = "Michael", LastName = "Brown", Email = "michael.brown@example.com" },
            new Person { FirstName = "Olivia", LastName = "Garcia", Email = "olivia.garcia@example.com" },
            new Person { FirstName = "William", LastName = "Davis", Email = "william.davis@example.com" },
            new Person { FirstName = "Sophia", LastName = "Rodriguez", Email = "sophia.rodriguez@example.com" },
            new Person { FirstName = "James", LastName = "Martinez", Email = "james.martinez@example.com" },
            new Person { FirstName = "Ava", LastName = "Hernandez", Email = "ava.hernandez@example.com" },
            new Person { FirstName = "Liam", LastName = "Wilson", Email = "liam.wilson@example.com" },
            new Person { FirstName = "Emily", LastName = "Lopez", Email = "emily.lopez@example.com" },
            new Person { FirstName = "Ethan", LastName = "Lee", Email = "ethan.lee@example.com" },
            new Person { FirstName = "Isabella", LastName = "Gonzalez", Email = "isabella.gonzalez@example.com" },
            new Person { FirstName = "Noah", LastName = "Anderson", Email = "noah.anderson@example.com" },
            new Person { FirstName = "Mia", LastName = "Taylor", Email = "mia.taylor@example.com" },
            new Person { FirstName = "Lucas", LastName = "Moore", Email = "lucas.moore@example.com" },
            new Person { FirstName = "Sophie", LastName = "Jackson", Email = "sophie.jackson@example.com" },
            new Person { FirstName = "Benjamin", LastName = "White", Email = "benjamin.white@example.com" },
            new Person { FirstName = "Avery", LastName = "Harris", Email = "avery.harris@example.com" }
        };
        }
    }
}
