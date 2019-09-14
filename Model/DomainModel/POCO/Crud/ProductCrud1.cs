using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DomainModel.POCO.Crud
{
    interface ProductCrud1
    {
        void Insert(string name, int numberInShopping, int unitprice);
        List<DomainModel.DTO.EF.Product> Select();
        void Remove(int id);
        void edit(string name, int id, int numberInShopping, int unitprice);
       
        void update(int id, int numbrtInShopping);
        
    }
}
