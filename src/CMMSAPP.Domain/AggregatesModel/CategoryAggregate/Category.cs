﻿using CMMSAPP.Domain.AggregatesModel.AssetGroupAggregate;

namespace CMMSAPP.Domain.AggregatesModel.AssetCategoryAggregate;

public class Category : Entity, IAggregateRoot
{
    public string Title { get; private set; }
    public string Code { get; private set; }
    public Guid GroupId { get; private set; }
    public Group Group { get; private set; }

    #region Collection
    private readonly List<Asset> _assets = new();
    public IReadOnlyCollection<Asset> Assets => _assets.AsReadOnly();
    #endregion

    protected Category() { }

    public Category(string title, string code, Guid groupId, string? createdBy = null)
    {
        if (!title.HasValue())
            throw new AssetDomainException("عنوان دسته نمی‌تواند خالی باشد.");

        if (!code.HasValue())
            throw new AssetDomainException("کد دسته نمی‌تواند خالی باشد.");

        if (groupId == null)
            throw new AssetDomainException("گروه تجهیز نمی‌تواند خالی باشد.");

        Id = Guid.NewGuid();

        Title = title;
        Code = code;
        GroupId = groupId;
        SetCreationInfo(createdBy);
    }

    public void Update(string name, string code, Guid groupId, string? modifiedBy = null)
    {
        if (!name.HasValue())
            throw new AssetDomainException("عنوان دسته نمی‌تواند خالی باشد.");

        if (!code.HasValue())
            throw new AssetDomainException("کد دسته نمی‌تواند خالی باشد.");

        if (groupId == null)
            throw new AssetDomainException("گروه تجهیز نمی‌تواند خالی باشد.");


        Title = name;
        Code = code;
        GroupId = groupId;
        SetModificationInfo(modifiedBy);
    }

    public void UpdateStatus(string? modifiedBy = null) => SetStatus(modifiedBy);
    public void Remove(string? modifiedBy = null) => Delete(modifiedBy);
}

