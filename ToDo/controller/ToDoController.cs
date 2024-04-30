using Microsoft.AspNetCore.Mvc;
using ToDo.Communication.Request;
using ToDo.Communication.Responses;
using ToDoApplication.UseCases.Tasks.Register;

namespace ToDo.controller
{
    [Route("api/[controller]")]
    public class ToDoController : Controller
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisterTaskJson), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]

        public IActionResult Register([FromBody] TaskRequestJson request)
        {
            var response = new RegisterTaskUseCase().Execute(request);
            
            return Created(string.Empty, response);
        }
    }
}