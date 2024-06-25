using System.Text.Json.Serialization;

namespace EmployeesAPI.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TurnEnum
    {
        MANHA, 
        TARDE, 
        NOITE
    }
}
