#pragma checksum "C:\Users\Burak\Desktop\EğitimlerVeProjeler\ASP.NET & BTBD\C#Bootcamp\CoreDemo\CoreDemo\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47ebbcbd737581add2cc29ffc5d0c69733f273c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
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
#line 1 "C:\Users\Burak\Desktop\EğitimlerVeProjeler\ASP.NET & BTBD\C#Bootcamp\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Burak\Desktop\EğitimlerVeProjeler\ASP.NET & BTBD\C#Bootcamp\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Burak\Desktop\EğitimlerVeProjeler\ASP.NET & BTBD\C#Bootcamp\CoreDemo\CoreDemo\Views\Employee\Index.cshtml"
using CoreDemo.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47ebbcbd737581add2cc29ffc5d0c69733f273c5", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Class1>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Burak\Desktop\EğitimlerVeProjeler\ASP.NET & BTBD\C#Bootcamp\CoreDemo\CoreDemo\Views\Employee\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<table class=\"table table-bordered\">\r\n        <tr>\r\n            <th>#</th>\r\n            <th>Adı Soyadı</th>\r\n            <th>Sil</th>\r\n            <th>Düzenle</th>\r\n\r\n\r\n        </tr>\r\n\r\n");
#nullable restore
#line 20 "C:\Users\Burak\Desktop\EğitimlerVeProjeler\ASP.NET & BTBD\C#Bootcamp\CoreDemo\CoreDemo\Views\Employee\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("             <tr>\n                 <td>");
#nullable restore
#line 23 "C:\Users\Burak\Desktop\EğitimlerVeProjeler\ASP.NET & BTBD\C#Bootcamp\CoreDemo\CoreDemo\Views\Employee\Index.cshtml"
                Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                 <td>");
#nullable restore
#line 24 "C:\Users\Burak\Desktop\EğitimlerVeProjeler\ASP.NET & BTBD\C#Bootcamp\CoreDemo\CoreDemo\Views\Employee\Index.cshtml"
                Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                 <td><a");
            BeginWriteAttribute("href", " href=\"", 496, "\"", 536, 2);
            WriteAttributeValue("", 503, "/Employee/DeleteEmployee/", 503, 25, true);
#nullable restore
#line 25 "C:\Users\Burak\Desktop\EğitimlerVeProjeler\ASP.NET & BTBD\C#Bootcamp\CoreDemo\CoreDemo\Views\Employee\Index.cshtml"
WriteAttributeValue("", 528, item.ID, 528, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n                 <td><a");
            BeginWriteAttribute("href", " href=\"", 598, "\"", 636, 2);
            WriteAttributeValue("", 605, "/Employee/EditEmployee/", 605, 23, true);
#nullable restore
#line 26 "C:\Users\Burak\Desktop\EğitimlerVeProjeler\ASP.NET & BTBD\C#Bootcamp\CoreDemo\CoreDemo\Views\Employee\Index.cshtml"
WriteAttributeValue("", 628, item.ID, 628, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Düzenle</a></td>\r\n\r\n             </tr>\n");
#nullable restore
#line 29 "C:\Users\Burak\Desktop\EğitimlerVeProjeler\ASP.NET & BTBD\C#Bootcamp\CoreDemo\CoreDemo\Views\Employee\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n\r\n<a href=\"/Employee/AddEmployee/\" class=\"btn btn-outline-primary\">Yeni Çalışan Girişi</a>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Class1>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591