namespace SportsManagement.Models
{
    public class SportsPersonViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AssociatedSports { get; set; }
        public int PlayingProfessionallySince { get; set; }
        public string GravatarUrl { get; set; }
        public bool IsActive { get; set; }
        public string FullName
        {
            get
            {
                return $"{FirstName}{" "}{LastName}";
            }
        }
    }
}
