﻿using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace Services.CarModel
{
    public interface ICarModelService
    {
        public List<Model> GetModels();
        public bool Delite(int id);
        public bool Update(int id, ModelViewModel model);
    }
}
