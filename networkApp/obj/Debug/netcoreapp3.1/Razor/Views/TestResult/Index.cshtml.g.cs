#pragma checksum "D:\networkApp\networkApp\Views\TestResult\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "409bd253554604e55345f991beef97b7df9b7126"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TestResult_Index), @"mvc.1.0.view", @"/Views/TestResult/Index.cshtml")]
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
#line 1 "D:\networkApp\networkApp\Views\_ViewImports.cshtml"
using networkApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\networkApp\networkApp\Views\_ViewImports.cshtml"
using networkApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\networkApp\networkApp\Views\_ViewImports.cshtml"
using networkApp.ViewModels.TestConstructor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\networkApp\networkApp\Views\_ViewImports.cshtml"
using networkApp.ViewModels.TestResult;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"409bd253554604e55345f991beef97b7df9b7126", @"/Views/TestResult/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7316a8470aab35e9f06cffd6510345aa656d9ce", @"/Views/_ViewImports.cshtml")]
    public class Views_TestResult_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TestResultModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\networkApp\networkApp\Views\TestResult\Index.cshtml"
  
    ViewData["Title"] = "Index";
    bool isRepeat = false;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\networkApp\networkApp\Views\TestResult\Index.cshtml"
 if (Model.Count != 0)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("<table>\r\n    <tr>\r\n        <td>\r\n            ");
#nullable restore
#line 13 "D:\networkApp\networkApp\Views\TestResult\Index.cshtml"
       Write(Model[0].FNpLN);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 16 "D:\networkApp\networkApp\Views\TestResult\Index.cshtml"
       Write(Model[0].Group);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n");
#nullable restore
#line 18 "D:\networkApp\networkApp\Views\TestResult\Index.cshtml"
         foreach (var detail in Model[0].Details)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>\r\n                ");
#nullable restore
#line 21 "D:\networkApp\networkApp\Views\TestResult\Index.cshtml"
           Write(detail.Result);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 24 "D:\networkApp\networkApp\Views\TestResult\Index.cshtml"
           Write(detail.TestName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 27 "D:\networkApp\networkApp\Views\TestResult\Index.cshtml"
           Write(detail.CountAllQuestions);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 30 "D:\networkApp\networkApp\Views\TestResult\Index.cshtml"
           Write(detail.TestDate.ToString("dd:mm:yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n            </td>\r\n");
#nullable restore
#line 32 "D:\networkApp\networkApp\Views\TestResult\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tr>\r\n\r\n");
#nullable restore
#line 36 "D:\networkApp\networkApp\Views\TestResult\Index.cshtml"
     for (int i = 1; i < Model.Count; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n");
#nullable restore
#line 39 "D:\networkApp\networkApp\Views\TestResult\Index.cshtml"
     if (Model[i].FNpLN == Model[i - 1].FNpLN && Model[i].Group == Model[i - 1].Group)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <td></td>\r\n        <td></td>\r\n");
#nullable restore
#line 43 "D:\networkApp\networkApp\Views\TestResult\Index.cshtml"
         foreach (var detail in Model[i].Details)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>\r\n                ");
#nullable restore
#line 46 "D:\networkApp\networkApp\Views\TestResult\Index.cshtml"
           Write(detail.Result);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "D:\networkApp\networkApp\Views\TestResult\Index.cshtml"
           Write(detail.TestName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "D:\networkApp\networkApp\Views\TestResult\Index.cshtml"
           Write(detail.CountAllQuestions);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "D:\networkApp\networkApp\Views\TestResult\Index.cshtml"
           Write(detail.TestDate.ToString("dd:mm:yyyy hh:mm:ss"));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n            </td>\r\n");
#nullable restore
#line 57 "D:\networkApp\networkApp\Views\TestResult\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "D:\networkApp\networkApp\Views\TestResult\Index.cshtml"
         
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <td>\r\n            ");
#nullable restore
#line 62 "D:\networkApp\networkApp\Views\TestResult\Index.cshtml"
       Write(Model[i].FNpLN);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 65 "D:\networkApp\networkApp\Views\TestResult\Index.cshtml"
       Write(Model[i].Group);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n");
#nullable restore
#line 67 "D:\networkApp\networkApp\Views\TestResult\Index.cshtml"
         foreach (var detail in Model[i].Details)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>\r\n                ");
#nullable restore
#line 70 "D:\networkApp\networkApp\Views\TestResult\Index.cshtml"
           Write(detail.Result);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 73 "D:\networkApp\networkApp\Views\TestResult\Index.cshtml"
           Write(detail.TestName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 76 "D:\networkApp\networkApp\Views\TestResult\Index.cshtml"
           Write(detail.CountAllQuestions);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 79 "D:\networkApp\networkApp\Views\TestResult\Index.cshtml"
           Write(detail.TestDate.ToString("dd:mm:yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n            </td>\r\n");
#nullable restore
#line 81 "D:\networkApp\networkApp\Views\TestResult\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "D:\networkApp\networkApp\Views\TestResult\Index.cshtml"
         

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</tr>\r\n");
#nullable restore
#line 85 "D:\networkApp\networkApp\Views\TestResult\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
#nullable restore
#line 87 "D:\networkApp\networkApp\Views\TestResult\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Записи отсутствуют</h1>\r\n");
#nullable restore
#line 91 "D:\networkApp\networkApp\Views\TestResult\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TestResultModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591