using System;

namespace Clubs.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Email { get; private set; }
        public bool Active { get; private set; }
        
        /// <summary>
        /// private, parameterless constructor used by EF Core
        /// </summary>
        private User()
        {
            
        }

         #region Setter Methods

         #endregion
    }
}