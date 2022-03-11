// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace onlinebookstore.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "/Users/madaleineosmun/code/junior-core/onlinebookstore/onlinebookstore/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/madaleineosmun/code/junior-core/onlinebookstore/onlinebookstore/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/madaleineosmun/code/junior-core/onlinebookstore/onlinebookstore/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/madaleineosmun/code/junior-core/onlinebookstore/onlinebookstore/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/madaleineosmun/code/junior-core/onlinebookstore/onlinebookstore/Pages/Admin/_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/madaleineosmun/code/junior-core/onlinebookstore/onlinebookstore/Pages/Admin/_Imports.razor"
using onlinebookstore.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/checkouts")]
    public partial class Checkouts : OwningComponentBase<ICheckoutRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "/Users/madaleineosmun/code/junior-core/onlinebookstore/onlinebookstore/Pages/Admin/Checkouts.razor"
      

    public ICheckoutRepository repo => Service;

    public IEnumerable<Checkout> AllOrders { get; set; }
    public IEnumerable<Checkout> NotShipped { get; set; }
    public IEnumerable<Checkout> Shipped { get; set; }

    protected async override Task OnInitializedAsync()
    {
        await UpdateData();
    }

    public async Task UpdateData()
    {
        AllOrders = await repo.Checkouts.ToListAsync();
        NotShipped = AllOrders.Where(x => !x.OrderShipped);
        Shipped = AllOrders.Where(x => x.OrderShipped);
    }


    public void ShippingInfo(int id) => UpdateShipping(id, true);
    public void ResetShipping(int id) => UpdateShipping(id, false);


    private void UpdateShipping(int id, bool shipped)
    {
        Checkout c = repo.Checkouts.FirstOrDefault(x => x.CheckoutId == id);
        c.OrderShipped = shipped;
        repo.SaveCheckout(c);
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591