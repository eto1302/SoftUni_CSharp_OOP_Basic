﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<int> Posts { get; set; }

    public Category(int id, string name, IEnumerable<int> posts)
    {
        this.Id = id;
        this.Name = name;
        this.Posts = new List<int>(posts);
    }

}
