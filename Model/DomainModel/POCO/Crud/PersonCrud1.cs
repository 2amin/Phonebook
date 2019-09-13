using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DomainModel.POCO.Crud
{
    interface PersonCrud1
    {
        void Insert(string name, string surname, int username, int password, string email);
           
        List<DomainModel.DTO.EF.Person> Select();
        void Remove(int id);
        void edit(string name, string surname, int username, int password, string email, int id);
      
            
    }   
}
