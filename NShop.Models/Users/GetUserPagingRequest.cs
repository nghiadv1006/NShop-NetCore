﻿using NShop.Models.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace NShop.Models.Users
{
    public class GetUserPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
    }
}
