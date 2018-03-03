using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.CSharp.RuntimeBinder;


class Tomcat : Cat
{
    public Tomcat(string name, int age) : base(name, age, "Male")
    {
        
    }

    public override string ProduceSound()
    {
        return "MEOW";
    }
}
