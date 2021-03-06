using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Clubs.Domain.Common;

namespace Clubs.Domain.Entities
{
    public class Club : AuditableEntity
    {
        [Key]
        public Guid Id { get; private set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        [DefaultValue(true)]
        public bool Active { get; set; } = true;

        public string Creator { get; set; } = "Unknown";

        public ICollection<Member> Members { get; set; }

        /// <summary>
        /// Record of matches played by a club
        /// </summary>
        /// <value></value>
        public ICollection<Match> Matches { get; set; }

        /// <summary>
        /// Identifies in future if the club is private
        /// </summary>
        /// <value></value>
        public bool Private { get; set; } = false;

        /// <summary>
        /// private, parameterless constructor used by EF Core
        /// </summary>
        public Club() { }

        public Club(string name, bool active, bool privateClub, string creator)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException(nameof(name));

            Name = name;
            Active = active;
            Private = privateClub;
            Creator = creator;
        }

        #region Public Setters

        public void AddMember(Member member)
        {

        }

        #endregion
    }
}