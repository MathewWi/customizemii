﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:2.0.50727.4927
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CustomizeMii.Properties {
    using System;
    
    
    /// <summary>
    ///   Eine stark typisierte Ressourcenklasse zum Suchen von lokalisierten Zeichenfolgen usw.
    /// </summary>
    // Diese Klasse wurde von der StronglyTypedResourceBuilder automatisch generiert
    // -Klasse über ein Tool wie ResGen oder Visual Studio automatisch generiert.
    // Um einen Member hinzuzufügen oder zu entfernen, bearbeiten Sie die .ResX-Datei und führen dann ResGen
    // mit der /str-Option erneut aus, oder Sie erstellen Ihr VS-Projekt neu.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Gibt die zwischengespeicherte ResourceManager-Instanz zurück, die von dieser Klasse verwendet wird.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CustomizeMii.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Überschreibt die CurrentUICulture-Eigenschaft des aktuellen Threads für alle
        ///   Ressourcenzuordnungen, die diese stark typisierte Ressourcenklasse verwenden.
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
        
        internal static System.Drawing.Bitmap btnCreate {
            get {
                object obj = ResourceManager.GetObject("btnCreate", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap btnSend {
            get {
                object obj = ResourceManager.GetObject("btnSend", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Icon CustomizeMii {
            get {
                object obj = ResourceManager.GetObject("CustomizeMii", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die {\rtf1\ansi\ansicpg1252\deff0\deflang1031{\fonttbl{\f0\fnil\fcharset0 MS Sans Serif;}}
        ///{\colortbl ;\red255\green0\blue0;\red0\green0\blue255;}
        ///{\*\generator Msftedit 5.41.21.2509;}\viewkind4\uc1\pard\sl276\slmult1\b\f0\fs17 These are some basic instructions for CustomizeMii.\b0\par
        ///\par
        ///\cf1 At the very beginning, let me say this again: Don&apos;t install any WADs without a proper brick protection!\cf0\par
        ///\par
        ///Ok, so you want to create your own custom channels?\par
        ///First it is important to understand how [Rest der Zeichenfolge wurde abgeschnitten]&quot;; ähnelt.
        /// </summary>
        internal static string Instructions {
            get {
                return ResourceManager.GetString("Instructions", resourceCulture);
            }
        }
    }
}