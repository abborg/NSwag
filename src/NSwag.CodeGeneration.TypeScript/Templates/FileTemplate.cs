﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 15.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace NSwag.CodeGeneration.TypeScript.Templates
{
    using NJsonSchema;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration.TypeScript\Templates\FileTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    internal partial class FileTemplate : FileTemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("/* tslint:disable */\r\n//----------------------\r\n// <auto-generated>\r\n//     Gener" +
                    "ated using the NSwag toolchain v");
            
            #line 6 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration.TypeScript\Templates\FileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SwaggerDocument.ToolchainVersion));
            
            #line default
            #line hidden
            this.Write(" (NJsonSchema v");
            
            #line 6 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration.TypeScript\Templates\FileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(JsonSchema4.ToolchainVersion));
            
            #line default
            #line hidden
            this.Write(") (http://NSwag.org)\r\n// </auto-generated>\r\n//----------------------\r\n// ReSharpe" +
                    "r disable InconsistentNaming\r\n\r\n");
            
            #line 11 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration.TypeScript\Templates\FileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.ExtensionCodeImport));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 12 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration.TypeScript\Templates\FileTemplate.tt"
if(Model.ImportRequiredTypes){
            
            #line default
            #line hidden
            
            #line 13 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration.TypeScript\Templates\FileTemplate.tt"
  if(Model.IsAngular){
            
            #line default
            #line hidden
            this.Write(@"
import 'rxjs/add/observable/fromPromise';
import 'rxjs/add/observable/of';
import 'rxjs/add/observable/throw';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/toPromise';
import 'rxjs/add/operator/mergeMap';
import 'rxjs/add/operator/catch';

import { Observable } from 'rxjs/Observable';
import { Injectable, Inject, Optional, ");
            
            #line 24 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration.TypeScript\Templates\FileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.InjectionTokenType));
            
            #line default
            #line hidden
            this.Write(" } from \'@angular/core\';\r\n");
            
            #line 25 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration.TypeScript\Templates\FileTemplate.tt"
    if(Model.UseAngularHttpClient){
            
            #line default
            #line hidden
            this.Write("import { HttpClient, HttpHeaders, HttpResponse, HttpParams } from \'@angular/commo" +
                    "n/http\';\r\n");
            
            #line 27 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration.TypeScript\Templates\FileTemplate.tt"
    }else{
            
            #line default
            #line hidden
            this.Write("import { Http, Headers, ResponseContentType, Response");
            
            #line 28 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration.TypeScript\Templates\FileTemplate.tt"
if(Model.UseTransformOptionsMethod){
            
            #line default
            #line hidden
            this.Write(", RequestOptionsArgs");
            
            #line 28 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration.TypeScript\Templates\FileTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write(" } from \'@angular/http\';\r\n");
            
            #line 29 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration.TypeScript\Templates\FileTemplate.tt"
    }
            
            #line default
            #line hidden
            
            #line 30 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration.TypeScript\Templates\FileTemplate.tt"
  }
            
            #line default
            #line hidden
            
            #line 31 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration.TypeScript\Templates\FileTemplate.tt"
  if(Model.IsAurelia){
            
            #line default
            #line hidden
            this.Write("\r\nimport { inject } from \'aurelia-framework\';\r\nimport { HttpClient, RequestInit }" +
                    " from \'aurelia-fetch-client\';\r\n");
            
            #line 35 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration.TypeScript\Templates\FileTemplate.tt"
  }
            
            #line default
            #line hidden
            
            #line 36 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration.TypeScript\Templates\FileTemplate.tt"
  if(Model.IsAngularJS){
            
            #line default
            #line hidden
            this.Write("\r\nimport * as ng from \'angular\';\r\n");
            
            #line 39 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration.TypeScript\Templates\FileTemplate.tt"
  }
            
            #line default
            #line hidden
            
            #line 40 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration.TypeScript\Templates\FileTemplate.tt"
  if(Model.IsKnockout){
            
            #line default
            #line hidden
            this.Write("\r\nimport * as ko from \'knockout\';\r\n");
            
            #line 43 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration.TypeScript\Templates\FileTemplate.tt"
  }
            
            #line default
            #line hidden
            
            #line 44 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration.TypeScript\Templates\FileTemplate.tt"
  if(Model.IsJQuery){
            
            #line default
            #line hidden
            this.Write("\r\nimport * as jQuery from \'jquery\';\r\n");
            
            #line 47 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration.TypeScript\Templates\FileTemplate.tt"
  }
            
            #line default
            #line hidden
            
            #line 48 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration.TypeScript\Templates\FileTemplate.tt"
  if(Model.RequiresMomentJS){
            
            #line default
            #line hidden
            this.Write("\r\nimport * as moment from \'moment\';\r\n");
            
            #line 51 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration.TypeScript\Templates\FileTemplate.tt"
  }
            
            #line default
            #line hidden
            
            #line 52 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration.TypeScript\Templates\FileTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 54 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration.TypeScript\Templates\FileTemplate.tt"
if(Model.HasModuleName){
            
            #line default
            #line hidden
            this.Write("module ");
            
            #line 55 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration.TypeScript\Templates\FileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.ModuleName));
            
            #line default
            #line hidden
            this.Write(" {\r\n");
            
            #line 56 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration.TypeScript\Templates\FileTemplate.tt"
}
  if(Model.HasNamespace){
            
            #line default
            #line hidden
            this.Write("namespace ");
            
            #line 58 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration.TypeScript\Templates\FileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Namespace));
            
            #line default
            #line hidden
            this.Write(" {\r\n");
            
            #line 59 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration.TypeScript\Templates\FileTemplate.tt"
}
            
            #line default
            #line hidden
            
            #line 60 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration.TypeScript\Templates\FileTemplate.tt"
if(Model.GenerateClientClasses && Model.IsAngular){
            
            #line default
            #line hidden
            this.Write("export const ");
            
            #line 61 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration.TypeScript\Templates\FileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.BaseUrlTokenName));
            
            #line default
            #line hidden
            this.Write(" = new ");
            
            #line 61 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration.TypeScript\Templates\FileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.InjectionTokenType));
            
            #line default
            #line hidden
            
            #line 61 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration.TypeScript\Templates\FileTemplate.tt"
if(Model.InjectionTokenType == "InjectionToken"){
            
            #line default
            #line hidden
            this.Write("<string>");
            
            #line 61 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration.TypeScript\Templates\FileTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write("(\'");
            
            #line 61 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration.TypeScript\Templates\FileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.BaseUrlTokenName));
            
            #line default
            #line hidden
            this.Write("\');\r\n\r\n");
            
            #line 63 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration.TypeScript\Templates\FileTemplate.tt"
}
            
            #line default
            #line hidden
            
            #line 64 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration.TypeScript\Templates\FileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.ExtensionCodeTop));
            
            #line default
            #line hidden
            this.Write("\r\n\r\n");
            
            #line 66 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration.TypeScript\Templates\FileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Clients));
            
            #line default
            #line hidden
            this.Write("\r\n\r\n");
            
            #line 68 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration.TypeScript\Templates\FileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Types));
            
            #line default
            #line hidden
            this.Write("\r\n\r\n");
            
            #line 70 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration.TypeScript\Templates\FileTemplate.tt"
if(Model.WrapResponses && Model.GenerateResponseClasses){
            
            #line default
            #line hidden
            
            #line 71 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration.TypeScript\Templates\FileTemplate.tt"
  foreach (var responseClassName in Model.ResponseClassNames){
            
            #line default
            #line hidden
            this.Write("export class ");
            
            #line 72 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration.TypeScript\Templates\FileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(responseClassName));
            
            #line default
            #line hidden
            this.Write(@"<TResult> {
    status: number;
    headers: { [key: string]: any; };
    result: TResult;
        
    constructor(status: number, headers: { [key: string]: any; }, result: TResult) 
    {
        this.status = status;
        this.headers = headers;
        this.result = result;
    }
}

");
            
            #line 85 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration.TypeScript\Templates\FileTemplate.tt"
  }
            
            #line default
            #line hidden
            
            #line 86 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration.TypeScript\Templates\FileTemplate.tt"
}
            
            #line default
            #line hidden
            
            #line 87 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration.TypeScript\Templates\FileTemplate.tt"
if(Model.RequiresFileParameterInterface){
            
            #line default
            #line hidden
            this.Write("export interface FileParameter {\r\n    data: any;\r\n    fileName: string;\r\n}\r\n\r\n");
            
            #line 93 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration.TypeScript\Templates\FileTemplate.tt"
}
            
            #line default
            #line hidden
            
            #line 94 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration.TypeScript\Templates\FileTemplate.tt"
if(Model.RequiresFileResponseInterface){
            
            #line default
            #line hidden
            this.Write("export interface FileResponse {\r\n    data: Blob;\r\n    status: number;\r\n    fileNa" +
                    "me?: string;\r\n    headers?: { [name: string]: any };\r\n}\r\n\r\n");
            
            #line 102 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration.TypeScript\Templates\FileTemplate.tt"
}
            
            #line default
            #line hidden
            
            #line 103 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration.TypeScript\Templates\FileTemplate.tt"
if(Model.RequiresSwaggerExceptionClass){
            
            #line default
            #line hidden
            this.Write(@"export class SwaggerException extends Error {
    message: string;
    status: number; 
    response: string; 
    headers: { [key: string]: any; };
    result: any; 

    constructor(message: string, status: number, response: string, headers: { [key: string]: any; }, result: any) {
        super();

        this.message = message;
        this.status = status;
        this.response = response;
        this.headers = headers;
        this.result = result;
    }

    protected isSwaggerException = true;

    static isSwaggerException(obj: any): obj is SwaggerException {
        return obj.isSwaggerException === true;
    }
}

");
            
            #line 128 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration.TypeScript\Templates\FileTemplate.tt"
}
            
            #line default
            #line hidden
            
            #line 129 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration.TypeScript\Templates\FileTemplate.tt"
if(Model.GenerateClientClasses){
            
            #line default
            #line hidden
            
            #line 130 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration.TypeScript\Templates\FileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TypeScriptTemplatePartGenerator.RenderClientMethodsCode(Model, 0)));
            
            #line default
            #line hidden
            this.Write("\r\n\r\n");
            
            #line 132 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration.TypeScript\Templates\FileTemplate.tt"
if(Model.HandleReferences){
            
            #line default
            #line hidden
            
            #line 133 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration.TypeScript\Templates\FileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.ReferenceHandlingCode));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 134 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration.TypeScript\Templates\FileTemplate.tt"
}
            
            #line default
            #line hidden
            
            #line 135 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration.TypeScript\Templates\FileTemplate.tt"
}
            
            #line default
            #line hidden
            
            #line 136 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration.TypeScript\Templates\FileTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.ExtensionCodeBottom));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 137 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration.TypeScript\Templates\FileTemplate.tt"
if(Model.HasNamespace){
            
            #line default
            #line hidden
            this.Write("}\r\n");
            
            #line 139 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration.TypeScript\Templates\FileTemplate.tt"
}
  if(Model.HasModuleName){
            
            #line default
            #line hidden
            this.Write("}\r\n");
            
            #line 142 "C:\Data\Projects\NSwag\src\NSwag.CodeGeneration.TypeScript\Templates\FileTemplate.tt"
}
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    internal class FileTemplateBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
