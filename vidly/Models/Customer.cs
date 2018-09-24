using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Date of Birth")]   
        [Min18YearsIfAMember]
        public DateTime? BirtDateTime { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipType MembershipType { get; set; }//radi koristenja u viewovima

        [Display (Name = "Membership Types")]
        public byte MembershipTypeId { get; set; }//radi optimizacije ponekad ti je dovoljan fk
    }
}