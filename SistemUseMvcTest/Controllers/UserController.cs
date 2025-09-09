using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace SistemUseMvcTest.Controllers
{
    public class UserController : Controller
    {
        public async Task<IActionResult> Index()
        {
            using (var cliente = new HttpClient())
            {
                cliente.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/users/");
                cliente.DefaultRequestHeaders.Accept.Clear();
                cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                // HTTP GET
                HttpResponseMessage response = await cliente.GetAsync("");
                if (response.IsSuccessStatusCode)
                {
                    var user = await response.Content.ReadAsStringAsync();///;
                    var responses = JsonConvert.DeserializeObject<List<User>>(user);
                    return View(responses);
                }
            }

            return BadRequest();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Details(int id)
        {
            using (var cliente = new HttpClient())
            {
                cliente.BaseAddress = new Uri($"https://jsonplaceholder.typicode.com/users/{id}");
                cliente.DefaultRequestHeaders.Accept.Clear();
                cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                // HTTP GET
                HttpResponseMessage response = await cliente.GetAsync("");
                if (response.IsSuccessStatusCode)
                {
                    var user = await response.Content.ReadAsStringAsync();///;
                    var responses = JsonConvert.DeserializeObject<User>(user);
                    return View(responses);
                }
            }

            return BadRequest();
        }


    }
}
