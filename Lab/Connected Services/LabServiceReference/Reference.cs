﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab.LabServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CPost", Namespace="http://schemas.datacontract.org/2004/07/LabService")]
    [System.SerializableAttribute()]
    public partial class CPost : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Lab.LabServiceReference.CComment[] CommentsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Lab.LabServiceReference.CUser[] LikesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Lab.LabServiceReference.CUser OwnerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Drawing.Bitmap PictureField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Lab.LabServiceReference.CComment[] Comments {
            get {
                return this.CommentsField;
            }
            set {
                if ((object.ReferenceEquals(this.CommentsField, value) != true)) {
                    this.CommentsField = value;
                    this.RaisePropertyChanged("Comments");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Date {
            get {
                return this.DateField;
            }
            set {
                if ((this.DateField.Equals(value) != true)) {
                    this.DateField = value;
                    this.RaisePropertyChanged("Date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Lab.LabServiceReference.CUser[] Likes {
            get {
                return this.LikesField;
            }
            set {
                if ((object.ReferenceEquals(this.LikesField, value) != true)) {
                    this.LikesField = value;
                    this.RaisePropertyChanged("Likes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Lab.LabServiceReference.CUser Owner {
            get {
                return this.OwnerField;
            }
            set {
                if ((object.ReferenceEquals(this.OwnerField, value) != true)) {
                    this.OwnerField = value;
                    this.RaisePropertyChanged("Owner");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Drawing.Bitmap Picture {
            get {
                return this.PictureField;
            }
            set {
                if ((object.ReferenceEquals(this.PictureField, value) != true)) {
                    this.PictureField = value;
                    this.RaisePropertyChanged("Picture");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CUser", Namespace="http://schemas.datacontract.org/2004/07/LabService")]
    [System.SerializableAttribute()]
    public partial class CUser : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SurnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Drawing.Bitmap UserPictureField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Surname {
            get {
                return this.SurnameField;
            }
            set {
                if ((object.ReferenceEquals(this.SurnameField, value) != true)) {
                    this.SurnameField = value;
                    this.RaisePropertyChanged("Surname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Drawing.Bitmap UserPicture {
            get {
                return this.UserPictureField;
            }
            set {
                if ((object.ReferenceEquals(this.UserPictureField, value) != true)) {
                    this.UserPictureField = value;
                    this.RaisePropertyChanged("UserPicture");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CComment", Namespace="http://schemas.datacontract.org/2004/07/LabService")]
    [System.SerializableAttribute()]
    public partial class CComment : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Lab.LabServiceReference.CUser OwnerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TextField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Date {
            get {
                return this.DateField;
            }
            set {
                if ((this.DateField.Equals(value) != true)) {
                    this.DateField = value;
                    this.RaisePropertyChanged("Date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Lab.LabServiceReference.CUser Owner {
            get {
                return this.OwnerField;
            }
            set {
                if ((object.ReferenceEquals(this.OwnerField, value) != true)) {
                    this.OwnerField = value;
                    this.RaisePropertyChanged("Owner");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Text {
            get {
                return this.TextField;
            }
            set {
                if ((object.ReferenceEquals(this.TextField, value) != true)) {
                    this.TextField = value;
                    this.RaisePropertyChanged("Text");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CProcessingTemplate", Namespace="http://schemas.datacontract.org/2004/07/LabService")]
    [System.SerializableAttribute()]
    public partial class CProcessingTemplate : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Drawing.Bitmap ExampleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Drawing.Bitmap Example {
            get {
                return this.ExampleField;
            }
            set {
                if ((object.ReferenceEquals(this.ExampleField, value) != true)) {
                    this.ExampleField = value;
                    this.RaisePropertyChanged("Example");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LabServiceReference.ILabService")]
    public interface ILabService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILabService/GetFeed", ReplyAction="http://tempuri.org/ILabService/GetFeedResponse")]
        Lab.LabServiceReference.CPost[] GetFeed(System.Guid userId, int startIndex, int length);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILabService/GetFeed", ReplyAction="http://tempuri.org/ILabService/GetFeedResponse")]
        System.Threading.Tasks.Task<Lab.LabServiceReference.CPost[]> GetFeedAsync(System.Guid userId, int startIndex, int length);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILabService/GetCurrentUser", ReplyAction="http://tempuri.org/ILabService/GetCurrentUserResponse")]
        System.Guid GetCurrentUser();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILabService/GetCurrentUser", ReplyAction="http://tempuri.org/ILabService/GetCurrentUserResponse")]
        System.Threading.Tasks.Task<System.Guid> GetCurrentUserAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILabService/GetUserInfo", ReplyAction="http://tempuri.org/ILabService/GetUserInfoResponse")]
        Lab.LabServiceReference.CUser GetUserInfo(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILabService/GetUserInfo", ReplyAction="http://tempuri.org/ILabService/GetUserInfoResponse")]
        System.Threading.Tasks.Task<Lab.LabServiceReference.CUser> GetUserInfoAsync(System.Guid userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILabService/GetUserPosts", ReplyAction="http://tempuri.org/ILabService/GetUserPostsResponse")]
        Lab.LabServiceReference.CPost[] GetUserPosts(System.Guid userId, int startIndex, int length);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILabService/GetUserPosts", ReplyAction="http://tempuri.org/ILabService/GetUserPostsResponse")]
        System.Threading.Tasks.Task<Lab.LabServiceReference.CPost[]> GetUserPostsAsync(System.Guid userId, int startIndex, int length);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILabService/GetPost", ReplyAction="http://tempuri.org/ILabService/GetPostResponse")]
        Lab.LabServiceReference.CPost GetPost(System.Guid postId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILabService/GetPost", ReplyAction="http://tempuri.org/ILabService/GetPostResponse")]
        System.Threading.Tasks.Task<Lab.LabServiceReference.CPost> GetPostAsync(System.Guid postId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILabService/GetComments", ReplyAction="http://tempuri.org/ILabService/GetCommentsResponse")]
        Lab.LabServiceReference.CComment[] GetComments(System.Guid postId, int startIndex, int length);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILabService/GetComments", ReplyAction="http://tempuri.org/ILabService/GetCommentsResponse")]
        System.Threading.Tasks.Task<Lab.LabServiceReference.CComment[]> GetCommentsAsync(System.Guid postId, int startIndex, int length);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILabService/GetTemplates", ReplyAction="http://tempuri.org/ILabService/GetTemplatesResponse")]
        Lab.LabServiceReference.CProcessingTemplate[] GetTemplates(System.Guid userId, int startIndex, int length);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILabService/GetTemplates", ReplyAction="http://tempuri.org/ILabService/GetTemplatesResponse")]
        System.Threading.Tasks.Task<Lab.LabServiceReference.CProcessingTemplate[]> GetTemplatesAsync(System.Guid userId, int startIndex, int length);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILabServiceChannel : Lab.LabServiceReference.ILabService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LabServiceClient : System.ServiceModel.ClientBase<Lab.LabServiceReference.ILabService>, Lab.LabServiceReference.ILabService {
        
        public LabServiceClient() {
        }
        
        public LabServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LabServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LabServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LabServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Lab.LabServiceReference.CPost[] GetFeed(System.Guid userId, int startIndex, int length) {
            return base.Channel.GetFeed(userId, startIndex, length);
        }
        
        public System.Threading.Tasks.Task<Lab.LabServiceReference.CPost[]> GetFeedAsync(System.Guid userId, int startIndex, int length) {
            return base.Channel.GetFeedAsync(userId, startIndex, length);
        }
        
        public System.Guid GetCurrentUser() {
            return base.Channel.GetCurrentUser();
        }
        
        public System.Threading.Tasks.Task<System.Guid> GetCurrentUserAsync() {
            return base.Channel.GetCurrentUserAsync();
        }
        
        public Lab.LabServiceReference.CUser GetUserInfo(System.Guid userId) {
            return base.Channel.GetUserInfo(userId);
        }
        
        public System.Threading.Tasks.Task<Lab.LabServiceReference.CUser> GetUserInfoAsync(System.Guid userId) {
            return base.Channel.GetUserInfoAsync(userId);
        }
        
        public Lab.LabServiceReference.CPost[] GetUserPosts(System.Guid userId, int startIndex, int length) {
            return base.Channel.GetUserPosts(userId, startIndex, length);
        }
        
        public System.Threading.Tasks.Task<Lab.LabServiceReference.CPost[]> GetUserPostsAsync(System.Guid userId, int startIndex, int length) {
            return base.Channel.GetUserPostsAsync(userId, startIndex, length);
        }
        
        public Lab.LabServiceReference.CPost GetPost(System.Guid postId) {
            return base.Channel.GetPost(postId);
        }
        
        public System.Threading.Tasks.Task<Lab.LabServiceReference.CPost> GetPostAsync(System.Guid postId) {
            return base.Channel.GetPostAsync(postId);
        }
        
        public Lab.LabServiceReference.CComment[] GetComments(System.Guid postId, int startIndex, int length) {
            return base.Channel.GetComments(postId, startIndex, length);
        }
        
        public System.Threading.Tasks.Task<Lab.LabServiceReference.CComment[]> GetCommentsAsync(System.Guid postId, int startIndex, int length) {
            return base.Channel.GetCommentsAsync(postId, startIndex, length);
        }
        
        public Lab.LabServiceReference.CProcessingTemplate[] GetTemplates(System.Guid userId, int startIndex, int length) {
            return base.Channel.GetTemplates(userId, startIndex, length);
        }
        
        public System.Threading.Tasks.Task<Lab.LabServiceReference.CProcessingTemplate[]> GetTemplatesAsync(System.Guid userId, int startIndex, int length) {
            return base.Channel.GetTemplatesAsync(userId, startIndex, length);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LabServiceReference.ILabRegistrationService")]
    public interface ILabRegistrationService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILabRegistrationService/Register", ReplyAction="http://tempuri.org/ILabRegistrationService/RegisterResponse")]
        bool Register(string login, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILabRegistrationService/Register", ReplyAction="http://tempuri.org/ILabRegistrationService/RegisterResponse")]
        System.Threading.Tasks.Task<bool> RegisterAsync(string login, string password);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILabRegistrationServiceChannel : Lab.LabServiceReference.ILabRegistrationService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LabRegistrationServiceClient : System.ServiceModel.ClientBase<Lab.LabServiceReference.ILabRegistrationService>, Lab.LabServiceReference.ILabRegistrationService {
        
        public LabRegistrationServiceClient() {
        }
        
        public LabRegistrationServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LabRegistrationServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LabRegistrationServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LabRegistrationServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Register(string login, string password) {
            return base.Channel.Register(login, password);
        }
        
        public System.Threading.Tasks.Task<bool> RegisterAsync(string login, string password) {
            return base.Channel.RegisterAsync(login, password);
        }
    }
}
