using PhoneCameraApp.Models;
using System;

namespace PhoneCameraApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var basicCameraApp = new BasicCameraApp();
            basicCameraApp.Share();

            Console.WriteLine();

            var cameraPlusApp = new CameraPlusApp();
            cameraPlusApp.Share();  

            Console.ReadLine();
        }
    }
}
