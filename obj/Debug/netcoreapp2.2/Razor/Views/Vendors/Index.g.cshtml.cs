#pragma checksum "/Users/Guest/Desktop/Vendor-Tracker/Views/Vendors/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a92f2c0228259c8967e33d6f148cff8699fc07c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vendors_Index), @"mvc.1.0.view", @"/Views/Vendors/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vendors/Index.cshtml", typeof(AspNetCore.Views_Vendors_Index))]
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
#line 5 "/Users/Guest/Desktop/Vendor-Tracker/Views/Vendors/Index.cshtml"
using VendorTracker.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a92f2c0228259c8967e33d6f148cff8699fc07c2", @"/Views/Vendors/Index.cshtml")]
    public class Views_Vendors_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/Vendor-Tracker/Views/Vendors/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(57, 23, true);
            WriteLiteral("\n<h1>Vendor list</h1>\n\n");
            EndContext();
#line 9 "/Users/Guest/Desktop/Vendor-Tracker/Views/Vendors/Index.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
            BeginContext(106, 31, true);
            WriteLiteral("  <h3>No vendors to show!</h3>\n");
            EndContext();
#line 12 "/Users/Guest/Desktop/Vendor-Tracker/Views/Vendors/Index.cshtml"
} 

#line default
#line hidden
            BeginContext(140, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 14 "/Users/Guest/Desktop/Vendor-Tracker/Views/Vendors/Index.cshtml"
 foreach (Vendor vendor in Model)
{

#line default
#line hidden
            BeginContext(177, 8, true);
            WriteLiteral("  <h3><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 185, "\'", 211, 2);
            WriteAttributeValue("", 192, "/vendors/", 192, 9, true);
#line 16 "/Users/Guest/Desktop/Vendor-Tracker/Views/Vendors/Index.cshtml"
WriteAttributeValue("", 201, vendor.Id, 201, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(212, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(214, 11, false);
#line 16 "/Users/Guest/Desktop/Vendor-Tracker/Views/Vendors/Index.cshtml"
                               Write(vendor.Name);

#line default
#line hidden
            EndContext();
            BeginContext(225, 10, true);
            WriteLiteral("</a></h3>\n");
            EndContext();
#line 17 "/Users/Guest/Desktop/Vendor-Tracker/Views/Vendors/Index.cshtml"
}

#line default
#line hidden
            BeginContext(237, 34, true);
            WriteLiteral("\n<p><a href=\'/\'>Back home</a></p>\n");
            EndContext();
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
