#pragma checksum "C:\Users\Jose Alejandro\Documents\asp .net\Projects\Sims\Sims\Sims\Views\Activity\Temp.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed9f87e21a1a451ef3fe735836c8377890010471"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Activity_Temp), @"mvc.1.0.view", @"/Views/Activity/Temp.cshtml")]
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
#line 1 "C:\Users\Jose Alejandro\Documents\asp .net\Projects\Sims\Sims\Sims\Views\_ViewImports.cshtml"
using Sims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jose Alejandro\Documents\asp .net\Projects\Sims\Sims\Sims\Views\_ViewImports.cshtml"
using Sims.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Jose Alejandro\Documents\asp .net\Projects\Sims\Sims\Sims\Views\_ViewImports.cshtml"
using Sims.Models.Relations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Jose Alejandro\Documents\asp .net\Projects\Sims\Sims\Sims\Views\_ViewImports.cshtml"
using Sims.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Jose Alejandro\Documents\asp .net\Projects\Sims\Sims\Sims\Views\_ViewImports.cshtml"
using System.Web.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed9f87e21a1a451ef3fe735836c8377890010471", @"/Views/Activity/Temp.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3195615aab047eac0eefd9b1d6fa14d9a9caf0e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Activity_Temp : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Activity>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Jose Alejandro\Documents\asp .net\Projects\Sims\Sims\Sims\Views\Activity\Temp.cshtml"
 using (Html.BeginForm("Temp", "Activity", FormMethod.Post, new { id = "temp" }))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Jose Alejandro\Documents\asp .net\Projects\Sims\Sims\Sims\Views\Activity\Temp.cshtml"
Write(Html.HiddenFor(p => p.ActivityID));

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Jose Alejandro\Documents\asp .net\Projects\Sims\Sims\Sims\Views\Activity\Temp.cshtml"
Write(Html.HiddenFor(p => p.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Jose Alejandro\Documents\asp .net\Projects\Sims\Sims\Sims\Views\Activity\Temp.cshtml"
Write(Html.HiddenFor(p => p.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <button type=\"submit\" class=\"btn btn-primary\">Accept</button>\r\n");
#nullable restore
#line 9 "C:\Users\Jose Alejandro\Documents\asp .net\Projects\Sims\Sims\Sims\Views\Activity\Temp.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Activity> Html { get; private set; }
    }
}
#pragma warning restore 1591
