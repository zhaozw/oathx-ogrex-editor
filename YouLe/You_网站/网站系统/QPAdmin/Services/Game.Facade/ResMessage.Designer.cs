﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Game.Facade {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ResMessage {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ResMessage() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Game.Facade.ResMessage", typeof(ResMessage).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
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
        ///   Looks up a localized string similar to 请填写您的管理帐号。.
        /// </summary>
        internal static string EmptyAccounts {
            get {
                return ResourceManager.GetString("EmptyAccounts", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 请填写管理密码。.
        /// </summary>
        internal static string EmptyPassword {
            get {
                return ResourceManager.GetString("EmptyPassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 错误，超级管理员不能删除。.
        /// </summary>
        internal static string Error_DeleteSuperAdministrator {
            get {
                return ResourceManager.GetString("Error_DeleteSuperAdministrator", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Email地址已经存在。.
        /// </summary>
        internal static string Error_ExistsLinkEmail {
            get {
                return ResourceManager.GetString("Error_ExistsLinkEmail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 用户已经存在。.
        /// </summary>
        internal static string Error_ExistsUser {
            get {
                return ResourceManager.GetString("Error_ExistsUser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 超级管理员.
        /// </summary>
        internal static string Hit_SuperAdministrator {
            get {
                return ResourceManager.GetString("Hit_SuperAdministrator", resourceCulture);
            }
        }
    }
}
