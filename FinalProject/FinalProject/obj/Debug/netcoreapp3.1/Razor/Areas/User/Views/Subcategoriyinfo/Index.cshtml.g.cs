#pragma checksum "D:\github\Ecommerce-System\FinalProject\FinalProject\Areas\User\Views\Subcategoriyinfo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67aa8bc958f16807785df1637a94f4952f38b016"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Views_Subcategoriyinfo_Index), @"mvc.1.0.view", @"/Areas/User/Views/Subcategoriyinfo/Index.cshtml")]
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
#nullable restore
#line 1 "D:\github\Ecommerce-System\FinalProject\FinalProject\Areas\User\Views\_ViewImports.cshtml"
using FinalProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\github\Ecommerce-System\FinalProject\FinalProject\Areas\User\Views\_ViewImports.cshtml"
using FinalProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67aa8bc958f16807785df1637a94f4952f38b016", @"/Areas/User/Views/Subcategoriyinfo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1cd403b176af46e85ea812cbc8b3a7a1a86d4d8", @"/Areas/User/Views/_ViewImports.cshtml")]
    public class Areas_User_Views_Subcategoriyinfo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IQueryable<FinalProject.Models.mainCategory>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\github\Ecommerce-System\FinalProject\FinalProject\Areas\User\Views\Subcategoriyinfo\Index.cshtml"
   
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "D:\github\Ecommerce-System\FinalProject\FinalProject\Areas\User\Views\Subcategoriyinfo\Index.cshtml"
             foreach (var Maincat in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-4 media-list span4 text-left\">\r\n                    <h5 class=\"tittle-w3layouts-sub mb-3\">");
#nullable restore
#line 9 "D:\github\Ecommerce-System\FinalProject\FinalProject\Areas\User\Views\Subcategoriyinfo\Index.cshtml"
                                                     Write(Maincat.mainCategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <ul>\r\n");
#nullable restore
#line 11 "D:\github\Ecommerce-System\FinalProject\FinalProject\Areas\User\Views\Subcategoriyinfo\Index.cshtml"
                         foreach (var subcat in Maincat.SubCategories.Take(10))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 502, "\"", 591, 1);
#nullable restore
#line 14 "D:\github\Ecommerce-System\FinalProject\FinalProject\Areas\User\Views\Subcategoriyinfo\Index.cshtml"
WriteAttributeValue("", 509, Url.Action("getsubcategoryData","subCategoryData",new {id=subcat.subCategoryId }), 509, 82, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 14 "D:\github\Ecommerce-System\FinalProject\FinalProject\Areas\User\Views\Subcategoriyinfo\Index.cshtml"
                                                                                                                        Write(subcat.subCategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            </li>\r\n");
#nullable restore
#line 16 "D:\github\Ecommerce-System\FinalProject\FinalProject\Areas\User\Views\Subcategoriyinfo\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n\r\n                </div>\r\n");
#nullable restore
#line 20 "D:\github\Ecommerce-System\FinalProject\FinalProject\Areas\User\Views\Subcategoriyinfo\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IQueryable<FinalProject.Models.mainCategory>> Html { get; private set; }
    }
}
#pragma warning restore 1591
