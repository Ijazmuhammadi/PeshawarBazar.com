using Clothbazar.Database;
using Clothbazar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeshawarBazar.Services
{
   public class ProductServie
    {
        public Product GetProduct(int ID)
        {
            using (var context = new CBContext())
            {
                return context.Products.Find(ID);
            }
        }

        public List<Product> GetProduct()
        {
            using (var context = new CBContext())
            {
                return context.Products.ToList();
            }
        }

        public void SaveProduct(Product product)
        {
            using(var context=new CBContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }
        public void UpdateProduct(Product product)
        {
            using (var context = new CBContext())
            {
                context.Entry(product).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void DeleteProduct(int ID)
        {
            using (var context = new CBContext())
            {
                var product1 = context.Products.Find(ID);
                context.Products.Remove(product1);
                context.SaveChanges();
            }
        }
    }
}
