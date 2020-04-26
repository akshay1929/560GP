using ClothingStoreData.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace ClothingStoreData.Delegate
{
    class FetchProductQuantityDelegate : NonQueryDataDelegate<Product>
    {
    }
}
