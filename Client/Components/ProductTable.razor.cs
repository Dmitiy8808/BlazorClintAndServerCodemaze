using Entities.Models;
using Microsoft.AspNetCore.Components;

namespace Client.Components
{
    partial class ProductTable
    {
        [Parameter]
        public List<Product> Products { get; set; }
    }
}