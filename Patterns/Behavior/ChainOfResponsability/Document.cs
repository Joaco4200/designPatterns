public class Document
{
    public string Title { get; set; }
    public int ImportanceLevel { get; set; } // 1: bajo, 2: medio, 3: alto

    public Document(string title, int importanceLevel)
    {
        Title = title;
        ImportanceLevel = importanceLevel;
    }
}