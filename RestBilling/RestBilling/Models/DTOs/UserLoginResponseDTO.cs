namespace ApiRestBilling.Models.DTOs
{
    public class UserLoginResponseDTO
    {
        public required UserdatosDTO User { get; set; }
        public string Token { get; set; }
    }
}