#pragma checksum "C:\Users\User\Documents\GitHub\Gorlov.Yaroslav.931704\SecondLab\SecondLab\Views\Calc\Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22bb2478b9174018155545eba49430ed106f15a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Calc_Result), @"mvc.1.0.view", @"/Views/Calc/Result.cshtml")]
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
#line 1 "C:\Users\User\Documents\GitHub\Gorlov.Yaroslav.931704\SecondLab\SecondLab\Views\_ViewImports.cshtml"
using SecondLab;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Documents\GitHub\Gorlov.Yaroslav.931704\SecondLab\SecondLab\Views\_ViewImports.cshtml"
using SecondLab.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22bb2478b9174018155545eba49430ed106f15a7", @"/Views/Calc/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56af952a82ab4b4a8103030544b4501fbb2b3c1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Calc_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\User\Documents\GitHub\Gorlov.Yaroslav.931704\SecondLab\SecondLab\Views\Calc\Result.cshtml"
  
    ViewData["Title"] = "Result";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Result</h2>\r\n<div>");
#nullable restore
#line 7 "C:\Users\User\Documents\GitHub\Gorlov.Yaroslav.931704\SecondLab\SecondLab\Views\Calc\Result.cshtml"
Write(ViewBag.input1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 7 "C:\Users\User\Documents\GitHub\Gorlov.Yaroslav.931704\SecondLab\SecondLab\Views\Calc\Result.cshtml"
                Write(ViewBag.operation);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 7 "C:\Users\User\Documents\GitHub\Gorlov.Yaroslav.931704\SecondLab\SecondLab\Views\Calc\Result.cshtml"
                                   Write(ViewBag.input2);

#line default
#line hidden
#nullable disable
            WriteLiteral(" = ");
#nullable restore
#line 7 "C:\Users\User\Documents\GitHub\Gorlov.Yaroslav.931704\SecondLab\SecondLab\Views\Calc\Result.cshtml"
                                                     Write(ViewBag.result);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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