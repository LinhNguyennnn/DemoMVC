#pragma checksum "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46eb980b418944a6c94fc12d64103174fe95f20f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Home), @"mvc.1.0.view", @"/Views/Home/Home.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Home.cshtml", typeof(AspNetCore.Views_Home_Home))]
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
#line 1 "C:\Users\lenovo\Desktop\DemoMVC\Views\_ViewImports.cshtml"
using DemoMVC;

#line default
#line hidden
#line 2 "C:\Users\lenovo\Desktop\DemoMVC\Views\_ViewImports.cshtml"
using DemoMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46eb980b418944a6c94fc12d64103174fe95f20f", @"/Views/Home/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4f3640992204b1ab1edab80a3d884ce08f2b2b0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/Home"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
  
ViewData["Title"] = "VTCA";

#line default
#line hidden
            BeginContext(36, 129, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <h3>\r\n                Xin chào, ");
            EndContext();
            BeginContext(166, 16, false);
#line 9 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                     Write(ViewBag.Username);

#line default
#line hidden
            EndContext();
            BeginContext(182, 263, true);
            WriteLiteral(@"
            </h3>
            <input type=""button"" class=""btn btn-primary ml-auto"" value=""Đăng xuất""
                onclick=""window.location.href = '/Home/Logout'"">
        </div>
    </div>
    <div class=""row"">
        <div class=""col-3"">
            ");
            EndContext();
            BeginContext(445, 771, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46eb980b418944a6c94fc12d64103174fe95f20f4749", async() => {
                BeginContext(485, 724, true);
                WriteLiteral(@"
                <ul class=""nav nav-pills flex-column"">
                    <li class=""nav-item"">
                        <a class=""nav-link active"" data-toggle=""tab"" href=""#home"">Soạn thư</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" onclick=""send()"" data-toggle=""tab"" href=""#menu1"">Đã gửi</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" onclick=""receiver()"" data-toggle=""tab"" href=""#menu2"">Đã nhận
                            <span class=""badge badge-primary badge-pill"">14</span>
                        </a>
                    </li>
                </ul>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1216, 179, true);
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"col-9\">\r\n            <div class=\"tab-content\">\r\n                <div id=\"home\" class=\"container tab-pane active\"><br>\r\n                    ");
            EndContext();
            BeginContext(1395, 1131, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46eb980b418944a6c94fc12d64103174fe95f20f7433", async() => {
                BeginContext(1435, 1084, true);
                WriteLiteral(@"
                        <div class=""form-group wrap-compose d-flex flex-wrap align-items-center"">
                            <label>Người nhận</label>
                            <textarea id=""receiver"" name=""receiver"" placeholder=""Nhập tên người nhận""
                                class=""form-control js-formatInputName receiver""></textarea>
                        </div>
                        <div class=""form-group"">
                            <label>Tiêu đề</label>
                            <input type=""text"" class=""form-control "" name=""title"" placeholder=""Nhập tiêu đề"" required>
                        </div>
                        <div>
                            <label>Nội dung</label>
                            <br>
                            <textarea id=""subject"" class=""form-control"" name=""content"" placeholder=""Nhập nội dung ...""
                                style=""height:200px"" required></textarea>
                        </div>
                        <button class=""b");
                WriteLiteral("tn btn-primary\" id=\"send\">Gửi</button>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2526, 116, true);
            WriteLiteral("\r\n                </div>\r\n                <div id=\"menu1\" class=\"container tab-pane fade\"><br>\r\n                    ");
            EndContext();
            BeginContext(2642, 2545, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46eb980b418944a6c94fc12d64103174fe95f20f10445", async() => {
                BeginContext(2682, 273, true);
                WriteLiteral(@"
                        <div class=""huhu"">
                            <p>Người nhận</p>
                            <p>Tiêu đề</p>
                            <p>Nội dung</p>
                        </div>
                        <ul class=""list-group"" id=""hihi"">
");
                EndContext();
#line 64 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                             if(ViewBag.ListMailSend != null)
                            {
                            

#line default
#line hidden
#line 66 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                             foreach (var item in ViewBag.ListMailSend)
                            {

#line default
#line hidden
                BeginContext(3153, 48, true);
                WriteLiteral("                            <a class=\"card-link\"");
                EndContext();
                BeginWriteAttribute("onclick", "\r\n                                onclick=\"", 3201, "\"", 3319, 9);
                WriteAttributeValue("", 3244, "detail(\'", 3244, 8, true);
#line 69 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
WriteAttributeValue("", 3252, item.Receiver.Username, 3252, 23, false);

#line default
#line hidden
                WriteAttributeValue("", 3275, "\',", 3275, 2, true);
                WriteAttributeValue(" ", 3277, "\'", 3278, 2, true);
#line 69 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
WriteAttributeValue("", 3279, item.Mail.Title, 3279, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 3295, "\',", 3295, 2, true);
                WriteAttributeValue(" ", 3297, "\'", 3298, 2, true);
#line 69 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
WriteAttributeValue("", 3299, item.Mail.Content, 3299, 18, false);

#line default
#line hidden
                WriteAttributeValue("", 3317, "\')", 3317, 2, true);
                EndWriteAttribute();
                BeginContext(3320, 575, true);
                WriteLiteral(@"
                                data-toggle=""modal"" data-target=""#detailmail"" id=""recivermail"">
                                <li class=""list-group-item"">
                                    <div class=""container"">
                                        <div class=""row"">
                                            <div class=""col-4 text-truncate"">
                                                <b class=""text-dark d-inline-block"" id=""re_name"">Người
                                                    nhận:
                                                    ");
                EndContext();
                BeginContext(3896, 22, false);
#line 77 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                                               Write(item.Receiver.Username);

#line default
#line hidden
                EndContext();
                BeginContext(3918, 230, true);
                WriteLiteral("</b>\r\n                                            </div>\r\n                                            <div class=\"col-7 contentt\">\r\n                                                <div class=\"col-6 text-truncate\"><b id=\"re_title\">");
                EndContext();
                BeginContext(4149, 15, false);
#line 80 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                                                                                             Write(item.Mail.Title);

#line default
#line hidden
                EndContext();
                BeginContext(4164, 225, true);
                WriteLiteral("</b>\r\n                                                </div>\r\n                                                <div class=\"col-6 text-truncate\"><span id=\"re_contnent\">-\r\n                                                        ");
                EndContext();
                BeginContext(4390, 17, false);
#line 83 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                                                   Write(item.Mail.Content);

#line default
#line hidden
                EndContext();
                BeginContext(4407, 210, true);
                WriteLiteral("</span></div>\r\n                                            </div>\r\n                                            <div class=\"col-1\">\r\n                                                <button class=\"btn btn-danger\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 4617, "\"", 4685, 5);
                WriteAttributeValue("", 4627, "window.location.href", 4627, 20, true);
                WriteAttributeValue(" ", 4647, "=", 4648, 2, true);
                WriteAttributeValue(" ", 4649, "\'/Home/RemoveSender(", 4650, 21, true);
#line 86 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
WriteAttributeValue("", 4670, item.Mail_Id, 4670, 13, false);

#line default
#line hidden
                WriteAttributeValue("", 4683, ")\'", 4683, 2, true);
                EndWriteAttribute();
                BeginContext(4686, 381, true);
                WriteLiteral(@">
                                                    <i class=""fa fa-trash-o"" aria-hidden=""true""></i>
                                                </button>
                                            </div>
                                        </div>
                                    </div>
                                </li>
                            </a>
");
                EndContext();
#line 94 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                            }

#line default
#line hidden
#line 94 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                             
                            }

#line default
#line hidden
                BeginContext(5129, 51, true);
                WriteLiteral("                        </ul>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5187, 117, true);
            WriteLiteral(" \r\n                </div>\r\n                <div id=\"menu2\" class=\"container tab-pane fade\"><br>\r\n                    ");
            EndContext();
            BeginContext(5304, 2032, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46eb980b418944a6c94fc12d64103174fe95f20f18363", async() => {
                BeginContext(5344, 61, true);
                WriteLiteral("\r\n                        <ul class=\"list-group\" id=\"haha\">\r\n");
                EndContext();
#line 102 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                             if(ViewBag.ListMailReceiver != null)
                            {
                            

#line default
#line hidden
#line 104 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                             foreach (var item in ViewBag.ListMailReceiver){

#line default
#line hidden
                BeginContext(5581, 48, true);
                WriteLiteral("                            <a class=\"card-link\"");
                EndContext();
                BeginWriteAttribute("onclick", "\r\n                                onclick=\"", 5629, "\"", 5744, 8);
                WriteAttributeValue("", 5672, "detail(\'", 5672, 8, true);
#line 106 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
WriteAttributeValue("", 5680, item.Sender.Username, 5680, 21, false);

#line default
#line hidden
                WriteAttributeValue("", 5701, "\',\'", 5701, 3, true);
#line 106 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
WriteAttributeValue("", 5704, item.Mail.Title, 5704, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 5720, "\',", 5720, 2, true);
                WriteAttributeValue(" ", 5722, "\'", 5723, 2, true);
#line 106 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
WriteAttributeValue("", 5724, item.Mail.Content, 5724, 18, false);

#line default
#line hidden
                WriteAttributeValue("", 5742, "\')", 5742, 2, true);
                EndWriteAttribute();
                BeginContext(5745, 437, true);
                WriteLiteral(@"
                                data-toggle=""modal"" data-target=""#detailmail"" id=""sendmail"">
                                <li class=""list-group-item"">
                                    <div class=""container"">
                                        <div class=""row"">
                                            <div class=""col-4 text-truncate"">
                                                <b class=""text-dark"">Người gửi: ");
                EndContext();
                BeginContext(6183, 20, false);
#line 112 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                                                                           Write(item.Sender.Username);

#line default
#line hidden
                EndContext();
                BeginContext(6203, 216, true);
                WriteLiteral("</b>\r\n                                            </div>\r\n                                            <div class=\"col-7 contentt\">\r\n                                                <div class=\"col-6 text-truncate\"><b>");
                EndContext();
                BeginContext(6420, 15, false);
#line 115 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                                                                               Write(item.Mail.Title);

#line default
#line hidden
                EndContext();
                BeginContext(6435, 101, true);
                WriteLiteral("</b></div>\r\n                                                <div class=\"col-6 text-truncate\"><span>- ");
                EndContext();
                BeginContext(6537, 17, false);
#line 116 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                                                                                    Write(item.Mail.Content);

#line default
#line hidden
                EndContext();
                BeginContext(6554, 210, true);
                WriteLiteral("</span></div>\r\n                                            </div>\r\n                                            <div class=\"col-1\">\r\n                                                <button class=\"btn btn-danger\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 6764, "\"", 6834, 5);
                WriteAttributeValue("", 6774, "window.location.href", 6774, 20, true);
                WriteAttributeValue(" ", 6794, "=", 6795, 2, true);
                WriteAttributeValue(" ", 6796, "\'/Home/RemoveReceiver(", 6797, 23, true);
#line 119 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
WriteAttributeValue("", 6819, item.Mail_Id, 6819, 13, false);

#line default
#line hidden
                WriteAttributeValue("", 6832, ")\'", 6832, 2, true);
                EndWriteAttribute();
                BeginContext(6835, 381, true);
                WriteLiteral(@">
                                                    <i class=""fa fa-trash-o"" aria-hidden=""true""></i>
                                                </button>
                                            </div>
                                        </div>
                                    </div>
                                </li>
                            </a>
");
                EndContext();
#line 127 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                            }

#line default
#line hidden
#line 127 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                             
                            }

#line default
#line hidden
                BeginContext(7278, 51, true);
                WriteLiteral("                        </ul>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7336, 468, true);
            WriteLiteral(@"
                </div>
                <div id=""maildetail"">
                    <div>
                        <h3 id=""title-detail""></h3>
                    </div>
                    <div>
                        <p id=""receiver-detail""></p>
                    </div>
                    <div>
                        <p id=""content-detail""></p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>");
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
