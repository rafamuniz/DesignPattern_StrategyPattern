using System;

namespace PhoneCameraApp.Models.Behaviors
{
    public class WhatsApp : IShareBehavior
    {
        public void Share()
        {
            Console.WriteLine("WhatsApp");
        }
    }
}
