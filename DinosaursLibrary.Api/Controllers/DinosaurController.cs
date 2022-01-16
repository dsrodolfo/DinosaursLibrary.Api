using DinosaursLibrary.Application.Interfaces;
using DinosaursLibrary.Application.Models.Responses;
using Microsoft.AspNetCore.Mvc;

namespace DinosaursLibrary.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DinosaurController : ControllerBase
    {
        private readonly IDinosaurService _dinosaurService;

        public DinosaurController(IDinosaurService dinosaurService)
        {
            _dinosaurService = dinosaurService;
        }

        [HttpGet]
        [Route("getAll")]
        [ProducesResponseType(typeof(IEnumerable<DinosaurResponse>), StatusCodes.Status200OK)]
        public IActionResult GetAll()
        {
            return Ok(_dinosaurService.GetAllDinosaurs());
        }

        [HttpGet]
        [Route("get/{id}")]
        [ProducesResponseType(typeof(DinosaurResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Get(int id)
        {
            var response = _dinosaurService.GetDinosaur(id);
            IActionResult result = response != null? Ok(response) : NotFound();

            return result;
        }

        //TODO - Implement Post Request
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //TODO - Implement Put Request
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //TODO - Implement Delete Request
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
