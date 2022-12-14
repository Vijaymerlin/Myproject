#pragma checksum "E:\Project\Myproject\Myproject\Pages\Employees\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "590e6eb7cd86f2a6b8984b0058df38092b4c30fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Myproject.Pages.Employees.Pages_Employees_Index), @"mvc.1.0.razor-page", @"/Pages/Employees/Index.cshtml")]
namespace Myproject.Pages.Employees
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"590e6eb7cd86f2a6b8984b0058df38092b4c30fb", @"/Pages/Employees/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb88780b50e31aa3b52f58d2aac88462c77fe759", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Employees_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<br />
<h2>List of Employees</h2>
<a class='btn btn-primary btn-sm' href='/Employees/Create'>New Employee</a>
<a class='btn btn-primary btn-sm' href='/Assign_task/Task'>Assign Task</a>

<table class=""table"">
    <thead>
        <tr>
            <th>ID</th>
            <th>Name</th>
            <th>Email</th>
            <th>Phone</th>
            <th>Address</th>
            <th>Created at</th>
            <th style=""display:none"">Task</th>
            <th>Action</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 24 "E:\Project\Myproject\Myproject\Pages\Employees\Index.cshtml"
         foreach (var item in Model.listEmployees)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 27 "E:\Project\Myproject\Myproject\Pages\Employees\Index.cshtml"
               Write(item.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "E:\Project\Myproject\Myproject\Pages\Employees\Index.cshtml"
               Write(item.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "E:\Project\Myproject\Myproject\Pages\Employees\Index.cshtml"
               Write(item.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "E:\Project\Myproject\Myproject\Pages\Employees\Index.cshtml"
               Write(item.phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "E:\Project\Myproject\Myproject\Pages\Employees\Index.cshtml"
               Write(item.address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "E:\Project\Myproject\Myproject\Pages\Employees\Index.cshtml"
               Write(item.created_at);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td style=\"display:none\">");
#nullable restore
#line 33 "E:\Project\Myproject\Myproject\Pages\Employees\Index.cshtml"
                                    Write(item.task);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a class=\"btn btn-primary btn-sm\"");
            BeginWriteAttribute("href", " href=\"", 1035, "\"", 1069, 2);
            WriteAttributeValue("", 1042, "/Employees/Edit?id=", 1042, 19, true);
#nullable restore
#line 35 "E:\Project\Myproject\Myproject\Pages\Employees\Index.cshtml"
WriteAttributeValue("", 1061, item.id, 1061, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> \r\n                    <a class=\"btn btn-danger btn-sm\"");
            BeginWriteAttribute("href", " href=\"", 1134, "\"", 1170, 2);
            WriteAttributeValue("", 1141, "/Employees/Delete?id=", 1141, 21, true);
#nullable restore
#line 36 "E:\Project\Myproject\Myproject\Pages\Employees\Index.cshtml"
WriteAttributeValue("", 1162, item.id, 1162, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 39 "E:\Project\Myproject\Myproject\Pages\Employees\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Myproject.Pages.Employees.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Myproject.Pages.Employees.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Myproject.Pages.Employees.IndexModel>)PageContext?.ViewData;
        public Myproject.Pages.Employees.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
