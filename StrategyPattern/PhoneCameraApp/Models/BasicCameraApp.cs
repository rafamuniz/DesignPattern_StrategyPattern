using PhoneCameraApp.Models.Behaviors;

namespace PhoneCameraApp.Models
{
    public class BasicCameraApp : PhoneCameraApp
    {
        public BasicCameraApp()
        {
            this.SetShare(new Text());
        }

        public override void Edit()
        {

        }
    }
}
