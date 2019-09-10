using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeiwModel
{
   public class ProductVeiwModel1
    {
        #region [-Ctor-]
        public ProductVeiwModel1()
        {

        } 
        #endregion
        public Model.DomainModel.POCO.Base.ProductBase1 Ref_ProdctCrud { get; set; }
        #region [-Funection-]
        #region [-Save-]
        public void Save(string name, int numberInShopping, int unitprice)
        {
            Ref_ProdctCrud = new Model.DomainModel.POCO.Base.ProductBase1();

            Ref_ProdctCrud.Insert(name, numberInShopping, unitprice);
        }
        #endregion
        #region [-FillGrid-]
        public dynamic FillGrid()
        {
            Ref_ProdctCrud = new Model.DomainModel.POCO.Base.ProductBase1();

            return Ref_ProdctCrud.Select();
        }
        #endregion
        #region [-Delete-]
        public void Delete(int id)
        {
            Ref_ProdctCrud = new Model.DomainModel.POCO.Base.ProductBase1();
            Ref_ProdctCrud.Remove(id);
        }
        #endregion
        #region [-Edit-]
        public void Edit(string name, int numberInShopping, int unitprice, int id)
        {
            Ref_ProdctCrud = new Model.DomainModel.POCO.Base.ProductBase1();

            Ref_ProdctCrud.edit(name, numberInShopping, unitprice, id);

        }
        #endregion
        #region [-Consider-]
        public int Consider(int id)
        {
            Ref_ProdctCrud = new Model.DomainModel.POCO.Base.ProductBase1();

            return Ref_ProdctCrud.Check(id);

        }
        #endregion
        #region [-Changing-]
        public void Changing(int id, int number)
        {
            Ref_ProdctCrud = new Model.DomainModel.POCO.Base.ProductBase1();

            Ref_ProdctCrud.update(id, number);

        } 
        #endregion
        #endregion
    }
}
