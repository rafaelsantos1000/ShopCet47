using Microsoft.AspNetCore.Mvc.Rendering;
using ShopCet47.Web.Data.Entities;
using System.Collections;
using System.Collections.Generic;

namespace ShopCet47.Web.Data.Repositories
{
    public interface IProductRepository : IGenericRepository<Product>
    {

        IEnumerable<SelectListItem> GetComboProducts();
    }
}
