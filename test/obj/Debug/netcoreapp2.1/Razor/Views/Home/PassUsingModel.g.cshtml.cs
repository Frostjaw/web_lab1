#pragma checksum "D:\Учеба\3 course\Web-технология\Лабы 2 сем\1\test\test\Views\Home\PassUsingModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ac004310c83f1341cb0b69da21ccf26c24d62e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PassUsingModel), @"mvc.1.0.view", @"/Views/Home/PassUsingModel.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/PassUsingModel.cshtml", typeof(AspNetCore.Views_Home_PassUsingModel))]
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
#line 1 "D:\Учеба\3 course\Web-технология\Лабы 2 сем\1\test\test\Views\_ViewImports.cshtml"
using test;

#line default
#line hidden
#line 2 "D:\Учеба\3 course\Web-технология\Лабы 2 сем\1\test\test\Views\_ViewImports.cshtml"
using test.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ac004310c83f1341cb0b69da21ccf26c24d62e9", @"/Views/Home/PassUsingModel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04aae2d41d7a1f2a1b7badf4f453e10febdd2915", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_PassUsingModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dictionary<string, double>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(121, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 5 "D:\Учеба\3 course\Web-технология\Лабы 2 сем\1\test\test\Views\Home\PassUsingModel.cshtml"
  
    ViewData["Title"] = "PassUsingModel - Backend1";

#line default
#line hidden
            BeginContext(221, 46, true);
            WriteLiteral("<h2>PassUsingModel</h2>\r\n<p>Rand Value First: ");
            EndContext();
            BeginContext(268, 20, false);
#line 10 "D:\Учеба\3 course\Web-технология\Лабы 2 сем\1\test\test\Views\Home\PassUsingModel.cshtml"
                Write(Model["firstNumber"]);

#line default
#line hidden
            EndContext();
            BeginContext(288, 28, true);
            WriteLiteral("</p>\r\n<p>Rand Value Second: ");
            EndContext();
            BeginContext(317, 21, false);
#line 11 "D:\Учеба\3 course\Web-технология\Лабы 2 сем\1\test\test\Views\Home\PassUsingModel.cshtml"
                 Write(Model["secondNumber"]);

#line default
#line hidden
            EndContext();
            BeginContext(338, 14, true);
            WriteLiteral("</p>\r\n<p>Add: ");
            EndContext();
            BeginContext(353, 12, false);
#line 12 "D:\Учеба\3 course\Web-технология\Лабы 2 сем\1\test\test\Views\Home\PassUsingModel.cshtml"
   Write(Model["sum"]);

#line default
#line hidden
            EndContext();
            BeginContext(365, 14, true);
            WriteLiteral("</p>\r\n<p>Sub: ");
            EndContext();
            BeginContext(380, 12, false);
#line 13 "D:\Учеба\3 course\Web-технология\Лабы 2 сем\1\test\test\Views\Home\PassUsingModel.cshtml"
   Write(Model["sub"]);

#line default
#line hidden
            EndContext();
            BeginContext(392, 15, true);
            WriteLiteral("</p>\r\n<p>Mult: ");
            EndContext();
            BeginContext(408, 13, false);
#line 14 "D:\Учеба\3 course\Web-технология\Лабы 2 сем\1\test\test\Views\Home\PassUsingModel.cshtml"
    Write(Model["mult"]);

#line default
#line hidden
            EndContext();
            BeginContext(421, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 15 "D:\Учеба\3 course\Web-технология\Лабы 2 сем\1\test\test\Views\Home\PassUsingModel.cshtml"
 if (Model.ContainsKey("div"))
{

#line default
#line hidden
            BeginContext(462, 12, true);
            WriteLiteral("    <p>Div: ");
            EndContext();
            BeginContext(475, 12, false);
#line 17 "D:\Учеба\3 course\Web-технология\Лабы 2 сем\1\test\test\Views\Home\PassUsingModel.cshtml"
       Write(Model["div"]);

#line default
#line hidden
            EndContext();
            BeginContext(487, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 18 "D:\Учеба\3 course\Web-технология\Лабы 2 сем\1\test\test\Views\Home\PassUsingModel.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(505, 30, true);
            WriteLiteral("    <p>Div: Деление на 0</p>\r\n");
            EndContext();
#line 22 "D:\Учеба\3 course\Web-технология\Лабы 2 сем\1\test\test\Views\Home\PassUsingModel.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dictionary<string, double>> Html { get; private set; }
    }
}
#pragma warning restore 1591
