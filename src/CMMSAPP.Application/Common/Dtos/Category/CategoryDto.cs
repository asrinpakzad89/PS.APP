namespace CMMSAPP.Application.Common.Dtos.Category;

public class CategoryDto
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Code { get; set; }
    public Guid AssetGroupId { get; set; }
}
