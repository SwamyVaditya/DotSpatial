﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace DotSpatial.Symbology {
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [DebuggerNonUserCode()]
    [CompilerGenerated()]
    internal class SymbologyImages {
        
        private static ResourceManager resourceMan;
        
        private static CultureInfo resourceCulture;
        
        [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SymbologyImages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static ResourceManager ResourceManager {
            get {
                if (ReferenceEquals(resourceMan, null)) {
                    ResourceManager temp = new ResourceManager("DotSpatial.Symbology.SymbologyImages", typeof(SymbologyImages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        internal static Bitmap color_scheme {
            get {
                object obj = ResourceManager.GetObject("color_scheme", resourceCulture);
                return ((Bitmap)(obj));
            }
        }
        
        internal static Bitmap Copy {
            get {
                object obj = ResourceManager.GetObject("Copy", resourceCulture);
                return ((Bitmap)(obj));
            }
        }
        
        internal static Bitmap deselect_16x16 {
            get {
                object obj = ResourceManager.GetObject("deselect_16x16", resourceCulture);
                return ((Bitmap)(obj));
            }
        }
        
        internal static Bitmap Label {
            get {
                object obj = ResourceManager.GetObject("Label", resourceCulture);
                return ((Bitmap)(obj));
            }
        }
        
        internal static Icon Layers {
            get {
                object obj = ResourceManager.GetObject("Layers", resourceCulture);
                return ((Icon)(obj));
            }
        }
        
        internal static Bitmap mnuLayerClear {
            get {
                object obj = ResourceManager.GetObject("mnuLayerClear", resourceCulture);
                return ((Bitmap)(obj));
            }
        }
        
        internal static Bitmap redbluearrows {
            get {
                object obj = ResourceManager.GetObject("redbluearrows", resourceCulture);
                return ((Bitmap)(obj));
            }
        }
        
        internal static Icon save {
            get {
                object obj = ResourceManager.GetObject("save", resourceCulture);
                return ((Icon)(obj));
            }
        }
        
        internal static Icon select {
            get {
                object obj = ResourceManager.GetObject("select", resourceCulture);
                return ((Icon)(obj));
            }
        }
        
        internal static Bitmap select_all {
            get {
                object obj = ResourceManager.GetObject("select_all", resourceCulture);
                return ((Bitmap)(obj));
            }
        }
        
        internal static Bitmap ZoomInMap {
            get {
                object obj = ResourceManager.GetObject("ZoomInMap", resourceCulture);
                return ((Bitmap)(obj));
            }
        }
        
        internal static Bitmap ZoomScale {
            get {
                object obj = ResourceManager.GetObject("ZoomScale", resourceCulture);
                return ((Bitmap)(obj));
            }
        }
    }
}
