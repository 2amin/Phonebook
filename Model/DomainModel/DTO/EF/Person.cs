//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model.DomainModel.DTO.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public Nullable<int> UserName { get; set; }
        public Nullable<int> Password { get; set; }
    

        public static implicit operator Person(List<Person> v)
        {
            throw new NotImplementedException();
        }
    }
}
