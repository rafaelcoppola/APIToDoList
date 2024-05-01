using ToDo.Communication.Request;
using ToDo.Communication.Responses;

namespace ToDoApplication.UseCases.Tasks.Register;

public class RegisterTaskUseCase
{
    public ResponseRegisterTaskJson Execute(TaskRequestJson request)
    {

        return new ResponseRegisterTaskJson
        {
            Id = 1,
            Name = request.Name,
            Description = request.Description,
            Priority = request.Priority,
            Status = request.Status,
            Date = request.Date
        };
    }
}
