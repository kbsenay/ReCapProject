﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    { 
        void Add(Brand brand);
        void Update(Brand brand);
        void delete(Brand brand);

        List<Brand> GetAll();
        Brand GetCarsByBrandId(int id);
    }
}
