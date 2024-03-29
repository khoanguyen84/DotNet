﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopingCart.Helper
{
    public static class Helper
    {
        public static string CurrencyFormat(int number)
        {
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            return double.Parse(number.ToString()).ToString("#,###", cul.NumberFormat);
        }
        public enum ActionName
        {
            GetProducts = 1,
            AddToCart = 2,
            ShowCartDetail = 3,
            RemoveCartItem = 4,
            Checkout = 5,
            ShowBill = 6,
            Exit = 7
        }    
    }
}
