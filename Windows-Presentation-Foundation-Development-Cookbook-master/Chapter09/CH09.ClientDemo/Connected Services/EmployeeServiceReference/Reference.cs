﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CH09.ClientDemo.EmployeeServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employee", Namespace="http://schemas.datacontract.org/2004/07/CH09.EmployeeService.DataModels")]
    [System.SerializableAttribute()]
    public partial class Employee : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DesignationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
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
        public string Designation {
            get {
                return this.DesignationField;
            }
            set {
                if ((object.ReferenceEquals(this.DesignationField, value) != true)) {
                    this.DesignationField = value;
                    this.RaisePropertyChanged("Designation");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ID {
            get {
                return this.IDField;
            }
            set {
                if ((object.ReferenceEquals(this.IDField, value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EmployeeServiceReference.IEmployeeService")]
    public interface IEmployeeService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/GetEmployeeByID", ReplyAction="http://tempuri.org/IEmployeeService/GetEmployeeByIDResponse")]
        CH09.ClientDemo.EmployeeServiceReference.Employee GetEmployeeByID(string empID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/GetEmployeeByID", ReplyAction="http://tempuri.org/IEmployeeService/GetEmployeeByIDResponse")]
        System.Threading.Tasks.Task<CH09.ClientDemo.EmployeeServiceReference.Employee> GetEmployeeByIDAsync(string empID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/GetEmployees", ReplyAction="http://tempuri.org/IEmployeeService/GetEmployeesResponse")]
        CH09.ClientDemo.EmployeeServiceReference.Employee[] GetEmployees();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/GetEmployees", ReplyAction="http://tempuri.org/IEmployeeService/GetEmployeesResponse")]
        System.Threading.Tasks.Task<CH09.ClientDemo.EmployeeServiceReference.Employee[]> GetEmployeesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/InsertEmployee", ReplyAction="http://tempuri.org/IEmployeeService/InsertEmployeeResponse")]
        void InsertEmployee(CH09.ClientDemo.EmployeeServiceReference.Employee employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/InsertEmployee", ReplyAction="http://tempuri.org/IEmployeeService/InsertEmployeeResponse")]
        System.Threading.Tasks.Task InsertEmployeeAsync(CH09.ClientDemo.EmployeeServiceReference.Employee employee);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmployeeServiceChannel : CH09.ClientDemo.EmployeeServiceReference.IEmployeeService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmployeeServiceClient : System.ServiceModel.ClientBase<CH09.ClientDemo.EmployeeServiceReference.IEmployeeService>, CH09.ClientDemo.EmployeeServiceReference.IEmployeeService
    {        
        public EmployeeServiceClient() {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public CH09.ClientDemo.EmployeeServiceReference.Employee GetEmployeeByID(string empID) {
            return base.Channel.GetEmployeeByID(empID);
        }
        
        public System.Threading.Tasks.Task<CH09.ClientDemo.EmployeeServiceReference.Employee> GetEmployeeByIDAsync(string empID) {
            return base.Channel.GetEmployeeByIDAsync(empID);
        }
        
        public CH09.ClientDemo.EmployeeServiceReference.Employee[] GetEmployees() {
            return base.Channel.GetEmployees();
        }
        
        public System.Threading.Tasks.Task<CH09.ClientDemo.EmployeeServiceReference.Employee[]> GetEmployeesAsync() {
            return base.Channel.GetEmployeesAsync();
        }
        
        public void InsertEmployee(CH09.ClientDemo.EmployeeServiceReference.Employee employee) {
            base.Channel.InsertEmployee(employee);
        }
        
        public System.Threading.Tasks.Task InsertEmployeeAsync(CH09.ClientDemo.EmployeeServiceReference.Employee employee) {
            return base.Channel.InsertEmployeeAsync(employee);
        }
    }
}