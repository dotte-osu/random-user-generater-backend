using System;

namespace UserApi.Models
{
    public class User
    {
        public string Name { get; set; }
        public Guid Id { get; set; }
        public string Url { get; set; }
    }
}
