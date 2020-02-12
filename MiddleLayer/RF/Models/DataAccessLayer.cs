using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RF.Models
{
    public class DataAccessLayer
    {
public class EmployeeDataAccessLayer  
    {  
        RetailContext db = new RetailContext();  
  
        public IEnumerable<Products> GetAllProducts()  
        {  
            try  
            {  
                return db.Products.ToList();  
            }  
            catch  
            {  
                throw;  
            }  
        }  
  
        //To Add new employee record   
        public int AddProducts(Products product)  
        {  
            try  
            {  
                db.Products.Add(product);  
                db.SaveChanges();  
                return 1;  
            }  
            catch  
            {  
                throw;  
            }  
        }  
  
        //To Update the records of a particluar employee  
        public int UpdateProducts(Products product)  
        {  
            try  
            {  
                db.Entry(product).State = EntityState.Modified;  
                db.SaveChanges();  
  
                return 1;  
            }  
            catch  
            {  
                throw;  
            }  
        }  
  
        //Get the details of a particular employee  
        public Products GetProductData(int id)  
        {  
            try  
            {  
                Products product = db.Products.Find(id);  
                return product;  
            }  
            catch  
            {  
                throw;  
            }  
        }  
  
        //To Delete the record of a particular employee  
        public int DeleteProducts(int id)  
        {  
            try  
            {  
                Products emp = db.Products.Find(id);  
                db.Products.Remove(emp);  
                db.SaveChanges();  
                return 1;  
            }  
            catch  
            {  
                throw;  
            }  
        }  
  
        //To Get the list of Cities  
        //public List<TblCities> GetCities()  
        //{  
        //    List<TblCities> lstCity = new List<TblCities>();  
        //    lstCity = (from CityList in db.TblCities select CityList).ToList();  
  
        //    return lstCity;  
        //}  
    }

    }
}
