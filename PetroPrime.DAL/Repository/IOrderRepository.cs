﻿using PetroPrime.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetroPrime.DAL.Repository
{
    public interface IOrderRepository
    {
        void AddOrderDetails(Orders OrderInfo);

    }
}
