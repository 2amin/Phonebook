using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DomainModel.POCO.Crud
{
    interface ProductCrud
    {
        void Insert(string name, decimal unitprice,  int number,int id);
        List<DomainModel.DTO.EF.Product> Select();
        void Remove(int id);
        void edit(string name, decimal unitprice, int number, int id);
    }
}
