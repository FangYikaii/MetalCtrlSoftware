/// <summary>
/// 配方接口（可选实现，用于扩展）
/// </summary>
public interface IRecipe
{
    string RecipeName { get; set; }
    void DisplayRecipe();
}