#pragma checksum "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "738d1a42752b6a528fecd5cb6b961996a758e9d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MascotaFeliz.App.Frontend.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace MascotaFeliz.App.Frontend.Pages
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
#line 1 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\_ViewImports.cshtml"
using MascotaFeliz.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"738d1a42752b6a528fecd5cb6b961996a758e9d2", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cf052204a3bb4119b871dc96742e016457a0b55", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""box-padre"">
      <div class=""testbox"">
        <h1 class="" text1"">VETERINARIA MASCOTA FELIZ</h1>
        

        <p class=""text2"">Hoy en día, en muchos hogares, las mascotas se han convertido en un miembro 
          más de la familia y como tales, es necesario garantizar su bienestar en todo sentido, 
          especialmente en lo que a salud se refiere.
        </p> 

        <p class=""text2"">La empresa “Mascota Feliz”, tiene dentro de su portafolio de servicios
          diversos beneficios para las mascotas afiliadas, entre ellos se encuentra el de visitas 
          domiciliarias periódicas de promoción de la salud y prevención 
          de la enfermedad, las cuales son realizadas por un médico 
          veterinario, y que además son gratuitas para los perros y gatos 
          afiliados a la empresa.
        </p>

          <p class=""text2"">Mascota Feliz cuenta con un equipo de veterinarios que se 
            encargan de realizar visitas a domicilio, durante la");
            WriteLiteral(@"s cuales se 
            revisan las mascotas y se dan recomendaciones para prevenir 
            enfermedades, mejorar la calidad de vida de los peludos o en caso 
            de ser necesario (si la mascota se encuentra enferma) se realiza 
            el diagnóstico y se formulan medicamentos.
          </p>
          <p class=""text3""> © Todos los derechos reservados </br> Elaborado por: MisionTIC 2022 </p>
        
      </div>
      <div class=""contenedor-perrito"">
        <img src=img/perrofeliz.png class=""mascota1"" >
      </div>
    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
