#pragma checksum "/Users/Guest/Desktop/Vendor-Tracker/Views/Orders/Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8802523e925b76826506276071395bf2d3f01ee0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Show), @"mvc.1.0.view", @"/Views/Orders/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Orders/Show.cshtml", typeof(AspNetCore.Views_Orders_Show))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8802523e925b76826506276071395bf2d3f01ee0", @"/Views/Orders/Show.cshtml")]
    public class Views_Orders_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/Vendor-Tracker/Views/Orders/Show.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 33, true);
            WriteLiteral("\n\n<h1> Order Details: </h1>\n\n<h2>");
            EndContext();
            BeginContext(61, 20, false);
#line 8 "/Users/Guest/Desktop/Vendor-Tracker/Views/Orders/Show.cshtml"
Write(Model["order"].Title);

#line default
#line hidden
            EndContext();
            BeginContext(81, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(83, 31, false);
#line 8 "/Users/Guest/Desktop/Vendor-Tracker/Views/Orders/Show.cshtml"
                     Write(Model["order"].OrderDescription);

#line default
#line hidden
            EndContext();
            BeginContext(114, 2, true);
            WriteLiteral(" $");
            EndContext();
            BeginContext(117, 20, false);
#line 8 "/Users/Guest/Desktop/Vendor-Tracker/Views/Orders/Show.cshtml"
                                                       Write(Model["order"].Price);

#line default
#line hidden
            EndContext();
            BeginContext(137, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(139, 19, false);
#line 8 "/Users/Guest/Desktop/Vendor-Tracker/Views/Orders/Show.cshtml"
                                                                             Write(Model["order"].Date);

#line default
#line hidden
            EndContext();
            BeginContext(158, 17, true);
            WriteLiteral("</p>\n<h3>Vendor: ");
            EndContext();
            BeginContext(176, 20, false);
#line 9 "/Users/Guest/Desktop/Vendor-Tracker/Views/Orders/Show.cshtml"
       Write(Model["vendor"].Name);

#line default
#line hidden
            EndContext();
            BeginContext(196, 9, true);
            WriteLiteral("</h3>\n\n<a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 205, "\'", 251, 3);
            WriteAttributeValue("", 212, "/vendors/", 212, 9, true);
#line 11 "/Users/Guest/Desktop/Vendor-Tracker/Views/Orders/Show.cshtml"
WriteAttributeValue("", 221, Model["vendor"].Id, 221, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 240, "/orders/new", 240, 11, true);
            EndWriteAttribute();
            BeginContext(252, 66, true);
            WriteLiteral(">Add another order</a><br>\n<a href=\'/vendors\'>View all vendors</a>");
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
