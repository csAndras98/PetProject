#pragma checksum "C:\Users\tompu\OneDrive\Desktop\c#\PetProject\PetProject\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c682e25963de7aea368f0bd61712ba1fbfc7f8b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PetProject.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace PetProject.Pages
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
#line 2 "C:\Users\tompu\OneDrive\Desktop\c#\PetProject\PetProject\Pages\_ViewImports.cshtml"
using PetProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tompu\OneDrive\Desktop\c#\PetProject\PetProject\Pages\_ViewImports.cshtml"
using PetProject.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tompu\OneDrive\Desktop\c#\PetProject\PetProject\Pages\Index.cshtml"
using Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tompu\OneDrive\Desktop\c#\PetProject\PetProject\Pages\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\tompu\OneDrive\Desktop\c#\PetProject\PetProject\Pages\Index.cshtml"
using PetProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\tompu\OneDrive\Desktop\c#\PetProject\PetProject\Pages\Index.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\tompu\OneDrive\Desktop\c#\PetProject\PetProject\Pages\Index.cshtml"
using Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c682e25963de7aea368f0bd61712ba1fbfc7f8b", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5076cba04b8246b217b1d6ac7a57e4ac164b2104", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 11 "C:\Users\tompu\OneDrive\Desktop\c#\PetProject\PetProject\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 15 "C:\Users\tompu\OneDrive\Desktop\c#\PetProject\PetProject\Pages\Index.cshtml"
 if (SignInManager.IsSignedIn(User))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\tompu\OneDrive\Desktop\c#\PetProject\PetProject\Pages\Index.cshtml"
Write(await Html.RenderComponentAsync<Components.Index>(RenderMode.ServerPrerendered));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\tompu\OneDrive\Desktop\c#\PetProject\PetProject\Pages\Index.cshtml"
                                                                                      
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Please Register or Login</h1>\r\n");
#nullable restore
#line 22 "C:\Users\tompu\OneDrive\Desktop\c#\PetProject\PetProject\Pages\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<script src=\"_framework/blazor.server.js\"></script>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ApplicationDbService ProductService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<AppUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<AppUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
