using Assignment__05_OOP.Queetion02;
using Assignment__05_OOP.Question01;
using Assignment__05_OOP.Question03;

namespace Assignment__05_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  Question 01
            Console.WriteLine("=== Q1: Shapes ===");
            IShape circle = new Circle(5);
            IShape rectangle = new Rectangle(4, 6);

            circle.DisplayShapeInfo();
            rectangle.DisplayShapeInfo();
            Console.WriteLine();
            #endregion

            #region Question 02
            Console.WriteLine("=== Q2: Authentication ===");
            IAuthenticationService authService = new BasicAuthenticationService();

            bool isAuthenticated = authService.AuthenticateUser("admin", "1234");
            Console.WriteLine($"Authenticated: {isAuthenticated}");

            bool isAuthorized = authService.AuthorizeUser("admin", "Admin");
            Console.WriteLine($"Authorized: {isAuthorized}");
            Console.WriteLine();
            #endregion

            #region Question 03
            Console.WriteLine("=== Q3: Notifications ===");
            INotificationService emailService = new EmailNotificationService();
            INotificationService smsService = new SmsNotificationService();
            INotificationService pushService = new PushNotificationService();

            emailService.SendNotification("user@example.com", "Welcome to our system!");
            smsService.SendNotification("+20123456789", "Your OTP is 4321");
            pushService.SendNotification("User123", "You have a new message");
            #endregion
        }
    }
}
