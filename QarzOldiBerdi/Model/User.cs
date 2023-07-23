using System.ComponentModel.DataAnnotations.Schema;

namespace QarzOldiBerdi.Model
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private string _personaldata;
        public string PersonalData
        {
            get
            {
                return _personaldata;
            }
            set
            {
                _personaldata = value;
            }
        }
        [InverseProperty("Debtors")]
        public ICollection<UserLoans> Debitor { get; set; }
        [InverseProperty("Creditors")]
        public ICollection<UserLoans> Creditor { get; set; }
    }
}
