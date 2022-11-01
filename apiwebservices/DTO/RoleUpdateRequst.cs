namespace apiwebservices.DTO
{
    public class RoleUpdateRequst
    {
        public int id { get; set; }
        public string name { get; set; }
        public string level { get; set; }
        public string role_key { get; set; }
        public string status { get; set; }
        public DateTime created_at { get; set; } = DateTime.Now;
        public DateTime updated_at { get; set; }
        public DateTime deleted_at { get; set; }
    }
}
