#pragma checksum "C:\Users\elena\RiderProjects\DNP 1st class\Bakery\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8837454ad3ae89f6d0628b24cbef17b9f073307"
// <auto-generated/>
#pragma warning disable 1591
namespace Bakery.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\elena\RiderProjects\DNP 1st class\Bakery\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\elena\RiderProjects\DNP 1st class\Bakery\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\elena\RiderProjects\DNP 1st class\Bakery\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\elena\RiderProjects\DNP 1st class\Bakery\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\elena\RiderProjects\DNP 1st class\Bakery\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\elena\RiderProjects\DNP 1st class\Bakery\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\elena\RiderProjects\DNP 1st class\Bakery\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\elena\RiderProjects\DNP 1st class\Bakery\_Imports.razor"
using Bakery;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\elena\RiderProjects\DNP 1st class\Bakery\_Imports.razor"
using Bakery.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\elena\RiderProjects\DNP 1st class\Bakery\Pages\Index.razor"
using Bakery.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\elena\RiderProjects\DNP 1st class\Bakery\Pages\Index.razor"
using Bakery.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Welcome to Fourth Coffee!</h1>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "id", "featuredProduct");
            __builder.AddAttribute(3, "class", "row");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-sm-8");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "img");
            __builder.AddAttribute(9, "alt", "Featured Product");
            __builder.AddAttribute(10, "src", "/Images/Products/" + (
#nullable restore
#line 12 "C:\Users\elena\RiderProjects\DNP 1st class\Bakery\Pages\Index.razor"
                                                           FeaturedProduct.ImageName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "class", "img-fluid rounded");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "id", "featuredProductInfo");
            __builder.AddAttribute(16, "class", "col-sm-4");
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "id", "productInfo");
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.OpenElement(21, "h2");
            __builder.AddContent(22, 
#nullable restore
#line 16 "C:\Users\elena\RiderProjects\DNP 1st class\Bakery\Pages\Index.razor"
                 FeaturedProduct.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.OpenElement(24, "p");
            __builder.AddAttribute(25, "class", "price");
            __builder.AddContent(26, "$");
            __builder.AddContent(27, 
#nullable restore
#line 17 "C:\Users\elena\RiderProjects\DNP 1st class\Bakery\Pages\Index.razor"
                               string.Format("{0:f}", @FeaturedProduct.Price)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n            ");
            __builder.OpenElement(29, "p");
            __builder.AddAttribute(30, "class", "description");
            __builder.AddContent(31, 
#nullable restore
#line 18 "C:\Users\elena\RiderProjects\DNP 1st class\Bakery\Pages\Index.razor"
                                    FeaturedProduct.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n        ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "id", "callToAction");
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.OpenElement(37, "a");
            __builder.AddAttribute(38, "href", "order/" + (
#nullable restore
#line 21 "C:\Users\elena\RiderProjects\DNP 1st class\Bakery\Pages\Index.razor"
                            FeaturedProduct.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.AddMarkupContent(40, "<button class=\"btn btn-sm btn-dark order-button float-right\">\r\n                    Order Now\r\n                </button>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "id", "productsWrapper");
            __builder.AddAttribute(47, "class", "row");
            __builder.AddMarkupContent(48, "\r\n");
#nullable restore
#line 31 "C:\Users\elena\RiderProjects\DNP 1st class\Bakery\Pages\Index.razor"
 foreach (var product in Products)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(49, "    ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "col-sm-3");
            __builder.AddMarkupContent(52, "\r\n        ");
            __builder.OpenElement(53, "a");
            __builder.AddAttribute(54, "asp-page", "/order");
            __builder.AddAttribute(55, "asp-route-id", 
#nullable restore
#line 34 "C:\Users\elena\RiderProjects\DNP 1st class\Bakery\Pages\Index.razor"
                                            product.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(56, "title", "Order" + " " + (
#nullable restore
#line 34 "C:\Users\elena\RiderProjects\DNP 1st class\Bakery\Pages\Index.razor"
                                                                      product.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(57, "\r\n            ");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "productInfo");
            __builder.AddMarkupContent(60, "\r\n                ");
            __builder.OpenElement(61, "h3");
            __builder.AddContent(62, 
#nullable restore
#line 36 "C:\Users\elena\RiderProjects\DNP 1st class\Bakery\Pages\Index.razor"
                     product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                ");
            __builder.OpenElement(64, "img");
            __builder.AddAttribute(65, "class", "product-image img-fluid img-thumbnail");
            __builder.AddAttribute(66, "src", "Images/Products/Thumbnails/" + (
#nullable restore
#line 37 "C:\Users\elena\RiderProjects\DNP 1st class\Bakery\Pages\Index.razor"
                                                                                                    product.ImageName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(67, "alt", "Image" + " of" + " " + (
#nullable restore
#line 37 "C:\Users\elena\RiderProjects\DNP 1st class\Bakery\Pages\Index.razor"
                                                                                                                                      product.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n                ");
            __builder.OpenElement(69, "p");
            __builder.AddAttribute(70, "class", "description");
            __builder.AddContent(71, 
#nullable restore
#line 38 "C:\Users\elena\RiderProjects\DNP 1st class\Bakery\Pages\Index.razor"
                                        product.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n        ");
            __builder.OpenElement(75, "div");
            __builder.AddAttribute(76, "class", "action");
            __builder.AddMarkupContent(77, "\r\n            ");
            __builder.OpenElement(78, "p");
            __builder.AddAttribute(79, "class", "price float-left");
            __builder.AddContent(80, "$");
            __builder.AddContent(81, 
#nullable restore
#line 42 "C:\Users\elena\RiderProjects\DNP 1st class\Bakery\Pages\Index.razor"
                                          string.Format("{0:f}", product.Price)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n            ");
            __builder.OpenElement(83, "button");
            __builder.AddAttribute(84, "class", "btn btn-sm btn-dark order-button float-right");
            __builder.AddAttribute(85, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\elena\RiderProjects\DNP 1st class\Bakery\Pages\Index.razor"
                                                                                     () => NavigateToComponent(product)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(86, "\r\n    \t\tOrder Now\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n");
#nullable restore
#line 49 "C:\Users\elena\RiderProjects\DNP 1st class\Bakery\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "C:\Users\elena\RiderProjects\DNP 1st class\Bakery\Pages\Index.razor"
 
    public List<Product> Products { get; set; }
    public Product FeaturedProduct { get; set; }

    protected override async Task OnInitializedAsync()
    {
        Products = (List<Product>) ProductsService.GetProducts();
        FeaturedProduct = Products.ElementAt(new Random().Next(Products.Count));
    }

    private void NavigateToComponent(Product p)
    {
        NavigationManager.NavigateTo("order/" + p.Id);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductsService ProductsService { get; set; }
    }
}
#pragma warning restore 1591
