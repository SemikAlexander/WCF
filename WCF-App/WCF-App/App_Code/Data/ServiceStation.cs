using System.Runtime.Serialization;

public class ServiceStation
{
    [DataMember]
    public int Id { get; set; }

    [DataMember]
    public string Name { get; set; }

    [DataMember]
    public string Address { get; set; }

    [DataMember]
    public string Description { get; set; }
}