// Yarışmacıyı temsil eden sınıf, her yarışmacının bilgilerini burada tutuyoruz.
using SurvivorProject.Model.Entity;

public class Competitors : BaseEntity
{
    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public int Age { get; set; }

    public string? City { get; set; }

    public int CategoryId { get; set; }

    public Category? Category { get; set; }

    public override string ToString()
    {
        return $"FirstName: {FirstName}, LastName: {LastName}, Age: {Age}, City: {City}, CategoryId: {CategoryId}";
    }
}
