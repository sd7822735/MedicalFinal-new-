#pragma checksum "C:\ADO.NET\作業區\Medical-final-3.0\Medical\Views\AllPatientRecord\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3772c352a0cc6213d523ddc3ae182ff78ed5da7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AllPatientRecord_List), @"mvc.1.0.view", @"/Views/AllPatientRecord/List.cshtml")]
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
#line 1 "C:\ADO.NET\作業區\Medical-final-3.0\Medical\Views\_ViewImports.cshtml"
using Medical;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ADO.NET\作業區\Medical-final-3.0\Medical\Views\_ViewImports.cshtml"
using Medical.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3772c352a0cc6213d523ddc3ae182ff78ed5da7", @"/Views/AllPatientRecord/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24de361111f0b04cb59052ed4f6ecd3219f4a4fd", @"/Views/_ViewImports.cshtml")]
    public class Views_AllPatientRecord_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Medical.ViewModels.CaseRecordViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\ADO.NET\作業區\Medical-final-3.0\Medical\Views\AllPatientRecord\List.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Hero Start -->
<div class=""container-fluid bg-primary py-5 hero-header mb-5"">
    <div class=""row py-3"">
        <div class=""col-12 text-center"">
            <h3 class=""display-3 text-white animated zoomIn"">病患總覽</h3>
        </div>
    </div>
</div>
<!-- Hero End -->
<br>
");
#nullable restore
#line 17 "C:\ADO.NET\作業區\Medical-final-3.0\Medical\Views\AllPatientRecord\List.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            WriteLiteral("病患查詢 ");
#nullable restore
#line 19 "C:\ADO.NET\作業區\Medical-final-3.0\Medical\Views\AllPatientRecord\List.cshtml"
      Write(Html.TextBox("txtKeyword"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <input type=\"submit\" value=\"查詢\" class=\"btn btn-primary\" />\r\n");
#nullable restore
#line 21 "C:\ADO.NET\作業區\Medical-final-3.0\Medical\Views\AllPatientRecord\List.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<p></p>
<table class=""table table-sm align-middle table-hover"" style=""margin-bottom:100px"">
    <thead>
        <tr>
            <th>
                序
            </th>
            <th>
                病患名稱
            </th>
            <th>
                病例概況
            </th>
            <th>
                治療科目
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 42 "C:\ADO.NET\作業區\Medical-final-3.0\Medical\Views\AllPatientRecord\List.cshtml"
          
            int count = 0;
            foreach (var item in Model)
            {
                count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 49 "C:\ADO.NET\作業區\Medical-final-3.0\Medical\Views\AllPatientRecord\List.cshtml"
                   Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 52 "C:\ADO.NET\作業區\Medical-final-3.0\Medical\Views\AllPatientRecord\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Member.MemberName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 55 "C:\ADO.NET\作業區\Medical-final-3.0\Medical\Views\AllPatientRecord\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DiagnosticRecord));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 58 "C:\ADO.NET\作業區\Medical-final-3.0\Medical\Views\AllPatientRecord\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TreatmentDetail.TreatmentDetail1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
            WriteLiteral("                </tr>\r\n");
#nullable restore
#line 66 "C:\ADO.NET\作業區\Medical-final-3.0\Medical\Views\AllPatientRecord\List.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Medical.ViewModels.CaseRecordViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
