
Asset asset = new Asset.Builder()
.SetName("Lenovo")
.SetSerialNumber("12345ZZ")
.SetDateCreated()
.Build();
asset.Print();

Employee employee = new Employee.Builder()
.SetName("Kwanda")
.SetSurname("Mkhize")
.SetEmail("kwanda@gmail.com")
.SetEmployeeNumber(123)
.Build();
employee.DisplayEmployeeInformation();