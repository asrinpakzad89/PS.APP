﻿namespace CMMSAPP.Domain.AggregatesModel.AssertCodingAggregate;

public class AssetCoding : Entity, IAggregateRoot
{
    public Guid AssetId { get; private set; }
    public Asset Asset { get; private set; }

    public int FromNumber { get; private set; }
    public int ToNumber { get; private set; }

    public string Code { get; private set; }


    #region Collection
    private readonly List<InstalledAssetCoding> _installedAssetCodings = new();
    public IReadOnlyCollection<InstalledAssetCoding> InstalledAssetCodings => _installedAssetCodings.AsReadOnly();
    #endregion

    public AssetCoding() { }
    public AssetCoding(Guid assetId, string code, int fromNumber = 1, int toNumber = 1, string? createdBy = null)
    {
        if (assetId == null)
            throw new AssetDomainException("تجهیز نمی‌تواند خالی باشد.");

        Id = Guid.NewGuid();
        AssetId = assetId;
        FromNumber = fromNumber;
        ToNumber = toNumber;
        Code = code;
        SetCreationInfo(createdBy);
    }
    public void Update(Guid assetId, string code, int fromNumber = 1, int toNumber = 1, string? createdBy = null)
    {
        if (assetId == null)
            throw new AssetDomainException("تجهیز نمی‌تواند خالی باشد.");

        AssetId = assetId;
        FromNumber = fromNumber;
        ToNumber = toNumber;
        Code = code;
        SetCreationInfo(createdBy);
    }
        public void UpdateStatus(string? modifiedBy = null) => SetStatus(modifiedBy);
    public void Remove(string? modifiedBy = null) => Delete(modifiedBy);
}
