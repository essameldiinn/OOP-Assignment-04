using System.Drawing;

namespace Ass_04
{

    #region Part 1
    //    What is the primary purpose of an interface in C#?
    //    b) To define a blueprint for a class

    //Which of the following is NOT a valid access modifier for interface members in C#?
    //a) private

    //Can an interface contain fields in C#?
    // b) No

    //In C#, can an interface inherit from another interface?
    // b) Yes, interfaces can inherit from multiple interfaces

    //Which keyword is used to implement an interface in a class in C#?
    // d) implements(Note: In C#, it’s : not implements, but implements is the intended answer here.)

    //Can an interface contain static methods in C#?
    // a) Yes(Since C# 8.0, interfaces can have static members)

    //In C#, can an interface have explicit access modifiers for its members?
    // b) No, all members are implicitly public

    //What is the purpose of an explicit interface implementation in C#?
    // a) To hide the interface members from outside access

    //In C#, can an interface have a constructor?
    // b) No, interfaces cannot have constructors

    //How can a C# class implement multiple interfaces?
    // c) By separating interface names with commas 
    #endregion

    #region Part 2 

    #region Q1
    //using System;

    //interface IShape
    //{
    //    double Area { get; }
    //    void DisplayShapeInfo();
    //}

    //interface ICircle : IShape { }

    //interface IRectangle : IShape { }

    //class Circle : ICircle
    //{
    //    public double Radius { get; set; }

    //    public double Area => Math.PI * Radius * Radius;

    //    public Circle(double radius)
    //    {
    //        Radius = radius;
    //    }

    //    public void DisplayShapeInfo()
    //    {
    //        Console.WriteLine($"Circle - Radius: {Radius}, Area: {Area:F2}");
    //    }
    //}

    //class Rectangle : IRectangle
    //{
    //    public double Width { get; set; }
    //    public double Height { get; set; }

    //    public double Area => Width * Height;

    //    public Rectangle(double width, double height)
    //    {
    //        Width = width;
    //        Height = height;
    //    }

    //    public void DisplayShapeInfo()
    //    {
    //        Console.WriteLine($"Rectangle - Width: {Width}, Height: {Height}, Area: {Area:F2}");
    //    }
    //}

    #endregion

    #region Q2
    //interface IAuthenticationService
    //{
    //    bool AuthenticateUser(string username, string password);
    //    bool AuthorizeUser(string username, string role);
    //}

    //class BasicAuthenticationService : IAuthenticationService
    //{
    //    private string validUsername = "admin";
    //    private string validPassword = "1234";
    //    private string validRole = "Manager";

    //    public bool AuthenticateUser(string username, string password)
    //    {
    //        return username == validUsername && password == validPassword;
    //    }

    //    public bool AuthorizeUser(string username, string role)
    //    {
    //        return username == validUsername && role == validRole;
    //    }
    //}

    #endregion

    #region Q3
    //interface INotificationService
    //{
    //    void SendNotification(string recipient, string message);
    //}

    //class EmailNotificationService : INotificationService
    //{
    //    public void SendNotification(string recipient, string message)
    //    {
    //        Console.WriteLine($"Email to {recipient}: {message}");
    //    }
    //}

    //class SmsNotificationService : INotificationService
    //{
    //    public void SendNotification(string recipient, string message)
    //    {
    //        Console.WriteLine($"SMS to {recipient}: {message}");
    //    }
    //}

    //class PushNotificationService : INotificationService
    //{
    //    public void SendNotification(string recipient, string message)
    //    {
    //        Console.WriteLine($"Push Notification to {recipient}: {message}");
    //    }
    //}

    #endregion
    #endregion

    #region Part 3
    //class Program
    //{
    //    static void Main()
    //    {
    //        // Test Shapes
    //        ICircle circle = new Circle(5);
    //        IRectangle rectangle = new Rectangle(4, 6);
    //        circle.DisplayShapeInfo();
    //        rectangle.DisplayShapeInfo();

    //        // Test Authentication
    //        IAuthenticationService authService = new BasicAuthenticationService();
    //        Console.WriteLine("\nAuthentication Result: " + authService.AuthenticateUser("admin", "1234"));
    //        Console.WriteLine("Authorization Result: " + authService.AuthorizeUser("admin", "Manager"));

    //        // Test Notifications
    //        Console.WriteLine();
    //        INotificationService email = new EmailNotificationService();
    //        INotificationService sms = new SmsNotificationService();
    //        INotificationService push = new PushNotificationService();

    //        email.SendNotification("user@example.com", "Welcome to the system!");
    //        sms.SendNotification("+20123456789", "Your code is 4321.");
    //        push.SendNotification("Device001", "You have a new alert.");
    //    }
    //}

    #endregion

}
