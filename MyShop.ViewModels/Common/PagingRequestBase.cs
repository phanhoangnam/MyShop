﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyShop.ViewModels.Common
{
    public class PagingRequestBase
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }
}
