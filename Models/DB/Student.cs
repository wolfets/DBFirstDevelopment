using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DBFirstDevelopment.Models.DB
{
    public partial class Student
    {
        [Display(Name = "Id")]
        public Guid Id { get; set; }

        [Display(Name = "Prénom")]
        public string FirstName { get; set; }

        [Display(Name = "Nom")]
        public string LastName { get; set; }

        [Display(Name = "Sexe")]
        public string Gender { get; set; }

        [Display(Name = "Naissance le")]
        public DateTime? DateOfBirth { get; set; }

        [Display(Name = "Date création")]
        public DateTime? DateOfRegistration { get; set; }

        [Display(Name = "Téléphone")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Mail")]
        public string Email { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }
}
