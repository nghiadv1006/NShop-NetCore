﻿using NShop.Models.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace NShop.Models.Products
{
    public class GetPublicProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}
