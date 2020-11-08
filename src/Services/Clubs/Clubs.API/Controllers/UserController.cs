namespace Clubs.API.Controllers
{
    public class UserController: ApiController
    {
        private readonly ILogger<UserController> _Logger;
        public UserController(ILogger<UserController> logger)
        {
            _Logger = logger;
        }

        #region GET

        /// <summary>
        /// Query all Users
        /// </summary>
        /// <returns>Collection of TODO records</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> Get()
        {
            _Logger.LogInformation($"User: {HelperMethods.GetCallerMemberName()}");
            throw new NotImplementedException();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">unique Guid for a user</param>
        /// <returns>A single user record</returns>
        [HttpGet("{id}", Name = "GetUserById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> GetUserById(Guid id)
        {
            _Logger.LogInformation($"User: {HelperMethods.GetCallerMemberName()}");
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">unique Guid for a user</param>
        /// <returns>A single user record</returns>
        [HttpGet("{id}", Name = "GetUserByObjectId")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> GetUserByObjectId(Guid id)
        {
            _Logger.LogInformation($"User: {HelperMethods.GetCallerMemberName()}");
            throw new NotImplementedException();
        }

        #endregion
    }
}