#pragma checksum "C:\Users\User\Documents\GitHub\Gorlov.Yaroslav.931704\FourthLab\FourthLab\Views\Account\SignUpResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6b5aedf4127ce717f5d9c5821e010fb3fcf5e57"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_SignUpResult), @"mvc.1.0.view", @"/Views/Account/SignUpResult.cshtml")]
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
#line 1 "C:\Users\User\Documents\GitHub\Gorlov.Yaroslav.931704\FourthLab\FourthLab\Views\_ViewImports.cshtml"
using FourthLab;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Documents\GitHub\Gorlov.Yaroslav.931704\FourthLab\FourthLab\Views\_ViewImports.cshtml"
using FourthLab.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6b5aedf4127ce717f5d9c5821e010fb3fcf5e57", @"/Views/Account/SignUpResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90c656bc5220dbba084bb7f5af476d8ce4ae1173", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_SignUpResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FourthLab.Models.SignUpModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Documents\GitHub\Gorlov.Yaroslav.931704\FourthLab\FourthLab\Views\Account\SignUpResult.cshtml"
  
    ViewData["Title"] = "SignUpResult";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Sign Up result</h2>\n\n<b>First name:</b>\n<p>");
#nullable restore
#line 9 "C:\Users\User\Documents\GitHub\Gorlov.Yaroslav.931704\FourthLab\FourthLab\Views\Account\SignUpResult.cshtml"
Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p><br />\n<b>Last name:</b>\n<p>");
#nullable restore
#line 11 "C:\Users\User\Documents\GitHub\Gorlov.Yaroslav.931704\FourthLab\FourthLab\Views\Account\SignUpResult.cshtml"
Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p><br />\n<b>Gender:</b>\n<p>");
#nullable restore
#line 13 "C:\Users\User\Documents\GitHub\Gorlov.Yaroslav.931704\FourthLab\FourthLab\Views\Account\SignUpResult.cshtml"
Write(Model.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p><br />\n<b>Birthday:</b>\n<p>");
#nullable restore
#line 15 "C:\Users\User\Documents\GitHub\Gorlov.Yaroslav.931704\FourthLab\FourthLab\Views\Account\SignUpResult.cshtml"
Write(Model.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 15 "C:\Users\User\Documents\GitHub\Gorlov.Yaroslav.931704\FourthLab\FourthLab\Views\Account\SignUpResult.cshtml"
         Write(Model.Month);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 15 "C:\Users\User\Documents\GitHub\Gorlov.Yaroslav.931704\FourthLab\FourthLab\Views\Account\SignUpResult.cshtml"
                       Write(Model.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p><br />\n<b>E-mail:</b>\n<p>");
#nullable restore
#line 17 "C:\Users\User\Documents\GitHub\Gorlov.Yaroslav.931704\FourthLab\FourthLab\Views\Account\SignUpResult.cshtml"
Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p><br />\n<b>Password:</b>\n<p>");
#nullable restore
#line 19 "C:\Users\User\Documents\GitHub\Gorlov.Yaroslav.931704\FourthLab\FourthLab\Views\Account\SignUpResult.cshtml"
Write(Model.Password);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p><br />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FourthLab.Models.SignUpModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
