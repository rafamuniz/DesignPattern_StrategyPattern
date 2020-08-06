using System;

namespace PhoneCameraApp.Models.Behaviors
{
    public class Text : IShareBehavior
    {
        public void Share()
        {
            Console.WriteLine("Text");
        }
    }
}
