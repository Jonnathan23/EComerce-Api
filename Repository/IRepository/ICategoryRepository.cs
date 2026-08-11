namespace EComerce;

public interface ICategoryRepository
{
    public ICollection<Category> GetCategories();
    public Category GetCategory(int id);
    public bool CategoryExists(int id);
    public bool CategoryExists(string name);

    public bool CreateCategory(Category category);
    public bool UpdateCategory(Category category);
    public bool DeleteCategory(Category category);
    public bool Save();
}
