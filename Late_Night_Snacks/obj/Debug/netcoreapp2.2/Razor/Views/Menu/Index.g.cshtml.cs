#pragma checksum "C:\Users\theof\lc101\liftoff\Late_Night_Snacks\Late_Night_Snacks\Views\Menu\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77f00391259b8524e3dc5e5c7acb949c34d52741"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Menu_Index), @"mvc.1.0.view", @"/Views/Menu/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Menu/Index.cshtml", typeof(AspNetCore.Views_Menu_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\theof\lc101\liftoff\Late_Night_Snacks\Late_Night_Snacks\Views\_ViewImports.cshtml"
using Late_Night_Snacks;

#line default
#line hidden
#line 2 "C:\Users\theof\lc101\liftoff\Late_Night_Snacks\Late_Night_Snacks\Views\_ViewImports.cshtml"
using Late_Night_Snacks.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77f00391259b8524e3dc5e5c7acb949c34d52741", @"/Views/Menu/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f92cb929d5a457d845567a7fec9ecd70b29da2a", @"/Views/_ViewImports.cshtml")]
    public class Views_Menu_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 180, true);
            WriteLiteral("\r\n\r\n<h1>Menu Items List</h1>\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>Name</th>\r\n        <th>Description</th>\r\n        <th>Price</th>\r\n        <th>Quantity</th>\r\n    </tr>\r\n");
            EndContext();
#line 12 "C:\Users\theof\lc101\liftoff\Late_Night_Snacks\Late_Night_Snacks\Views\Menu\Index.cshtml"
     foreach(MenuItem m in ViewBag.MenuItems)
    {

#line default
#line hidden
            BeginContext(234, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(265, 6, false);
#line 15 "C:\Users\theof\lc101\liftoff\Late_Night_Snacks\Late_Night_Snacks\Views\Menu\Index.cshtml"
           Write(m.Name);

#line default
#line hidden
            EndContext();
            BeginContext(271, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(295, 13, false);
#line 16 "C:\Users\theof\lc101\liftoff\Late_Night_Snacks\Late_Night_Snacks\Views\Menu\Index.cshtml"
           Write(m.Description);

#line default
#line hidden
            EndContext();
            BeginContext(308, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(332, 7, false);
#line 17 "C:\Users\theof\lc101\liftoff\Late_Night_Snacks\Late_Night_Snacks\Views\Menu\Index.cshtml"
           Write(m.Price);

#line default
#line hidden
            EndContext();
            BeginContext(339, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(363, 10, false);
#line 18 "C:\Users\theof\lc101\liftoff\Late_Night_Snacks\Late_Night_Snacks\Views\Menu\Index.cshtml"
           Write(m.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(373, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 20 "C:\Users\theof\lc101\liftoff\Late_Night_Snacks\Late_Night_Snacks\Views\Menu\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(402, 12, true);
            WriteLiteral("</table>\r\n\r\n");
            EndContext();
#line 23 "C:\Users\theof\lc101\liftoff\Late_Night_Snacks\Late_Night_Snacks\Views\Menu\Index.cshtml"
 if(ViewBag.MenuItems.Count == 0)
{

#line default
#line hidden
            BeginContext(452, 32, true);
            WriteLiteral("    <p>NO FOOD FOR YOU!!!!</p>\r\n");
            EndContext();
#line 26 "C:\Users\theof\lc101\liftoff\Late_Night_Snacks\Late_Night_Snacks\Views\Menu\Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
