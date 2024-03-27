using Microsoft.AspNetCore.Mvc;

namespace ControllerAttributes.Controllers
{
    [Controller]
    public class Password
    {
        public string CheckPassword()
        {
            return "true";
        }
    }
}
