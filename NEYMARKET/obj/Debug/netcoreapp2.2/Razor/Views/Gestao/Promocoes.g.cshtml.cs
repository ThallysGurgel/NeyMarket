#pragma checksum "C:\Users\guyjunior\Desktop\NEYMARKET\Views\Gestao\Promocoes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02ee181d6a6c9054b235045ac421a1a17b993ccc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gestao_Promocoes), @"mvc.1.0.view", @"/Views/Gestao/Promocoes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Gestao/Promocoes.cshtml", typeof(AspNetCore.Views_Gestao_Promocoes))]
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
#line 1 "C:\Users\guyjunior\Desktop\NEYMARKET\Views\_ViewImports.cshtml"
using NEYMARKET;

#line default
#line hidden
#line 2 "C:\Users\guyjunior\Desktop\NEYMARKET\Views\_ViewImports.cshtml"
using NEYMARKET.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02ee181d6a6c9054b235045ac421a1a17b993ccc", @"/Views/Gestao/Promocoes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7850909d7fed46c4752b59a4941d2e940b3dcec2", @"/Views/_ViewImports.cshtml")]
    public class Views_Gestao_Promocoes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NEYMARKET.Models.Promocao>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NovaPromocao", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Gestao", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: inline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\guyjunior\Desktop\NEYMARKET\Views\Gestao\Promocoes.cshtml"
  
    Layout = "_LayoutAdmin";

#line default
#line hidden
            BeginContext(86, 33, true);
            WriteLiteral("\r\n<h2>Promoções</h2>\r\n\r\n<hr/>\r\n\r\n");
            EndContext();
            BeginContext(119, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02ee181d6a6c9054b235045ac421a1a17b993ccc5078", async() => {
                BeginContext(196, 19, true);
                WriteLiteral("Criar nova promoção");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
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
            BeginContext(219, 293, true);
            WriteLiteral(@"

<hr/>

<table id=""promocoes"" class=""table table-striped table-bordered"">
    <thead>
        <tr>
            <th>Id</th>
            <th>Nome</th>
            <th>Produto</th>
            <th>Porcentagem</th>
            <th>Ações</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 26 "C:\Users\guyjunior\Desktop\NEYMARKET\Views\Gestao\Promocoes.cshtml"
         foreach(var promocao in Model){

#line default
#line hidden
            BeginContext(554, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(593, 11, false);
#line 28 "C:\Users\guyjunior\Desktop\NEYMARKET\Views\Gestao\Promocoes.cshtml"
               Write(promocao.Id);

#line default
#line hidden
            EndContext();
            BeginContext(604, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(632, 13, false);
#line 29 "C:\Users\guyjunior\Desktop\NEYMARKET\Views\Gestao\Promocoes.cshtml"
               Write(promocao.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(645, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(673, 21, false);
#line 30 "C:\Users\guyjunior\Desktop\NEYMARKET\Views\Gestao\Promocoes.cshtml"
               Write(promocao.Produto.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(694, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(722, 20, false);
#line 31 "C:\Users\guyjunior\Desktop\NEYMARKET\Views\Gestao\Promocoes.cshtml"
               Write(promocao.Porcentagem);

#line default
#line hidden
            EndContext();
            BeginContext(742, 119, true);
            WriteLiteral("%</td>\r\n                <td>\r\n                <a class=\"btn btn-primary\">Editar</a>\r\n                \r\n                ");
            EndContext();
            BeginContext(861, 200, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02ee181d6a6c9054b235045ac421a1a17b993ccc8841", async() => {
                BeginContext(892, 56, true);
                WriteLiteral("\r\n                <input type=\"Hidden\" name=\"Id\" id=\"id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 948, "\"", 968, 1);
#line 36 "C:\Users\guyjunior\Desktop\NEYMARKET\Views\Gestao\Promocoes.cshtml"
WriteAttributeValue("", 956, promocao.Id, 956, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(969, 85, true);
                WriteLiteral("> \r\n                <button class=\"btn btn-danger\">Deletar</button>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1061, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 41 "C:\Users\guyjunior\Desktop\NEYMARKET\Views\Gestao\Promocoes.cshtml"
        }

#line default
#line hidden
            BeginContext(1116, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NEYMARKET.Models.Promocao>> Html { get; private set; }
    }
}
#pragma warning restore 1591
