using Microsoft.AspNetCore.Mvc;
using ToDo.Communication.Request;
using ToDo.Communication.Responses;
using ToDo.Application.UseCases.Tasks.Register;
using ToDo.Application.UseCases.Tasks.Update;
using ToDo.Application.UseCases.Tasks.GetById;
using ToDo.Application.UseCases.Tasks.GetAll;
using ToDo.Application.UseCases.Tasks.Delete;

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

		[HttpPut]
		[Route("{id}")]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]

		public IActionResult Update([FromRoute] int id, [FromBody] TaskRequestJson request)
		{
			var response = new UpdateTaskUseCase();

			response.Execute(id, request);

			return NoContent();
		}

		[HttpGet]
		[Route("{id}")]
		[ProducesResponseType(typeof(ResponseTaskJson), StatusCodes.Status200OK)]
		[ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]

		public IActionResult Get([FromRoute] int id)
		{
			var useCase = new GetByIdTaskUseCase();
			var response = useCase.Execute(id);

			return Ok(response);
		}


		[HttpGet]
		[ProducesResponseType(typeof(ResponseAllTasksJson), StatusCodes.Status200OK)]
		[ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]

		public IActionResult GetAll()
		{
			var useCase = new GetAllTasksUseCase();
			var response = useCase.Execute();

			if (response.Tasks.Any())
			{
				return Ok(response);

			}

			return NoContent();
		}

		[HttpDelete]
		[Route("{id}")]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]

		public IActionResult Delete(int id)
		{
			var useCase = new DeleteTaskUseCase();
			useCase.Execute(id);

			return NoContent();
		}
	}
}