using System;
namespace TeamPage.Models
{
    public class Member
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Bio { get; set; }
        public string Picture { get; set; }

        public Member(string name, string title, string bio, string picture)
        {
            Name = name;
            Title = title;
            Bio = bio;
            Picture = picture;
        }
    }
}
