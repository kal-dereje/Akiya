#pragma checksum "C:\Users\kalab dereje\Desktop\revised\Akiya\Akiya\Views\Buy\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c87151e9120d7db05092c042effe6210da7ffa74"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Buy_index), @"mvc.1.0.view", @"/Views/Buy/index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c87151e9120d7db05092c042effe6210da7ffa74", @"/Views/Buy/index.cshtml")]
    #nullable restore
    public class Views_Buy_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Akiya.Models.Property>>
    #nullable disable
    {
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
#line 2 "C:\Users\kalab dereje\Desktop\revised\Akiya\Akiya\Views\Buy\index.cshtml"
  
    ViewData["Title"] = "index";
    Layout = "~/Views/Shared/_CommonLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"buy-container\">\r\n\r\n");
#nullable restore
#line 9 "C:\Users\kalab dereje\Desktop\revised\Akiya\Akiya\Views\Buy\index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"property\">\r\n            <div class=\"image\">\r\n               ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c87151e9120d7db05092c042effe6210da7ffa743209", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 294, "~/images/propertys/", 294, 19, true);
#nullable restore
#line 13 "C:\Users\kalab dereje\Desktop\revised\Akiya\Akiya\Views\Buy\index.cshtml"
AddHtmlAttributeValue("", 313, item.Image, 313, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <h2>&#36 ");
#nullable restore
#line 15 "C:\Users\kalab dereje\Desktop\revised\Akiya\Akiya\Views\Buy\index.cshtml"
                Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            <p>");
#nullable restore
#line 16 "C:\Users\kalab dereje\Desktop\revised\Akiya\Akiya\Views\Buy\index.cshtml"
          Write(item.Descr);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 16 "C:\Users\kalab dereje\Desktop\revised\Akiya\Akiya\Views\Buy\index.cshtml"
                       Write(item.PropType);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 16 "C:\Users\kalab dereje\Desktop\revised\Akiya\Akiya\Views\Buy\index.cshtml"
                                      Write(item.Purpose);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br> phone number: ");
#nullable restore
#line 16 "C:\Users\kalab dereje\Desktop\revised\Akiya\Akiya\Views\Buy\index.cshtml"
                                                                       Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n        </div>\r\n");
#nullable restore
#line 18 "C:\Users\kalab dereje\Desktop\revised\Akiya\Akiya\Views\Buy\index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 20 "C:\Users\kalab dereje\Desktop\revised\Akiya\Akiya\Views\Buy\index.cshtml"
      if ( !Model.Any() )
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <style>\r\n            .buy-container{\r\n               justify-content:center;\r\n               align-items: center;\r\n            }\r\n        </style>\r\n        <h1>There are no property for now</h1>\r\n");
#nullable restore
#line 29 "C:\Users\kalab dereje\Desktop\revised\Akiya\Akiya\Views\Buy\index.cshtml"
      
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("   \r\n\r\n</div>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Akiya.Models.Property>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
