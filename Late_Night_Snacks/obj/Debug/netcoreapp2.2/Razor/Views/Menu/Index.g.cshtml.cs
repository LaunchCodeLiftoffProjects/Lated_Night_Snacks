<<<<<<< HEAD
#pragma checksum "C:\Users\theof\lc101\liftoff\Late_Night_Snacks\Late_Night_Snacks\Views\Menu\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ac849ef3e84eb7aa87cae47fa91eb1a68e342dc"
=======
#pragma checksum "C:\Users\theof\lc101\liftoff\Late_Night_Snacks\Late_Night_Snacks\Views\Menu\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77f00391259b8524e3dc5e5c7acb949c34d52741"
>>>>>>> master
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
<<<<<<< HEAD
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ac849ef3e84eb7aa87cae47fa91eb1a68e342dc", @"/Views/Menu/Index.cshtml")]
=======
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77f00391259b8524e3dc5e5c7acb949c34d52741", @"/Views/Menu/Index.cshtml")]
>>>>>>> master
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f92cb929d5a457d845567a7fec9ecd70b29da2a", @"/Views/_ViewImports.cshtml")]
    public class Views_Menu_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
<<<<<<< HEAD
            BeginContext(0, 123, true);
            WriteLiteral("\r\n\r\n<h1>Menu Items List</h1>\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>Item</th>\r\n        <th>Price</th>\r\n    </tr>\r\n");
            EndContext();
#line 10 "C:\Users\theof\lc101\liftoff\Late_Night_Snacks\Late_Night_Snacks\Views\Menu\Index.cshtml"
     foreach(Menu m in ViewBag.menus)
=======
            BeginContext(0, 180, true);
            WriteLiteral("\r\n\r\n<h1>Menu Items List</h1>\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>Name</th>\r\n        <th>Description</th>\r\n        <th>Price</th>\r\n        <th>Quantity</th>\r\n    </tr>\r\n");
            EndContext();
#line 12 "C:\Users\theof\lc101\liftoff\Late_Night_Snacks\Late_Night_Snacks\Views\Menu\Index.cshtml"
     foreach(MenuItem m in ViewBag.MenuItems)
>>>>>>> master
    {

#line default
#line hidden
<<<<<<< HEAD
            BeginContext(169, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(200, 10, false);
#line 13 "C:\Users\theof\lc101\liftoff\Late_Night_Snacks\Late_Night_Snacks\Views\Menu\Index.cshtml"
           Write(m.MenuItem);
=======
            BeginContext(234, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(265, 6, false);
#line 15 "C:\Users\theof\lc101\liftoff\Late_Night_Snacks\Late_Night_Snacks\Views\Menu\Index.cshtml"
           Write(m.Name);
>>>>>>> master

#line default
#line hidden
            EndContext();
<<<<<<< HEAD
            BeginContext(210, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(234, 18, false);
#line 14 "C:\Users\theof\lc101\liftoff\Late_Night_Snacks\Late_Night_Snacks\Views\Menu\Index.cshtml"
           Write(m.Price.ToString());
=======
            BeginContext(271, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(295, 13, false);
#line 16 "C:\Users\theof\lc101\liftoff\Late_Night_Snacks\Late_Night_Snacks\Views\Menu\Index.cshtml"
           Write(m.Description);
>>>>>>> master

#line default
#line hidden
            EndContext();
<<<<<<< HEAD
            BeginContext(252, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 16 "C:\Users\theof\lc101\liftoff\Late_Night_Snacks\Late_Night_Snacks\Views\Menu\Index.cshtml"
=======
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
>>>>>>> master
    }

#line default
#line hidden
<<<<<<< HEAD
            BeginContext(281, 12, true);
            WriteLiteral("</table>\r\n\r\n");
            EndContext();
#line 19 "C:\Users\theof\lc101\liftoff\Late_Night_Snacks\Late_Night_Snacks\Views\Menu\Index.cshtml"
 if(ViewBag.menus.Count == 0)
=======
            BeginContext(402, 12, true);
            WriteLiteral("</table>\r\n\r\n");
            EndContext();
#line 23 "C:\Users\theof\lc101\liftoff\Late_Night_Snacks\Late_Night_Snacks\Views\Menu\Index.cshtml"
 if(ViewBag.MenuItems.Count == 0)
>>>>>>> master
{

#line default
#line hidden
<<<<<<< HEAD
            BeginContext(327, 32, true);
            WriteLiteral("    <p>NO FOOD FOR YOU!!!!</p>\r\n");
            EndContext();
#line 22 "C:\Users\theof\lc101\liftoff\Late_Night_Snacks\Late_Night_Snacks\Views\Menu\Index.cshtml"
=======
            BeginContext(452, 32, true);
            WriteLiteral("    <p>NO FOOD FOR YOU!!!!</p>\r\n");
            EndContext();
#line 26 "C:\Users\theof\lc101\liftoff\Late_Night_Snacks\Late_Night_Snacks\Views\Menu\Index.cshtml"
>>>>>>> master
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
