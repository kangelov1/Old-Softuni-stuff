using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public interface Subject
{
    void register(Observer o);
    void unregister(Observer o);
    void notifyObserver();
}

