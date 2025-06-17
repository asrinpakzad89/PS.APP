using CMMSAPP.Domain.AggregatesModel.ToolTypeAggregate;

namespace CMMSAPP.Domain.AggregatesModel.ToolsAggregate;

public class Tool : Entity, IAggregateRoot
{
    public string Title { get; private set; }
    public string Code { get; private set; }
    public Guid ToolTypeId { get; private set; }
    public ToolType ToolType { get; private set; }
    public UnitOfMeasureEnum Unit { get; private set; }
    public string? Specification { get; private set; }
    protected Tool() { }

    public Tool(string title, string code, Guid toolTypeId, UnitOfMeasureEnum unit, string? specification, string? createdBy = null)
    {
        if (!title.HasValue())
            throw new AssetDomainException("عنوان نمی‌تواند خالی باشد.");

        if (!code.HasValue())
            throw new AssetDomainException("کد نمی‌تواند خالی باشد.");

        Id = Guid.NewGuid();

        Title = title;
        Code = code;
        ToolTypeId = toolTypeId;
        Unit = unit;
        Specification = specification ?? string.Empty;
        SetCreationInfo(createdBy);
    }

    public void Update(string title, string code, Guid toolTypeId, UnitOfMeasureEnum unit, string? specification, string? modifiedBy = null)
    {
        if (!title.HasValue())
            throw new AssetDomainException("عنوان نمی‌تواند خالی باشد.");

        if (!code.HasValue())
            throw new AssetDomainException("کد نمی‌تواند خالی باشد.");

        Title = title;
        Code = code;
        ToolTypeId = toolTypeId;
        Unit = unit;
        Specification = specification ?? string.Empty;
        SetModificationInfo(modifiedBy);
    }
        public void UpdateStatus(string? modifiedBy = null) => SetStatus(modifiedBy);
    public void Remove(string? modifiedBy = null) => Delete(modifiedBy);
}
