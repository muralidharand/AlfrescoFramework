﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.42
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 2.0.50727.42.
// 
#pragma warning disable 1591

namespace Alfresco.DictionaryServiceWebService {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="DictionaryServiceSoapBinding", Namespace="http://www.alfresco.org/ws/service/dictionary/1.0")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ValueDefinition))]
    public partial class DictionaryService : Microsoft.Web.Services3.WebServicesClientProtocol {
        
        private System.Threading.SendOrPostCallback getClassesOperationCompleted;
        
        private System.Threading.SendOrPostCallback getPropertiesOperationCompleted;
        
        private System.Threading.SendOrPostCallback getAssociationsOperationCompleted;
        
        private System.Threading.SendOrPostCallback isSubClassOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public DictionaryService() {
            this.Url = global::Alfresco.Properties.Settings.Default.Alfresco_DictionaryServiceWebService_DictionaryService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event getClassesCompletedEventHandler getClassesCompleted;
        
        /// <remarks/>
        public event getPropertiesCompletedEventHandler getPropertiesCompleted;
        
        /// <remarks/>
        public event getAssociationsCompletedEventHandler getAssociationsCompleted;
        
        /// <remarks/>
        public event isSubClassCompletedEventHandler isSubClassCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.alfresco.org/ws/service/dictionary/1.0/getClasses", RequestNamespace="http://www.alfresco.org/ws/service/dictionary/1.0", ResponseNamespace="http://www.alfresco.org/ws/service/dictionary/1.0", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("getClassesReturn")]
        public ClassDefinition[] getClasses(ClassPredicate types, ClassPredicate aspects) {
            object[] results = this.Invoke("getClasses", new object[] {
                        types,
                        aspects});
            return ((ClassDefinition[])(results[0]));
        }
        
        /// <remarks/>
        public void getClassesAsync(ClassPredicate types, ClassPredicate aspects) {
            this.getClassesAsync(types, aspects, null);
        }
        
        /// <remarks/>
        public void getClassesAsync(ClassPredicate types, ClassPredicate aspects, object userState) {
            if ((this.getClassesOperationCompleted == null)) {
                this.getClassesOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetClassesOperationCompleted);
            }
            this.InvokeAsync("getClasses", new object[] {
                        types,
                        aspects}, this.getClassesOperationCompleted, userState);
        }
        
        private void OngetClassesOperationCompleted(object arg) {
            if ((this.getClassesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getClassesCompleted(this, new getClassesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.alfresco.org/ws/service/dictionary/1.0/getProperties", RequestNamespace="http://www.alfresco.org/ws/service/dictionary/1.0", ResponseNamespace="http://www.alfresco.org/ws/service/dictionary/1.0", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("getPropertiesReturn")]
        public PropertyDefinition[] getProperties([System.Xml.Serialization.XmlElementAttribute("propertyNames")] string[] propertyNames) {
            object[] results = this.Invoke("getProperties", new object[] {
                        propertyNames});
            return ((PropertyDefinition[])(results[0]));
        }
        
        /// <remarks/>
        public void getPropertiesAsync(string[] propertyNames) {
            this.getPropertiesAsync(propertyNames, null);
        }
        
        /// <remarks/>
        public void getPropertiesAsync(string[] propertyNames, object userState) {
            if ((this.getPropertiesOperationCompleted == null)) {
                this.getPropertiesOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetPropertiesOperationCompleted);
            }
            this.InvokeAsync("getProperties", new object[] {
                        propertyNames}, this.getPropertiesOperationCompleted, userState);
        }
        
        private void OngetPropertiesOperationCompleted(object arg) {
            if ((this.getPropertiesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getPropertiesCompleted(this, new getPropertiesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.alfresco.org/ws/service/dictionary/1.0/getAssociations", RequestNamespace="http://www.alfresco.org/ws/service/dictionary/1.0", ResponseNamespace="http://www.alfresco.org/ws/service/dictionary/1.0", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("getAssociationsReturn")]
        public AssociationDefinition[] getAssociations([System.Xml.Serialization.XmlElementAttribute("associationNames")] string[] associationNames) {
            object[] results = this.Invoke("getAssociations", new object[] {
                        associationNames});
            return ((AssociationDefinition[])(results[0]));
        }
        
        /// <remarks/>
        public void getAssociationsAsync(string[] associationNames) {
            this.getAssociationsAsync(associationNames, null);
        }
        
        /// <remarks/>
        public void getAssociationsAsync(string[] associationNames, object userState) {
            if ((this.getAssociationsOperationCompleted == null)) {
                this.getAssociationsOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetAssociationsOperationCompleted);
            }
            this.InvokeAsync("getAssociations", new object[] {
                        associationNames}, this.getAssociationsOperationCompleted, userState);
        }
        
        private void OngetAssociationsOperationCompleted(object arg) {
            if ((this.getAssociationsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getAssociationsCompleted(this, new getAssociationsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.alfresco.org/ws/service/dictionary/1.0/isSubClass", RequestNamespace="http://www.alfresco.org/ws/service/dictionary/1.0", ResponseNamespace="http://www.alfresco.org/ws/service/dictionary/1.0", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("isSubClassReturn")]
        public bool isSubClass(string className, string isSubClassOfName) {
            object[] results = this.Invoke("isSubClass", new object[] {
                        className,
                        isSubClassOfName});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void isSubClassAsync(string className, string isSubClassOfName) {
            this.isSubClassAsync(className, isSubClassOfName, null);
        }
        
        /// <remarks/>
        public void isSubClassAsync(string className, string isSubClassOfName, object userState) {
            if ((this.isSubClassOperationCompleted == null)) {
                this.isSubClassOperationCompleted = new System.Threading.SendOrPostCallback(this.OnisSubClassOperationCompleted);
            }
            this.InvokeAsync("isSubClass", new object[] {
                        className,
                        isSubClassOfName}, this.isSubClassOperationCompleted, userState);
        }
        
        private void OnisSubClassOperationCompleted(object arg) {
            if ((this.isSubClassCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.isSubClassCompleted(this, new isSubClassCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.alfresco.org/ws/service/dictionary/1.0")]
    public partial class ClassPredicate {
        
        private string[] namesField;
        
        private bool followSubClassField;
        
        private bool followSuperClassField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("names", IsNullable=true)]
        public string[] names {
            get {
                return this.namesField;
            }
            set {
                this.namesField = value;
            }
        }
        
        /// <remarks/>
        public bool followSubClass {
            get {
                return this.followSubClassField;
            }
            set {
                this.followSubClassField = value;
            }
        }
        
        /// <remarks/>
        public bool followSuperClass {
            get {
                return this.followSuperClassField;
            }
            set {
                this.followSuperClassField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.alfresco.org/ws/model/content/1.0")]
    public partial class RoleDefinition {
        
        private string nameField;
        
        private Cardinality cardinalityField;
        
        public RoleDefinition() {
            this.cardinalityField = Cardinality.Item;
        }
        
        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(Cardinality.Item)]
        public Cardinality cardinality {
            get {
                return this.cardinalityField;
            }
            set {
                this.cardinalityField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.alfresco.org/ws/model/content/1.0")]
    public enum Cardinality {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0..1")]
        Item01,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("*")]
        Item,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1..*")]
        Item11,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.alfresco.org/ws/model/content/1.0")]
    public partial class AssociationDefinition {
        
        private string nameField;
        
        private string titleField;
        
        private string descriptionField;
        
        private bool isChildField;
        
        private RoleDefinition sourceRoleField;
        
        private RoleDefinition targetRoleField;
        
        private string targetClassField;
        
        public AssociationDefinition() {
            this.isChildField = true;
        }
        
        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
        
        /// <remarks/>
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        public bool isChild {
            get {
                return this.isChildField;
            }
            set {
                this.isChildField = value;
            }
        }
        
        /// <remarks/>
        public RoleDefinition sourceRole {
            get {
                return this.sourceRoleField;
            }
            set {
                this.sourceRoleField = value;
            }
        }
        
        /// <remarks/>
        public RoleDefinition targetRole {
            get {
                return this.targetRoleField;
            }
            set {
                this.targetRoleField = value;
            }
        }
        
        /// <remarks/>
        public string targetClass {
            get {
                return this.targetClassField;
            }
            set {
                this.targetClassField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PropertyDefinition))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.alfresco.org/ws/model/content/1.0")]
    public partial class ValueDefinition {
        
        private string nameField;
        
        private string titleField;
        
        private string descriptionField;
        
        private string dataTypeField;
        
        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
        
        /// <remarks/>
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        public string dataType {
            get {
                return this.dataTypeField;
            }
            set {
                this.dataTypeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.alfresco.org/ws/model/content/1.0")]
    public partial class PropertyDefinition : ValueDefinition {
        
        private bool mandatoryField;
        
        private bool readOnlyField;
        
        private string defaultValueField;
        
        public PropertyDefinition() {
            this.mandatoryField = false;
            this.readOnlyField = false;
        }
        
        /// <remarks/>
        public bool mandatory {
            get {
                return this.mandatoryField;
            }
            set {
                this.mandatoryField = value;
            }
        }
        
        /// <remarks/>
        public bool readOnly {
            get {
                return this.readOnlyField;
            }
            set {
                this.readOnlyField = value;
            }
        }
        
        /// <remarks/>
        public string defaultValue {
            get {
                return this.defaultValueField;
            }
            set {
                this.defaultValueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.alfresco.org/ws/model/content/1.0")]
    public partial class ClassDefinition {
        
        private string nameField;
        
        private string titleField;
        
        private string descriptionField;
        
        private string superClassField;
        
        private bool isAspectField;
        
        private PropertyDefinition[] propertiesField;
        
        private AssociationDefinition[] associationsField;
        
        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
        
        /// <remarks/>
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        public string superClass {
            get {
                return this.superClassField;
            }
            set {
                this.superClassField = value;
            }
        }
        
        /// <remarks/>
        public bool isAspect {
            get {
                return this.isAspectField;
            }
            set {
                this.isAspectField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("properties", IsNullable=true)]
        public PropertyDefinition[] properties {
            get {
                return this.propertiesField;
            }
            set {
                this.propertiesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("associations", IsNullable=true)]
        public AssociationDefinition[] associations {
            get {
                return this.associationsField;
            }
            set {
                this.associationsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    public delegate void getClassesCompletedEventHandler(object sender, getClassesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getClassesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getClassesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ClassDefinition[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ClassDefinition[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    public delegate void getPropertiesCompletedEventHandler(object sender, getPropertiesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getPropertiesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getPropertiesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public PropertyDefinition[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((PropertyDefinition[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    public delegate void getAssociationsCompletedEventHandler(object sender, getAssociationsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getAssociationsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getAssociationsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public AssociationDefinition[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((AssociationDefinition[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    public delegate void isSubClassCompletedEventHandler(object sender, isSubClassCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class isSubClassCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal isSubClassCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591