#pragma checksum "D:\ContosoCrafts.Users\ContosoCrafts.Users\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d3ec96e130fd955b8c58c2910bcf9dc6533c203"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ContosoCrafts.Users.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace ContosoCrafts.Users.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\ContosoCrafts.Users\ContosoCrafts.Users\Pages\_ViewImports.cshtml"
using ContosoCrafts.Users;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d3ec96e130fd955b8c58c2910bcf9dc6533c203", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a4c8183518ca095ad364bd79de25d9c3b26b5c1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\ContosoCrafts.Users\ContosoCrafts.Users\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h1>Users </h1>
<table>
    <thead>
        <tr>
            <th>ID</th>
            <th>Name</th>
            <th>Username</th>
            <th>Phone</th>
            <th>Website</th>
            <th>Adddres</th>
            <th>Company</th>

        </tr>
    </thead>
    <tbody>

");
#nullable restore
#line 22 "D:\ContosoCrafts.Users\ContosoCrafts.Users\Pages\Index.cshtml"
         foreach (var item in Model.Users)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 25 "D:\ContosoCrafts.Users\ContosoCrafts.Users\Pages\Index.cshtml"
               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "D:\ContosoCrafts.Users\ContosoCrafts.Users\Pages\Index.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "D:\ContosoCrafts.Users\ContosoCrafts.Users\Pages\Index.cshtml"
               Write(item.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "D:\ContosoCrafts.Users\ContosoCrafts.Users\Pages\Index.cshtml"
               Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "D:\ContosoCrafts.Users\ContosoCrafts.Users\Pages\Index.cshtml"
               Write(item.Website);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
#nullable restore
#line 31 "D:\ContosoCrafts.Users\ContosoCrafts.Users\Pages\Index.cshtml"
               Write(item.address.Street);

#line default
#line hidden
#nullable disable
            WriteLiteral(",   ");
#nullable restore
#line 31 "D:\ContosoCrafts.Users\ContosoCrafts.Users\Pages\Index.cshtml"
                                       Write(item.address.Suite);

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n                    ");
#nullable restore
#line 32 "D:\ContosoCrafts.Users\ContosoCrafts.Users\Pages\Index.cshtml"
               Write(item.address.City);

#line default
#line hidden
#nullable disable
            WriteLiteral(",   ");
#nullable restore
#line 32 "D:\ContosoCrafts.Users\ContosoCrafts.Users\Pages\Index.cshtml"
                                     Write(item.address.Zipcode);

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n                    ");
#nullable restore
#line 33 "D:\ContosoCrafts.Users\ContosoCrafts.Users\Pages\Index.cshtml"
               Write(item.address.geo.Lat);

#line default
#line hidden
#nullable disable
            WriteLiteral(",  ");
#nullable restore
#line 33 "D:\ContosoCrafts.Users\ContosoCrafts.Users\Pages\Index.cshtml"
                                       Write(item.address.geo.Lat);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 36 "D:\ContosoCrafts.Users\ContosoCrafts.Users\Pages\Index.cshtml"
               Write(item.company.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <br />\r\n                    ");
#nullable restore
#line 38 "D:\ContosoCrafts.Users\ContosoCrafts.Users\Pages\Index.cshtml"
               Write(item.company.CatchPhrase);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <br />\r\n                    ");
#nullable restore
#line 40 "D:\ContosoCrafts.Users\ContosoCrafts.Users\Pages\Index.cshtml"
               Write(item.company.Bs);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 43 "D:\ContosoCrafts.Users\ContosoCrafts.Users\Pages\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
