using System.Runtime.Serialization;

public class ServicesOnStation
{
    [DataMember]
    public int Id { get; set; }

    [DataMember]
    public string Name { get; set; }

    [DataMember]
    public int Price { get; set; }
}