using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.DomainModel.DTO.EF;

namespace Model.DomainModel.POCO.Base
{
    public class ProductBase1 : Crud.ProductCrud1
    {
        #region [-Ctor-]
        public ProductBase1()
        {

        }

        
        #endregion
        #region [-edit-]
        public void edit(string name, int id, int numberInShopping, int unitprice)
        {
            using (var Context = new DomainModel.DTO.EF.OnlineShoppingEntities1())
            {
                try
                {
                    var Ref_Product = new DTO.EF.Product();
                    Ref_Product = Context.Product.Find(id);
                    Ref_Product.Name = name;
                    Ref_Product.UnitPrice = unitprice;
                    Ref_Product.NumberInShopping = numberInShopping;
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
        #region [-Inserting Product-]
        public void Insert(string name, int numberInShopping, int unitprice)
        {
            using (var Context = new DomainModel.DTO.EF.OnlineShoppingEntities1())
            {

                try
                {
                    DTO.EF.Product Ref_Product = new DTO.EF.Product();
                    Ref_Product.Name = name;
                    Ref_Product.UnitPrice = unitprice;
                    Ref_Product.NumberInShopping = numberInShopping;
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
        #region [-Remove-]
        public void Remove(int id)
        {
            using (var Context = new DomainModel.DTO.EF.OnlineShoppingEntities1())
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
        #region [-Select-]
        public List<Product> Select()
        {
            using (var Context = new DomainModel.DTO.EF.OnlineShoppingEntities1())
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
        #region [-Check-]
        public int Check(int id)
        {
            using (var Context = new DomainModel.DTO.EF.OnlineShoppingEntities1())
            {
                try
                {
                    var Ref_Product = new Product();
                    Ref_Product = Context.Product.Find(id);
                    return Convert.ToInt32(Ref_Product.NumberInShopping);
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
        #region [-update-]
        public void update(int id, int numbrtInShopping)
        {
            using (var Context = new DomainModel.DTO.EF.OnlineShoppingEntities1())
            {
                try
                {
                    var Ref_Product = new Product();
                    Ref_Product = Context.Product.Find(id);
                    Ref_Product.NumberInShopping = numbrtInShopping;
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
    }
}
