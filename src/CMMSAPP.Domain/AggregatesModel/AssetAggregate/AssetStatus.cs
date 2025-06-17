﻿namespace CMMSAPP.Domain.AggregatesModel.AssetAggregate;

public class AssetStatus : Entity
{
    public Guid AssetId { get; private set; }
    public Asset Asset { get; private set; }

    public AssetStatusTypeEnum Status { get; private set; }
    public string? Description { get; private set; }

    public DateTime? Date { get; set; }

    public AssetStatus() { }
    public AssetStatus(Guid assetId, AssetStatusTypeEnum status, DateTime? date, string? description = null, string? createdBy = null)
    {
        if (assetId == null)
            throw new AssetDomainException("کد تجهیز نمی‌تواند خالی باشد.");

        if (status == null)
            throw new AssetDomainException("نوع وضعیت نمی‌تواند خالی باشد.");

        Id = Guid.NewGuid();
        AssetId = assetId;
        Status = status;
        Date = date ?? DateTime.Now;
        Description = description;

        SetCreationInfo(createdBy);
    }
    public void Update(Guid assetId, AssetStatusTypeEnum status, DateTime? date, string? description = null, string? modifiedBy = null)
    {
        if (assetId == null)
            throw new AssetDomainException("کد تجهیز نمی‌تواند خالی باشد.");

        if (status == null)
            throw new AssetDomainException("نوع وضعیت نمی‌تواند خالی باشد.");

        AssetId = assetId;
        Status = status;
        Date = date ?? DateTime.Now;
        Description = description;
        SetModificationInfo(modifiedBy);
    }
        public void UpdateStatus(string? modifiedBy = null) => SetStatus(modifiedBy);
    public void Remove(string? modifiedBy = null) => Delete(modifiedBy);
}
