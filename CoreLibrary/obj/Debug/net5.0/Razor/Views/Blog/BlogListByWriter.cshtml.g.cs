#pragma checksum "C:\Users\balib\source\repos\CoreLibrary\CoreLibrary\Views\Blog\BlogListByWriter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7029d69c79ec2514f8a7db2f60d9dfc6f066cfe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogListByWriter), @"mvc.1.0.view", @"/Views/Blog/BlogListByWriter.cshtml")]
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
#line 1 "C:\Users\balib\source\repos\CoreLibrary\CoreLibrary\Views\Blog\BlogListByWriter.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7029d69c79ec2514f8a7db2f60d9dfc6f066cfe", @"/Views/Blog/BlogListByWriter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3109cbb06e4322abb9e6b6eadc5b92f61aced30d", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_BlogListByWriter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\balib\source\repos\CoreLibrary\CoreLibrary\Views\Blog\BlogListByWriter.cshtml"
  
	ViewData["Title"] = "BlogListByWriter";
	Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script src=\"https://unpkg.com/sweetalert/dist/sweetalert.min.js\"></script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7029d69c79ec2514f8a7db2f60d9dfc6f066cfe4045", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<div class=""container-fluid"">
	<div class=""col-lg-12 grid-margin stretch-card"">
		<div class=""card"">
			<div class=""card-body"">
				<h4 class=""card-title"">Yazarın Blogları</h4>
				<br />
				<table class=""table"">
					<tr>
						<th>#</th>
						<th>Blog Baslik</th>
						<th>Blog Tarihi</th>
						<th>Blog Kategori</th>
						<th>Blog Durum</th>
						<th>Sil</th>
						<th>Duzenle</th>
					</tr>
");
#nullable restore
#line 27 "C:\Users\balib\source\repos\CoreLibrary\CoreLibrary\Views\Blog\BlogListByWriter.cshtml"
                     foreach (var item in Model)
					{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t<th>");
#nullable restore
#line 30 "C:\Users\balib\source\repos\CoreLibrary\CoreLibrary\Views\Blog\BlogListByWriter.cshtml"
                           Write(item.BlogID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\t\t\t\t\t\t\t<td>");
#nullable restore
#line 31 "C:\Users\balib\source\repos\CoreLibrary\CoreLibrary\Views\Blog\BlogListByWriter.cshtml"
                           Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t<td>");
#nullable restore
#line 32 "C:\Users\balib\source\repos\CoreLibrary\CoreLibrary\Views\Blog\BlogListByWriter.cshtml"
                            Write(((DateTime)item.BlogCreateDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t<td>");
#nullable restore
#line 33 "C:\Users\balib\source\repos\CoreLibrary\CoreLibrary\Views\Blog\BlogListByWriter.cshtml"
                           Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 34 "C:\Users\balib\source\repos\CoreLibrary\CoreLibrary\Views\Blog\BlogListByWriter.cshtml"
                             if (item.BlogStatus)
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<td><span class=\"badge badge-success\">Aktif</span></td>\r\n");
#nullable restore
#line 37 "C:\Users\balib\source\repos\CoreLibrary\CoreLibrary\Views\Blog\BlogListByWriter.cshtml"
							}
							else
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<td><span class=\"badge badge-danger\">Pasif</span></td>\r\n");
#nullable restore
#line 41 "C:\Users\balib\source\repos\CoreLibrary\CoreLibrary\Views\Blog\BlogListByWriter.cshtml"
							}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t<td><a");
            BeginWriteAttribute("href", " href=\"", 1165, "\"", 1201, 2);
            WriteAttributeValue("", 1172, "/Blog/DeleteBlog/", 1172, 17, true);
#nullable restore
#line 43 "C:\Users\balib\source\repos\CoreLibrary\CoreLibrary\Views\Blog\BlogListByWriter.cshtml"
WriteAttributeValue("", 1189, item.BlogID, 1189, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\" id=\"ask\" style=\"color:black\">Sil</a></td>\r\n\t\t\t\t\t\t\t<td><a");
            BeginWriteAttribute("href", " href=\"", 1282, "\"", 1315, 2);
            WriteAttributeValue("", 1289, "/Blog/GetBLog/", 1289, 14, true);
#nullable restore
#line 44 "C:\Users\balib\source\repos\CoreLibrary\CoreLibrary\Views\Blog\BlogListByWriter.cshtml"
WriteAttributeValue("", 1303, item.BlogID, 1303, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\" style=\"color:black\">Düzenle</a></td>\r\n\t\t\t\t\t\t</tr>\r\n");
#nullable restore
#line 46 "C:\Users\balib\source\repos\CoreLibrary\CoreLibrary\Views\Blog\BlogListByWriter.cshtml"
					}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"				</table>
			</div>
		</div>
		<br />
	</div>
	<a href=""/Blog/AddBlog/"" class=""btn btn-primary"" style=""margin-left:20px"">Yeni Blog Ekle</a>
</div>
<script>
		$('#ask').click(function(){
				swal({
			  title: ""Are you sure?"",
			  text: ""You will not be able to recover this imaginary file!"",
			  type: ""warning"",
			  showCancelButton: true,
			  confirmButtonColor: ""#DD6B55"",
			  confirmButtonText: ""Yes, delete it!"",
			  closeOnConfirm: false
			},
			function(){
			  swal(""Deleted!"", ""Your imaginary file has been deleted."", ""success"");
			});
		)};
</script>");
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
