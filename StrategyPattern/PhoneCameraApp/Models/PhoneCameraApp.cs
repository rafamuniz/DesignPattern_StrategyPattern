using PhoneCameraApp.Models.Behaviors;

namespace PhoneCameraApp.Models
{
    public abstract class PhoneCameraApp
    {
        private IShareBehavior _shareBehavior;

        public void Take()
        {

        }

        public virtual void Edit()
        {

        }

        public void Save()
        {

        }

        protected void SetShare(IShareBehavior shareBehavior)
        {
            this._shareBehavior = shareBehavior;
        }

        public void Share()
        {
            this._shareBehavior.Share();
        }
    }
}
