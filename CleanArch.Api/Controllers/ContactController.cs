using CleanArch.Application.Interfaces;
using CleanArch.Application.IServices;
using CleanArch.Domain.Entities;
using CleanArch.Logging;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace CleanArch.Api.Controllers
{
    public class ContactController : BaseApiController
    {
        #region ===[ Private Members ]=============================================================
        private readonly IContactService _contactService;


        #endregion

        #region ===[ Constructor ]=================================================================

        /// <summary>
        /// Initialize ContactController by injecting an object type of IUnitOfWork
        /// </summary>
        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        #endregion

        #region ===[ Public Methods ]==============================================================
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            return Ok(await _contactService.GetAllContacts());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(int id)
        {
            var result = await _contactService.GetContactById(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult> Add(Contact contact)
        {
            var apiResponse = await _contactService.AddContact(contact);

            if (apiResponse.Success)
            {
                return Ok(apiResponse.Result);
            }
            else
            {
                return BadRequest(apiResponse.Message);
            }
        }


        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, Contact contact)
        {
            if (id != contact.ContactId)
            {
                return BadRequest("Invalid contact ID");
            }

            var apiResponse = await _contactService.UpdateContact(contact);

            if (apiResponse.Success)
            {
                return Ok(apiResponse.Result);
            }
            else
            {
                return BadRequest(apiResponse.Message);
            }
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var apiResponse = await _contactService.DeleteContact(id);

            if (apiResponse.Success)
            {
                return Ok(apiResponse.Result);
            }
            else
            {
                return BadRequest(apiResponse.Message);
            }
        }

        #endregion
    }
}
