using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MvcUser.Models;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using System.Net.Http;
using System.Threading.Tasks;

namespace MvcUser.Controllers
{
    public class LookupController : Controller
    {
        private readonly UserAPISettings _MvcUserAPISettings;

        public LookupController(IOptions<UserAPISettings> options)
        {
            _MvcUserAPISettings = options.Value;
        }

        [Route("/Users")]
        [HttpGet("{filter}")]
        public async Task<IActionResult> Users(string filter)
        {
            Users users = new Users();

            if (string.IsNullOrEmpty(filter))
            {
                ModelState.AddModelError("", "A Surname to search for must be entered.");
                users.UserList = new List<User>();
                return View(users);
            }

            Regex r = new Regex("^[a-z ,.'-]+$", RegexOptions.IgnoreCase); // a valid surname regex
            Match m = r.Match(filter);
            if (!m.Success)
            {
                ModelState.AddModelError("", "An invalid Surname was entered, please only use alphabetic, space, dash, comma, period or apostrophe characters.");
                users.UserList = new List<User>();
                return View(users);
            }

            // typically routing would resolve the URI in the same service but this is a separate service currently embedded in the same project.
            // As a separate service it would need config to determine the API URI.
            string URI = _MvcUserAPISettings.URI + "/Users/" + filter; 

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(URI);

                response.EnsureSuccessStatusCode();

                HttpContent content = response.Content;

                string json = await response.Content.ReadAsStringAsync();

                users.UserList = JsonConvert.DeserializeObject<List<User>>(json);
            }

            if (users.UserList.Count == 0)
            {
                ModelState.AddModelError("", $"No search results for '{filter}'.");
            }

            return View(users);
        }
    }
}