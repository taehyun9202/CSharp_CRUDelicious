#pragma checksum "C:\Users\TylerN\Coding\CRUD\Views\Home\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ea41c2cc2e00a729e7f0cb7f77a8a1323b3e1c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Show), @"mvc.1.0.view", @"/Views/Home/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Show.cshtml", typeof(AspNetCore.Views_Home_Show))]
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
#line 1 "C:\Users\TylerN\Coding\CRUD\Views\_ViewImports.cshtml"
using CRUD;

#line default
#line hidden
#line 2 "C:\Users\TylerN\Coding\CRUD\Views\_ViewImports.cshtml"
using CRUD.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ea41c2cc2e00a729e7f0cb7f77a8a1323b3e1c0", @"/Views/Home/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"813d028d5e7480ef09b6d196de8cd6b00c3ad294", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Menu>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(13, 33, true);
            WriteLiteral("<div class=\"jumbotron\">\r\n    <h1>");
            EndContext();
            BeginContext(47, 14, false);
#line 3 "C:\Users\TylerN\Coding\CRUD\Views\Home\Show.cshtml"
   Write(Model.ItemName);

#line default
#line hidden
            EndContext();
            BeginContext(61, 14, true);
            WriteLiteral("</h1>\r\n    <p>");
            EndContext();
            BeginContext(76, 14, false);
#line 4 "C:\Users\TylerN\Coding\CRUD\Views\Home\Show.cshtml"
  Write(Model.ChefName);

#line default
#line hidden
            EndContext();
            BeginContext(90, 67, true);
            WriteLiteral("</p>\r\n    <a href=\"/\" class=\"btn btn-primary\">Home</a>\r\n</div>\r\n<p>");
            EndContext();
            BeginContext(158, 17, false);
#line 7 "C:\Users\TylerN\Coding\CRUD\Views\Home\Show.cshtml"
Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(175, 19, true);
            WriteLiteral("</p>\r\n<p>Calories: ");
            EndContext();
            BeginContext(195, 14, false);
#line 8 "C:\Users\TylerN\Coding\CRUD\Views\Home\Show.cshtml"
        Write(Model.Calories);

#line default
#line hidden
            EndContext();
            BeginContext(209, 20, true);
            WriteLiteral("</p>\r\n<p>Tastiness: ");
            EndContext();
            BeginContext(230, 15, false);
#line 9 "C:\Users\TylerN\Coding\CRUD\Views\Home\Show.cshtml"
         Write(Model.Tastiness);

#line default
#line hidden
            EndContext();
            BeginContext(245, 56, true);
            WriteLiteral("</p>\r\n\r\n<a href=\"\" class=\"btn btn-danger\">Delete</a>\r\n<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 301, "\"", 327, 2);
            WriteAttributeValue("", 308, "/edit/", 308, 6, true);
#line 12 "C:\Users\TylerN\Coding\CRUD\Views\Home\Show.cshtml"
WriteAttributeValue("", 314, Model.FoodId, 314, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(328, 32, true);
            WriteLiteral(" class=\"btn btn-info\">Edit</a>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Menu> Html { get; private set; }
    }
}
#pragma warning restore 1591