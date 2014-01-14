/* 
 * 
 * (c) Copyright Ascensio System Limited 2010-2014
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU Affero General Public License as
 * published by the Free Software Foundation, either version 3 of the
 * License, or (at your option) any later version.
 * 
 * http://www.gnu.org/licenses/agpl.html 
 * 
 */

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASC.Mail.Service.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class MailServiceResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal MailServiceResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ASC.Mail.Service.Resources.MailServiceResource", typeof(MailServiceResource).Assembly);
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
        ///   Looks up a localized string similar to Field %1 is empty.
        /// </summary>
        internal static string ErrorEmptyField {
            get {
                return ResourceManager.GetString("ErrorEmptyField", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Incorrect e-mail address in %1 field.
        /// </summary>
        internal static string ErrorIncorrectEmailAddress {
            get {
                return ResourceManager.GetString("ErrorIncorrectEmailAddress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tag %1 already exists.
        /// </summary>
        internal static string ErrorTagNameAlreadyExists {
            get {
                return ResourceManager.GetString("ErrorTagNameAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tag name can&apos;t be empty.
        /// </summary>
        internal static string ErrorTagNameCantBeEmpty {
            get {
                return ResourceManager.GetString("ErrorTagNameCantBeEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Bcc.
        /// </summary>
        internal static string FieldNameBcc {
            get {
                return ResourceManager.GetString("FieldNameBcc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cc.
        /// </summary>
        internal static string FieldNameCc {
            get {
                return ResourceManager.GetString("FieldNameCc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to From.
        /// </summary>
        internal static string FieldNameFrom {
            get {
                return ResourceManager.GetString("FieldNameFrom", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to To.
        /// </summary>
        internal static string FieldNameTo {
            get {
                return ResourceManager.GetString("FieldNameTo", resourceCulture);
            }
        }
    }
}