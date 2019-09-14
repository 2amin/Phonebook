using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.DomainModel.DTO.EF;
using Model.DomainModel.POCO.Crud;

namespace Model.DomainModel.POCO.Base
{
    public class PersonBase1 : PersonCrud1
    {
        #region [-Ctor-]
        public PersonBase1()
        {

        }




        #endregion
        #region [-Insert-]
        public void Insert(string name, string surname, int username, int password,string email)
        {
            using (var Context = new DomainModel.DTO.EF.OnlineShoppingEntities1())
            {

                try
                {
                    DTO.EF.Person Ref_Person = new DTO.EF.Person();
                    Ref_Person.FirstName = name;
                    Ref_Person.Surname = surname;
                    Ref_Person.UserName = (username);
                    Ref_Person.Password = (password);
                    Ref_Person.Email = email;
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


        #endregion
        #region [-Select-]
        public List<Person> Select()
        {
            using (var Context = new DomainModel.DTO.EF.OnlineShoppingEntities1())
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
        #region [-Remove-]
        public void Remove(int id)
        {
            using (var Context = new DomainModel.DTO.EF.OnlineShoppingEntities1())
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
                    if (Context != null)
                    {
                        Context.Dispose();

                    }
                }

            }
        }
        #endregion
        #region [-edit-]
        public void edit(string name, string surname, int username, int password,string email, int id)
        {
            using (var Context = new DomainModel.DTO.EF.OnlineShoppingEntities1())
            {
                try
                {
                    var Ref_Person = new DTO.EF.Person();
                    Ref_Person = Context.Person.Find(id);
                    Ref_Person.FirstName = name;
                    Ref_Person.Surname = surname;
                    Ref_Person.UserName = username;
                    Ref_Person.Password = password;
                    Ref_Person.Email = email;
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

        public List<Person> Check(int id)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region [-Findname-]
        public string Findname(int id)
        {
            using (var Context = new DomainModel.DTO.EF.OnlineShoppingEntities1())
            {
                try
                {
                    var Ref_Person = new Person();
                    Ref_Person = Context.Person.Find(id);
                    return Ref_Person.FirstName;

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
        #region [-Findsurame-]
        public string Findsurame(int id)
        {
            using (var Context = new DomainModel.DTO.EF.OnlineShoppingEntities1())
            {
                try
                {
                    var Ref_Person = new Person();
                    Ref_Person = Context.Person.Find(id);
                    return Ref_Person.Surname;

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
        #region [-Findusername-]
        public string Findusername(int id)
        {
            using (var Context = new DomainModel.DTO.EF.OnlineShoppingEntities1())
            {
                try
                {
                    var Ref_Person = new Person();
                    Ref_Person = Context.Person.Find(id);
                    return Convert.ToString(Ref_Person.UserName);

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
        #region [-Findpassword-]
        public string Findpassword(int id)
        {
            using (var Context = new DomainModel.DTO.EF.OnlineShoppingEntities1())
            {
                try
                {
                    var Ref_Person = new Person();
                    Ref_Person = Context.Person.Find(id);
                    return Convert.ToString(Ref_Person.Password);

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
        #region [-Findemail-]
        public string Findemail(int id)
        {
            using (var Context = new DomainModel.DTO.EF.OnlineShoppingEntities1())
            {
                try
                {
                    var Ref_Person = new Person();
                    Ref_Person = Context.Person.Find(id);
                    return Ref_Person.Email;

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

    }
}
