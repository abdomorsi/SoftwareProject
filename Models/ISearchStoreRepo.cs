﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorePackage
{
    interface ISearchStoreRepo
    {
        StoreController searchStoreByName(string storeName);
    }
}
