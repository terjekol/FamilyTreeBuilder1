using System;
using System.Collections.Generic;

namespace FamilyTreeBuilder1.ModelsGenerated
{
    public partial class Person
    {
        public Person()
        {
            InverseFatherNavigation = new HashSet<Person>();
            InverseMotherNavigation = new HashSet<Person>();
        }

        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime? Birthdate { get; set; }
        public DateTime? Deathdate { get; set; }
        public int? Father { get; set; }
        public int? Mother { get; set; }

        public virtual Person FatherNavigation { get; set; }
        public virtual Person MotherNavigation { get; set; }
        public virtual ICollection<Person> InverseFatherNavigation { get; set; }
        public virtual ICollection<Person> InverseMotherNavigation { get; set; }
    }
}
