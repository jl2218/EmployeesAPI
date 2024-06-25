using System.Text.Json.Serialization;

namespace EmployeesAPI.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DepartmentEnum
    {
        RH, 
        FINANCEIRO, 
        COMPRAS,
        ATENDIMENTO,
        ZELADORIA
    }
}
