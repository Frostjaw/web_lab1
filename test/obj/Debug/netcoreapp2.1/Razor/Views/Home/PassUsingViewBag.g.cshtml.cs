#pragma checksum "D:\Учеба\3 course\Web-технология\Лабы 2 сем\1\test\test\Views\Home\PassUsingViewBag.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ac892377bbd8a23ba237b7275f0db9cd8304cd0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PassUsingViewBag), @"mvc.1.0.view", @"/Views/Home/PassUsingViewBag.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/PassUsingViewBag.cshtml", typeof(AspNetCore.Views_Home_PassUsingViewBag))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ac892377bbd8a23ba237b7275f0db9cd8304cd0", @"/Views/Home/PassUsingViewBag.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04aae2d41d7a1f2a1b7badf4f453e10febdd2915", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_PassUsingViewBag : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\Учеба\3 course\Web-технология\Лабы 2 сем\1\test\test\Views\Home\PassUsingViewBag.cshtml"
  
    ViewData["Title"] = "PassUsingViewBag - Backend1";

#line default
#line hidden
            BeginContext(65, 50, true);
            WriteLiteral("\r\n<h2>PassUsingViewBag</h2>\r\n<p>Rand Value First: ");
            EndContext();
            BeginContext(116, 19, false);
#line 7 "D:\Учеба\3 course\Web-технология\Лабы 2 сем\1\test\test\Views\Home\PassUsingViewBag.cshtml"
                Write(ViewBag.firstNumber);

#line default
#line hidden
            EndContext();
            BeginContext(135, 28, true);
            WriteLiteral("</p>\r\n<p>Rand Value Second: ");
            EndContext();
            BeginContext(164, 20, false);
#line 8 "D:\Учеба\3 course\Web-технология\Лабы 2 сем\1\test\test\Views\Home\PassUsingViewBag.cshtml"
                 Write(ViewBag.secondNumber);

#line default
#line hidden
            EndContext();
            BeginContext(184, 14, true);
            WriteLiteral("</p>\r\n<p>Add: ");
            EndContext();
            BeginContext(199, 11, false);
#line 9 "D:\Учеба\3 course\Web-технология\Лабы 2 сем\1\test\test\Views\Home\PassUsingViewBag.cshtml"
   Write(ViewBag.sum);

#line default
#line hidden
            EndContext();
            BeginContext(210, 14, true);
            WriteLiteral("</p>\r\n<p>Sub: ");
            EndContext();
            BeginContext(225, 11, false);
#line 10 "D:\Учеба\3 course\Web-технология\Лабы 2 сем\1\test\test\Views\Home\PassUsingViewBag.cshtml"
   Write(ViewBag.sub);

#line default
#line hidden
            EndContext();
            BeginContext(236, 15, true);
            WriteLiteral("</p>\r\n<p>Mult: ");
            EndContext();
            BeginContext(252, 12, false);
#line 11 "D:\Учеба\3 course\Web-технология\Лабы 2 сем\1\test\test\Views\Home\PassUsingViewBag.cshtml"
    Write(ViewBag.mult);

#line default
#line hidden
            EndContext();
            BeginContext(264, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 12 "D:\Учеба\3 course\Web-технология\Лабы 2 сем\1\test\test\Views\Home\PassUsingViewBag.cshtml"
 if (ViewBag.div != null)
{

#line default
#line hidden
            BeginContext(300, 12, true);
            WriteLiteral("    <p>Div: ");
            EndContext();
            BeginContext(313, 11, false);
#line 14 "D:\Учеба\3 course\Web-технология\Лабы 2 сем\1\test\test\Views\Home\PassUsingViewBag.cshtml"
       Write(ViewBag.div);

#line default
#line hidden
            EndContext();
            BeginContext(324, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 15 "D:\Учеба\3 course\Web-технология\Лабы 2 сем\1\test\test\Views\Home\PassUsingViewBag.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(342, 30, true);
            WriteLiteral("    <p>Div: Деление на 0</p>\r\n");
            EndContext();
#line 19 "D:\Учеба\3 course\Web-технология\Лабы 2 сем\1\test\test\Views\Home\PassUsingViewBag.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
