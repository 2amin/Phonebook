using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeiwModel
{
   public class ProductVeiwModel
    {
        public Model.DomainModel.POCO.Base.ProductBase Ref_ProductBase { get; set; }
        public void Save(string name, decimal unitprice, int number, int id)
        {
            Ref_ProductBase = new Model.DomainModel.POCO.Base.ProductBase();

            Ref_ProductBase.Insert(name, unitprice, number, id);
        }
        public dynamic FillGrid()
        {
            Ref_ProductBase = new Model.DomainModel.POCO.Base.ProductBase();
            return Ref_ProductBase.Select();
        }
        public void Delete(int id)
        {
            Ref_ProductBase = new Model.DomainModel.POCO.Base.ProductBase();
            Ref_ProductBase.Remove(id);

        }
        public void Edit(string name, decimal unitprice, int number, int id)
        {
            Ref_ProductBase = new Model.DomainModel.POCO.Base.ProductBase();
            Ref_ProductBase.edit(name, unitprice, number, id);

        }
    }
}
