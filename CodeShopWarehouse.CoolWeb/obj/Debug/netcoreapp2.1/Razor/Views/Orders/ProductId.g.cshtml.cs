#pragma checksum "C:\source\bcw2018\CodeShopWarehouse\CodeShopWarehouse.CoolWeb\Views\Orders\ProductId.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8c35cb562fc7ba4930e75554c9053b261672d9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_ProductId), @"mvc.1.0.view", @"/Views/Orders/ProductId.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Orders/ProductId.cshtml", typeof(AspNetCore.Views_Orders_ProductId))]
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
#line 1 "C:\source\bcw2018\CodeShopWarehouse\CodeShopWarehouse.CoolWeb\Views\_ViewImports.cshtml"
using CodeShopWarehouse.CoolWeb;

#line default
#line hidden
#line 2 "C:\source\bcw2018\CodeShopWarehouse\CodeShopWarehouse.CoolWeb\Views\_ViewImports.cshtml"
using CodeShopWarehouse.CoolWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8c35cb562fc7ba4930e75554c9053b261672d9d", @"/Views/Orders/ProductId.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ca3cd72eebe33d4de3d14b71cdacbad7c103667", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_ProductId : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<System.Collections.Generic.IEnumerable<CodeShopWarehouse.Shared.Interfaces.IOrder>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(91, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\source\bcw2018\CodeShopWarehouse\CodeShopWarehouse.CoolWeb\Views\Orders\ProductId.cshtml"
  
    ViewBag.Title = "title";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(155, 72, true);
            WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n    <tr>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(228, 45, false);
#line 11 "C:\source\bcw2018\CodeShopWarehouse\CodeShopWarehouse.CoolWeb\Views\Orders\ProductId.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductId));

#line default
#line hidden
            EndContext();
            BeginContext(273, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(317, 41, false);
#line 14 "C:\source\bcw2018\CodeShopWarehouse\CodeShopWarehouse.CoolWeb\Views\Orders\ProductId.cshtml"
       Write(Html.DisplayNameFor(model => model.Stock));

#line default
#line hidden
            EndContext();
            BeginContext(358, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(402, 45, false);
#line 17 "C:\source\bcw2018\CodeShopWarehouse\CodeShopWarehouse.CoolWeb\Views\Orders\ProductId.cshtml"
       Write(Html.DisplayNameFor(model => model.OrderType));

#line default
#line hidden
            EndContext();
            BeginContext(447, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(491, 44, false);
#line 20 "C:\source\bcw2018\CodeShopWarehouse\CodeShopWarehouse.CoolWeb\Views\Orders\ProductId.cshtml"
       Write(Html.DisplayNameFor(model => model.FilledAt));

#line default
#line hidden
            EndContext();
            BeginContext(535, 74, true);
            WriteLiteral("\r\n        </th>\r\n        <th></th>\r\n    </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 26 "C:\source\bcw2018\CodeShopWarehouse\CodeShopWarehouse.CoolWeb\Views\Orders\ProductId.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(650, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(699, 44, false);
#line 30 "C:\source\bcw2018\CodeShopWarehouse\CodeShopWarehouse.CoolWeb\Views\Orders\ProductId.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProductId));

#line default
#line hidden
            EndContext();
            BeginContext(743, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(799, 43, false);
#line 33 "C:\source\bcw2018\CodeShopWarehouse\CodeShopWarehouse.CoolWeb\Views\Orders\ProductId.cshtml"
           Write(Html.DisplayFor(modelItem => item.FilledAt));

#line default
#line hidden
            EndContext();
            BeginContext(842, 59, true);
            WriteLiteral("\r\n            </td>    \r\n            <td>\r\n                ");
            EndContext();
            BeginContext(902, 40, false);
#line 36 "C:\source\bcw2018\CodeShopWarehouse\CodeShopWarehouse.CoolWeb\Views\Orders\ProductId.cshtml"
           Write(Html.DisplayFor(modelItem => item.Stock));

#line default
#line hidden
            EndContext();
            BeginContext(942, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(998, 44, false);
#line 39 "C:\source\bcw2018\CodeShopWarehouse\CodeShopWarehouse.CoolWeb\Views\Orders\ProductId.cshtml"
           Write(Html.DisplayFor(modelItem => item.OrderType));

#line default
#line hidden
            EndContext();
            BeginContext(1042, 39, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
            EndContext();
#line 42 "C:\source\bcw2018\CodeShopWarehouse\CodeShopWarehouse.CoolWeb\Views\Orders\ProductId.cshtml"
                 using (Html.BeginForm("FillOrder", "Orders", item.Id, FormMethod.Post))
                {

#line default
#line hidden
            BeginContext(1190, 33, true);
            WriteLiteral("                    <input hidden");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1223, "\"", 1239, 1);
#line 44 "C:\source\bcw2018\CodeShopWarehouse\CodeShopWarehouse.CoolWeb\Views\Orders\ProductId.cshtml"
WriteAttributeValue("", 1231, item.Id, 1231, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1240, 56, true);
            WriteLiteral(" name=\"id\" />\r\n                    <button type=\"submit\"");
            EndContext();
            BeginWriteAttribute("disabled", " disabled=\"", 1296, "\"", 1331, 1);
#line 45 "C:\source\bcw2018\CodeShopWarehouse\CodeShopWarehouse.CoolWeb\Views\Orders\ProductId.cshtml"
WriteAttributeValue("", 1307, item.FilledAt != null, 1307, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1332, 22, true);
            WriteLiteral(">Proccess</button>  \r\n");
            EndContext();
#line 46 "C:\source\bcw2018\CodeShopWarehouse\CodeShopWarehouse.CoolWeb\Views\Orders\ProductId.cshtml"
                }

#line default
#line hidden
            BeginContext(1373, 34, true);
            WriteLiteral("            </td>\r\n        </tr>\r\n");
            EndContext();
#line 49 "C:\source\bcw2018\CodeShopWarehouse\CodeShopWarehouse.CoolWeb\Views\Orders\ProductId.cshtml"
    }

#line default
#line hidden
            BeginContext(1414, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<System.Collections.Generic.IEnumerable<CodeShopWarehouse.Shared.Interfaces.IOrder>> Html { get; private set; }
    }
}
#pragma warning restore 1591
