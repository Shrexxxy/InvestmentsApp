namespace InvestmentsApp.Client.Models;

public class UpdateProgressModel
{
    public int Total { get; set; }
    public int Completed { get; set; }
    public double Percent { get; set; }
    public string Item { get; set; }
}