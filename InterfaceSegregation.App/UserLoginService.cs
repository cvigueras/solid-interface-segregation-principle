namespace InterfaceSegregation.App
{
    public class UserLoginService : ILoginService
    {
        public User Login(string userName, string password)
        {
            //Do login
            return new User();
        }
    }
}
