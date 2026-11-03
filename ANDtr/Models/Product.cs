namespace ANDtr.Models;

public class Product
{
    public int Id { get; set; }   // primary key - EF Core finds "Id" by name and auto-numbers it
    public String Name { get; set; }
    public String CodeName { get; set; }
    public String RegNum { get; set; }
    public String RecallNum { get; set; }
    public String TradeName { get; set; }
    public String RecallClass { get; set; }
    public String CenterClass { get; set; }
    public String PostedInternetDate { get; set; }
    public String TerminationDate { get; set; }
    public String FeiNum { get; set; }
    public String FirmName { get; set; }
    public String RecallReason { get; set; }
}
