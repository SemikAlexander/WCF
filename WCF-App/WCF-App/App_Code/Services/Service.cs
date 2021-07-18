using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using Npgsql;

public class Service : IService
{
	private NpgsqlConnection dbConnection;
	string connectionString = "Server = 127.0.0.1; User Id = postgres; Database = STO; Port = 5432; Password = 15021999";

    public string insertSQL(string sql)
    {
        dbConnection = new NpgsqlConnection(connectionString);
        dbConnection.Open();

        string result = "";

        using (var cmd = new NpgsqlCommand(sql, dbConnection))
        {
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    result = reader.GetString(0);
                    dbConnection.Close();
                }
            }
        }

        dbConnection.Close();
        return result;
    }

    public int InsertServiceStation(string name, string address, string description)
    {
        return insertSQL(Functions.AddCarService(name, address, description)) == "Success" ? 1 : 0;
    }

    public int InsertService(string name, string description)
    {
        return insertSQL(Functions.AddService(name, description)) == "Success" ? 1 : 0;
    }

    public int InsertCarBrand(string name, string year)
    {
        return insertSQL(Functions.AddCarBrand(name, year)) == "Success" ? 1 : 0;
    }

    public int AddServiceForStation(int idStation, int idService, int price)
    {
        return insertSQL(Functions.AddServiceForStation(idStation, idService, price)) == "Success" ? 1 : 0;
    }

    public int AddExecutedService(int idStation, int idCar, int idService, string date)
    {
        return insertSQL(Functions.AddExecutedService(idStation, idCar, idService, date)) == "Success" ? 1 : 0;
    }

    public List<ServiceStation> GetAllServiceStations()
    {
        dbConnection = new NpgsqlConnection(connectionString);
        dbConnection.Open();

        var serviceStations = new List<ServiceStation>();

        using (var cmd = new NpgsqlCommand(Functions.GetAllServiceStations(), dbConnection))
        {
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    serviceStations.Add(new ServiceStation()
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Address = reader.GetString(2),
                        Description = reader.GetString(3)
                    });
                }

                dbConnection.Close();
                return serviceStations;
            }
        }
    }

    public List<ServicesOnStation> GetAllServicesOnStation(int idStation)
    {
        dbConnection = new NpgsqlConnection(connectionString);
        dbConnection.Open();

        var servicesOnStations = new List<ServicesOnStation>();

        using (var cmd = new NpgsqlCommand(Functions.GetAllServicesOnStation(idStation), dbConnection))
        {
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    servicesOnStations.Add(new ServicesOnStation()
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Price = reader.GetInt32(2)
                    });
                }

                dbConnection.Close();
                return servicesOnStations;
            }
        }
    }

    public List<CarBrand> GetAllCars()
    {
        dbConnection = new NpgsqlConnection(connectionString);
        dbConnection.Open();

        var carBrands = new List<CarBrand>();

        using (var cmd = new NpgsqlCommand(Functions.GetAllCars(), dbConnection))
        {
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    carBrands.Add(new CarBrand()
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Year = reader.GetInt32(2)
                    });
                }

                dbConnection.Close();
                return carBrands;
            }
        }
    }

    public List<Services> GetAllServices()
    {
        dbConnection = new NpgsqlConnection(connectionString);
        dbConnection.Open();

        var services = new List<Services>();

        using (var cmd = new NpgsqlCommand(Functions.GetAllServices(), dbConnection))
        {
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    services.Add(new Services()
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Description = reader.GetString(2)
                    });
                }

                dbConnection.Close();
                return services;
            }
        }
    }

    public List<ServicesPerformed> GetAllPerformedServices()
    {
        dbConnection = new NpgsqlConnection(connectionString);
        dbConnection.Open();

        var services = new List<ServicesPerformed>();

        using (var cmd = new NpgsqlCommand(Functions.GetAllServices(), dbConnection))
        {
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    services.Add(new ServicesPerformed()
                    {
                        nameCar = reader.GetString(0),
                        nameService = reader.GetString(1),
                        date = reader.GetString(2),
                        price = reader.GetInt32(3)
                    });
                }

                dbConnection.Close();
                return services;
            }
        }
    }

    public List<ServicesPerformed> GetAllexecutedServicesOnStation(int idStation)
    {
        dbConnection = new NpgsqlConnection(connectionString);
        dbConnection.Open();

        var services = new List<ServicesPerformed>();

        using (var cmd = new NpgsqlCommand(Functions.GetAllexecutedServicesOnStation(idStation), dbConnection))
        {
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    services.Add(new ServicesPerformed()
                    {
                        nameCar = reader.GetString(0),
                        year = reader.GetInt32(1),
                        nameService = reader.GetString(2),
                        date = reader.GetString(3),
                        price = reader.GetInt32(4)
                    });
                }

                dbConnection.Close();
                return services;
            }
        }
    }

    public List<ServicesPerformed> GetAllexecutedServicesOnStationWithFilter(int idStation, string fromDate, string untilDate)
    {
        dbConnection = new NpgsqlConnection(connectionString);
        dbConnection.Open();

        var services = new List<ServicesPerformed>();

        using (var cmd = new NpgsqlCommand(Functions.GetAllexecutedServicesOnStationWithFilter(idStation, fromDate, untilDate), dbConnection))
        {
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    services.Add(new ServicesPerformed()
                    {
                        nameCar = reader.GetString(0),
                        year = reader.GetInt32(1),
                        nameService = reader.GetString(2),
                        date = reader.GetString(3),
                        price = reader.GetInt32(4)
                    });
                }

                dbConnection.Close();
                return services;
            }
        }
    }

    public Statistic GetStatistic()
    {
        dbConnection = new NpgsqlConnection(connectionString);
        dbConnection.Open();

        var statistic = new Statistic();

        using (var cmd = new NpgsqlCommand(Functions.GetStatistic(), dbConnection))
        {
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    statistic.countServices = reader.GetInt32(0);
                    statistic.totalAmount = reader.GetInt32(1);
                }

                dbConnection.Close();
                return statistic;
            }
        }
    }
}