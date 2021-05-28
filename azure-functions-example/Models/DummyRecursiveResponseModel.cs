namespace azure_functions_example.Models
{
    public class DummyRecursiveResponseModel
    {
        public string Id { get; set; }

        public DummyRecursiveResponseModel RecursiveValue { get; set; }
    }
}
