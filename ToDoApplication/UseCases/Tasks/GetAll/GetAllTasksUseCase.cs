using ToDo.Communication.Responses;

namespace ToDo.Application.UseCases.Tasks.GetAll;

public class GetAllTasksUseCase
{
	public ResponseAllTasksJson Execute()
	{
		return new ResponseAllTasksJson
		{
			Tasks = new List<ResponseShortTaskJson>
			{
				new ResponseShortTaskJson
				{
					Id = 1,
					Name = "Terminar desafio",
					Description = "Terminar o desafio de lista de tarefas da rocketSeat",
				}
			}
		};
	}
}
