#pragma checksum "C:\Users\Student\Source\Repos\MedicalFinal-new-\Medical\Views\Doctor\RatingDoctorpartail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5275a16bc11c78e128f4d84682cc4c8a9459fa89"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Doctor_RatingDoctorpartail), @"mvc.1.0.view", @"/Views/Doctor/RatingDoctorpartail.cshtml")]
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
#line 1 "C:\Users\Student\Source\Repos\MedicalFinal-new-\Medical\Views\_ViewImports.cshtml"
using Medical;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Student\Source\Repos\MedicalFinal-new-\Medical\Views\_ViewImports.cshtml"
using Medical.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5275a16bc11c78e128f4d84682cc4c8a9459fa89", @"/Views/Doctor/RatingDoctorpartail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24de361111f0b04cb59052ed4f6ecd3219f4a4fd", @"/Views/_ViewImports.cshtml")]
    public class Views_Doctor_RatingDoctorpartail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Medical.Models.RatingDoctor>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n<h3> ");
#nullable restore
#line 5 "C:\Users\Student\Source\Repos\MedicalFinal-new-\Medical\Views\Doctor\RatingDoctorpartail.cshtml"
Write(ViewBag.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("  醫師 共有 ");
#nullable restore
#line 5 "C:\Users\Student\Source\Repos\MedicalFinal-new-\Medical\Views\Doctor\RatingDoctorpartail.cshtml"
                     Write(ViewBag.count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" 則評論 </h3>
<table class=""table"">
    <thead>
        <tr>            
            <th>
                評分
            </th>
            <th>
                評論內容
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>

");
#nullable restore
#line 20 "C:\Users\Student\Source\Repos\MedicalFinal-new-\Medical\Views\Doctor\RatingDoctorpartail.cshtml"
          
            int count = 0;
            double total = 0;
            foreach (var item in Model)
            {
                count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>                  \r\n                    <td>\r\n                        ");
#nullable restore
#line 28 "C:\Users\Student\Source\Repos\MedicalFinal-new-\Medical\Views\Doctor\RatingDoctorpartail.cshtml"
                   Write(Html.DisplayFor(modelItem => item.RatingType.RatingTypeName));

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n                        <img />\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 32 "C:\Users\Student\Source\Repos\MedicalFinal-new-\Medical\Views\Doctor\RatingDoctorpartail.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 35 "C:\Users\Student\Source\Repos\MedicalFinal-new-\Medical\Views\Doctor\RatingDoctorpartail.cshtml"
                total += Convert.ToDouble(@item.RatingType.RatingTypeName);

            }
            double a = Math.Round((total / count),2);
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<div class=\"card-footer clearfix\">\r\n    <h3 style=\"vertical-align: inherit;\">平均分數: ");
#nullable restore
#line 43 "C:\Users\Student\Source\Repos\MedicalFinal-new-\Medical\Views\Doctor\RatingDoctorpartail.cshtml"
                                          Write(a);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / 5</h3>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Medical.Models.RatingDoctor>> Html { get; private set; }
    }
}
#pragma warning restore 1591
