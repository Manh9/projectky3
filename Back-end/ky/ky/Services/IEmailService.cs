using ky.Models.Email;
namespace ky.Services
{
    public interface IEmailService
    {
        void SendEmail(EmailModel request);
        void sentOtp(string to, string body);

        
    }
}
