#pragma checksum "C:\Users\Luknak\Documents\PJ\.NET CORE\Test\Tarefas\Views\Tarefas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd0b7239c76a00ddd9695bbc82b51f26f968eafe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tarefas_Index), @"mvc.1.0.view", @"/Views/Tarefas/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tarefas/Index.cshtml", typeof(AspNetCore.Views_Tarefas_Index))]
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
#line 1 "C:\Users\Luknak\Documents\PJ\.NET CORE\Test\Tarefas\Views\_ViewImports.cshtml"
using Tarefas;

#line default
#line hidden
#line 2 "C:\Users\Luknak\Documents\PJ\.NET CORE\Test\Tarefas\Views\_ViewImports.cshtml"
using Tarefas.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd0b7239c76a00ddd9695bbc82b51f26f968eafe", @"/Views/Tarefas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22b1d4ceb903fd790b0685a9067e34add11b7dd8", @"/Views/_ViewImports.cshtml")]
    public class Views_Tarefas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
            BeginContext(1, 5, false);
#line 1 "C:\Users\Luknak\Documents\PJ\.NET CORE\Test\Tarefas\Views\Tarefas\Index.cshtml"
Write(Model);

#line default
#line hidden
            EndContext();
            BeginContext(6, 20, true);
            WriteLiteral(" TarefaViewModel\r\n\r\n");
            EndContext();
#line 3 "C:\Users\Luknak\Documents\PJ\.NET CORE\Test\Tarefas\Views\Tarefas\Index.cshtml"
  
    ViewData["Title"] = "Task List";

#line default
#line hidden
            BeginContext(71, 81, true);
            WriteLiteral("\r\n<div class=\"panel panel-default tarefa-panel\">\r\n    <div class=\"panel-heading\">");
            EndContext();
            BeginContext(153, 17, false);
#line 8 "C:\Users\Luknak\Documents\PJ\.NET CORE\Test\Tarefas\Views\Tarefas\Index.cshtml"
                          Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(170, 222, true);
            WriteLiteral("</div>\r\n\r\n\r\n    <table class=\"table table-hover\">\r\n        <thead>\r\n            <tr>\r\n               <td>&#xd2714</td>\r\n               <td>Tarefa</td>\r\n               <td>Previsao</td>\r\n           </tr>\r\n        </thead>\r\n");
            EndContext();
#line 19 "C:\Users\Luknak\Documents\PJ\.NET CORE\Test\Tarefas\Views\Tarefas\Index.cshtml"
       foreach (var item in Model.TarefaViewModel){
        

#line default
#line hidden
            BeginContext(455, 76, true);
            WriteLiteral("         <tr>\r\n             <td>\r\n                    <input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 531, "\"", 546, 1);
#line 23 "C:\Users\Luknak\Documents\PJ\.NET CORE\Test\Tarefas\Views\Tarefas\Index.cshtml"
WriteAttributeValue("", 538, item.Id, 538, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(547, 77, true);
            WriteLiteral(" value=\"true\" class=\"done-checkbox\">\r\n              </td>\r\n              <td>");
            EndContext();
            BeginContext(625, 9, false);
#line 25 "C:\Users\Luknak\Documents\PJ\.NET CORE\Test\Tarefas\Views\Tarefas\Index.cshtml"
             Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(634, 26, true);
            WriteLiteral("</td>\r\n               <td>");
            EndContext();
            BeginContext(661, 19, false);
#line 26 "C:\Users\Luknak\Documents\PJ\.NET CORE\Test\Tarefas\Views\Tarefas\Index.cshtml"
              Write(item.ConclusionDate);

#line default
#line hidden
            EndContext();
            BeginContext(680, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 28 "C:\Users\Luknak\Documents\PJ\.NET CORE\Test\Tarefas\Views\Tarefas\Index.cshtml"

     }

#line default
#line hidden
            BeginContext(716, 68, true);
            WriteLiteral("    </table>\r\n    <div class=\"panel-footer add-item-form\">\r\n        ");
            EndContext();
            BeginContext(784, 274, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee18ddede625470eb957112763f86c91", async() => {
                BeginContext(790, 261, true);
                WriteLiteral(@"
            <div id=""add-item-error"" class = ""text-danger""></div>
            <label for=""add-item-title""> Include new Task </label>
            <input id=""add-item-title"">
            <button type=""button"" id=""add-item-button""> Include </button>
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1058, 20, true);
            WriteLiteral("\r\n    </div>\r\n</div>");
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