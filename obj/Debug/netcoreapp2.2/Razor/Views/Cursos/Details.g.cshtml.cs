#pragma checksum "c:\Users\caioo\desktop\CursoCliente3\Views\Cursos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f637ca31313822c0c9b00aa2cdd2f730bf78c42e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cursos_Details), @"mvc.1.0.view", @"/Views/Cursos/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cursos/Details.cshtml", typeof(AspNetCore.Views_Cursos_Details))]
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
#line 1 "c:\Users\caioo\desktop\CursoCliente3\Views\_ViewImports.cshtml"
using CursoCLiente3;

#line default
#line hidden
#line 2 "c:\Users\caioo\desktop\CursoCliente3\Views\_ViewImports.cshtml"
using CursoCLiente3.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f637ca31313822c0c9b00aa2cdd2f730bf78c42e", @"/Views/Cursos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9dabde4007ef3c671a9416189d2c8b6631f7a831", @"/Views/_ViewImports.cshtml")]
    public class Views_Cursos_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CursoCliente3.Models.Curso>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "c:\Users\caioo\desktop\CursoCliente3\Views\Cursos\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(80, 128, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Curso</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(209, 40, false);
#line 14 "c:\Users\caioo\desktop\CursoCliente3\Views\Cursos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(249, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(313, 36, false);
#line 17 "c:\Users\caioo\desktop\CursoCliente3\Views\Cursos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(349, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(412, 47, false);
#line 20 "c:\Users\caioo\desktop\CursoCliente3\Views\Cursos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DataInicial));

#line default
#line hidden
            EndContext();
            BeginContext(459, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(523, 43, false);
#line 23 "c:\Users\caioo\desktop\CursoCliente3\Views\Cursos\Details.cshtml"
       Write(Html.DisplayFor(model => model.DataInicial));

#line default
#line hidden
            EndContext();
            BeginContext(566, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(629, 45, false);
#line 26 "c:\Users\caioo\desktop\CursoCliente3\Views\Cursos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DataFInal));

#line default
#line hidden
            EndContext();
            BeginContext(674, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(738, 41, false);
#line 29 "c:\Users\caioo\desktop\CursoCliente3\Views\Cursos\Details.cshtml"
       Write(Html.DisplayFor(model => model.DataFInal));

#line default
#line hidden
            EndContext();
            BeginContext(779, 87, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <h4>Clientes do Curso</h4>\r\n    <hr />\r\n");
            EndContext();
#line 36 "c:\Users\caioo\desktop\CursoCliente3\Views\Cursos\Details.cshtml"
     foreach(var c in Model.Clientes) {

#line default
#line hidden
            BeginContext(907, 80, true);
            WriteLiteral("        <dl class=\"row\">            \r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(988, 6, false);
#line 39 "c:\Users\caioo\desktop\CursoCliente3\Views\Cursos\Details.cshtml"
               Write(c.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(994, 40, true);
            WriteLiteral("\r\n                </dd>\r\n        </dl>\r\n");
            EndContext();
#line 42 "c:\Users\caioo\desktop\CursoCliente3\Views\Cursos\Details.cshtml"
    }

#line default
#line hidden
            BeginContext(1041, 19, true);
            WriteLiteral("</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1060, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f637ca31313822c0c9b00aa2cdd2f730bf78c42e7568", async() => {
                BeginContext(1106, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 45 "c:\Users\caioo\desktop\CursoCliente3\Views\Cursos\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1114, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1122, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f637ca31313822c0c9b00aa2cdd2f730bf78c42e9874", async() => {
                BeginContext(1144, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1160, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CursoCliente3.Models.Curso> Html { get; private set; }
    }
}
#pragma warning restore 1591