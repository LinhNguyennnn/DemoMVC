#pragma checksum "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0dd06de749f8af9f1abd11c033251c21ddc9229a"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0dd06de749f8af9f1abd11c033251c21ddc9229a", @"/Views/Home/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4f3640992204b1ab1edab80a3d884ce08f2b2b0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/Home"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("hihi"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("haha"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("restore"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(445, 860, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0dd06de749f8af9f1abd11c033251c21ddc9229a5775", async() => {
                BeginContext(485, 813, true);
                WriteLiteral(@"
                <ul class=""nav nav-pills flex-column"">
                    <li class=""nav-item"">
                        <a class=""nav-link active"" onclick=""start()"" data-toggle=""tab"" href=""#home"">Soạn thư</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" onclick=""send()"" data-toggle=""tab"" href=""#menu1"">Đã gửi</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" onclick=""receiver()"" data-toggle=""tab"" href=""#menu2"">Đã nhận</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" onclick=""restore()"" data-toggle=""tab"" href=""#menu3"">Thùng rác</a>
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
            BeginContext(1305, 179, true);
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"col-9\">\r\n            <div class=\"tab-content\">\r\n                <div id=\"home\" class=\"container tab-pane active\"><br>\r\n                    ");
            EndContext();
            BeginContext(1484, 1131, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0dd06de749f8af9f1abd11c033251c21ddc9229a8558", async() => {
                BeginContext(1524, 1084, true);
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
            BeginContext(2615, 116, true);
            WriteLiteral("\r\n                </div>\r\n                <div id=\"menu1\" class=\"container tab-pane fade\"><br>\r\n                    ");
            EndContext();
            BeginContext(2731, 2510, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0dd06de749f8af9f1abd11c033251c21ddc9229a11570", async() => {
                BeginContext(2781, 51, true);
                WriteLiteral("\r\n                        <ul class=\"list-group\">\r\n");
                EndContext();
#line 60 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                             if(ViewBag.ListMailSend != null)
                            {
                            

#line default
#line hidden
#line 62 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                             foreach (var item in ViewBag.ListMailSend)
                            {
                            

#line default
#line hidden
#line 64 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                             if (item.Remove == 1 || item.Remove == 3)
                            {}
                            else{

#line default
#line hidden
                BeginContext(3169, 48, true);
                WriteLiteral("                            <a class=\"card-link\"");
                EndContext();
                BeginWriteAttribute("onclick", "\r\n                                onclick=\"", 3217, "\"", 3335, 9);
                WriteAttributeValue("", 3260, "detail(\'", 3260, 8, true);
#line 68 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
WriteAttributeValue("", 3268, item.Receiver.Username, 3268, 23, false);

#line default
#line hidden
                WriteAttributeValue("", 3291, "\',", 3291, 2, true);
                WriteAttributeValue(" ", 3293, "\'", 3294, 2, true);
#line 68 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
WriteAttributeValue("", 3295, item.Mail.Title, 3295, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 3311, "\',", 3311, 2, true);
                WriteAttributeValue(" ", 3313, "\'", 3314, 2, true);
#line 68 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
WriteAttributeValue("", 3315, item.Mail.Content, 3315, 18, false);

#line default
#line hidden
                WriteAttributeValue("", 3333, "\')", 3333, 2, true);
                EndWriteAttribute();
                BeginContext(3336, 522, true);
                WriteLiteral(@"
                                data-toggle=""modal"" data-target=""#detailmail"" id=""recivermail"">
                                <li class=""list-group-item"">
                                    <div class=""container"">
                                        <div class=""row"">
                                            <div class=""col-4 text-truncate"">
                                                <b class=""text-dark d-inline-block"" id=""re_name"">Người nhận:
                                                    ");
                EndContext();
                BeginContext(3859, 22, false);
#line 75 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                                               Write(item.Receiver.Username);

#line default
#line hidden
                EndContext();
                BeginContext(3881, 230, true);
                WriteLiteral("</b>\r\n                                            </div>\r\n                                            <div class=\"col-7 contentt\">\r\n                                                <div class=\"col-6 text-truncate\"><b id=\"re_title\">");
                EndContext();
                BeginContext(4112, 15, false);
#line 78 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                                                                                             Write(item.Mail.Title);

#line default
#line hidden
                EndContext();
                BeginContext(4127, 225, true);
                WriteLiteral("</b>\r\n                                                </div>\r\n                                                <div class=\"col-6 text-truncate\"><span id=\"re_contnent\">-\r\n                                                        ");
                EndContext();
                BeginContext(4353, 17, false);
#line 81 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                                                   Write(item.Mail.Content);

#line default
#line hidden
                EndContext();
                BeginContext(4370, 210, true);
                WriteLiteral("</span></div>\r\n                                            </div>\r\n                                            <div class=\"col-1\">\r\n                                                <button class=\"btn btn-danger\"");
                EndContext();
                BeginWriteAttribute("onclick", "\r\n                                                    onclick=\"", 4580, "\"", 4708, 5);
                WriteAttributeValue("", 4643, "window.location.href", 4643, 20, true);
                WriteAttributeValue(" ", 4663, "=", 4664, 2, true);
                WriteAttributeValue(" ", 4665, "\'/Home/RemoveSender?Mail_id=", 4666, 29, true);
#line 85 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
WriteAttributeValue("", 4694, item.Mail_Id, 4694, 13, false);

#line default
#line hidden
                WriteAttributeValue("", 4707, "\'", 4707, 1, true);
                EndWriteAttribute();
                BeginContext(4709, 381, true);
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
#line 93 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                            }

#line default
#line hidden
#line 93 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                             
                            }

#line default
#line hidden
#line 94 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                             
                            }

#line default
#line hidden
                BeginContext(5183, 51, true);
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5241, 116, true);
            WriteLiteral("\r\n                </div>\r\n                <div id=\"menu2\" class=\"container tab-pane fade\"><br>\r\n                    ");
            EndContext();
            BeginContext(5357, 2262, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0dd06de749f8af9f1abd11c033251c21ddc9229a19782", async() => {
                BeginContext(5407, 51, true);
                WriteLiteral("\r\n                        <ul class=\"list-group\">\r\n");
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
#line 105 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                             if (item.Remove == 2 || item.Remove == 3)
                            {}
                            else{

#line default
#line hidden
                BeginContext(5773, 48, true);
                WriteLiteral("                            <a class=\"card-link\"");
                EndContext();
                BeginWriteAttribute("onclick", "\r\n                                onclick=\"", 5821, "\"", 5936, 8);
                WriteAttributeValue("", 5864, "detail(\'", 5864, 8, true);
#line 109 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
WriteAttributeValue("", 5872, item.Sender.Username, 5872, 21, false);

#line default
#line hidden
                WriteAttributeValue("", 5893, "\',\'", 5893, 3, true);
#line 109 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
WriteAttributeValue("", 5896, item.Mail.Title, 5896, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 5912, "\',", 5912, 2, true);
                WriteAttributeValue(" ", 5914, "\'", 5915, 2, true);
#line 109 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
WriteAttributeValue("", 5916, item.Mail.Content, 5916, 18, false);

#line default
#line hidden
                WriteAttributeValue("", 5934, "\')", 5934, 2, true);
                EndWriteAttribute();
                BeginContext(5937, 437, true);
                WriteLiteral(@"
                                data-toggle=""modal"" data-target=""#detailmail"" id=""sendmail"">
                                <li class=""list-group-item"">
                                    <div class=""container"">
                                        <div class=""row"">
                                            <div class=""col-4 text-truncate"">
                                                <b class=""text-dark"">Người gửi: ");
                EndContext();
                BeginContext(6375, 20, false);
#line 115 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                                                                           Write(item.Sender.Username);

#line default
#line hidden
                EndContext();
                BeginContext(6395, 216, true);
                WriteLiteral("</b>\r\n                                            </div>\r\n                                            <div class=\"col-7 contentt\">\r\n                                                <div class=\"col-6 text-truncate\"><b>");
                EndContext();
                BeginContext(6612, 15, false);
#line 118 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                                                                               Write(item.Mail.Title);

#line default
#line hidden
                EndContext();
                BeginContext(6627, 101, true);
                WriteLiteral("</b></div>\r\n                                                <div class=\"col-6 text-truncate\"><span>- ");
                EndContext();
                BeginContext(6729, 17, false);
#line 119 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                                                                                    Write(item.Mail.Content);

#line default
#line hidden
                EndContext();
                BeginContext(6746, 210, true);
                WriteLiteral("</span></div>\r\n                                            </div>\r\n                                            <div class=\"col-1\">\r\n                                                <button class=\"btn btn-danger\"");
                EndContext();
                BeginWriteAttribute("onclick", "\r\n                                                    onclick=\"", 6956, "\"", 7086, 5);
                WriteAttributeValue("", 7019, "window.location.href", 7019, 20, true);
                WriteAttributeValue(" ", 7039, "=", 7040, 2, true);
                WriteAttributeValue(" ", 7041, "\'/Home/RemoveReceiver?Mail_id=", 7042, 31, true);
#line 123 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
WriteAttributeValue("", 7072, item.Mail_Id, 7072, 13, false);

#line default
#line hidden
                WriteAttributeValue("", 7085, "\'", 7085, 1, true);
                EndWriteAttribute();
                BeginContext(7087, 381, true);
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
#line 131 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                            }

#line default
#line hidden
#line 131 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                             
                            }

#line default
#line hidden
#line 132 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                             
                            }

#line default
#line hidden
                BeginContext(7561, 51, true);
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7619, 116, true);
            WriteLiteral("\r\n                </div>\r\n                <div id=\"menu3\" class=\"container tab-pane fade\"><br>\r\n                    ");
            EndContext();
            BeginContext(7735, 3575, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0dd06de749f8af9f1abd11c033251c21ddc9229a27729", async() => {
                BeginContext(7788, 51, true);
                WriteLiteral("\r\n                        <ul class=\"list-group\">\r\n");
                EndContext();
#line 140 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                             if(ViewBag.ListMailinTrash != null)
                            {
                            

#line default
#line hidden
#line 142 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                             foreach (var item in ViewBag.ListMailinTrash){
                            

#line default
#line hidden
#line 143 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                             if (item.Remove == 1 || item.Remove == 3){
                            

#line default
#line hidden
#line 144 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                             if (item.Sender.Username == ViewBag.Username)
                            {

#line default
#line hidden
                BeginContext(8193, 48, true);
                WriteLiteral("                            <a class=\"card-link\"");
                EndContext();
                BeginWriteAttribute("onclick", "\r\n                                onclick=\"", 8241, "\"", 8356, 8);
                WriteAttributeValue("", 8284, "detail(\'", 8284, 8, true);
#line 147 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
WriteAttributeValue("", 8292, item.Sender.Username, 8292, 21, false);

#line default
#line hidden
                WriteAttributeValue("", 8313, "\',\'", 8313, 3, true);
#line 147 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
WriteAttributeValue("", 8316, item.Mail.Title, 8316, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 8332, "\',", 8332, 2, true);
                WriteAttributeValue(" ", 8334, "\'", 8335, 2, true);
#line 147 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
WriteAttributeValue("", 8336, item.Mail.Content, 8336, 18, false);

#line default
#line hidden
                WriteAttributeValue("", 8354, "\')", 8354, 2, true);
                EndWriteAttribute();
                BeginContext(8357, 423, true);
                WriteLiteral(@"
                                data-toggle=""modal"" data-target=""#detailmail"" id=""trash"">
                                <li class=""list-group-item"">
                                    <div class=""container"">
                                        <div class=""row"">
                                            <div class=""col-4 text-truncate"">
                                                <b class=""text-dark"">");
                EndContext();
                BeginContext(8781, 22, false);
#line 153 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                                                                Write(item.Receiver.Username);

#line default
#line hidden
                EndContext();
                BeginContext(8803, 216, true);
                WriteLiteral("</b>\r\n                                            </div>\r\n                                            <div class=\"col-7 contentt\">\r\n                                                <div class=\"col-6 text-truncate\"><b>");
                EndContext();
                BeginContext(9020, 15, false);
#line 156 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                                                                               Write(item.Mail.Title);

#line default
#line hidden
                EndContext();
                BeginContext(9035, 101, true);
                WriteLiteral("</b></div>\r\n                                                <div class=\"col-6 text-truncate\"><span>- ");
                EndContext();
                BeginContext(9137, 17, false);
#line 157 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                                                                                    Write(item.Mail.Content);

#line default
#line hidden
                EndContext();
                BeginContext(9154, 349, true);
                WriteLiteral(@"</span></div>
                                            </div>
                                            <div class=""col-1"">
                                            </div>
                                        </div>
                                    </div>
                                </li>
                            </a>
");
                EndContext();
#line 165 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                            }
                            else{}

#line default
#line hidden
#line 166 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                                  
                            }

#line default
#line hidden
#line 168 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                             if (item.Remove == 2 || item.Remove == 3){
                            

#line default
#line hidden
#line 169 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                             if (item.Receiver.Username == ViewBag.Username)
                            {

#line default
#line hidden
                BeginContext(9783, 48, true);
                WriteLiteral("                            <a class=\"card-link\"");
                EndContext();
                BeginWriteAttribute("onclick", "\r\n                                onclick=\"", 9831, "\"", 9946, 8);
                WriteAttributeValue("", 9874, "detail(\'", 9874, 8, true);
#line 172 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
WriteAttributeValue("", 9882, item.Sender.Username, 9882, 21, false);

#line default
#line hidden
                WriteAttributeValue("", 9903, "\',\'", 9903, 3, true);
#line 172 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
WriteAttributeValue("", 9906, item.Mail.Title, 9906, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 9922, "\',", 9922, 2, true);
                WriteAttributeValue(" ", 9924, "\'", 9925, 2, true);
#line 172 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
WriteAttributeValue("", 9926, item.Mail.Content, 9926, 18, false);

#line default
#line hidden
                WriteAttributeValue("", 9944, "\')", 9944, 2, true);
                EndWriteAttribute();
                BeginContext(9947, 424, true);
                WriteLiteral(@"
                                data-toggle=""modal"" data-target=""#detailmail"" id=""trash2"">
                                <li class=""list-group-item"">
                                    <div class=""container"">
                                        <div class=""row"">
                                            <div class=""col-4 text-truncate"">
                                                <b class=""text-dark"">");
                EndContext();
                BeginContext(10372, 20, false);
#line 178 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                                                                Write(item.Sender.Username);

#line default
#line hidden
                EndContext();
                BeginContext(10392, 216, true);
                WriteLiteral("</b>\r\n                                            </div>\r\n                                            <div class=\"col-7 contentt\">\r\n                                                <div class=\"col-6 text-truncate\"><b>");
                EndContext();
                BeginContext(10609, 15, false);
#line 181 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                                                                               Write(item.Mail.Title);

#line default
#line hidden
                EndContext();
                BeginContext(10624, 101, true);
                WriteLiteral("</b></div>\r\n                                                <div class=\"col-6 text-truncate\"><span>- ");
                EndContext();
                BeginContext(10726, 17, false);
#line 182 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                                                                                    Write(item.Mail.Content);

#line default
#line hidden
                EndContext();
                BeginContext(10743, 349, true);
                WriteLiteral(@"</span></div>
                                            </div>
                                            <div class=""col-1"">
                                            </div>
                                        </div>
                                    </div>
                                </li>
                            </a>
");
                EndContext();
#line 190 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                            }
                            else{}

#line default
#line hidden
#line 191 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                                  
                            }

#line default
#line hidden
#line 192 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                             
                            }

#line default
#line hidden
#line 193 "C:\Users\lenovo\Desktop\DemoMVC\Views\Home\Home.cshtml"
                             
                            }

#line default
#line hidden
                BeginContext(11252, 51, true);
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(11310, 522, true);
            WriteLiteral(@"
                </div>
                <div id=""maildetail"">
                    <div>
                        <h3 id=""title-detail""></h3>
                    </div>
                    <hr>
                    <div>
                        <h5 id=""receiver-detail""></h5>
                    </div>
                    <hr>
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
