#pragma checksum "C:\Users\balib\source\repos\CoreLibrary\CoreLibrary\Views\Shared\Components\BlogLast3Post\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0398b438118ca431ee9189d7bde35696248e533"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_BlogLast3Post_Default), @"mvc.1.0.view", @"/Views/Shared/Components/BlogLast3Post/Default.cshtml")]
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
#line 1 "C:\Users\balib\source\repos\CoreLibrary\CoreLibrary\Views\_ViewImports.cshtml"
using CoreLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\balib\source\repos\CoreLibrary\CoreLibrary\Views\_ViewImports.cshtml"
using CoreLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\balib\source\repos\CoreLibrary\CoreLibrary\Views\Shared\Components\BlogLast3Post\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0398b438118ca431ee9189d7bde35696248e533", @"/Views/Shared/Components/BlogLast3Post/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3109cbb06e4322abb9e6b6eadc5b92f61aced30d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_BlogLast3Post_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"tech-btm\">\r\n\t<h3>Son Postlar</h3>\r\n");
#nullable restore
#line 5 "C:\Users\balib\source\repos\CoreLibrary\CoreLibrary\Views\Shared\Components\BlogLast3Post\Default.cshtml"
     foreach (var item in Model)
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<div class=\"blog-grids row mb-3\">\r\n\r\n\t\t\t<div class=\"col-md-5 blog-grid-left\">\r\n\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 217, "\"", 254, 2);
            WriteAttributeValue("", 224, "/Blog/BlogReadAll/", 224, 18, true);
#nullable restore
#line 10 "C:\Users\balib\source\repos\CoreLibrary\CoreLibrary\Views\Shared\Components\BlogLast3Post\Default.cshtml"
WriteAttributeValue("", 242, item.BlogID, 242, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 267, "\"", 288, 1);
#nullable restore
#line 11 "C:\Users\balib\source\repos\CoreLibrary\CoreLibrary\Views\Shared\Components\BlogLast3Post\Default.cshtml"
WriteAttributeValue("", 273, item.BlogImage, 273, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 320, "\"", 326, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t</a>\r\n\t\t\t</div>\r\n\t\t\t<div class=\"col-md-7 blog-grid-right\">\r\n\r\n\t\t\t\t<h5>\r\n\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 413, "\"", 450, 2);
            WriteAttributeValue("", 420, "/Blog/BlogReadAll/", 420, 18, true);
#nullable restore
#line 17 "C:\Users\balib\source\repos\CoreLibrary\CoreLibrary\Views\Shared\Components\BlogLast3Post\Default.cshtml"
WriteAttributeValue("", 438, item.BlogID, 438, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 17 "C:\Users\balib\source\repos\CoreLibrary\CoreLibrary\Views\Shared\Components\BlogLast3Post\Default.cshtml"
                                                        Write(item.BlogContent.Substring(0,item.BlogContent.Substring(0,50).LastIndexOf(" ")));

#line default
#line hidden
#nullable disable
            WriteLiteral("... </a>\r\n\t\t\t\t</h5>\r\n\t\t\t\t<div class=\"sub-meta\">\r\n\t\t\t\t\t<span>\r\n\t\t\t\t\t\t<i class=\"far fa-clock\"></i> ");
#nullable restore
#line 21 "C:\Users\balib\source\repos\CoreLibrary\CoreLibrary\Views\Shared\Components\BlogLast3Post\Default.cshtml"
                                                 Write(((DateTime)item.BlogCreateDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</span>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n");
#nullable restore
#line 26 "C:\Users\balib\source\repos\CoreLibrary\CoreLibrary\Views\Shared\Components\BlogLast3Post\Default.cshtml"
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591