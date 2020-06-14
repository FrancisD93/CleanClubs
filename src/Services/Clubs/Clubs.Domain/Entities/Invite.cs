using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Clubs.Domain.Common;

namespace Clubs.Domain.Entities
{    
    public class Invite
    {
        [Key]
        public Guid Id { get; set; }
        public Guid MemberId { get; set; }
        public Member Member { get; set; }
        public string Email { get; set; }
        public bool Accepted { get; set; } = false;
        public DateTime? Date { get; set; }
        public Match Match {get; set; }
        public Guid MatchId { get; set; }
    }
}