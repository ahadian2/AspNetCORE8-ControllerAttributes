using Microsoft.AspNetCore.Mvc;

namespace ControllerAttributes.Controllers
{
    [NonController]
    public class AgeController
    {
        public string TestAge()
        {
            return "test";
        }
    }
}
