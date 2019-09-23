using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Model.DomainModel.DTO.EF;
using Model.DomainModel.POCO.Crud;
using System.Threading;

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



        #endregion
        #region [-Find-]
        public void Find(int id)
        {
            using (var Context = new DomainModel.DTO.EF.OnlineShoppingEntities1())
            {
                try
                {
                    var Ref_Person = new Person();
                    Ref_Person = Context.Person.Find(id);
                   
                    MemoryStream ms = new MemoryStream();


                    FileStream fs = new FileStream("ser1.txt", FileMode.Create, FileAccess.Write);
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(ms, Ref_Person);

                    ms.Seek(0, SeekOrigin.Begin);

                    

                    int b = ms.ReadByte();
                    while (b != -1)
                    {
                        fs.WriteByte((byte)b);
                        b = ms.ReadByte();
                    }

                    
                    //fs.Close();
                    //ms.Close();



                    //Context.SaveChanges();
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
