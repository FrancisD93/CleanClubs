

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Club.API.Controllers;
using Clubs.Application.Profiles.DTO;
using Clubs.Application.Requests.Member.Commands;
using Clubs.Application.Requests.Member.Queries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Utilities;

namespace Clubs.API.Controllers
{
    public class MemberController : ApiController
    {
        private readonly ILogger<MemberController> _Logger;
        public MemberController(ILogger<MemberController> logger)
        {
            _Logger = logger;
        }

        #region GET

        /// <summary>
        /// Support the querying of all members across the platform
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<MemberListDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IEnumerable<MemberListDTO>> Get()
        {
            _Logger.LogInformation($"Members: {HelperMethods.GetCallerMemberName()}");
            return await Mediator.Send(new GetAllMembersQuery());
        }

        /// <summary>
        /// Query A single member record
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}", Name = "GetMemberById")]
        [ProducesResponseType(typeof(MemberDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> GetMemberById(Guid id)
        {
            _Logger.LogInformation($"Members: {HelperMethods.GetCallerMemberName()}");

            var result = await Mediator.Send(new GetMemberQuery() { Id = id });

            if (result != null)
                return Ok(result);

            return StatusCode(204, "No Record Found");
        }

        /// <summary>
        /// Query All Members of a club
        /// </summary>
        /// <param name="id">Club ID</param>
        /// <returns></returns>
        [HttpGet("{id}", Name = "GetMembersByClubId")]
        [ProducesResponseType(typeof(IEnumerable<MemberDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> GetMembersByClubId(Guid id)
        {
            _Logger.LogInformation($"Members: {HelperMethods.GetCallerMemberName()}");

            var result = await Mediator.Send(new GetClubMembersQuery() { ClubId = id });

            if (result != null)
                return Ok(result);

            return StatusCode(204, "No Record Found");
        }

        #endregion

        #region POST

        /// <summary>
        /// Create a new member - for a respective club
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        // [HttpPost]
        // [ProducesResponseType(typeof(CreateMemberDTO), StatusCodes.Status201Created)]
        // [ProducesResponseType(StatusCodes.Status400BadRequest)]
        // public async Task<IActionResult> Post([FromBody] CreateMemberDTO member)
        // {
        //     _Logger.LogInformation($"Members: {HelperMethods.GetCallerMemberName()}");
        //     if (!ModelState.IsValid)
        //     {
        //         return BadRequest(ModelState);
        //     }
        //     var record = await Mediator.Send(new CreateMemberCommand() { Member = member });
        //     if (record != null)
        //         return CreatedAtRoute("GetMemberById", new { id = record }, member);

        //     return BadRequest("Save failed");
        // }

        #endregion

        #region PUT/UPDATE

        // [HttpPut("{id}")]
        // [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        // [ProducesResponseType(StatusCodes.Status400BadRequest)]
        // public async Task<IActionResult> UpdateMember(Guid id, [FromBody] MemberDTO update)
        // {
        //     _Logger.LogInformation($"Members: {HelperMethods.GetCallerMemberName()}");
        //     if (!ModelState.IsValid)
        //     {
        //         return BadRequest(ModelState);
        //     }

        //     var record = await Mediator.Send(new UpdateMemberCommand() { Member = update });
        //     if (record)
        //         return Ok("Member Updated!");

        //     return BadRequest("Update failed");
        // }

        #endregion
    }
}