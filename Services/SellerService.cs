﻿using AulasAspNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace AulasAspNetCore.Services
{
    public class SellerService
    {
        private readonly AulasAspNetCoreContext _context;

        public SellerService(AulasAspNetCoreContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}