﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeiwModel
{
   public class PersonVeiwModel
    {
        #region [-ctor-]
        public PersonVeiwModel()
        {

        } 
        #endregion
        public Model.DomainModel.POCO.Base.PersonBase1 Ref_PersonCrud { get; set; }
        #region [-Funection-]
        #region [-Save-]
        public void Save(string name, string surname, int username, int password)
        {
            Ref_PersonCrud = new Model.DomainModel.POCO.Base.PersonBase1();

            Ref_PersonCrud.Insert(name, surname, username, password);
        }
        #endregion
        #region [-FillGrid-]
        public dynamic FillGrid()
        {
            Ref_PersonCrud = new Model.DomainModel.POCO.Base.PersonBase1();
            return Ref_PersonCrud.Select();
        }
        #endregion
        #region [-Delete-]
        public void Delete(int id)
        {
            Ref_PersonCrud = new Model.DomainModel.POCO.Base.PersonBase1();
            Ref_PersonCrud.Remove(id);

        }
        #endregion
        #region [-Edit-]
        public void Edit(string name, string surname, int username, int password, int id)
        {
            Ref_PersonCrud = new Model.DomainModel.POCO.Base.PersonBase1();
            Ref_PersonCrud.edit(name, surname, username, password, id);

        }  
        #endregion
        #endregion
    }
}
