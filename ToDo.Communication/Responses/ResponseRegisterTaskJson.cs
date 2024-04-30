using ToDo.Communication.Enums;

namespace ToDo.Communication.Responses;

public class ResponseRegisterTaskJson
{
    public int Id {get; set;}
    
    public string Name {get; set;} = String.Empty;

    public string Description {get; set;} = String.Empty;

    public Priority Priority {get; set;}

    public DateTime Date {get; set;}

    public Status Status {get; set;}
}
