// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MenuCardapio.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\geremias.bezerra\source\repos\MenuCardapio\MenuCardapio\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\geremias.bezerra\source\repos\MenuCardapio\MenuCardapio\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\geremias.bezerra\source\repos\MenuCardapio\MenuCardapio\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\geremias.bezerra\source\repos\MenuCardapio\MenuCardapio\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\geremias.bezerra\source\repos\MenuCardapio\MenuCardapio\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\geremias.bezerra\source\repos\MenuCardapio\MenuCardapio\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\geremias.bezerra\source\repos\MenuCardapio\MenuCardapio\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\geremias.bezerra\source\repos\MenuCardapio\MenuCardapio\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\geremias.bezerra\source\repos\MenuCardapio\MenuCardapio\_Imports.razor"
using MenuCardapio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\geremias.bezerra\source\repos\MenuCardapio\MenuCardapio\_Imports.razor"
using MenuCardapio.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "C:\Users\geremias.bezerra\source\repos\MenuCardapio\MenuCardapio\Pages\Index.razor"
      
    int cod, qtd;
    double total;

    void CheckTotal()
    {
        if(cod == 1)
        {
            total = qtd * 4.00;
        }else if(cod == 2)
        {
            total = qtd * 4.50;
        }else if(cod == 3)
        {
            total = qtd * 5.00;
        }else if(cod == 4)
        {
            total = qtd * 2.00;
        }else if(cod == 5)
        {
            total = qtd * 1.50;
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
