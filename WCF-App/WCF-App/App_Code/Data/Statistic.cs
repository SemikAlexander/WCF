using System.Runtime.Serialization;

public class Statistic
{
    [DataMember]
    public int countServices { get; set; }

    [DataMember]
    public int totalAmount { get; set; }
}