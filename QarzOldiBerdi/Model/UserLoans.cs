using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QarzOldiBerdi.Model
{
    public class UserLoans
    {
        [Key]
        public Guid Id { get; set; }

        
        public Guid DebtorId { get; set; }
        public virtual User Debtors { get; set; }

        public Guid CreditorId { get; set; }

        public double Money { get; set; }
        public DateTime TakeDate { get; set; }
        public DateTime ReturnDate { get; set; }


        public virtual User Creditors { get; set; }

    }
}
