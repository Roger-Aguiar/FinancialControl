namespace FinancialControl.FinancialControl.Models
{
    public class RegisterModel
    {
        public int IdRegister {get; set;}
        public string? RegisterDate {get; set;}
        public decimal Value {get; set;}
        public string? Description {get; set;}
        public int IdCategory {get; set;}
    }
}