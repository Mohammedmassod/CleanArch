using CleanArch.Application.Interfaces;
using CleanArch.Application.IServices;
using CleanArch.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNet.OData;
using CleanArch.Domain.IRepositores;
using Microsoft.AspNet.OData.Routing;
using Dapper;

namespace CleanArch.Api.Controllers
{
    public class ContactODataController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactODataController(IContactService contactService)
        {
            _contactService = contactService;
        }
       /* [EnableQuery]
        [HttpGet]
        [ODataRoute]
        public async Task<ActionResult<IEnumerable<Contact>>> Get()
        {
            var contacts = await _contactService.GetAllContacts();

            if (contacts.Success)
            {
                return Ok(contacts.Result);
            }
            else
            {
                return BadRequest(contacts.Message); // أو يمكنك التعامل مع الخطأ بالطريقة المناسبة هنا
            }
        }
*/

        /*[EnableQuery]
        public IActionResult Get(int key)
        {
            var result = _contactService.GetContactById(key);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        public async Task<IActionResult> Post([FromBody] Contact contact)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var apiResponse = await _contactService.AddContact(contact);

            if (apiResponse.Success)
            {
                return CreatedAtAction(nameof(Get), new { key = contact.ContactId }, contact);
            }
            else
            {
                return BadRequest(apiResponse.Message);
            }
        }

        public async Task<IActionResult> Put(int key, [FromBody] Contact contact)
        {
            if (key != contact.ContactId)
            {
                return BadRequest("Invalid contact ID");
            }

            var apiResponse = await _contactService.UpdateContact(contact);

            if (apiResponse.Success)
            {
                return Ok(contact);
            }
            else
            {
                return BadRequest(apiResponse.Message);
            }
        }

        public async Task<IActionResult> Delete(int key)
        {
            var apiResponse = await _contactService.DeleteContact(key);

            if (apiResponse.Success)
            {
                return NoContent();
            }
            else
            {
                return BadRequest(apiResponse.Message);
            }
        }*/
    }
}
