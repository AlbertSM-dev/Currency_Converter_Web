using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;
using RootObject.Models;

namespace Currency_C.Helpers
{
    public class CurrencySelected
    {
        public double CurrrencySelectedTotal(int quantity, double currency)
        {
            return quantity * currency;
        }
    }
}
