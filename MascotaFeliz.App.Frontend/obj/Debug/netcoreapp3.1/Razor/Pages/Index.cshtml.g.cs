#pragma checksum "C:\mascotafeliz\mascotafeliz.app.frontend\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9119bacfdc5037c2d725f44ceaf21b350c1584d3"
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
#line 1 "C:\mascotafeliz\mascotafeliz.app.frontend\Pages\_ViewImports.cshtml"
using MascotaFeliz.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9119bacfdc5037c2d725f44ceaf21b350c1584d3", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cf052204a3bb4119b871dc96742e016457a0b55", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\mascotafeliz\mascotafeliz.app.frontend\Pages\Index.cshtml"
  
    ViewData["Title"] = "Mascota Feliz";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    * {
        margin: 0;
        padding: 0;
        box-sizing: border-box;
    }

    body,
    html {
        background-color: #98d4f3;
        height: 100%;
        padding: 0;
        margin: 0;
        font-family: 'Sniglet', cursive;
    }

    h1 {

        font-weight: normal;
        font-size: 3em;
        font-style: bold;
        font-family: 'Raleway', sans-serif;
        margin: 0 auto;
        margin-top: 10px;
        width: 500px;
        color: #F90;
        text-align: center;

    }

    header {
        height: 200px;
        margin-top: -10px;
        background: url('http://www.geertjanhendriks.nl/codepen/form/golf.png') repeat-x bottom;
        background-color:  white;
    }

    #form {
        max-width: 100%;
        max-height: 100%;
        background-color: #98d4f3;
        overflow: hidden;
        position: relative;

    }

    form {
        margin-top: -250px;
        margin: 0 auto;
        padding-top: -100px;
");
            WriteLiteral(@"        color: rgb(47, 107, 137);
        position: relative;
    }

    label,
    input,
    textarea {
        display: block;
    }

    .title {
        color: #642a73;
        font-weight: normal;
        font-size: 1.5em;
        font-style: bold;
        font-family: 'Raleway', sans-serif;
        margin-bottom: 50px;
        text-align: center;
    }

    input,
    textarea {
        width: 500px;
        border: none;
        border-radius: 20px;
        outline: none;
        padding: 8px;
        font-family: 'Sniglet', cursive;
        font-size: 1em;
        color: #676767;
        transition: border 0.5s;
        -webkit-transition: border 0.5s;
        -moz-transition: border 0.5s;
        -o-transition: border 0.5s;
        border: solid 3px #98d4f3;
        -webkit-box-sizing: border-box;
        -moz-box-sizing: border-box;
        box-sizing: border-box;

    }

    input:focus,
    textarea:focus {
        border: solid 3px #77bde0;
    }

  ");
            WriteLiteral(@"  textarea {
        height: 100px;
        resize: none;
        overflow: auto;
    }

    input[type=""submit""] {
        background-color: #F90;
        color: white;
        height: 50px;
        cursor: pointer;
        margin-top: 30px;
        font-size: 1.29em;
        font-family: 'Sniglet', cursive;
        -webkit-transition: background-color 0.5s;
        -moz-transition: background-color 0.5s;
        -o-transition: background-color 0.5s;
        transition: background-color 0.5s;
    }

    input[type=""submit""]:hover {
        background-color: #e58f0e;

    }

    label {
        font-size: 1.5em;
        margin-top: 20px;
        padding-left: 20px;
    }

    .formgroup,
    .formgroup-active,
    .formgroup-error {
        background-repeat: no-repeat;
        background-position: right bottom;
        background-size: 10.5%;
        transition: background-image 0.7s;
        -webkit-transition: background-image 0.7s;
        -moz-transition: background");
            WriteLiteral(@"-image 0.7s;
        -o-transition: background-image 0.7s;
        width: 566px;
        padding-top: 2px;
    }

    .formgroup {
        margin-top: -15px;
        background-image: url('http://www.geertjanhendriks.nl/codepen/form/pixel.gif');
    }

    .formgroup-active {
        background-image: url('http://www.geertjanhendriks.nl/codepen/form/octo.png');
    }

    .formgroup-error {
        background-image: url('http://www.geertjanhendriks.nl/codepen/form/octo-error.png');
        color: red;
    }

    a {
        text-decoration: none;
        list-style: none;
        font-weight: bold;
        background-color: rgb(237, 163, 52);
        border-radius: 5px;
        height: 100px;
        cursor: pointer;
        margin-top: 30px;
        margin-left: 40px;
        font-size: 2.2em;
        font-family: 'Sniglet', cursive;
        -webkit-transition: background-color 0.5s;
        -moz-transition: background-color 0.5s;
        -o-transition: background-color 0.5s");
            WriteLiteral(@";
        transition: background-color 0.5s;

    }

    a:hover {
        background-color: #e58f0e;
    }

    .aIndex {
        text-decoration: none;
        list-style: none;
        font-weight: bold;
        background-color: rgb(237, 163, 52);
        border-radius: 5px;
        height: 50px;
        cursor: pointer;
        margin-top: 30px;
        margin-left: 40px;
        font-size: 1.1em;
        font-family: 'Sniglet', cursive;
        -webkit-transition: background-color 0.5s;
        -moz-transition: background-color 0.5s;
        -o-transition: background-color 0.5s;
        transition: background-color 0.5s;
    }

    .link {
        margin-left: 640px;
    }

    img {
        max-width: 100%;
        height: 280px;
        width: 280px;
        margin-left: 50px;
        margin-top: 20px;
    }

    #perroImg {
        margin-top: -500px;
        margin-left: 1100px;
    }

    .footer{
        font-weight: normal;
        font-size: 2em;
  ");
            WriteLiteral(@"      font-style: bold;
        font-family: 'Raleway', sans-serif;
        color: #F90;
        margin-top: 50px;
        text-align: center;
    }
    .imagenbanner{
        width: 1250px;
        height: 600px;
    }
    
    .imagenindex{
        width: 1250px;
        height: 600px;
        margin-left: 300px;

    }

    .imgenLogo{
        width: 300px;
        height: 100px;
    }
</style>

<header>
    <div class=""title"">
        <img class=""imgenLogo"" src=""https://cdn.discordapp.com/attachments/704142250845929492/1022683078235263006/mascotafeliz.png"" >

    </div>
</header>

<div id=""form"">
    <div class=""imagenbanner"">

        <img class=""imagenindex"" src=""https://cdn.discordapp.com/attachments/704142250845929492/1022682832528744478/1663896943557.png"">
   
    </div>

    
    <br>
    <a href=""/Mascotas/ListaMascotas"">¡Listar Mascotas!</a>
    <a href=""/Veterinarios/ListarVeterinarios"">¡Listar Veterinarios!</a>
    <a href=""/Duenos/ListaDuenos"">¡Listar D");
            WriteLiteral(@"ueños!</a>
    <a href=""/VisitasPyP/ListaVisitasPyP"">¡Listar las Visitas!</a>
    <a href=""/Historias/ListaHistorias"">¡Listar Historias!</a>


    <img src=""https://cdn.discordapp.com/attachments/704142250845929492/1013996190695690280/1661825843640.png""
        alt=""perro"">
    <img src=""https://cdn.discordapp.com/attachments/704142250845929492/1013996148597465148/1661825895379.png""
        alt=""vet"">
    <img src=""https://cdn.discordapp.com/attachments/704142250845929492/1013996148857503824/1661825874301.png""
        alt=""dueno"">
    <img src=""https://cdn-icons-png.flaticon.com/512/1810/1810231.png"" alt=""visita"">
    <img src=""https://cdn-icons-png.flaticon.com/512/2885/2885186.png"" alt=""visita"">

    <br>
    <br>
    <br>
    <br>
    <h6 class=""footer"">&copy; 2022 - Mascota Feliz Grupo 2</h6>
</div>
");
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
