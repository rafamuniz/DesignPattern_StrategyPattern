using System;

namespace PhoneCameraApp.Models.Behaviors
{
    public class Email : IShareBehavior
    {
        public void Share()
        {
            Console.WriteLine("Email");
        }
    }
}
