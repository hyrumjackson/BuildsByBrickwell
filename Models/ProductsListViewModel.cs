using BuildsByBrickwell.Models.ViewModels;

namespace BuildsByBrickwell.Models
{
    public class ProductsListViewModel
    {
        public IQueryable<Product> Products { get; set; }
        public PaginationInfo PaginationInfo { get; set; } = new PaginationInfo();
        public string? CurrentProductType { get; set; }
    }
}
