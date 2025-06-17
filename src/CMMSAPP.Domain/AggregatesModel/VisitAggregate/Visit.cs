namespace CMMSAPP.Domain.AggregatesModel.VisitAggregate;

public class Visit : Entity, IAggregateRoot
{
    public string Title { get; private set; }
    public string Code { get; private set; }
    protected Visit() { }

    public Visit(string title, string code, string? createdBy = null)
    {
        if (!title.HasValue())
            throw new AssetDomainException("عنوان نمی‌تواند خالی باشد.");

        Id = Guid.NewGuid();

        Title = title;
        Code = code;
        SetCreationInfo(createdBy);
    }

    public void Update(string title, string code, string? modifiedBy = null)
    {
        if (string.IsNullOrWhiteSpace(title))
            throw new AssetDomainException("عنوان نمی‌تواند خالی باشد.");

        Title = title;
        Code = code;
        SetModificationInfo(modifiedBy);
    }
        public void UpdateStatus(string? modifiedBy = null) => SetStatus(modifiedBy);
    public void Remove(string? modifiedBy = null) => Delete(modifiedBy);
}
