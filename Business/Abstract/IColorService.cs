﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        void Add(Color brand);
        void Delete(Color brand);
        void Update(Color brand);
        List<Color> GetAll();
        Color GetById(int id);
    }
}
