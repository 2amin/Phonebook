using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.DomainModel.DTO.EF;
using Model.DomainModel.POCO.Crud;

namespace Model.DomainModel.POCO.Base
{
 public  class ProductBase: Crud.ProductCrud
    {
        #region [-Edit DataBase-]
        

        public void edit(string name, decimal unitprice, int number, int id)
        {
            using (var Context = new DomainModel.DTO.EF.OnlineShoppingEntities())
            {
                try
                {

                    var Ref_Product = new DTO.EF.Product();
                    Ref_Product = Context.Product.Find(id);
                    Ref_Product.Name = name;
                    Ref_Product.Id = id;
                    Ref_Product.UnitPrice = unitprice;
                    Ref_Product.NumberInShopping = number;
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
        #region [-Insert in DataBase-]
        public void Insert(string name, decimal unitprice, int number, int id)
        {
            using (var Context = new DomainModel.DTO.EF.OnlineShoppingEntities())
            {
                try
                {
                    var Ref_Product = new Product();
                    Ref_Product = Context.Product.Find(id);
                    Ref_Product.Name = name;
                    Ref_Product.Id = id;
                    Ref_Product.UnitPrice = unitprice;
                    Ref_Product.NumberInShopping = number;
                    Context.Product.Add(Ref_Product);
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
        #region [-Remove From DataBase-]
        public void Remove(int id)
        {
            using (var Context = new DomainModel.DTO.EF.OnlineShoppingEntities())
            {
                try
                {
                    var Ref_Product = new Product();
                    Ref_Product = Context.Product.Find(id);
                    Context.Product.Remove(Ref_Product);



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
        #region [-Choose All Product From DataBase-]
        public List<Product> Select()
        {
            using (var Context = new OnlineShoppingEntities())
            {
                try
                {
                    var Ref_Product = Context.Product.ToList();
                    return Ref_Product;

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
