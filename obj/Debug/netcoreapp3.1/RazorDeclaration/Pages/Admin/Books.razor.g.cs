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
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/books")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin")]
    public partial class Books : OwningComponentBase<IOnlineBookstoreRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "/Users/madaleineosmun/code/junior-core/onlinebookstore/onlinebookstore/Pages/Admin/Books.razor"
       

    public IOnlineBookstoreRepository repo => Service;

    public IEnumerable<Book> BookData { get; set; }

    protected async override Task OnInitializedAsync()
    {
        await UpdateData();
    }

    public async Task UpdateData()
    {
        BookData = await repo.Books.ToListAsync();
    }

    public string GetDetailsUrl(long id) => $"/admin/books/details/{id}";

    public string GetEditUrl(long id) => $"/admin/books/edit/{id}";

    public async Task RemoveBook (Book b)
    {
        repo.DeleteProject(b);
        await UpdateData();
    }



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
