﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF_Client.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ServiceStation", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class ServiceStation : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
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
        public int Id {
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ServicesOnStation", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class ServicesOnStation : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PriceField;
        
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
        public int Id {
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
        public int Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CarBrand", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class CarBrand : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int YearField;
        
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
        public int Id {
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
        public int Year {
            get {
                return this.YearField;
            }
            set {
                if ((this.YearField.Equals(value) != true)) {
                    this.YearField = value;
                    this.RaisePropertyChanged("Year");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Services", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class Services : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public int Id {
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ServicesPerformed", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class ServicesPerformed : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string dateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameCarField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameServiceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int priceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int yearField;
        
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
        public string date {
            get {
                return this.dateField;
            }
            set {
                if ((object.ReferenceEquals(this.dateField, value) != true)) {
                    this.dateField = value;
                    this.RaisePropertyChanged("date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nameCar {
            get {
                return this.nameCarField;
            }
            set {
                if ((object.ReferenceEquals(this.nameCarField, value) != true)) {
                    this.nameCarField = value;
                    this.RaisePropertyChanged("nameCar");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nameService {
            get {
                return this.nameServiceField;
            }
            set {
                if ((object.ReferenceEquals(this.nameServiceField, value) != true)) {
                    this.nameServiceField = value;
                    this.RaisePropertyChanged("nameService");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int price {
            get {
                return this.priceField;
            }
            set {
                if ((this.priceField.Equals(value) != true)) {
                    this.priceField = value;
                    this.RaisePropertyChanged("price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int year {
            get {
                return this.yearField;
            }
            set {
                if ((this.yearField.Equals(value) != true)) {
                    this.yearField = value;
                    this.RaisePropertyChanged("year");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Statistic", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class Statistic : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int countServicesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int totalAmountField;
        
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
        public int countServices {
            get {
                return this.countServicesField;
            }
            set {
                if ((this.countServicesField.Equals(value) != true)) {
                    this.countServicesField = value;
                    this.RaisePropertyChanged("countServices");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int totalAmount {
            get {
                return this.totalAmountField;
            }
            set {
                if ((this.totalAmountField.Equals(value) != true)) {
                    this.totalAmountField = value;
                    this.RaisePropertyChanged("totalAmount");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/InsertServiceStation", ReplyAction="http://tempuri.org/IService/InsertServiceStationResponse")]
        int InsertServiceStation(string name, string address, string description);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/InsertServiceStation", ReplyAction="http://tempuri.org/IService/InsertServiceStationResponse")]
        System.Threading.Tasks.Task<int> InsertServiceStationAsync(string name, string address, string description);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/InsertCarBrand", ReplyAction="http://tempuri.org/IService/InsertCarBrandResponse")]
        int InsertCarBrand(string name, string year);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/InsertCarBrand", ReplyAction="http://tempuri.org/IService/InsertCarBrandResponse")]
        System.Threading.Tasks.Task<int> InsertCarBrandAsync(string name, string year);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/InsertService", ReplyAction="http://tempuri.org/IService/InsertServiceResponse")]
        int InsertService(string name, string description);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/InsertService", ReplyAction="http://tempuri.org/IService/InsertServiceResponse")]
        System.Threading.Tasks.Task<int> InsertServiceAsync(string name, string description);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddServiceForStation", ReplyAction="http://tempuri.org/IService/AddServiceForStationResponse")]
        int AddServiceForStation(int idStation, int idService, int price);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddServiceForStation", ReplyAction="http://tempuri.org/IService/AddServiceForStationResponse")]
        System.Threading.Tasks.Task<int> AddServiceForStationAsync(int idStation, int idService, int price);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddExecutedService", ReplyAction="http://tempuri.org/IService/AddExecutedServiceResponse")]
        int AddExecutedService(int idStation, int idCar, int idService, string date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddExecutedService", ReplyAction="http://tempuri.org/IService/AddExecutedServiceResponse")]
        System.Threading.Tasks.Task<int> AddExecutedServiceAsync(int idStation, int idCar, int idService, string date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAllServiceStations", ReplyAction="http://tempuri.org/IService/GetAllServiceStationsResponse")]
        WCF_Client.ServiceReference1.ServiceStation[] GetAllServiceStations();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAllServiceStations", ReplyAction="http://tempuri.org/IService/GetAllServiceStationsResponse")]
        System.Threading.Tasks.Task<WCF_Client.ServiceReference1.ServiceStation[]> GetAllServiceStationsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAllServicesOnStation", ReplyAction="http://tempuri.org/IService/GetAllServicesOnStationResponse")]
        WCF_Client.ServiceReference1.ServicesOnStation[] GetAllServicesOnStation(int idStation);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAllServicesOnStation", ReplyAction="http://tempuri.org/IService/GetAllServicesOnStationResponse")]
        System.Threading.Tasks.Task<WCF_Client.ServiceReference1.ServicesOnStation[]> GetAllServicesOnStationAsync(int idStation);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAllCars", ReplyAction="http://tempuri.org/IService/GetAllCarsResponse")]
        WCF_Client.ServiceReference1.CarBrand[] GetAllCars();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAllCars", ReplyAction="http://tempuri.org/IService/GetAllCarsResponse")]
        System.Threading.Tasks.Task<WCF_Client.ServiceReference1.CarBrand[]> GetAllCarsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAllServices", ReplyAction="http://tempuri.org/IService/GetAllServicesResponse")]
        WCF_Client.ServiceReference1.Services[] GetAllServices();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAllServices", ReplyAction="http://tempuri.org/IService/GetAllServicesResponse")]
        System.Threading.Tasks.Task<WCF_Client.ServiceReference1.Services[]> GetAllServicesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAllPerformedServices", ReplyAction="http://tempuri.org/IService/GetAllPerformedServicesResponse")]
        WCF_Client.ServiceReference1.ServicesPerformed[] GetAllPerformedServices();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAllPerformedServices", ReplyAction="http://tempuri.org/IService/GetAllPerformedServicesResponse")]
        System.Threading.Tasks.Task<WCF_Client.ServiceReference1.ServicesPerformed[]> GetAllPerformedServicesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAllexecutedServicesOnStation", ReplyAction="http://tempuri.org/IService/GetAllexecutedServicesOnStationResponse")]
        WCF_Client.ServiceReference1.ServicesPerformed[] GetAllexecutedServicesOnStation(int idStation);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAllexecutedServicesOnStation", ReplyAction="http://tempuri.org/IService/GetAllexecutedServicesOnStationResponse")]
        System.Threading.Tasks.Task<WCF_Client.ServiceReference1.ServicesPerformed[]> GetAllexecutedServicesOnStationAsync(int idStation);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAllexecutedServicesOnStationWithFilter", ReplyAction="http://tempuri.org/IService/GetAllexecutedServicesOnStationWithFilterResponse")]
        WCF_Client.ServiceReference1.ServicesPerformed[] GetAllexecutedServicesOnStationWithFilter(int idStation, string fromDate, string untilDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAllexecutedServicesOnStationWithFilter", ReplyAction="http://tempuri.org/IService/GetAllexecutedServicesOnStationWithFilterResponse")]
        System.Threading.Tasks.Task<WCF_Client.ServiceReference1.ServicesPerformed[]> GetAllexecutedServicesOnStationWithFilterAsync(int idStation, string fromDate, string untilDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetStatistic", ReplyAction="http://tempuri.org/IService/GetStatisticResponse")]
        WCF_Client.ServiceReference1.Statistic GetStatistic();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetStatistic", ReplyAction="http://tempuri.org/IService/GetStatisticResponse")]
        System.Threading.Tasks.Task<WCF_Client.ServiceReference1.Statistic> GetStatisticAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : WCF_Client.ServiceReference1.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<WCF_Client.ServiceReference1.IService>, WCF_Client.ServiceReference1.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int InsertServiceStation(string name, string address, string description) {
            return base.Channel.InsertServiceStation(name, address, description);
        }
        
        public System.Threading.Tasks.Task<int> InsertServiceStationAsync(string name, string address, string description) {
            return base.Channel.InsertServiceStationAsync(name, address, description);
        }
        
        public int InsertCarBrand(string name, string year) {
            return base.Channel.InsertCarBrand(name, year);
        }
        
        public System.Threading.Tasks.Task<int> InsertCarBrandAsync(string name, string year) {
            return base.Channel.InsertCarBrandAsync(name, year);
        }
        
        public int InsertService(string name, string description) {
            return base.Channel.InsertService(name, description);
        }
        
        public System.Threading.Tasks.Task<int> InsertServiceAsync(string name, string description) {
            return base.Channel.InsertServiceAsync(name, description);
        }
        
        public int AddServiceForStation(int idStation, int idService, int price) {
            return base.Channel.AddServiceForStation(idStation, idService, price);
        }
        
        public System.Threading.Tasks.Task<int> AddServiceForStationAsync(int idStation, int idService, int price) {
            return base.Channel.AddServiceForStationAsync(idStation, idService, price);
        }
        
        public int AddExecutedService(int idStation, int idCar, int idService, string date) {
            return base.Channel.AddExecutedService(idStation, idCar, idService, date);
        }
        
        public System.Threading.Tasks.Task<int> AddExecutedServiceAsync(int idStation, int idCar, int idService, string date) {
            return base.Channel.AddExecutedServiceAsync(idStation, idCar, idService, date);
        }
        
        public WCF_Client.ServiceReference1.ServiceStation[] GetAllServiceStations() {
            return base.Channel.GetAllServiceStations();
        }
        
        public System.Threading.Tasks.Task<WCF_Client.ServiceReference1.ServiceStation[]> GetAllServiceStationsAsync() {
            return base.Channel.GetAllServiceStationsAsync();
        }
        
        public WCF_Client.ServiceReference1.ServicesOnStation[] GetAllServicesOnStation(int idStation) {
            return base.Channel.GetAllServicesOnStation(idStation);
        }
        
        public System.Threading.Tasks.Task<WCF_Client.ServiceReference1.ServicesOnStation[]> GetAllServicesOnStationAsync(int idStation) {
            return base.Channel.GetAllServicesOnStationAsync(idStation);
        }
        
        public WCF_Client.ServiceReference1.CarBrand[] GetAllCars() {
            return base.Channel.GetAllCars();
        }
        
        public System.Threading.Tasks.Task<WCF_Client.ServiceReference1.CarBrand[]> GetAllCarsAsync() {
            return base.Channel.GetAllCarsAsync();
        }
        
        public WCF_Client.ServiceReference1.Services[] GetAllServices() {
            return base.Channel.GetAllServices();
        }
        
        public System.Threading.Tasks.Task<WCF_Client.ServiceReference1.Services[]> GetAllServicesAsync() {
            return base.Channel.GetAllServicesAsync();
        }
        
        public WCF_Client.ServiceReference1.ServicesPerformed[] GetAllPerformedServices() {
            return base.Channel.GetAllPerformedServices();
        }
        
        public System.Threading.Tasks.Task<WCF_Client.ServiceReference1.ServicesPerformed[]> GetAllPerformedServicesAsync() {
            return base.Channel.GetAllPerformedServicesAsync();
        }
        
        public WCF_Client.ServiceReference1.ServicesPerformed[] GetAllexecutedServicesOnStation(int idStation) {
            return base.Channel.GetAllexecutedServicesOnStation(idStation);
        }
        
        public System.Threading.Tasks.Task<WCF_Client.ServiceReference1.ServicesPerformed[]> GetAllexecutedServicesOnStationAsync(int idStation) {
            return base.Channel.GetAllexecutedServicesOnStationAsync(idStation);
        }
        
        public WCF_Client.ServiceReference1.ServicesPerformed[] GetAllexecutedServicesOnStationWithFilter(int idStation, string fromDate, string untilDate) {
            return base.Channel.GetAllexecutedServicesOnStationWithFilter(idStation, fromDate, untilDate);
        }
        
        public System.Threading.Tasks.Task<WCF_Client.ServiceReference1.ServicesPerformed[]> GetAllexecutedServicesOnStationWithFilterAsync(int idStation, string fromDate, string untilDate) {
            return base.Channel.GetAllexecutedServicesOnStationWithFilterAsync(idStation, fromDate, untilDate);
        }
        
        public WCF_Client.ServiceReference1.Statistic GetStatistic() {
            return base.Channel.GetStatistic();
        }
        
        public System.Threading.Tasks.Task<WCF_Client.ServiceReference1.Statistic> GetStatisticAsync() {
            return base.Channel.GetStatisticAsync();
        }
    }
}
