using pop_maria_lab7.Models;
using System.Collections;

namespace pop_maria_lab7
{
    internal class ShoppingListDatabase
    {
        private string v;

        public ShoppingListDatabase(string v)
        {
            this.v = v;
        }

        internal Task DeleteProductAsync(Product product)
        {
            throw new NotImplementedException();
        }

        internal Task DeleteShopListAsync(ShopList slist)
        {
            throw new NotImplementedException();
        }

        internal Task<IEnumerable> GetListProductsAsync(int iD)
        {
            throw new NotImplementedException();
        }

        internal Task<IEnumerable> GetProductsAsync()
        {
            throw new NotImplementedException();
        }

        internal Task<IEnumerable> GetShopListsAsync()
        {
            throw new NotImplementedException();
        }

        internal Task SaveListProductAsync(ListProduct lp)
        {
            throw new NotImplementedException();
        }

        internal Task SaveProductAsync(Product product)
        {
            throw new NotImplementedException();
        }

        internal Task SaveShopListAsync(ShopList slist)
        {
            throw new NotImplementedException();
        }
        public Task<int> SaveListProductAsync(ListProduct listp)
        {
            if (listp.ID != 0)
            {
                return database.UpdateAsync(listp);
            }
            else
            {
                return database.InsertAsync(listp);
            }
        }
        public Task<List<Product>> GetListProductsAsync(int shoplistid)
        {
            return _database.QueryAsync<Product>(
            "select P.ID, P.Description from Product P"
            + " inner join ListProduct LP"
            + " on P.ID = LP.ProductID where LP.ShopListID = ?",
            shoplistid);
        }

    }

}