#pragma checksum "C:\Mascotas\MisionTIC_Grupo3\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Mascotas\DetallesMascotas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e3b67cc54e049087bf91db989a34c1bd9efbde6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MascotaFeliz.App.Frontend.Pages.Mascotas.Pages_Mascotas_DetallesMascotas), @"mvc.1.0.razor-page", @"/Pages/Mascotas/DetallesMascotas.cshtml")]
namespace MascotaFeliz.App.Frontend.Pages.Mascotas
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
#line 1 "C:\Mascotas\MisionTIC_Grupo3\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\_ViewImports.cshtml"
using MascotaFeliz.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e3b67cc54e049087bf91db989a34c1bd9efbde6", @"/Pages/Mascotas/DetallesMascotas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d90b2b40ba8c1257b37c8db6b0a6d90a6076caca", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Mascotas_DetallesMascotas : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./ListaMascotas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<h1>Detalles Mascotas</h1>\n\n<div>\n    Id: ");
#nullable restore
#line 8 "C:\Mascotas\MisionTIC_Grupo3\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Mascotas\DetallesMascotas.cshtml"
   Write(Model.mascota.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n<div>\n    Nombre: ");
#nullable restore
#line 11 "C:\Mascotas\MisionTIC_Grupo3\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Mascotas\DetallesMascotas.cshtml"
       Write(Model.mascota.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n<div>\n    Color: ");
#nullable restore
#line 14 "C:\Mascotas\MisionTIC_Grupo3\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Mascotas\DetallesMascotas.cshtml"
      Write(Model.mascota.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n<div>\n    Especie: ");
#nullable restore
#line 17 "C:\Mascotas\MisionTIC_Grupo3\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Mascotas\DetallesMascotas.cshtml"
        Write(Model.mascota.Especie);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n<div>\n    Raza: ");
#nullable restore
#line 20 "C:\Mascotas\MisionTIC_Grupo3\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Mascotas\DetallesMascotas.cshtml"
     Write(Model.mascota.Raza);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e3b67cc54e049087bf91db989a34c1bd9efbde65169", async() => {
                WriteLiteral("Lista Mascotas");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MascotaFeliz.App.Frontend.Pages.DetallesMascotasModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.Frontend.Pages.DetallesMascotasModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.Frontend.Pages.DetallesMascotasModel>)PageContext?.ViewData;
        public MascotaFeliz.App.Frontend.Pages.DetallesMascotasModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
