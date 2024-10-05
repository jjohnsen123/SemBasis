using Microsoft.AspNetCore.Mvc;
using PersonMVC.Models;
using System.Text;
using System.Text.Json;

namespace PersonMVC.Controllers
{
    public class PersonController : Controller
    {
        private readonly HttpClient _httpClient;

        public PersonController()
        {
            _httpClient = new HttpClient()
            {
                BaseAddress = new Uri("https://localhost:7247/api/person/")
            };
        }

        public async Task<IActionResult> Index()
        {
            var response = await _httpClient.GetAsync("");
            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var persons = JsonSerializer.Deserialize<List<Person>>(jsonString);
                return View (persons);
            }
            return NotFound();
        }

        public async Task<IActionResult> Details(int id)
        {
            var response = await _httpClient.GetAsync(id.ToString());
            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var person = JsonSerializer.Deserialize<Person>(jsonString);
                return View(person);
            }
            return NotFound();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Person p)
        {
            if (ModelState.IsValid)
            {
                var jsonContent = new StringContent(JsonSerializer.Serialize(p), Encoding.UTF8, "application/json");
                var response = await _httpClient.PostAsync("", jsonContent);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }
            return View(p);
        }
    }
}
