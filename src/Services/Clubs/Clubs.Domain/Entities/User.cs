using System;
using Clubs.Domain.Common;

namespace Clubs.Domain.Entities
{
    public class User : AuditableEntity
    {
        public Guid Id { get; set; }
        /// <summary>
        /// External reference id from the authentication provider!
        /// </summary>
        /// <value></value>
        public string ObjectId { get; set; }
        public string DisplayName { get; set; }
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