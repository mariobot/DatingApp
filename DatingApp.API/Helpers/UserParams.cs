namespace DatingApp.API.Helpers
{
    public class UserParams
    {
        private const int MaxPagePerSize = 50;

        public int PageNumber { get; set; } = 1;

        private int pageSize = 5;

        public int PageSize
        {
            get {return pageSize;}
            set {pageSize = (value > MaxPagePerSize) ? MaxPagePerSize : value ;}
        }

        public int UserId { get; set; }

        public string Gender { get; set; }

        public int MinAge { get; set; }

        public int MaxAge { get; set; }


    }
}