﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PSRule.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class PSRuleResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal PSRuleResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PSRule.Resources.PSRuleResources", typeof(PSRuleResources).Assembly);
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
        ///   Looks up a localized string similar to The baseline &apos;{0}&apos; is obsolete. Consider switching to an alternative baseline..
        /// </summary>
        internal static string BaselineObsolete {
            get {
                return ResourceManager.GetString("BaselineObsolete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Binding functions are not supported in this language mode..
        /// </summary>
        internal static string ConstrainedTargetBinding {
            get {
                return ResourceManager.GetString("ConstrainedTargetBinding", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: The property &apos;${1}.{2}&apos; is obsolete and will be removed in the next major version..
        /// </summary>
        internal static string DebugPropertyObsolete {
            get {
                return ResourceManager.GetString("DebugPropertyObsolete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Target failed If precondition.
        /// </summary>
        internal static string DebugTargetIfMismatch {
            get {
                return ResourceManager.GetString("DebugTargetIfMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Target failed Type precondition.
        /// </summary>
        internal static string DebugTargetTypeMismatch {
            get {
                return ResourceManager.GetString("DebugTargetTypeMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A circular rule dependency was detected. The rule &apos;{0}&apos; depends on &apos;{1}&apos; which also depend on &apos;{0}&apos;..
        /// </summary>
        internal static string DependencyCircularReference {
            get {
                return ResourceManager.GetString("DependencyCircularReference", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The dependency &apos;{0}&apos; for &apos;{1}&apos; could not be found. Check that the rule is defined in a .Rule.ps1 file within the search path..
        /// </summary>
        internal static string DependencyNotFound {
            get {
                return ResourceManager.GetString("DependencyNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A rule with the same name &apos;{0}&apos; already exists..
        /// </summary>
        internal static string DuplicateRuleId {
            get {
                return ResourceManager.GetString("DuplicateRuleId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} : Reported &apos;{1}&apos;. At {2}:{3} char:{4}.
        /// </summary>
        internal static string ErrorDetailMessage {
            get {
                return ResourceManager.GetString("ErrorDetailMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to One or more errors occured..
        /// </summary>
        internal static string ErrorPipelineException {
            get {
                return ResourceManager.GetString("ErrorPipelineException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exists: {0}.
        /// </summary>
        internal static string ExistsTrue {
            get {
                return ResourceManager.GetString("ExistsTrue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [PSRule][D] -- Found {0} PSRule module(s).
        /// </summary>
        internal static string FoundModules {
            get {
                return ResourceManager.GetString("FoundModules", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An invalid ErrorAction ({0}) was specified for rule at {1}. Ignore | Stop are supported..
        /// </summary>
        internal static string InvalidErrorAction {
            get {
                return ResourceManager.GetString("InvalidErrorAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Rule nesting was detected for rule at {0}. Rules must not be nested..
        /// </summary>
        internal static string InvalidRuleNesting {
            get {
                return ResourceManager.GetString("InvalidRuleNesting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An invalid rule result was returned for {0}. Conditions must return boolean $True or $False..
        /// </summary>
        internal static string InvalidRuleResult {
            get {
                return ResourceManager.GetString("InvalidRuleResult", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The keyword &apos;{0}&apos; can only be used within a Rule block..
        /// </summary>
        internal static string KeywordConditionScope {
            get {
                return ResourceManager.GetString("KeywordConditionScope", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The keyword &apos;{0}&apos; can only be used within a Rule block or script precondition..
        /// </summary>
        internal static string KeywordRuleScope {
            get {
                return ResourceManager.GetString("KeywordRuleScope", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The keyword &apos;{0}&apos; can not be nested in a Rule block..
        /// </summary>
        internal static string KeywordSourceScope {
            get {
                return ResourceManager.GetString("KeywordSourceScope", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please open your browser to the following location: {0}.
        /// </summary>
        internal static string LaunchBrowser {
            get {
                return ResourceManager.GetString("LaunchBrowser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Wildcard match requires exactly one name..
        /// </summary>
        internal static string MatchSingleName {
            get {
                return ResourceManager.GetString("MatchSingleName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Matches: {0}.
        /// </summary>
        internal static string MatchTrue {
            get {
                return ResourceManager.GetString("MatchTrue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Target object &apos;{0}&apos; has not been processed because no matching rules were found..
        /// </summary>
        internal static string ObjectNotProcessed {
            get {
                return ResourceManager.GetString("ObjectNotProcessed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Options file does not exist..
        /// </summary>
        internal static string OptionsNotFound {
            get {
                return ResourceManager.GetString("OptionsNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to # Source: {0}.
        /// </summary>
        internal static string OptionsSourceComment {
            get {
                return ResourceManager.GetString("OptionsSourceComment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [FAIL] -- {0}:: Reported for &apos;{1}&apos;.
        /// </summary>
        internal static string OutcomeRuleFail {
            get {
                return ResourceManager.GetString("OutcomeRuleFail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [PASS] -- {0}:: Reported for &apos;{1}&apos;.
        /// </summary>
        internal static string OutcomeRulePass {
            get {
                return ResourceManager.GetString("OutcomeRulePass", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The property &apos;${0}.{1}&apos; is obsolete and will be removed in the next major version..
        /// </summary>
        internal static string PropertyObsolete {
            get {
                return ResourceManager.GetString("PropertyObsolete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Read JSON failed..
        /// </summary>
        internal static string ReadJsonFailed {
            get {
                return ResourceManager.GetString("ReadJsonFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The module version &apos;{1}&apos; for &apos;{0}&apos; does not match the required version &apos;{2}&apos;..
        /// </summary>
        internal static string RequiredVersionMismatch {
            get {
                return ResourceManager.GetString("RequiredVersionMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to One or more rules reported errors..
        /// </summary>
        internal static string RuleErrorPipelineException {
            get {
                return ResourceManager.GetString("RuleErrorPipelineException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to One or more rules reported failure..
        /// </summary>
        internal static string RuleFailPipelineException {
            get {
                return ResourceManager.GetString("RuleFailPipelineException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Inconclusive result reported for &apos;{1}&apos; @{0}..
        /// </summary>
        internal static string RuleInconclusive {
            get {
                return ResourceManager.GetString("RuleInconclusive", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find a matching rule. Please check that Path, Name and Tag parameters are correct..
        /// </summary>
        internal static string RuleNotFound {
            get {
                return ResourceManager.GetString("RuleNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find required rule definition parameter &apos;{0}&apos; on rule at {1}..
        /// </summary>
        internal static string RuleParameterNotFound {
            get {
                return ResourceManager.GetString("RuleParameterNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No matching .Rule.ps1 files were found. Rule definitions should be saved into script files with the .Rule.ps1 extension..
        /// </summary>
        internal static string RulePathNotFound {
            get {
                return ResourceManager.GetString("RulePathNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to at Rule &apos;{0}&apos;, {1}: line {2}.
        /// </summary>
        internal static string RuleStackTrace {
            get {
                return ResourceManager.GetString("RuleStackTrace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [PSRule][D] -- Scanning for source files in module: {0}.
        /// </summary>
        internal static string ScanModule {
            get {
                return ResourceManager.GetString("ScanModule", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [PSRule][D] -- Scanning for source files: {0}.
        /// </summary>
        internal static string ScanSource {
            get {
                return ResourceManager.GetString("ScanSource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The script was not found..
        /// </summary>
        internal static string ScriptNotFound {
            get {
                return ResourceManager.GetString("ScriptNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Can not serialize a null PSObject..
        /// </summary>
        internal static string SerializeNullPSObject {
            get {
                return ResourceManager.GetString("SerializeNullPSObject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Create path.
        /// </summary>
        internal static string ShouldCreatePath {
            get {
                return ResourceManager.GetString("ShouldCreatePath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Write file.
        /// </summary>
        internal static string ShouldWriteFile {
            get {
                return ResourceManager.GetString("ShouldWriteFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The source was not found..
        /// </summary>
        internal static string SourceNotFound {
            get {
                return ResourceManager.GetString("SourceNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Using invariant culture may cause rule infomation to be displayed incorrectly. Consider using -Culture or set the Output.Culture option..
        /// </summary>
        internal static string UsingInvariantCulture {
            get {
                return ResourceManager.GetString("UsingInvariantCulture", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The variable &apos;${0}&apos; can only be used within a Rule block..
        /// </summary>
        internal static string VariableConditionScope {
            get {
                return ResourceManager.GetString("VariableConditionScope", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The version constraint &apos;{0}&apos; is not valid..
        /// </summary>
        internal static string VersionConstraintInvalid {
            get {
                return ResourceManager.GetString("VersionConstraintInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Within parameter Value must be a string when the Like parameter is used..
        /// </summary>
        internal static string WithinLikeNotString {
            get {
                return ResourceManager.GetString("WithinLikeNotString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Within: {0}.
        /// </summary>
        internal static string WithinTrue {
            get {
                return ResourceManager.GetString("WithinTrue", resourceCulture);
            }
        }
    }
}
