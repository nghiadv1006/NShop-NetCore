﻿using NShop.Models.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace NShop.Models.Products
{
    public class GetManageProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }

        public string LanguageId { get; set; }

        public int? CategoryId { get; set; }
    }
}
