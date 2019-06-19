using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class StockGrabber:Subject
{
    private List<Observer> observers;
    private double ibmPrice;
    private double aaplPrice;
    private double googlePrice;

    public StockGrabber()
    {
        this.observers = new List<Observer>();
    }
    public void register(Observer newObserver)
    {
        observers.Add(newObserver);
    }

    public void unregister(Observer deleteObserver)
    {
        int observerIndex = observers.IndexOf(deleteObserver);
        observers.RemoveAt(observerIndex);
    }

    public void notifyObserver()
    {
        foreach(Observer obs in observers){
            obs.update(ibmPrice, aaplPrice, googlePrice);
        }
    }

    public void setIBMPrice(double ibmPrice)
    {
        this.ibmPrice = ibmPrice;
        notifyObserver();
    }
    public void setaaplPrice(double aaplPrice)
    {
        this.aaplPrice = aaplPrice;
        notifyObserver();
    }
    public void setgooglePrice(double googlePrice)
    {
        this.googlePrice = googlePrice;
        notifyObserver();
    }
}
