//---------------------------------------------------------------------------------
// <copyright file="AllInOnePrinter.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------
using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    public interface IPrinter
    {
        void PrintRecipe(Recipe recipe);
    }
}
/* Uso el patrón de polimorfismo, 
la operación de imprimir la implementan ConsolePrinter y FilePrinter,
de esta manera no hay que especificar dónde se quiere imprimir, 
se usa la clase deseada simplemente.
Esto permite que el código sea reusable y adaptable con mayor facilidad.
*/