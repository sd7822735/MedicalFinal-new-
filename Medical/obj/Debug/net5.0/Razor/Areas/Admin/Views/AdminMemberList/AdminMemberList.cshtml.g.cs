#pragma checksum "C:\Users\Student\Source\Repos\MedicalFinal-new-\Medical\Areas\Admin\Views\AdminMemberList\AdminMemberList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1efa1d3a99f7aa41630e3ab82d4689161036cdb1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminMemberList_AdminMemberList), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminMemberList/AdminMemberList.cshtml")]
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
#line 1 "C:\Users\Student\Source\Repos\MedicalFinal-new-\Medical\Areas\_ViewImports.cshtml"
using Medical;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Student\Source\Repos\MedicalFinal-new-\Medical\Areas\_ViewImports.cshtml"
using Medical.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1efa1d3a99f7aa41630e3ab82d4689161036cdb1", @"/Areas/Admin/Views/AdminMemberList/AdminMemberList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24de361111f0b04cb59052ed4f6ecd3219f4a4fd", @"/Areas/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AdminMemberList_AdminMemberList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Medical.ViewModel.CMemberViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AdminCreate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("fas fa-user-plus"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("Role"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("AdminMemberList"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Student\Source\Repos\MedicalFinal-new-\Medical\Areas\Admin\Views\AdminMemberList\AdminMemberList.cshtml"
  
    ViewData["Title"] = "AdminMemberList";
    Layout = "~/Areas/Admin/Admin_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"btn btn-outline-secondary\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1efa1d3a99f7aa41630e3ab82d4689161036cdb16083", async() => {
                WriteLiteral("新增會員");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n<h1>會員資料管理頁面</h1>\r\n<div class=\"col-md-3\">\r\n    <div>\r\n");
#nullable restore
#line 13 "C:\Users\Student\Source\Repos\MedicalFinal-new-\Medical\Areas\Admin\Views\AdminMemberList\AdminMemberList.cshtml"
         using (Html.BeginForm())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("關鍵字 ");
#nullable restore
#line 15 "C:\Users\Student\Source\Repos\MedicalFinal-new-\Medical\Areas\Admin\Views\AdminMemberList\AdminMemberList.cshtml"
             Write(Html.TextBox("txtKeyword"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <input type=\"submit\" value=\"查詢\" />\r\n");
#nullable restore
#line 17 "C:\Users\Student\Source\Repos\MedicalFinal-new-\Medical\Areas\Admin\Views\AdminMemberList\AdminMemberList.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <a>權限篩選</a>\r\n\r\n");
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1efa1d3a99f7aa41630e3ab82d4689161036cdb18351", async() => {
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1efa1d3a99f7aa41630e3ab82d4689161036cdb18667", async() => {
                    WriteLiteral("\r\n                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1efa1d3a99f7aa41630e3ab82d4689161036cdb18955", async() => {
                        WriteLiteral("權限篩選");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
#nullable restore
#line 26 "C:\Users\Student\Source\Repos\MedicalFinal-new-\Medical\Areas\Admin\Views\AdminMemberList\AdminMemberList.cshtml"
                     foreach (var item in Model.roleTypes)
                    {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1efa1d3a99f7aa41630e3ab82d4689161036cdb110580", async() => {
#nullable restore
#line 28 "C:\Users\Student\Source\Repos\MedicalFinal-new-\Medical\Areas\Admin\Views\AdminMemberList\AdminMemberList.cshtml"
                                              Write(item.RoleName);

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "C:\Users\Student\Source\Repos\MedicalFinal-new-\Medical\Areas\Admin\Views\AdminMemberList\AdminMemberList.cshtml"
                           WriteLiteral(item.Role);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
#nullable restore
#line 29 "C:\Users\Student\Source\Repos\MedicalFinal-new-\Medical\Areas\Admin\Views\AdminMemberList\AdminMemberList.cshtml"
                    }

#line default
#line hidden
#nullable disable
                    WriteLiteral("                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 24 "C:\Users\Student\Source\Repos\MedicalFinal-new-\Medical\Areas\Admin\Views\AdminMemberList\AdminMemberList.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Role);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                <input type=\"submit\" value=\"篩選\" class=\"btn btn-primary\" />\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
</div>





    <table class=""table"">
        <thead>
            <tr>
                <th>
                    序號
                </th>
                <th>
                    信箱
                </th>
                <th>
                    姓名
                </th>
                <th>
                    使用者ID
                </th>
                <th>
                    密碼
                </th>
                <th>
                    生日
                </th>
                <th>
                    性別
                </th>
                <th>
                    健保卡
                </th>
                <th>
                    電話
                </th>
                <th>
                    權限
                </th>
                <th>
                    城市
                </th>
                <th>
                    地址
                </th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 84 "C:\Users\Student\Source\Repos\MedicalFinal-new-\Medical\Areas\Admin\Views\AdminMemberList\AdminMemberList.cshtml"
              
                int count = 0;
                
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "C:\Users\Student\Source\Repos\MedicalFinal-new-\Medical\Areas\Admin\Views\AdminMemberList\AdminMemberList.cshtml"
                 foreach (var item in Model.mem)
                {
                    count++;

                    //前端篩選value=============================================================
                    var ro=Model.roleTypes.Where(t => t.Role == item.Role).Select(n => n.RoleName);  //篩選權限
                    string showRole = "";
                    foreach(var r in ro)
                    {
                        showRole = r;          //只會有一個
                    }
                    //========================
                    var gen = Model.MemGender.Where(t => t.GenderId == item.GenderId).Select(n => n.Gender1);
                    string showGen = "";
                    foreach(var g in gen)
                    {
                        showGen = g;
                    }
                    //========================
                    var ci = Model.MemCity.Where(t => t.CityId == item.CityId).Select(n => n.CityName);
                    string showCity = "";
                    foreach (var c in ci)
                    {
                        showCity = c;
                    }
                    //========================日期格式化，避免生日空值
                    string happyBD = "";
                    if(item.BirthDay!=null)
                    happyBD = item.BirthDay.Value.ToString("yyyy/MM/dd");

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 118 "C:\Users\Student\Source\Repos\MedicalFinal-new-\Medical\Areas\Admin\Views\AdminMemberList\AdminMemberList.cshtml"
               Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 121 "C:\Users\Student\Source\Repos\MedicalFinal-new-\Medical\Areas\Admin\Views\AdminMemberList\AdminMemberList.cshtml"
               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 124 "C:\Users\Student\Source\Repos\MedicalFinal-new-\Medical\Areas\Admin\Views\AdminMemberList\AdminMemberList.cshtml"
               Write(Html.DisplayFor(modelItem => item.MemberName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 127 "C:\Users\Student\Source\Repos\MedicalFinal-new-\Medical\Areas\Admin\Views\AdminMemberList\AdminMemberList.cshtml"
               Write(Html.DisplayFor(modelItem => item.IdentityId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 130 "C:\Users\Student\Source\Repos\MedicalFinal-new-\Medical\Areas\Admin\Views\AdminMemberList\AdminMemberList.cshtml"
               Write(Html.DisplayFor(modelItem => item.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 133 "C:\Users\Student\Source\Repos\MedicalFinal-new-\Medical\Areas\Admin\Views\AdminMemberList\AdminMemberList.cshtml"
               Write(happyBD);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 136 "C:\Users\Student\Source\Repos\MedicalFinal-new-\Medical\Areas\Admin\Views\AdminMemberList\AdminMemberList.cshtml"
               Write(showGen);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 139 "C:\Users\Student\Source\Repos\MedicalFinal-new-\Medical\Areas\Admin\Views\AdminMemberList\AdminMemberList.cshtml"
               Write(Html.DisplayFor(modelItem => item.IcCardNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 142 "C:\Users\Student\Source\Repos\MedicalFinal-new-\Medical\Areas\Admin\Views\AdminMemberList\AdminMemberList.cshtml"
               Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 145 "C:\Users\Student\Source\Repos\MedicalFinal-new-\Medical\Areas\Admin\Views\AdminMemberList\AdminMemberList.cshtml"
               Write(showRole);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 148 "C:\Users\Student\Source\Repos\MedicalFinal-new-\Medical\Areas\Admin\Views\AdminMemberList\AdminMemberList.cshtml"
               Write(showCity);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 151 "C:\Users\Student\Source\Repos\MedicalFinal-new-\Medical\Areas\Admin\Views\AdminMemberList\AdminMemberList.cshtml"
               Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 154 "C:\Users\Student\Source\Repos\MedicalFinal-new-\Medical\Areas\Admin\Views\AdminMemberList\AdminMemberList.cshtml"
               Write(Html.ActionLink("", "Edit", "AdminMemberList", new { id = item.MemberId }, new { Class = "fas fa-edit" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 155 "C:\Users\Student\Source\Repos\MedicalFinal-new-\Medical\Areas\Admin\Views\AdminMemberList\AdminMemberList.cshtml"
               Write(Html.ActionLink("", "Delete", "AdminMemberList", new { id = item.MemberId }, new { onclick = "return confirm('確定要刪除資料嗎?')", Class = "fas fa-trash" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 158 "C:\Users\Student\Source\Repos\MedicalFinal-new-\Medical\Areas\Admin\Views\AdminMemberList\AdminMemberList.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n    <br />\r\n    <br />\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Medical.ViewModel.CMemberViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
