#pragma checksum "D:\GRUPO3\MisionTIC_Grupo3\MascotaFeliz.App\mascotafeliz.app.frontend\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a92aca2d2acce2176308ea6cb132459c25120ebd"
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
#line 1 "D:\GRUPO3\MisionTIC_Grupo3\MascotaFeliz.App\mascotafeliz.app.frontend\Pages\_ViewImports.cshtml"
using MascotaFeliz.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a92aca2d2acce2176308ea6cb132459c25120ebd", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cf052204a3bb4119b871dc96742e016457a0b55", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\GRUPO3\MisionTIC_Grupo3\MascotaFeliz.App\mascotafeliz.app.frontend\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<!--!DOCTYPE html>
        <html lang=""en"">
        <head>
        <meta charset=""UTF-8"">
        <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
        <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap-icons@1.9.1/font/bootstrap-icons.css"">
        <link href=""styleN.css"" rel=""stylesheet"" type=""text/css"">
        <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
        <title>MASCOTA FELIZ</title>
      </head>

      <html lang=""es"">
        <head>
            <meta charset=""iso-8859-1"">
            <meta name=""description"" content=""Ejemplo de HTML5"">
            <meta name=""keywords"" content=""HTML5, CSS3, JavaScript"">
            <title>Este texto es el tÃ­tulo del documento</title>
            <link rel=""stylesheet"" href=""styleN.css"">
            <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap-icons@1.9.1/font/bootstrap-icons.css"">
        </head>
        <body class =""bodyPpal"">
            <div>
              ");
            WriteLiteral(@"  <ul class=""menu"">
                    <li><a href=""index.html"">Inicio</a></li>
                    <li><a href=""#"">Propietarios</a></li>
                    <li><a href=""#"">Mascotas</a></li>
                    <li><a href=""#"">Veterinarios</a></li>
                    <li><a href=""#"">Consultar</a></li>
                </ul>
            </div>

            <div class=""Div1"">
                <div class=""Div2"">
                    <h1 class=""h1"">Registro Propietario</h1>
                    <form action=""/"">
                        <hr>
                            <label id=""icon"" for=""name""><i class=""bi bi-clipboard-minus-fill""></i></label>
                            <input type=""text"" name=""name"" id=""name"" placeholder=""Nombres"" required/>
                            <label id=""icon"" for=""name""><i class=""bi bi-paint-bucket""></i></label>
                            <input type=""text"" name=""name"" id=""name"" placeholder=""Apellidos"" required/>
                            <label id=""icon"" for=""na");
            WriteLiteral(@"me""><i class=""bi bi-tag""></i></label>
                            <input type=""text"" name=""name"" id=""name"" placeholder=""DirecciÃ³n"" required/>
                            <label id=""icon"" for=""name""><i class=""bi bi-tag""></i></label>
                            <input type=""text"" name=""name"" id=""name"" placeholder=""TelÃ©fono"" required/>
                            <label id=""icon"" for=""name""><i class=""bi bi-tag""></i></label>
                            <input type=""text"" name=""name"" id=""name"" placeholder=""Email"" required/>
                        <hr>
                            
                            
                        <div class=""Div3"">
                            <hr>
                            <button type=""submit"" class=""registro-button""> Registrar</button>
                            <button type=""submit"" class=""registro-button""> Cancelar</button>
                            <hr>
                        </div>
                        
                </div>       
           ");
            WriteLiteral("             \r\n                <div class=\"Div4\">\r\n                   \r\n                        <img src=\"img/feliz.png\" class=\"mascota1\" >\r\n                    \r\n                \r\n                </div>\r\n\r\n        </body>\r\n</html-->");
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
