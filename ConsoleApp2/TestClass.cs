namespace ConsoleApp2;

public class TestClass
{
    public string testVariable { get; set; } = "A";
    public string testVariable2 { get; set; } = "B";

    TestClass(string testVariable, string testVariable2)
    {
        this.testVariable = testVariable;
        this.testVariable2 = testVariable2;
    }
    
    TestClass(string testNumber)
    {
        
    }
}