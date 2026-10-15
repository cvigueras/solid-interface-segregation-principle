namespace InterfaceSegregation.App
{
    public interface ILoginService
    {
        User Login(string userName, string password);
    }
}
