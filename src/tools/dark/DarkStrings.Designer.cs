// Copyright (c) .NET Foundation and contributors. All rights reserved. Licensed under the Microsoft Reciprocal License. See LICENSE.TXT file in the project root for full license information.

namespace Microsoft.Tools.WindowsInstallerXml.Tools {
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
    internal class DarkStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal DarkStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Tools.WindowsInstallerXml.Tools.DarkStrings", typeof(DarkStrings).Assembly);
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
        ///   Looks up a localized string similar to  usage: dark.exe [-?] [-nologo] database.msi source.wxs
        ///
        ///   -ext       extension assembly or &quot;class, assembly&quot;
        ///   -nologo    skip printing dark logo information
        ///   -notidy    do not delete temporary files (useful for debugging)
        ///   -sct       suppress decompiling custom tables
        ///   -sdet      suppress dropping empty tables (adds EnsureTable as appropriate)
        ///   -sras      suppress relative action sequencing (use explicit sequence numbers)
        ///   -sui       suppress decompiling UI-related tables
        ///   -sw&lt;N&gt;     suppress warning with specific message ID
        ///   -v [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string HelpMessage {
            get {
                return ResourceManager.GetString("HelpMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Temporary directory located at &apos;{0}&apos;..
        /// </summary>
        internal static string INF_TempDirLocatedAt {
            get {
                return ResourceManager.GetString("INF_TempDirLocatedAt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Warning, failed to delete temporary directory: {0}.
        /// </summary>
        internal static string WAR_FailedToDeleteTempDir {
            get {
                return ResourceManager.GetString("WAR_FailedToDeleteTempDir", resourceCulture);
            }
        }
    }
}
