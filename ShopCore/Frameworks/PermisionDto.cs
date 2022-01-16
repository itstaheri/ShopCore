namespace Frameworks
{
    public class PermisionDto
    {
        public PermisionDto(int code, string name)
        {
            Code = code;
            Name = name;
        }

        public int Code { get; set; }
        public string Name { get; set; }
    }
}
