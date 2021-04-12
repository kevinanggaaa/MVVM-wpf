using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;

namespace WpfApp1
{
    class LatihanContext : DbContext
    {   
        public DbSet<ItemPenjualan> DaftarItemPenjualan {
            get; set;
        }
    }
}
