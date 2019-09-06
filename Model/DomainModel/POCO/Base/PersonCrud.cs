using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.DomainModel.DTO.EF;

namespace Model.DomainModel.POCO.Base
{
    public class PersonCrud : Crud.Crud
    {
        #region [-Ctor-]
        public PersonCrud()
        {

        }




        #endregion
        #region [-Insert-]
        public void Insert(string name, string surname, int username, int password)
        {
            using (var Context = new DomainModel.DTO.EF.OnlineShoppingEntities4())
            {

                try
                {
                    DTO.EF.Person Ref_Person = new DTO.EF.Person();
                    Ref_Person.FirstName = name;
                    Ref_Person.Surname = surname;
                    Ref_Person.UserName = (username);
                    Ref_Person.Password = (password);
                    Context.Person.Add(Ref_Person);
                    Context.SaveChanges();

                }
                catch (Exception)
                {

                    throw;
                }


                finally
                {
                    if (Context != null)
                    {
                        Context.Dispose();
                    }

                }

            }
        }

        public List<Person> Select()
        {
            using (var Context = new DomainModel.DTO.EF.OnlineShoppingEntities4())
            {
                try
                {
                    var Ref_Person = Context.Person.ToList();
                    return Ref_Person;

                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (Context != null)
                    {
                        Context.Dispose();
                    }
                }
            }
        }
        #endregion
        public void Remove(int id)
        {
            using (var Context = new DomainModel.DTO.EF.OnlineShoppingEntities4())
            {
                try
                {
                    var Ref_Person = new Person();
                    Ref_Person = Context.Person.Find(id);
                    Context.Person.Remove(Ref_Person);
                    

                    
                    Context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if(Context != null)
                    {
                        Context.Dispose();

                    }
                }

            }
        }

        public void edit(string name, string surname, int username, int password, int id)
        {
            using (var Context = new DomainModel.DTO.EF.OnlineShoppingEntities4())
            {
                try
                {
                    var Ref_Person = new DTO.EF.Person();
                    Ref_Person = Context.Person.Find(id);
                    Ref_Person.FirstName = name;
                    Ref_Person.Surname = surname;
                    Ref_Person.UserName = username;
                    Ref_Person.Password = password;
                    Context.SaveChanges();






                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (Context != null)
                    {
                        Context.Dispose();

                    }
                }
            }
        }

        
    }
}
