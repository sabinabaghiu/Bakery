#pragma checksum "C:\Users\elena\RiderProjects\DNP 1st class\Bakery\Pages\Order.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "130c0e5a417226674b7ca2ecab5f9d4edf626260"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 4 "C:\Users\elena\RiderProjects\DNP 1st class\Bakery\Pages\Order.razor"
using Bakery.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\elena\RiderProjects\DNP 1st class\Bakery\Pages\Order.razor"
using Bakery.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\elena\RiderProjects\DNP 1st class\Bakery\Pages\Order.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Order")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Order/{Id:int}")]
    public partial class Order : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "C:\Users\elena\RiderProjects\DNP 1st class\Bakery\Pages\Order.razor"
       

    [Parameter]
    public int Id { get; set; }

    public Product Product { get; set; }
    
    private ShippingValidationModel shippingValidationModel = new ShippingValidationModel();

    protected override async Task OnInitializedAsync()
    {
        if (Id != 0)
        {
            Product = ProductsService.GetProducts().First(p => p.Id == Id);
        }
    }

    private void HandleInvalidSubmit()
    {
        Console.WriteLine("Invalid");
    }

    private void HandleValidSubmit()
    {
        NavigationManager.NavigateTo("/OrderSuccess");
    }

    private class ShippingValidationModel
    {
        [EmailAddress, Required, Display(Name = "Email Address")]
        public string OrderEmail { get; set; }

        [Required(ErrorMessage = "Please supply a shipping address"), Display(Name = "Shipping Address")]
        public string OrderShipping { get; set; }

        [Display(Name = "Quantity")]
        [Range(1, 10)]
        public int OrderQuantity { get; set; } = 1;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductsService ProductsService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591