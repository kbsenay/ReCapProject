using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        public void Add(Color color)
        {
            if (color.ColorName.Length>=3)
            {
                _colorDal.Add(color);
                Console.WriteLine("Yeni renk tonu eklendi!");
            }
        }

        public void Delete(Color color)
        {
            _colorDal.Delete(color);
            Console.WriteLine("Renk tonu listeden kaldırıldı!");
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public List<Color> GetByColorId(int colorId)
        {
            return _colorDal.GetAll(c => c.ColorId == colorId);
        }

        public void Update(Color color)
        {
            if (color.ColorName.Length >= 3)
            {
                _colorDal.Update(color);
                Console.WriteLine("Renk tonu güncellendi!");
            }
        }

       
    }
}
