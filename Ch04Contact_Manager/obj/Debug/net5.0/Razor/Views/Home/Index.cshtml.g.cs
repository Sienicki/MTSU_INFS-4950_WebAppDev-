#pragma checksum "C:\Users\justi\OneDrive\Desktop\Spring 2021\INFS 4950-001 WebAppDev\MTSU_INFS-4950_WebAppDev-\Ch04Contact_Manager\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "841348d5eed39642e5a880030250fbb97f654a68"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\justi\OneDrive\Desktop\Spring 2021\INFS 4950-001 WebAppDev\MTSU_INFS-4950_WebAppDev-\Ch04Contact_Manager\Views\_ViewImports.cshtml"
using Ch04ContactManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\justi\OneDrive\Desktop\Spring 2021\INFS 4950-001 WebAppDev\MTSU_INFS-4950_WebAppDev-\Ch04Contact_Manager\Views\_ViewImports.cshtml"
using Ch04ContactManager.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"841348d5eed39642e5a880030250fbb97f654a68", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2da22d5503ae223af5ca07dc712af0d50d46ea7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Contact>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\justi\OneDrive\Desktop\Spring 2021\INFS 4950-001 WebAppDev\MTSU_INFS-4950_WebAppDev-\Ch04Contact_Manager\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<a href=\"/\">Add Contact</a>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th> First Name</th>\r\n            <th>Last Name</th>\r\n            <th>Phone</th>\r\n            <th>Category</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 17 "C:\Users\justi\OneDrive\Desktop\Spring 2021\INFS 4950-001 WebAppDev\MTSU_INFS-4950_WebAppDev-\Ch04Contact_Manager\Views\Home\Index.cshtml"
         foreach (var contact in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\justi\OneDrive\Desktop\Spring 2021\INFS 4950-001 WebAppDev\MTSU_INFS-4950_WebAppDev-\Ch04Contact_Manager\Views\Home\Index.cshtml"
               Write(contact.F_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\justi\OneDrive\Desktop\Spring 2021\INFS 4950-001 WebAppDev\MTSU_INFS-4950_WebAppDev-\Ch04Contact_Manager\Views\Home\Index.cshtml"
               Write(contact.L_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\justi\OneDrive\Desktop\Spring 2021\INFS 4950-001 WebAppDev\MTSU_INFS-4950_WebAppDev-\Ch04Contact_Manager\Views\Home\Index.cshtml"
               Write(contact.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\justi\OneDrive\Desktop\Spring 2021\INFS 4950-001 WebAppDev\MTSU_INFS-4950_WebAppDev-\Ch04Contact_Manager\Views\Home\Index.cshtml"
               Write(contact.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a href=\"/\">Edit</a>\r\n                    <a href=\"/\">Delete</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 29 "C:\Users\justi\OneDrive\Desktop\Spring 2021\INFS 4950-001 WebAppDev\MTSU_INFS-4950_WebAppDev-\Ch04Contact_Manager\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Contact>> Html { get; private set; }
    }
}
#pragma warning restore 1591
