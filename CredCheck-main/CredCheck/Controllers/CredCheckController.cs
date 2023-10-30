using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace CredCheck.Controllers
{
    public class CredCheckController : Controller
    {

        //
        //GET: /CredCheck/PwndPassword/
        // Requires using System.Text.Encodings.Web;
        public string PwndPassword(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello this is Zach hitting this GET Method");
        }
    }
}
