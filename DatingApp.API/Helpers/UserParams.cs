namespace DatingApp.API.Helpers
{
    public class UserParams
    {
        private const int MaxPagePerSize = 50;

        public int PageNumber { get; set; } = 1;

        public int pageSize = 5;

        public int MyPoprerty
        {
            get {return pageSize;}
            set {pageSize = (value > MaxPagePerSize) ? MaxPagePerSize : value ;}
        }


    }
}