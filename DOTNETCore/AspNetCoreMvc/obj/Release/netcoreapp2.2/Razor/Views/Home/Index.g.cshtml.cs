#pragma checksum "D:\DOTNETCore\AspNetCoreMvc\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5eb938292d6d83e1edcedce5434cde817460ec5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "D:\DOTNETCore\AspNetCoreMvc\Views\_ViewImports.cshtml"
using AspNetCoreMvc;

#line default
#line hidden
#line 2 "D:\DOTNETCore\AspNetCoreMvc\Views\_ViewImports.cshtml"
using AspNetCoreMvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5eb938292d6d83e1edcedce5434cde817460ec5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"107ceff22abf4b11ff95f6cfb2d555cb8f9938c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("address", "agarwal.rohit993@gmail.com", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("Url", "../Images/redmi7.jpg", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("Fallback_Url", "../Images/redmi7.jpg", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::AspNetCoreMvc.TagHelpers.EmailTagHelper __AspNetCoreMvc_TagHelpers_EmailTagHelper;
        private global::AspNetCoreMvc.TagHelpers.ImageTagHelper __AspNetCoreMvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\DOTNETCore\AspNetCoreMvc\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 187, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n    ");
            EndContext();
            BeginContext(232, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("email", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c5eb938292d6d83e1edcedce5434cde817460ec54457", async() => {
            }
            );
            __AspNetCoreMvc_TagHelpers_EmailTagHelper = CreateTagHelper<global::AspNetCoreMvc.TagHelpers.EmailTagHelper>();
            __tagHelperExecutionContext.Add(__AspNetCoreMvc_TagHelpers_EmailTagHelper);
            __AspNetCoreMvc_TagHelpers_EmailTagHelper.Address = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(277, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(283, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("image", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c5eb938292d6d83e1edcedce5434cde817460ec55664", async() => {
            }
            );
            __AspNetCoreMvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::AspNetCoreMvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__AspNetCoreMvc_TagHelpers_ImageTagHelper);
            __AspNetCoreMvc_TagHelpers_ImageTagHelper.Url = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __AspNetCoreMvc_TagHelpers_ImageTagHelper.Fallback_Url = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(354, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(361, 18, false);
#line 10 "D:\DOTNETCore\AspNetCoreMvc\Views\Home\Index.cshtml"
Write(ViewBag.LodingTime);

#line default
#line hidden
            EndContext();
            BeginContext(379, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 12 "D:\DOTNETCore\AspNetCoreMvc\Views\Home\Index.cshtml"
     foreach(var item in ViewBag.Users)
    {        

#line default
#line hidden
            BeginContext(439, 11, true);
            WriteLiteral("        <p>");
            EndContext();
            BeginContext(451, 8, false);
#line 14 "D:\DOTNETCore\AspNetCoreMvc\Views\Home\Index.cshtml"
      Write(item.Key);

#line default
#line hidden
            EndContext();
            BeginContext(459, 4, true);
            WriteLiteral(" -- ");
            EndContext();
            BeginContext(464, 10, false);
#line 14 "D:\DOTNETCore\AspNetCoreMvc\Views\Home\Index.cshtml"
                   Write(item.Value);

#line default
#line hidden
            EndContext();
            BeginContext(474, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 15 "D:\DOTNETCore\AspNetCoreMvc\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(487, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(492, 14, false);
#line 16 "D:\DOTNETCore\AspNetCoreMvc\Views\Home\Index.cshtml"
Write(ViewBag.Source);

#line default
#line hidden
            EndContext();
            BeginContext(506, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
