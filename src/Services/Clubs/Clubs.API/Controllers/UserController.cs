namespace Clubs.API.Controllers
{
    public class UserController: ApiController
    {
        private readonly ILogger<UserController> _Logger;
        public UserController(ILogger<UserController> logger)
        {
            _Logger = logger;
        }
    }
}