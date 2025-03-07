﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cliente.Application.Messages {
    using System;
    
    
    /// <summary>
    ///   Clase de recurso fuertemente tipado, para buscar cadenas traducidas, etc.
    /// </summary>
    // StronglyTypedResourceBuilder generó automáticamente esta clase
    // a través de una herramienta como ResGen o Visual Studio.
    // Para agregar o quitar un miembro, edite el archivo .ResX y, a continuación, vuelva a ejecutar ResGen
    // con la opción /str o recompile su proyecto de VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class MessagesCliente {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal MessagesCliente() {
        }
        
        /// <summary>
        ///   Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Cliente.Application.Messages.MessagesCliente", typeof(MessagesCliente).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Se produjo un conflicto al momento de crear un nuevo cliente.
        /// </summary>
        public static string CreateClienteConflict {
            get {
                return ResourceManager.GetString("CreateClienteConflict", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Se produjo un error al crear un nuevo cliente.
        /// </summary>
        public static string CreateClienteError {
            get {
                return ResourceManager.GetString("CreateClienteError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Se creo el nuevo cliente correctamente.
        /// </summary>
        public static string CreateClienteOk {
            get {
                return ResourceManager.GetString("CreateClienteOk", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Se produjo un conflicto al eliminar de la base de datos el cliente seleccionado.
        /// </summary>
        public static string DeleteClienteConflic {
            get {
                return ResourceManager.GetString("DeleteClienteConflic", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Se produjo un error al eliminar de la base de datos el cliente seleccionado.
        /// </summary>
        public static string DeleteClienteError {
            get {
                return ResourceManager.GetString("DeleteClienteError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Se elimino de la base de datos el cliente seleccionado.
        /// </summary>
        public static string DeleteClienteOk {
            get {
                return ResourceManager.GetString("DeleteClienteOk", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a No se encontraron cliente almacenados en la base de datos.
        /// </summary>
        public static string GetAllClienteConflic {
            get {
                return ResourceManager.GetString("GetAllClienteConflic", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a No se encontraron cliente con la edad ingresada.
        /// </summary>
        public static string GetByEdadClienteConflic {
            get {
                return ResourceManager.GetString("GetByEdadClienteConflic", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a No se encontraron clientes con la edad ingresada.
        /// </summary>
        public static string GetByEdadClienteNotFound {
            get {
                return ResourceManager.GetString("GetByEdadClienteNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Se encontro el/los siguiente/s cliente/s con la edad ingresada.
        /// </summary>
        public static string GetByEdadClienteOk {
            get {
                return ResourceManager.GetString("GetByEdadClienteOk", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a No se encontro el ID cliente ingresado.
        /// </summary>
        public static string GetByIdClienteNotFound {
            get {
                return ResourceManager.GetString("GetByIdClienteNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Se encontro el siguiente cliente el ID ingresado.
        /// </summary>
        public static string GetByIdClienteOk {
            get {
                return ResourceManager.GetString("GetByIdClienteOk", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a No se encontraron clientes con el nombre ingresado.
        /// </summary>
        public static string GetByNameLikeClienteNotFound {
            get {
                return ResourceManager.GetString("GetByNameLikeClienteNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Se produjo un conflicto al actualizar los datos del cliente seleccionado.
        /// </summary>
        public static string UpDateClienteConflict {
            get {
                return ResourceManager.GetString("UpDateClienteConflict", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Se produjo un error al actualizar los datos del cliente seleccionado.
        /// </summary>
        public static string UpDateClienteError {
            get {
                return ResourceManager.GetString("UpDateClienteError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Se actualizo correctamente los datos del cliente seleccionado.
        /// </summary>
        public static string UpDateClienteOk {
            get {
                return ResourceManager.GetString("UpDateClienteOk", resourceCulture);
            }
        }
    }
}
