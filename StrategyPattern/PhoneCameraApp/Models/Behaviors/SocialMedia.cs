using System;

namespace PhoneCameraApp.Models.Behaviors
{
    public class SocialMedia : IShareBehavior
    {
        public void Share()
        {
            Console.WriteLine("SocialMedia");
        }
    }
}
