#pragma checksum "/Users/Guest/Desktop/Vendor-Tracker/Views/Vendors/Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e74aa1c64ca5503e3328f03d1f08686f9e85853a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vendors_Show), @"mvc.1.0.view", @"/Views/Vendors/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vendors/Show.cshtml", typeof(AspNetCore.Views_Vendors_Show))]
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
#line 5 "/Users/Guest/Desktop/Vendor-Tracker/Views/Vendors/Show.cshtml"
using VendorTracker.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e74aa1c64ca5503e3328f03d1f08686f9e85853a", @"/Views/Vendors/Show.cshtml")]
    public class Views_Vendors_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/Vendor-Tracker/Views/Vendors/Show.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(57, 66, true);
            WriteLiteral("\n<h3>Here are all the orders belonging to this vendor:</h3>\n\n<ol>\n");
            EndContext();
#line 10 "/Users/Guest/Desktop/Vendor-Tracker/Views/Vendors/Show.cshtml"
 foreach (Order order in @Model["orders"])
{

#line default
#line hidden
            BeginContext(168, 8, true);
            WriteLiteral("  <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 176, "\'", 228, 4);
            WriteAttributeValue("", 183, "/vendors/", 183, 9, true);
#line 12 "/Users/Guest/Desktop/Vendor-Tracker/Views/Vendors/Show.cshtml"
WriteAttributeValue("", 192, Model["vendor"].Id, 192, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 211, "/orders/", 211, 8, true);
#line 12 "/Users/Guest/Desktop/Vendor-Tracker/Views/Vendors/Show.cshtml"
WriteAttributeValue("", 219, order.Id, 219, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(229, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(231, 11, false);
#line 12 "/Users/Guest/Desktop/Vendor-Tracker/Views/Vendors/Show.cshtml"
                                                         Write(order.Title);

#line default
#line hidden
            EndContext();
            BeginContext(242, 10, true);
            WriteLiteral("</a></li>\n");
            EndContext();
#line 13 "/Users/Guest/Desktop/Vendor-Tracker/Views/Vendors/Show.cshtml"
}

#line default
#line hidden
            BeginContext(254, 12, true);
            WriteLiteral("</ol>\n\n<p><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 266, "\'", 312, 3);
            WriteAttributeValue("", 273, "/vendors/", 273, 9, true);
#line 16 "/Users/Guest/Desktop/Vendor-Tracker/Views/Vendors/Show.cshtml"
WriteAttributeValue("", 282, Model["vendor"].Id, 282, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 301, "/orders/new", 301, 11, true);
            EndWriteAttribute();
            BeginContext(313, 119, true);
            WriteLiteral(">Add a new order</a></p>\n<p><a href=\'/vendors\'>Return to vendor list</a></p>\n<p><a href=\'/\'>Return to Main Page</a></p>");
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
