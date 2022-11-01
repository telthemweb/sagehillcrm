namespace apiwebservices.DTO.SystemModuleDtO
{
    public class CreateSystemModuleDto
    {
        public string name { get; set; }
        public string? icon { get; set; }
        public string? widget { get; set; }
        public string? description { get; set; }
        public string? status { get; set; }
    }
}
