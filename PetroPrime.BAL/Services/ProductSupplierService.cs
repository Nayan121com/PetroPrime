﻿using PetroPrime.DAL.Repository;
using PetroPrime.DAL.Repository.InterfaceDefination;
using PetroPrime.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetroPrime.BAL.Services
{
    public class ProductSupplierService
    {
        private IProductSupplierRepository _productSupplierRepository;
        public ProductSupplierService(IProductSupplierRepository productSupplierRepository)
        {
            _productSupplierRepository = productSupplierRepository;
        }

        public void AddProductSupplier(ProductSupplier para)
        {
            _productSupplierRepository.AddProductSupplier(para);
        }

        public List<int> FetchProductSupplier(int productId) { 
            return _productSupplierRepository.FetchProductSupplier(productId);
        }
    }
}
