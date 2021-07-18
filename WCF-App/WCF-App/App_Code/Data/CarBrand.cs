using System.Runtime.Serialization;

public class CarBrand
{
    [DataMember]
    public int Id { get; set; }

    [DataMember]
    public string Name { get; set; }

    [DataMember]
    public int Year { get; set; }
}