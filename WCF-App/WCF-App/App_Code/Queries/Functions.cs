using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Сводное описание для Functions
/// </summary>
public class Functions
{
    #region ADD  

    public static string AddCarService(string name, string address, string description)
    {
        return "SELECT * FROM add_service_station('" + name + "', '" + address + "', '" + description + "')";
    }

    public static string AddCarBrand(string name, string year)
    {
        return "SELECT * FROM add_car_brand('" + name + "', '" + year + "')";
    }

    public static string AddServiceForStation(int idStation, int idService, int price)
    {
        return "SELECT * FROM add_service_for_station('" + idStation + "', '" + idService + "', '" + price + "')";
    }

    public static string AddService(string name, string description)
    {
        return "SELECT * FROM add_service('" + name + "', '" + description + "')";
    }

    public static string AddExecutedService(int idStation, int idCar, int idService, string date)
    {
        return "SELECT * FROM add_executed_service(" + idStation + ", " + idCar + ", to_date('" + date + "', 'YYYY-MM-DD'), " + idService + ")";
    }

    #endregion

    #region GET

    public static string GetAllServiceStations()
    {
        return "SELECT * FROM get_all_service_stations()";
    }

    public static string GetAllCars()
    {
        return "SELECT * FROM get_all_cars_brand()";
    }

    public static string GetAllServices()
    {
        return "SELECT * FROM get_all_services()";
    }

    public static string GetAllServicesOnStation(int idStation)
    {
        return "SELECT * FROM get_services_for_station(" + idStation + ")";
    }

    public static string GetAllexecutedServicesOnStation(int idStation)
    {
        return "SELECT * FROM get_executed_service(" + idStation + ")";
    }

    public static string GetAllexecutedServicesOnStationWithFilter(int idStation, string fromDate, string untilDate)
    {
        return "SELECT * FROM get_executed_service1(" + idStation + ", to_date('" + fromDate + "', 'YYYY-MM-DD'), to_date('" + untilDate + "', 'YYYY-MM-DD'))";
    }

    public static string GetStatistic()
    {
        return "SELECT sum(count_executed), sum(total_amount) FROM get_all_info()";
    }

    #endregion
}