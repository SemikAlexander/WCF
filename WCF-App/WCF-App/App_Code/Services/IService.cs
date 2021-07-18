using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Реструктуризация" можно использовать для одновременного изменения имени интерфейса "IService" в коде и файле конфигурации.
[ServiceContract]
public interface IService
{
    #region INSERT

    [OperationContract]
    int InsertServiceStation(string name, string address, string description);

    [OperationContract]
    int InsertCarBrand(string name, string year);

    [OperationContract]
    int InsertService(string name, string description);

    #endregion

    #region ADD

    [OperationContract]
    int AddServiceForStation(int idStation, int idService, int price);

    [OperationContract]
    int AddExecutedService(int idStation, int idCar, int idService, string date);

    #endregion

    #region SELECT

    [OperationContract]
    List<ServiceStation> GetAllServiceStations();

    [OperationContract]
    List<ServicesOnStation> GetAllServicesOnStation(int idStation);

    [OperationContract]
    List<CarBrand> GetAllCars();

    [OperationContract]
    List<Services> GetAllServices();

    [OperationContract]
    List<ServicesPerformed> GetAllPerformedServices();

    [OperationContract]
    List<ServicesPerformed> GetAllexecutedServicesOnStation(int idStation);

    [OperationContract]
    List<ServicesPerformed> GetAllexecutedServicesOnStationWithFilter(int idStation, string fromDate, string untilDate);

    [OperationContract]
    Statistic GetStatistic();

    #endregion
}