namespace CMMSAPP.Domain.AggregatesModel.ToolTypeAggregate;

public class ToolType : Entity, IAggregateRoot
{
    public string Title { get; private set; }
    public ToolGroupEnum Group { get; private set; }

    #region Collections
    private readonly List<Tool> _tools = new();
    public IReadOnlyCollection<Tool> Tools => _tools.AsReadOnly();
    #endregion

    protected ToolType() { }

    public ToolType(string title, ToolGroupEnum group, string? createdBy = null)
    {
        if (!title.HasValue())
            throw new AssetDomainException("عنوان نمی‌تواند خالی باشد.");

        if (group == null)
            throw new AssetDomainException("گروه ابزار را انتخاب نمایید.");

        Id = Guid.NewGuid();

        Title = title;
        Group = group;
        SetCreationInfo(createdBy);
    }

    public void Update(string title, ToolGroupEnum group, string? modifiedBy = null)
    {
        if (!title.HasValue())
            throw new AssetDomainException("عنوان نمی‌تواند خالی باشد.");

        if (group == null)
            throw new AssetDomainException("گروه ابزار را انتخاب نمایید.");

        Title = title;
        Group = group;
        SetModificationInfo(modifiedBy);
    }
    public void UpdateStatus(string? modifiedBy = null) => SetStatus(modifiedBy);
    public void Remove(string? modifiedBy = null) => Delete(modifiedBy);
}
