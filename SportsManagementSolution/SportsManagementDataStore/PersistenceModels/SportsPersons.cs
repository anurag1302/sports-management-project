using System;

namespace SportsManagement.PersistenceModels
{
    public partial class SportsPersons
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AssociatedSports { get; set; }
        public int PlayingProfessionallySince { get; set; }
        public string GravatarUrl { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOnUtc { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
