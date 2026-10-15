using InterfaceSegregation.App;

ILoginService loginService = new UserLoginService();
IEmailService emailService = new EmailService();

var user = loginService.Login("carlos", "1234");
emailService.SendEmail(user, "Bienvenido de nuevo");
