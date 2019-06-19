using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public interface Flys
{
    string fly();
}

public class ItFlys : Flys
{
    public string fly()
    {
        return "Flying high";
    }
}

public class CantFly : Flys
{
    public string fly()
    {
        return "Can't fly";
    }
}

