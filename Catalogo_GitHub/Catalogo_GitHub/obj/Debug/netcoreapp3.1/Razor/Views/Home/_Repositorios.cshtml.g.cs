#pragma checksum "C:\Users\Lucas\Desktop\Projetcs-master\CatalogoGitHub\Catalogo_GitHub\Catalogo_GitHub\Views\Home\_Repositorios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71acd682e73a3f0b0d8e9a7dad663c1fb5e6ee73"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__Repositorios), @"mvc.1.0.view", @"/Views/Home/_Repositorios.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71acd682e73a3f0b0d8e9a7dad663c1fb5e6ee73", @"/Views/Home/_Repositorios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"314acd928f2ceac310f0e3e917b2e1ee8b0b37a9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__Repositorios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Catalogo_GitHub.ViewModel.CatalogoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Repositorio", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row card-deck\">\r\n");
#nullable restore
#line 3 "C:\Users\Lucas\Desktop\Projetcs-master\CatalogoGitHub\Catalogo_GitHub\Catalogo_GitHub\Views\Home\_Repositorios.cshtml"
     for (int repIndex = 0; repIndex < Model.repositorios.Count; repIndex++)
    {
        if (repIndex > 0 && repIndex % 3 == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            WriteLiteral("</div><div class=\"row card-deck\">\r\n");
#nullable restore
#line 8 "C:\Users\Lucas\Desktop\Projetcs-master\CatalogoGitHub\Catalogo_GitHub\Catalogo_GitHub\Views\Home\_Repositorios.cshtml"
        }
        Repositorio repositorio = Model.repositorios[repIndex];

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-sm-6 col-lg-4 mb-3\">\r\n            <div class=\"card mb-3 h-100\">\r\n\r\n                <img class=\"card-img-top\" alt=\"...\">\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\">");
#nullable restore
#line 15 "C:\Users\Lucas\Desktop\Projetcs-master\CatalogoGitHub\Catalogo_GitHub\Catalogo_GitHub\Views\Home\_Repositorios.cshtml"
                                      Write(repositorio.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p class=\"card-text\">");
#nullable restore
#line 16 "C:\Users\Lucas\Desktop\Projetcs-master\CatalogoGitHub\Catalogo_GitHub\Catalogo_GitHub\Views\Home\_Repositorios.cshtml"
                                    Write(repositorio.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"card-text\">");
#nullable restore
#line 17 "C:\Users\Lucas\Desktop\Projetcs-master\CatalogoGitHub\Catalogo_GitHub\Catalogo_GitHub\Views\Home\_Repositorios.cshtml"
                                    Write(repositorio.language);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71acd682e73a3f0b0d8e9a7dad663c1fb5e6ee736264", async() => {
                WriteLiteral("Acessar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-repositorioName", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 20 "C:\Users\Lucas\Desktop\Projetcs-master\CatalogoGitHub\Catalogo_GitHub\Catalogo_GitHub\Views\Home\_Repositorios.cshtml"
                                      WriteLiteral(repositorio.name);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["repositorioName"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-repositorioName", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["repositorioName"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 21 "C:\Users\Lucas\Desktop\Projetcs-master\CatalogoGitHub\Catalogo_GitHub\Catalogo_GitHub\Views\Home\_Repositorios.cshtml"
                               WriteLiteral(repositorio.owner.login);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userName"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userName", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userName"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <div class=\"card-footer\">\r\n                    <p class=\"card-text\">\r\n                        <small class=\"text-muted\">Criado em ");
#nullable restore
#line 25 "C:\Users\Lucas\Desktop\Projetcs-master\CatalogoGitHub\Catalogo_GitHub\Catalogo_GitHub\Views\Home\_Repositorios.cshtml"
                                                       Write(repositorio.created_at.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                    </p>\r\n                    <p class=\"card-text\">\r\n                        <small class=\"text-muted\">Atualizado em ");
#nullable restore
#line 28 "C:\Users\Lucas\Desktop\Projetcs-master\CatalogoGitHub\Catalogo_GitHub\Catalogo_GitHub\Views\Home\_Repositorios.cshtml"
                                                           Write(repositorio.updated_at.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                    </p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 33 "C:\Users\Lucas\Desktop\Projetcs-master\CatalogoGitHub\Catalogo_GitHub\Catalogo_GitHub\Views\Home\_Repositorios.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<nav>\r\n    <ul class=\"pagination justify-content-center\">\r\n");
#nullable restore
#line 37 "C:\Users\Lucas\Desktop\Projetcs-master\CatalogoGitHub\Catalogo_GitHub\Catalogo_GitHub\Views\Home\_Repositorios.cshtml"
         for (int i = 1; i <= Model.totalPages; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\"");
            BeginWriteAttribute("id", " id=\"", 1677, "\"", 1689, 2);
            WriteAttributeValue("", 1682, "page_", 1682, 5, true);
#nullable restore
#line 39 "C:\Users\Lucas\Desktop\Projetcs-master\CatalogoGitHub\Catalogo_GitHub\Catalogo_GitHub\Views\Home\_Repositorios.cshtml"
WriteAttributeValue("", 1687, i, 1687, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1729, "\"", 1762, 3);
            WriteAttributeValue("", 1736, "javascript:PagerClick(", 1736, 22, true);
#nullable restore
#line 40 "C:\Users\Lucas\Desktop\Projetcs-master\CatalogoGitHub\Catalogo_GitHub\Catalogo_GitHub\Views\Home\_Repositorios.cshtml"
WriteAttributeValue("", 1758, i, 1758, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1760, ");", 1760, 2, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 40 "C:\Users\Lucas\Desktop\Projetcs-master\CatalogoGitHub\Catalogo_GitHub\Catalogo_GitHub\Views\Home\_Repositorios.cshtml"
                                                                  Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </li>\r\n");
#nullable restore
#line 42 "C:\Users\Lucas\Desktop\Projetcs-master\CatalogoGitHub\Catalogo_GitHub\Catalogo_GitHub\Views\Home\_Repositorios.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</nav>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Catalogo_GitHub.ViewModel.CatalogoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
