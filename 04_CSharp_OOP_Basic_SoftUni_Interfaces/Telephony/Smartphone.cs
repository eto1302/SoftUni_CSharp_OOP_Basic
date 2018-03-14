using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


class Smartphone : IBrowse, ICallPhones
{

    public Smartphone()
    {
    }




    public string Call(string number)
    {
        if(number.All(k => char.IsDigit(k))) return ($"Calling... {number}");
        return "Invalid number!";
    }
    public string Browse(string url)
    {
        if (url.All(k => !char.IsDigit(k))) return ($"Browsing: {url}!");
        return "Invalid URL!";
    }


}
