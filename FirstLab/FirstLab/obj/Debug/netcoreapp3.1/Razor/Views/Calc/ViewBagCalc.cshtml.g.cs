#pragma checksum "C:\Users\User\Documents\GitHub\Gorlov.Yaroslav.931704\FirstLab\FirstLab\Views\Calc\ViewBagCalc.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69e242008df062d66361e379d578579745076e14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Calc_ViewBagCalc), @"mvc.1.0.view", @"/Views/Calc/ViewBagCalc.cshtml")]
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
#line 1 "C:\Users\User\Documents\GitHub\Gorlov.Yaroslav.931704\FirstLab\FirstLab\Views\_ViewImports.cshtml"
using FirstLab;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Documents\GitHub\Gorlov.Yaroslav.931704\FirstLab\FirstLab\Views\_ViewImports.cshtml"
using FirstLab.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69e242008df062d66361e379d578579745076e14", @"/Views/Calc/ViewBagCalc.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"234dbfb00b8f5229dd84005bd7c22b63ad163a4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Calc_ViewBagCalc : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "C:\Users\User\Documents\GitHub\Gorlov.Yaroslav.931704\FirstLab\FirstLab\Views\Calc\ViewBagCalc.cshtml"
  
    ViewData["Title"] = "ViewBagCalc";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>ViewBagCalc</h2>\n<div>First value: ");
#nullable restore
#line 7 "C:\Users\User\Documents\GitHub\Gorlov.Yaroslav.931704\FirstLab\FirstLab\Views\Calc\ViewBagCalc.cshtml"
             Write(ViewBag.data.first);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n<div>Second value: ");
#nullable restore
#line 8 "C:\Users\User\Documents\GitHub\Gorlov.Yaroslav.931704\FirstLab\FirstLab\Views\Calc\ViewBagCalc.cshtml"
              Write(ViewBag.data.second);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n<div>Add: ");
#nullable restore
#line 9 "C:\Users\User\Documents\GitHub\Gorlov.Yaroslav.931704\FirstLab\FirstLab\Views\Calc\ViewBagCalc.cshtml"
     Write(ViewBag.data.first);

#line default
#line hidden
#nullable disable
            WriteLiteral(" + ");
#nullable restore
#line 9 "C:\Users\User\Documents\GitHub\Gorlov.Yaroslav.931704\FirstLab\FirstLab\Views\Calc\ViewBagCalc.cshtml"
                           Write(ViewBag.data.second);

#line default
#line hidden
#nullable disable
            WriteLiteral(" = ");
#nullable restore
#line 9 "C:\Users\User\Documents\GitHub\Gorlov.Yaroslav.931704\FirstLab\FirstLab\Views\Calc\ViewBagCalc.cshtml"
                                                  Write(ViewBag.data.resAdd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n<div>Sub: ");
#nullable restore
#line 10 "C:\Users\User\Documents\GitHub\Gorlov.Yaroslav.931704\FirstLab\FirstLab\Views\Calc\ViewBagCalc.cshtml"
     Write(ViewBag.data.first);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 10 "C:\Users\User\Documents\GitHub\Gorlov.Yaroslav.931704\FirstLab\FirstLab\Views\Calc\ViewBagCalc.cshtml"
                           Write(ViewBag.data.second);

#line default
#line hidden
#nullable disable
            WriteLiteral(" = ");
#nullable restore
#line 10 "C:\Users\User\Documents\GitHub\Gorlov.Yaroslav.931704\FirstLab\FirstLab\Views\Calc\ViewBagCalc.cshtml"
                                                  Write(ViewBag.data.resSub);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n<div>Mult: ");
#nullable restore
#line 11 "C:\Users\User\Documents\GitHub\Gorlov.Yaroslav.931704\FirstLab\FirstLab\Views\Calc\ViewBagCalc.cshtml"
      Write(ViewBag.data.first);

#line default
#line hidden
#nullable disable
            WriteLiteral(" * ");
#nullable restore
#line 11 "C:\Users\User\Documents\GitHub\Gorlov.Yaroslav.931704\FirstLab\FirstLab\Views\Calc\ViewBagCalc.cshtml"
                            Write(ViewBag.data.second);

#line default
#line hidden
#nullable disable
            WriteLiteral(" = ");
#nullable restore
#line 11 "C:\Users\User\Documents\GitHub\Gorlov.Yaroslav.931704\FirstLab\FirstLab\Views\Calc\ViewBagCalc.cshtml"
                                                   Write(ViewBag.data.resMult);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n<div>\n    Div: ");
#nullable restore
#line 13 "C:\Users\User\Documents\GitHub\Gorlov.Yaroslav.931704\FirstLab\FirstLab\Views\Calc\ViewBagCalc.cshtml"
    Write(ViewBag.data.first);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 13 "C:\Users\User\Documents\GitHub\Gorlov.Yaroslav.931704\FirstLab\FirstLab\Views\Calc\ViewBagCalc.cshtml"
                          Write(ViewBag.data.second);

#line default
#line hidden
#nullable disable
            WriteLiteral(" = ");
#nullable restore
#line 13 "C:\Users\User\Documents\GitHub\Gorlov.Yaroslav.931704\FirstLab\FirstLab\Views\Calc\ViewBagCalc.cshtml"
                                                       if (ViewBag.data.resDiv == -1)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            WriteLiteral(" error\n");
#nullable restore
#line 16 "C:\Users\User\Documents\GitHub\Gorlov.Yaroslav.931704\FirstLab\FirstLab\Views\Calc\ViewBagCalc.cshtml"
    }
    else
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\User\Documents\GitHub\Gorlov.Yaroslav.931704\FirstLab\FirstLab\Views\Calc\ViewBagCalc.cshtml"
   Write(ViewBag.data.resDiv);

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\User\Documents\GitHub\Gorlov.Yaroslav.931704\FirstLab\FirstLab\Views\Calc\ViewBagCalc.cshtml"
                            
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
