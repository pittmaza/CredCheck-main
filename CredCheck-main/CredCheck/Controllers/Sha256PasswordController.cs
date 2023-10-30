using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CredCheck.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class Sha256PasswordController : Controller
    {
        private IHttpClientFactory _clientFactory;
        
        public Sha256PasswordController(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        [HttpGet]
        [Route("GetLeakedSha256Passwords")]
        public async Task<IActionResult> GetLeakedSha256Passwords()
        {
            
            try
            {
                var client = _clientFactory.CreateClient();
                client.BaseAddress = new Uri("https://api.pwnedpasswords.com/range/12345");

                //GET Request to API
                HttpResponseMessage response = await client.GetAsync("");

                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    return View("Sha256Password", content);
                }
                else
                {
                    return StatusCode((int)response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                return BadRequest("An error occurred: " + ex.Message);
            }
        }


    }

}

