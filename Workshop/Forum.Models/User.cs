using System;
using System.Collections.Generic;
using System.Text;


public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Password { get; set; }
    public ICollection<int> PostIds { get; set; }

    public User(int id, string name, string password, IEnumerable<int> postIds)
    {
        this.Id = id;
        this.Name = name;
        this.Password = password;
        this.PostIds = new List<int>(postIds);
    }

    public User(int id, string name, string password)
    {
        this.Id = id;
        this.Name = name;
        this.Password = password;
        this.PostIds = new List<int>();
    }
}

