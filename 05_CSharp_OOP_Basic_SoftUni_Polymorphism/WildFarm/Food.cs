using System;
using System.Collections.Generic;
using System.Text;

public abstract class Food
{
    protected int quantity { get; set; }

    public Food(int quantity)
    {
        this.quantity = quantity;

    }
}
