using Domain.Interface;

namespace Domain.Items
{
    public abstract class Item : IDownloadable
    {
        protected string title;
        protected bool isBorrowed = false;

        public string GetTitle(){
            return title;
        }

        public bool GetIsBorrowed(){
            return isBorrowed;
        }
    }
}
