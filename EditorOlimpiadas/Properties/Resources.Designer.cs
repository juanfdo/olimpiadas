﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EditorOlimpiadas.Properties {
    using System;
    
    
    /// <summary>
    ///   Clase de recurso fuertemente tipado, para buscar cadenas traducidas, etc.
    /// </summary>
    // StronglyTypedResourceBuilder generó automáticamente esta clase
    // a través de una herramienta como ResGen o Visual Studio.
    // Para agregar o quitar un miembro, edite el archivo .ResX y, a continuación, vuelva a ejecutar ResGen
    // con la opción /str o recompile su proyecto de VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("EditorOlimpiadas.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Reemplaza la propiedad CurrentUICulture del subproceso actual para todas las
        ///   búsquedas de recursos mediante esta clase de recurso fuertemente tipado.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Busca un recurso adaptado de tipo System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap icons8_open_50 {
            get {
                object obj = ResourceManager.GetObject("icons8-open-50", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Busca un recurso adaptado de tipo System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap icons8_square_root_50 {
            get {
                object obj = ResourceManager.GetObject("icons8-square-root-50", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Busca un recurso adaptado de tipo System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap icons8_text_50 {
            get {
                object obj = ResourceManager.GetObject("icons8-text-50", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a CREATE TABLE tblOlimpiada(
        ///	intID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
        ///	txtNombre TEXT NOT NULL UNIQUE
        ///);
        ///
        ///CREATE TABLE tblCategoria(
        ///	intID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
        ///	txtNombre TEXT NOT NULL UNIQUE
        ///);
        ///
        ///-- https://www.sqlite.org/intern-v-extern-blob.html
        ///-- CREATE TABLE tblMediaFile(
        ///-- 	intID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
        ///-- 	pathRelativo BOOLEAN NOT NULL DEFAULT 1,
        ///-- 	web BOOLEAN NOT NULL DEFAULT 0,
        ///-- 	path NVARCHAR NOT NULL UNIQUE
        ///-- 	);
        ///-- https: [resto de la cadena truncado]&quot;;.
        /// </summary>
        internal static string ScriptCreateTables {
            get {
                return ResourceManager.GetString("ScriptCreateTables", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a INSERT INTO tblCuestionario(txtPregunta, txtVideo, txtEcuaciones, txtOtros, txtCorrecta, intIdCategoria, intIdOlimpiada)
        ///  VALUES(&apos;{0}&apos;, null, null, null, &apos;{1}&apos;, {2}, {3});
        ///--  SELECT last_insert_rowid();
        ///INSERT INTO tblRepuestaErronea(intID, txtRespuesta1, txtRespuesta2, txtRespuesta3)
        ///  SELECT last_insert_rowid(), &apos;{4}&apos;, &apos;{5}&apos;, &apos;{6}&apos;;
        ///
        ///--  VALUES({0},&apos;{1}&apos;,&apos;{2}&apos;,&apos;{3}&apos;);.
        /// </summary>
        internal static string ScriptInsertaPregunta {
            get {
                return ResourceManager.GetString("ScriptInsertaPregunta", resourceCulture);
            }
        }
    }
}
