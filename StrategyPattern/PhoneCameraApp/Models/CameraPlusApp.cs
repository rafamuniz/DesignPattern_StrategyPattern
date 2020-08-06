using PhoneCameraApp.Models.Behaviors;

namespace PhoneCameraApp.Models
{
    public class CameraPlusApp : PhoneCameraApp
    {
        public CameraPlusApp()
        {
            this.SetShare(new SocialMedia());
        }

        public override void Edit()
        {

        }
    }
}
