using ToDo.Communication.Responses;

namespace ToDo.Application.UseCases.Tasks.GetById;

public class GetByIdTaskUseCase
{
	public ResponseTaskJson Execute(int id)
	{
		return new ResponseTaskJson {
			Id = id,
			Name = "Terminar desafio",
			Description = "Terminar o desafio de lista de tarefas da rocketSeat",
			Date = new DateTime(day: 01, month: 05, year: 2024),
			Priority = Communication.Enums.Priority.Alta,
			Status = Communication.Enums.Status.Em_Andamento
		};
	}
}
