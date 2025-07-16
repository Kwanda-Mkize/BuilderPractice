
public class RequestBuilder
{

  private string? _assetName, _employeeName, _serialNumber, _category, _description;
  DateTime _requestDate;

  // private RequestBuilder() { }
  public static RequestBuilder Instance()
  {
    return new RequestBuilder();
  }

  public RequestBuilder AssetName(string assetName)
  {
    _assetName = assetName;
    return this;

  }
  public RequestBuilder Employee(string employee)
  {
    _employeeName = employee;
    return this;

  }

  public RequestBuilder SerialNumber(string serialNumber)
  {
    _serialNumber = serialNumber;
    return this;

  }

  public RequestBuilder Category(string category)
  {
    _category = category;
    return this;
  }

  public RequestBuilder Description(string description)
  {
    _description = description;
    return this;
  }

  public RequestBuilder RequestDate()
  {
    _requestDate = DateTime.Now;
    return this;
  }

  public Request Build()
  {
    return new Request(_assetName ?? string.Empty, _serialNumber ?? string.Empty, _category ?? string.Empty, _employeeName ?? string.Empty, _description ?? string.Empty, _requestDate);
  }
}