#pragma checksum "D:\Programming\С#\Projects\Course Alexey\networkApp\networkApp\Views\Question\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be246d8d70872f6c908391c373ce8b19c8280f52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Question_Index), @"mvc.1.0.view", @"/Views/Question/Index.cshtml")]
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
#line 1 "D:\Programming\С#\Projects\Course Alexey\networkApp\networkApp\Views\_ViewImports.cshtml"
using networkApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Programming\С#\Projects\Course Alexey\networkApp\networkApp\Views\_ViewImports.cshtml"
using networkApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be246d8d70872f6c908391c373ce8b19c8280f52", @"/Views/Question/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0719e64f774388262f9a66233f7a7fa2a018a87", @"/Views/_ViewImports.cshtml")]
    public class Views_Question_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<networkApp.ViewModels.Question>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Programming\С#\Projects\Course Alexey\networkApp\networkApp\Views\Question\Index.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>В списке ");
#nullable restore
#line 6 "D:\Programming\С#\Projects\Course Alexey\networkApp\networkApp\Views\Question\Index.cshtml"
        Write(Model.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" элемента</h3>\r\n\r\n");
#nullable restore
#line 8 "D:\Programming\С#\Projects\Course Alexey\networkApp\networkApp\Views\Question\Index.cshtml"
 foreach (var questions in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 10 "D:\Programming\С#\Projects\Course Alexey\networkApp\networkApp\Views\Question\Index.cshtml"
  Write(questions.NumQuestion);

#line default
#line hidden
#nullable disable
            WriteLiteral(". ");
#nullable restore
#line 10 "D:\Programming\С#\Projects\Course Alexey\networkApp\networkApp\Views\Question\Index.cshtml"
                          Write(questions.TextQuestion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <table class=\"table\">\r\n        <tr>\r\n            <td>");
#nullable restore
#line 13 "D:\Programming\С#\Projects\Course Alexey\networkApp\networkApp\Views\Question\Index.cshtml"
           Write(questions.TrueAnswer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 14 "D:\Programming\С#\Projects\Course Alexey\networkApp\networkApp\Views\Question\Index.cshtml"
           Write(questions.numAnswer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 15 "D:\Programming\С#\Projects\Course Alexey\networkApp\networkApp\Views\Question\Index.cshtml"
           Write(questions.TextAnswer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n    </table>\r\n");
#nullable restore
#line 18 "D:\Programming\С#\Projects\Course Alexey\networkApp\networkApp\Views\Question\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<networkApp.ViewModels.Question>> Html { get; private set; }
    }
}
#pragma warning restore 1591
