#pragma checksum "C:\Users\balib\source\repos\NetCoreBlogProject\NetCoreBlogProject\CoreLibrary\Views\Shared\Components\CategoryList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3c13f11a0a4e02c7824b395f8d8d4d194c806ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CategoryList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CategoryList/Default.cshtml")]
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
#line 1 "C:\Users\balib\source\repos\NetCoreBlogProject\NetCoreBlogProject\CoreLibrary\Views\_ViewImports.cshtml"
using CoreLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\balib\source\repos\NetCoreBlogProject\NetCoreBlogProject\CoreLibrary\Views\_ViewImports.cshtml"
using CoreLibrary.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3c13f11a0a4e02c7824b395f8d8d4d194c806ae", @"/Views/Shared/Components/CategoryList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3109cbb06e4322abb9e6b6eadc5b92f61aced30d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_CategoryList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Category>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"tech-btm\">\r\n\t<h4>Kategoriler</h4>\r\n\r\n\t<ul class=\"list-group single\">\r\n");
#nullable restore
#line 7 "C:\Users\balib\source\repos\NetCoreBlogProject\NetCoreBlogProject\CoreLibrary\Views\Shared\Components\CategoryList\Default.cshtml"
         foreach (var item in Model)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<li class=\"list-group-item d-flex justify-content-between align-items-center\">\r\n\t\t\t\t");
#nullable restore
#line 10 "C:\Users\balib\source\repos\NetCoreBlogProject\NetCoreBlogProject\CoreLibrary\Views\Shared\Components\CategoryList\Default.cshtml"
           Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t<span class=\"badge badge-primary badge-pill\">0</span>\r\n\t\t\t</li>\r\n");
#nullable restore
#line 13 "C:\Users\balib\source\repos\NetCoreBlogProject\NetCoreBlogProject\CoreLibrary\Views\Shared\Components\CategoryList\Default.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</ul>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concrete.Category>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
