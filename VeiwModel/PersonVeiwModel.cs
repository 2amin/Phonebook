using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeiwModel
{
   public class PersonVeiwModel
    {
        public PersonVeiwModel()
        {
            
        }
        public Model.DomainModel.POCO.Base.PersonBase1 Ref_PersonCrud { get; set; }
        public void Save(string name, string surname, int username, int password)
        {
            Ref_PersonCrud = new Model.DomainModel.POCO.Base.PersonBase1();

            Ref_PersonCrud.Insert(name, surname, username, password);
        }
        public dynamic FillGrid()
        {
            Ref_PersonCrud = new Model.DomainModel.POCO.Base.PersonBase1();
            return Ref_PersonCrud.Select();
        }
        public void Delete(int id)
        {
            Ref_PersonCrud = new Model.DomainModel.POCO.Base.PersonBase1();
            Ref_PersonCrud.Remove(id);
           
        }
        public void Edit(string name, string surname, int username, int password, int id)
        {
            Ref_PersonCrud = new Model.DomainModel.POCO.Base.PersonBase1();
            Ref_PersonCrud.edit(name, surname, username, password, id);

        }
       


    }
}
