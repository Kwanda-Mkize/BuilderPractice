public class Request
{
  private string? AssetName { get; set; }
  private string? SerialNumber { get; set; }
  private string? Category { get; set; }
  private string? EmployeeName { get; set; }
  private string? Description { get; set; }
  private DateTime RequestDate { get; set; }

  public Request(string assetName, string serialNumber, string category, string employee, string description, DateTime requestDate)
  {
    AssetName = assetName;
    SerialNumber = serialNumber;
    Category = category;
    EmployeeName = employee;
    Description = description;
    RequestDate = requestDate;
  }

  public void PrintRequestReceipt()
  {
    Console.WriteLine($"{EmployeeName} put in a request to get {AssetName} {Category} serial number {SerialNumber} which has {Description} to be fixed at {RequestDate}");
  }
} 