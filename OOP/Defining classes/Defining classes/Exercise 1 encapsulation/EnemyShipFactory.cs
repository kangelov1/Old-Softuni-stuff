using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class EnemyShipFactory
{
    public EnemyShip makeEnemyShip(String newShipType)
    {
        EnemyShip newShip = null;

        if (newShipType == "U")
        {
            return new UFOShip();
        }
        else if (newShipType == "R") { return new RocketShip();}
        else if (newShipType == "B") { return new BigUFOEnemyShip(); }
        else{return newShip;}
    }
}

