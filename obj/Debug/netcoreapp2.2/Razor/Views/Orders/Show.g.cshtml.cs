#pragma checksum "/Users/Guest/Desktop/Vendor-Tracker/Views/Orders/Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18d8a7bfb33cf132eea513c15cd3a22c6e05ae38"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18d8a7bfb33cf132eea513c15cd3a22c6e05ae38", @"/Views/Orders/Show.cshtml")]
    public class Views_Orders_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/Vendor-Tracker/Views/Orders/Show.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 13, true);
            WriteLiteral("\n<h3>Vendor: ");
            EndContext();
            BeginContext(41, 20, false);
#line 5 "/Users/Guest/Desktop/Vendor-Tracker/Views/Orders/Show.cshtml"
       Write(Model["vendor"].Name);

#line default
#line hidden
            EndContext();
            BeginContext(61, 45, true);
            WriteLiteral("</h3>\n\n\n<h1> Order Details: </h1>\n\n<h2>Item: ");
            EndContext();
            BeginContext(107, 20, false);
#line 10 "/Users/Guest/Desktop/Vendor-Tracker/Views/Orders/Show.cshtml"
     Write(Model["order"].Title);

#line default
#line hidden
            EndContext();
            BeginContext(127, 24, true);
            WriteLiteral("</h2> \n<h2>Description: ");
            EndContext();
            BeginContext(152, 31, false);
#line 11 "/Users/Guest/Desktop/Vendor-Tracker/Views/Orders/Show.cshtml"
            Write(Model["order"].OrderDescription);

#line default
#line hidden
            EndContext();
            BeginContext(183, 21, true);
            WriteLiteral("</h2> \n<h2>Quantity: ");
            EndContext();
            BeginContext(205, 23, false);
#line 12 "/Users/Guest/Desktop/Vendor-Tracker/Views/Orders/Show.cshtml"
         Write(Model["order"].Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(228, 27, true);
            WriteLiteral("</h2>\n<h2>Price of Order: $");
            EndContext();
            BeginContext(256, 20, false);
#line 13 "/Users/Guest/Desktop/Vendor-Tracker/Views/Orders/Show.cshtml"
                Write(Model["order"].Price);

#line default
#line hidden
            EndContext();
            BeginContext(276, 26, true);
            WriteLiteral("</h2> \n<h2>Date of Order: ");
            EndContext();
            BeginContext(303, 19, false);
#line 14 "/Users/Guest/Desktop/Vendor-Tracker/Views/Orders/Show.cshtml"
              Write(Model["order"].Date);

#line default
#line hidden
            EndContext();
            BeginContext(322, 11, true);
            WriteLiteral("</h2>\n\n\n\n<a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 333, "\'", 379, 3);
            WriteAttributeValue("", 340, "/vendors/", 340, 9, true);
#line 18 "/Users/Guest/Desktop/Vendor-Tracker/Views/Orders/Show.cshtml"
WriteAttributeValue("", 349, Model["vendor"].Id, 349, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 368, "/orders/new", 368, 11, true);
            EndWriteAttribute();
            BeginContext(380, 66, true);
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
