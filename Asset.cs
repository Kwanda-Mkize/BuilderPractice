public class Asset
{
  private string? Name { get; set; }
  private string? SerialNumber { get; set; }
  private string? Description { get; set; }
  private string? Category { get; set; }
  private string? Country { get; set; }
  private DateTime DateCreated { get; set; }

  public class Builder
  {
    private readonly Asset asset = new Asset();

    public Builder SetName(string name)
    {
      asset.Name = name;
      return this;
    }

    public Builder SetSerialNumber(string serialNumber)
    {
      asset.SerialNumber = serialNumber;
      return this;

    }

    public Builder SetDescription(string description)
    {
      asset.Description = description;
      return this;
    }

    public Builder SetCategory(string category)
    {
      asset.Category = category;
      return this;
    }

    public Builder SetCountry(string country)
    {
      asset.Country = country;
      return this;
    }

    public Builder SetDateCreated()
    {
      asset.DateCreated = DateTime.Now;
      return this;
    }

    public Asset Build()
    {
      return asset;
    }
  }


  public void Print()
  {
   Console.WriteLine( $"you just added {Name}, with serial number {SerialNumber} at {DateCreated}");
  }
}