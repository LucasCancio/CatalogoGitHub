#pragma checksum "C:\Users\Lucas\Desktop\Projetcs-master\CatalogoGitHub\Catalogo_GitHub\Catalogo_GitHub\Views\Repositorio\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70c859ea0de131665091722251cf198e3132bb37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Repositorio_Index), @"mvc.1.0.view", @"/Views/Repositorio/Index.cshtml")]
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
#line 1 "C:\Users\Lucas\Desktop\Projetcs-master\CatalogoGitHub\Catalogo_GitHub\Catalogo_GitHub\Views\_ViewImports.cshtml"
using Catalogo_GitHub;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lucas\Desktop\Projetcs-master\CatalogoGitHub\Catalogo_GitHub\Catalogo_GitHub\Views\_ViewImports.cshtml"
using Catalogo_GitHub.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70c859ea0de131665091722251cf198e3132bb37", @"/Views/Repositorio/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"314acd928f2ceac310f0e3e917b2e1ee8b0b37a9", @"/Views/_ViewImports.cshtml")]
    public class Views_Repositorio_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Catalogo_GitHub.ViewModel.RepositorioViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Arquivo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Repositorio", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Lucas\Desktop\Projetcs-master\CatalogoGitHub\Catalogo_GitHub\Catalogo_GitHub\Views\Repositorio\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<div class=\"container\">\r\n    <h4>");
#nullable restore
#line 10 "C:\Users\Lucas\Desktop\Projetcs-master\CatalogoGitHub\Catalogo_GitHub\Catalogo_GitHub\Views\Repositorio\Index.cshtml"
   Write(Model.repositorio.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <h5>");
#nullable restore
#line 11 "C:\Users\Lucas\Desktop\Projetcs-master\CatalogoGitHub\Catalogo_GitHub\Catalogo_GitHub\Views\Repositorio\Index.cshtml"
   Write(Model.repositorio.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 12 "C:\Users\Lucas\Desktop\Projetcs-master\CatalogoGitHub\Catalogo_GitHub\Catalogo_GitHub\Views\Repositorio\Index.cshtml"
     foreach (var conteudo in Model.conteudos)
    {

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Lucas\Desktop\Projetcs-master\CatalogoGitHub\Catalogo_GitHub\Catalogo_GitHub\Views\Repositorio\Index.cshtml"
         if (conteudo.type == "file")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70c859ea0de131665091722251cf198e3132bb375744", async() => {
                WriteLiteral("\r\n                <div class=\"row\">\r\n                    <i class=\"fas fa-file-alt\"></i>\r\n                    <button class=\"btn btn-link\" type=\"submit\">");
#nullable restore
#line 23 "C:\Users\Lucas\Desktop\Projetcs-master\CatalogoGitHub\Catalogo_GitHub\Catalogo_GitHub\Views\Repositorio\Index.cshtml"
                                                          Write(conteudo.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userName", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 18 "C:\Users\Lucas\Desktop\Projetcs-master\CatalogoGitHub\Catalogo_GitHub\Catalogo_GitHub\Views\Repositorio\Index.cshtml"
                          WriteLiteral(Model.repositorio.owner.login);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["userName"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userName", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["userName"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 19 "C:\Users\Lucas\Desktop\Projetcs-master\CatalogoGitHub\Catalogo_GitHub\Catalogo_GitHub\Views\Repositorio\Index.cshtml"
                                 WriteLiteral(Model.repositorio.name);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["repositorioName"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-repositorioName", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["repositorioName"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 20 "C:\Users\Lucas\Desktop\Projetcs-master\CatalogoGitHub\Catalogo_GitHub\Catalogo_GitHub\Views\Repositorio\Index.cshtml"
                      WriteLiteral(conteudo.path);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["path"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-path", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["path"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 26 "C:\Users\Lucas\Desktop\Projetcs-master\CatalogoGitHub\Catalogo_GitHub\Catalogo_GitHub\Views\Repositorio\Index.cshtml"
        }
        else if (conteudo.type == "dir")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row\">\r\n                <i class=\"fas fa-folder\"></i>\r\n                ");
#nullable restore
#line 31 "C:\Users\Lucas\Desktop\Projetcs-master\CatalogoGitHub\Catalogo_GitHub\Catalogo_GitHub\Views\Repositorio\Index.cshtml"
           Write(Html.ActionLink(conteudo.name, "Conteudo", "Repositorio", new
                {
                    userName = Model.repositorio.owner.login,
                    repositorioName = Model.repositorio.name,
                    path = conteudo.path
                }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 38 "C:\Users\Lucas\Desktop\Projetcs-master\CatalogoGitHub\Catalogo_GitHub\Catalogo_GitHub\Views\Repositorio\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\Lucas\Desktop\Projetcs-master\CatalogoGitHub\Catalogo_GitHub\Catalogo_GitHub\Views\Repositorio\Index.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <hr />\r\n</div>\r\n<div>\r\n    <a href=\"javascript: history.go(-1)\">Voltar</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Catalogo_GitHub.ViewModel.RepositorioViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
