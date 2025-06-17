namespace CMMSAPP.Domain.AggregatesModel.ManufacturerAggregate;

public class Manufacturer : Entity, IAggregateRoot
{
    public string CompanyName { get; private set; }
    public string? Brand { get; private set; }
    public string? Phone { get; private set; }
    public string? Address { get; private set; }
    public string? Email { get; private set; }
    public string? Country { get; private set; }

    private Manufacturer() { }

    public Manufacturer(string companyName, string brand, string? phone,
                        string? address, string? email, string? country, string? createdBy = null)
    {
        if (!companyName.HasValue())
            throw new AssetDomainException("نام شرکت نمی تواند خالی باشد.");

        Id = Guid.NewGuid();
        CompanyName = companyName;
        Brand = brand;
        Phone = phone;
        Address = address;
        Email = email;
        Country = country;

        SetCreationInfo(createdBy);
    }

    public void Update(string companyName, string brand, string? phone,
                       string? address, string? email, string? country, string? modifiedBy = null)
    {
        if (!companyName.HasValue())
            throw new AssetDomainException("نام شرکت نمی تواند خالی باشد.");

        CompanyName = companyName;
        Brand = brand;
        Phone = phone;
        Address = address;
        Email = email;
        Country = country;

        SetModificationInfo(modifiedBy);
    }

        public void UpdateStatus(string? modifiedBy = null) => SetStatus(modifiedBy);
    public void Remove(string? modifiedBy = null) => Delete(modifiedBy);
}

