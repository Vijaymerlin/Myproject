#pragma checksum "E:\Project\Myproject\Myproject\Pages\Assign_Task\Edit_task.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6f717f9f717ae78c6eb5dc585f5f77fb64c9c96"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Myproject.Pages.Assign_Task.Pages_Assign_Task_Edit_task), @"mvc.1.0.razor-page", @"/Pages/Assign_Task/Edit_task.cshtml")]
namespace Myproject.Pages.Assign_Task
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
#line 1 "E:\Project\Myproject\Myproject\Pages\_ViewImports.cshtml"
using Myproject;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6f717f9f717ae78c6eb5dc585f5f77fb64c9c96", @"/Pages/Assign_Task/Edit_task.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb88780b50e31aa3b52f58d2aac88462c77fe759", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Assign_Task_Edit_task : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<br />\r\n<h2>Edit Task</h2>\r\n\r\n");
#nullable restore
#line 9 "E:\Project\Myproject\Myproject\Pages\Assign_Task\Edit_task.cshtml"
 if (Model.errormessage.Length > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-warning alert-heading fade show\">\r\n        <strong>");
#nullable restore
#line 12 "E:\Project\Myproject\Myproject\Pages\Assign_Task\Edit_task.cshtml"
           Write(Model.errormessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n\r\n        <button type=\"button\" class=\"btn-close\" data-bs-dismiss=\"alert\" aria-label=\"close\"></button>\r\n    </div>\r\n");
#nullable restore
#line 16 "E:\Project\Myproject\Myproject\Pages\Assign_Task\Edit_task.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b6f717f9f717ae78c6eb5dc585f5f77fb64c9c964244", async() => {
                WriteLiteral("\r\n    <input type=\"hidden\" name=\"empid\"");
                BeginWriteAttribute("value", " value=\"", 428, "\"", 462, 1);
#nullable restore
#line 20 "E:\Project\Myproject\Myproject\Pages\Assign_Task\Edit_task.cshtml"
WriteAttributeValue("", 436, Model.employeesInfo.empid, 436, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <div class=\"row mb-3\">\r\n        <label class=\"col-sm-3 col-form-label\">Name</label>\r\n        <div class=\"col-sm-6\">\r\n            <input type=\"text\" class=\"form-control\" name=\"emp_name\"");
                BeginWriteAttribute("value", " value=\"", 656, "\"", 693, 1);
#nullable restore
#line 24 "E:\Project\Myproject\Myproject\Pages\Assign_Task\Edit_task.cshtml"
WriteAttributeValue("", 664, Model.employeesInfo.emp_name, 664, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        </div>\r\n    </div>\r\n    <div class=\"row mb-3\">\r\n        <label class=\"col-sm-3 col-form-label\">Task</label>\r\n        <div class=\"col-sm-6\">\r\n            <input type=\"text\" class=\"form-control\" name=\"emp_task\"");
                BeginWriteAttribute("value", " value=\"", 915, "\"", 952, 1);
#nullable restore
#line 30 "E:\Project\Myproject\Myproject\Pages\Assign_Task\Edit_task.cshtml"
WriteAttributeValue("", 923, Model.employeesInfo.emp_task, 923, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        </div>\r\n    </div>\r\n\r\n");
#nullable restore
#line 34 "E:\Project\Myproject\Myproject\Pages\Assign_Task\Edit_task.cshtml"
     if (Model.successmessage.Length > 0)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\'alert alert-success alert-dismissible fade show\' role=\'alert\'>\r\n            <strong>");
#nullable restore
#line 37 "E:\Project\Myproject\Myproject\Pages\Assign_Task\Edit_task.cshtml"
               Write(Model.successmessage);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong>\r\n            <button type=\'button\' class=\'btn-close\' data-bs-dismiss=\'alert\' aria-label=\'close\'></button>\r\n        </div>\r\n");
#nullable restore
#line 40 "E:\Project\Myproject\Myproject\Pages\Assign_Task\Edit_task.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

    <div class=""row mb-3"">
        <div class=""offset-sm-3 col-sm-3 d-grid"">
            <button type=""submit"" class=""btn btn-primary"">Submit</button>
        </div>
        <div class=""col-sm-3 d-grid"">
            <a class=""btn btn-outline-primary"" href=""/"" role=""button"">Cancel</a>
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Myproject.Pages.Assign_Task.Edit_taskModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Myproject.Pages.Assign_Task.Edit_taskModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Myproject.Pages.Assign_Task.Edit_taskModel>)PageContext?.ViewData;
        public Myproject.Pages.Assign_Task.Edit_taskModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
