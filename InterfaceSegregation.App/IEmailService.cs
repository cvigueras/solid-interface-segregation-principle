namespace InterfaceSegregation.App
{
    public interface IEmailService
    {
        void SendEmail(User user, string message);
    }
}
