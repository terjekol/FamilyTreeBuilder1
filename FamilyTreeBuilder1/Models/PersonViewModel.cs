using System.Collections.Generic;

namespace FamilyTreeBuilder1.Models
{
    public class PersonViewModel
    {
        public Person Person { get; set; }
        public IEnumerable<Person> Children { get; set; }
    }
}
