﻿using System;
using Demo.Common;

namespace Demo.Clip04
{
    class BookHandler
    {
        public void Handle(IBook product)
        {
            Size slimCdCase = new Size(
                142 * Length.Millimeter,
                125 * Length.Millimeter,
                5 * Length.Millimeter);

            Size size = product.GetDimensions(slimCdCase);
            Console.WriteLine($"Dealing with {product.GetType().Name} (title: {product.Title}) of size {size}");
        }
    }
}
