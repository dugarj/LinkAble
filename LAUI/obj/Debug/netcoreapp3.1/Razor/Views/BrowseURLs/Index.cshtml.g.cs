#pragma checksum "C:\Users\Jay\VisualStudioProjects\LinkAble\LAUI\Views\BrowseURLs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9959904ac7071a98c91e4ae5992d46e2de0807cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BrowseURLs_Index), @"mvc.1.0.view", @"/Views/BrowseURLs/Index.cshtml")]
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
#line 2 "C:\Users\Jay\VisualStudioProjects\LinkAble\LAUI\Views\_ViewImports.cshtml"
using LABOL;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9959904ac7071a98c91e4ae5992d46e2de0807cc", @"/Views/BrowseURLs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4169fe66e5089275124d1bf6b0af14259c7692d0", @"/Views/_ViewImports.cshtml")]
    public class Views_BrowseURLs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LAUI.ViewModel.BrowseURLsViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Jay\VisualStudioProjects\LinkAble\LAUI\Views\BrowseURLs\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Browse URLs</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\Jay\VisualStudioProjects\LinkAble\LAUI\Views\BrowseURLs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UrlId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\Jay\VisualStudioProjects\LinkAble\LAUI\Views\BrowseURLs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UrlTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Jay\VisualStudioProjects\LinkAble\LAUI\Views\BrowseURLs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LAUrlName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\Jay\VisualStudioProjects\LinkAble\LAUI\Views\BrowseURLs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\Jay\VisualStudioProjects\LinkAble\LAUI\Views\BrowseURLs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n");
            WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 33 "C:\Users\Jay\VisualStudioProjects\LinkAble\LAUI\Views\BrowseURLs\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 36 "C:\Users\Jay\VisualStudioProjects\LinkAble\LAUI\Views\BrowseURLs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.UrlId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 39 "C:\Users\Jay\VisualStudioProjects\LinkAble\LAUI\Views\BrowseURLs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.UrlTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 42 "C:\Users\Jay\VisualStudioProjects\LinkAble\LAUI\Views\BrowseURLs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LAUrlName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 45 "C:\Users\Jay\VisualStudioProjects\LinkAble\LAUI\Views\BrowseURLs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 48 "C:\Users\Jay\VisualStudioProjects\LinkAble\LAUI\Views\BrowseURLs\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n");
            WriteLiteral("        </tr>\r\n");
#nullable restore
#line 54 "C:\Users\Jay\VisualStudioProjects\LinkAble\LAUI\Views\BrowseURLs\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LAUI.ViewModel.BrowseURLsViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
