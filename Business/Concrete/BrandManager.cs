using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public void Add(Brand brand)
        {
            if (brand.BrandName.Length >= 3)
            {
                _brandDal.Add(brand);
                Console.WriteLine(brand.BrandName + " " + "markası eklendi!");
            }
            else
            {
                Console.WriteLine("Lütfen marka adını en az 3 karakter girin!");
            }
        }

        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            Console.WriteLine("Marka Silindi!");
        }

        public List<Brand> GetAll()
        {
            Console.WriteLine("-----------Tüm Markalar-----------");
            return _brandDal.GetAll();
        }

        public List<Brand> GetByBrandId(int brandId)
        {
            return _brandDal.GetAll(b => b.BrandId == brandId);
        }

        public void Update(Brand brand)
        {
            if (brand.BrandName.Length >= 3)
            {
                _brandDal.Update(brand);
                Console.WriteLine(brand.BrandName + " " + "markası güncellendi!");
            }
            else
            {
                Console.WriteLine("Lütfen marka adını en az 3 karakter girin!");
            }
        }


    }
}
