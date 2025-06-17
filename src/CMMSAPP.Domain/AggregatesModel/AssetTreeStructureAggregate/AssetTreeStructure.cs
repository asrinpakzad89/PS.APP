﻿namespace CMMSAPP.Domain.AggregatesModel.AssetTreeStructureAggregate;

public class AssetTreeStructure : Entity, IAggregateRoot
{
    public Guid InstalledAssetCodingId { get; private set; }
    public InstalledAssetCoding InstalledAssetCoding { get; private set; }

    public Guid LevelId { get; private set; }
    public Level Level { get; private set; }

    public string? Description { get; private set; }


    protected AssetTreeStructure() { }

    public AssetTreeStructure(Guid installedAssetCodingId, Level level, string? description = null, string? createdBy = null)
    {
        if (installedAssetCodingId == null) throw new AssetDomainException("کد تجهیز نصب‌شده نمی‌تواند خالی باشد.");
        if (level == null) throw new AssetDomainException("سطح تجهیز نمی‌تواند خالی باشد.");

        Id = Guid.NewGuid();
        InstalledAssetCodingId = installedAssetCodingId;

        LevelId = level.Id;
        Level = level;

        Description = description;
        SetCreationInfo(createdBy);
    }

    public void Update(Guid installedAssetCodingId, Level level, string? description = null, string? modifiedBy = null)
    {
        if (InstalledAssetCodingId == null) throw new AssetDomainException("کد تجهیز نصب‌شده نمی‌تواند خالی باشد.");
        if (level == null) throw new AssetDomainException("سطح تجهیز نمی‌تواند خالی باشد.");

        InstalledAssetCodingId = installedAssetCodingId;

        LevelId = level.Id;
        Level = level;

        Description = description;

        SetModificationInfo(modifiedBy);
    }
        public void UpdateStatus(string? modifiedBy = null) => SetStatus(modifiedBy);
    public void Remove(string? modifiedBy = null) => Delete(modifiedBy);
}

