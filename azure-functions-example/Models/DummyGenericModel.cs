namespace azure_functions_example.Models
{
    public class DummyGenericModel<T>
    {
        public string Name { get; set; }
        public T Value { get; set; }
    }
}
