#pragma checksum "D:\G55\Mascotas\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Veterinarios\DetallesVeterinarios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94ee45e4e3367c863efa2931f3062d683e088dde"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MascotaFeliz.App.Frontend.Pages.Veterinarios.Pages_Veterinarios_DetallesVeterinarios), @"mvc.1.0.razor-page", @"/Pages/Veterinarios/DetallesVeterinarios.cshtml")]
namespace MascotaFeliz.App.Frontend.Pages.Veterinarios
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
#line 1 "D:\G55\Mascotas\mascotafeliz.app\mascotafeliz.app.frontend\Pages\_ViewImports.cshtml"
using MascotaFeliz.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94ee45e4e3367c863efa2931f3062d683e088dde", @"/Pages/Veterinarios/DetallesVeterinarios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cf052204a3bb4119b871dc96742e016457a0b55", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Veterinarios_DetallesVeterinarios : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-add"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./ListaVeterinarios", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<h1 class=\"titulo1\">Detalles del Veterinario</h1>\r\n\r\n    <div class=\"Div1\">\r\n        <div class=\"Div6\">\r\n            <table class= \"tabla3\" >\r\n              <tr>\r\n                <th>Id:</th>\r\n                <td>");
#nullable restore
#line 13 "D:\G55\Mascotas\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Veterinarios\DetallesVeterinarios.cshtml"
               Write(Model.veterinario.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n              </tr>\r\n              <tr>\r\n                <th>Nombres:</th>\r\n                <td>");
#nullable restore
#line 17 "D:\G55\Mascotas\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Veterinarios\DetallesVeterinarios.cshtml"
               Write(Model.veterinario.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n              </tr>\r\n              <tr>\r\n              <tr>\r\n                <th>Apellidos:</th>\r\n                <td>");
#nullable restore
#line 22 "D:\G55\Mascotas\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Veterinarios\DetallesVeterinarios.cshtml"
               Write(Model.veterinario.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n              </tr>\r\n              <tr>  \r\n                <th>Direcci??n:</th>\r\n                <td>");
#nullable restore
#line 26 "D:\G55\Mascotas\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Veterinarios\DetallesVeterinarios.cshtml"
               Write(Model.veterinario.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n              </tr>\r\n              <tr>\r\n                <th>Tel??fono:</th>\r\n                <td>");
#nullable restore
#line 30 "D:\G55\Mascotas\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Veterinarios\DetallesVeterinarios.cshtml"
               Write(Model.veterinario.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n              </tr>\r\n              <tr>\r\n                <th>TarjetaProfesional:</th>\r\n                <td>");
#nullable restore
#line 34 "D:\G55\Mascotas\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Veterinarios\DetallesVeterinarios.cshtml"
               Write(Model.veterinario.TarjetaProfesional);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n              </tr>\r\n            </table>\r\n            <div>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94ee45e4e3367c863efa2931f3062d683e088dde6632", async() => {
                WriteLiteral("Volver");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>
      <div class = ""Div5"">
        <a >
        </a>
      </div>


    </div>














<h1 class=""titulo1"">Detalles del veterinario</h1>

<table class= ""tabla2"" >
  <tr class=""borde2"">
    <th class=""borde2"">Id:</th>
    <td class=""borde2"">");
#nullable restore
#line 67 "D:\G55\Mascotas\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Veterinarios\DetallesVeterinarios.cshtml"
                  Write(Model.veterinario.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n  </tr class=\"borde2\">\r\n  <tr>\r\n    <th>Nombres:</th>\r\n    <td>");
#nullable restore
#line 71 "D:\G55\Mascotas\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Veterinarios\DetallesVeterinarios.cshtml"
   Write(Model.veterinario.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n  </tr>\r\n  <tr>\r\n    <th>Direcci??n:</th>\r\n    <td>");
#nullable restore
#line 75 "D:\G55\Mascotas\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Veterinarios\DetallesVeterinarios.cshtml"
   Write(Model.veterinario.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n  </tr>\r\n  <tr>\r\n    <th>Tel??fono:</th>\r\n    <td>");
#nullable restore
#line 79 "D:\G55\Mascotas\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Veterinarios\DetallesVeterinarios.cshtml"
   Write(Model.veterinario.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n  </tr>\r\n  <tr>\r\n    <th>Tarjeta Profesional:</th>\r\n    <td>");
#nullable restore
#line 83 "D:\G55\Mascotas\mascotafeliz.app\mascotafeliz.app.frontend\Pages\Veterinarios\DetallesVeterinarios.cshtml"
   Write(Model.veterinario.TarjetaProfesional);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n  </tr>\r\n\r\n</table>\r\n\r\n\r\n<!--a asp-page=\"./ListaDuenos\" class=\"btn-default\">Lista Due??os</a-->\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MascotaFeliz.App.Frontend.Pages.DetallesVeterinariosModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.Frontend.Pages.DetallesVeterinariosModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.Frontend.Pages.DetallesVeterinariosModel>)PageContext?.ViewData;
        public MascotaFeliz.App.Frontend.Pages.DetallesVeterinariosModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
