#pragma checksum "C:\Users\NasserBinobied\Documents\Version Control\GitHub\.NetCore-Proof-of-Concept\POCApi\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d9e70186d3110a0179d36fd3b480f6760db1672"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d9e70186d3110a0179d36fd3b480f6760db1672", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<POCWeb.Models.WeatherForecast>>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\NasserBinobied\Documents\Version Control\GitHub\.NetCore-Proof-of-Concept\POCApi\Views\Home\Index.cshtml"
  
    var BaseUrl = @Model.FirstOrDefault().BaseUrl;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d9e70186d3110a0179d36fd3b480f6760db16723077", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n\r\n    <link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=\"", 293, "\"", 349, 2);
#nullable restore
#line 13 "C:\Users\NasserBinobied\Documents\Version Control\GitHub\.NetCore-Proof-of-Concept\POCApi\Views\Home\Index.cshtml"
WriteAttributeValue("", 300, BaseUrl, 300, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 308, "/lib/bootstrap/dist/css/bootstrap.min.css", 308, 41, true);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=\"", 381, "\"", 430, 2);
#nullable restore
#line 14 "C:\Users\NasserBinobied\Documents\Version Control\GitHub\.NetCore-Proof-of-Concept\POCApi\Views\Home\Index.cshtml"
WriteAttributeValue("", 388, BaseUrl, 388, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 396, "/lib/vue/css/bootstrap-vue.min.css", 396, 34, true);
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d9e70186d3110a0179d36fd3b480f6760db16725242", async() => {
                WriteLiteral("\r\n    <div id=\"app\">\r\n        <header>\r\n            <div class=\"container\">\r\n                <img");
                BeginWriteAttribute("src", " src=\"", 548, "\"", 575, 2);
#nullable restore
#line 20 "C:\Users\NasserBinobied\Documents\Version Control\GitHub\.NetCore-Proof-of-Concept\POCApi\Views\Home\Index.cshtml"
WriteAttributeValue("", 554, BaseUrl, 554, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 562, "/img/logo.png", 562, 13, true);
                EndWriteAttribute();
                WriteLiteral(@" class=""img-thumbnail"">
            </div>
        </header>
        <div class=""container"">
            <main role=""main"" class=""pb-3"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <td>
                                Date
                            </td>
                            <td>
                                TemperatureC
                            </td>
                            <td>
                                Summary
                            </td>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 40 "C:\Users\NasserBinobied\Documents\Version Control\GitHub\.NetCore-Proof-of-Concept\POCApi\Views\Home\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 44 "C:\Users\NasserBinobied\Documents\Version Control\GitHub\.NetCore-Proof-of-Concept\POCApi\Views\Home\Index.cshtml"
                               Write(item.Date);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 47 "C:\Users\NasserBinobied\Documents\Version Control\GitHub\.NetCore-Proof-of-Concept\POCApi\Views\Home\Index.cshtml"
                               Write(item.TemperatureC);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 50 "C:\Users\NasserBinobied\Documents\Version Control\GitHub\.NetCore-Proof-of-Concept\POCApi\Views\Home\Index.cshtml"
                               Write(item.Summary);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 53 "C:\Users\NasserBinobied\Documents\Version Control\GitHub\.NetCore-Proof-of-Concept\POCApi\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </tbody>
                </table>
            </main>
        </div>
        <div class=""container"">
            <div id=""qrcode""></div>
        </div>
        <footer class=""border-top footer text-muted"">
            <div class=""container"">
                &copy; 2020 - POCWeb - <a");
                BeginWriteAttribute("asp-area", " asp-area=\"", 2113, "\"", 2124, 0);
                EndWriteAttribute();
                WriteLiteral(" asp-page=\"/Privacy\">Privacy</a>\r\n            </div>\r\n        </footer>\r\n        <p id=\"log\"></p>\r\n    </div>\r\n\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 2249, "\"", 2276, 2);
#nullable restore
#line 69 "C:\Users\NasserBinobied\Documents\Version Control\GitHub\.NetCore-Proof-of-Concept\POCApi\Views\Home\Index.cshtml"
WriteAttributeValue("", 2255, BaseUrl, 2255, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2263, "/js/qrcode.js", 2263, 13, true);
                EndWriteAttribute();
                WriteLiteral(@"></script>

    <script>
            try {
                new QRCode(document.getElementById(""qrcode""), ""http://jindo.dev.naver.com/collie"");

                var c = document.getElementById(""log"");
                c.innerHTML = ""printed"";
            }
            catch (err) {
                var c = document.getElementById(""log"");
                c.innerHTML = ""catch: "" + err.messge;
            }
    </script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<POCWeb.Models.WeatherForecast>> Html { get; private set; }
    }
}
#pragma warning restore 1591
