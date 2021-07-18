using System.Runtime.Serialization;

public class ServicesPerformed
{
    [DataMember]
    public string nameCar { get; set; }

    [DataMember]
    public string nameService { get; set; }

    [DataMember]
    public string date { get; set; }

    [DataMember]
    public int price { get; set; }

    [DataMember]
    public int year { get; set; }
}