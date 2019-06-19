using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StockObserver:Observer
{
    private double ibmPrice;
    private double aaplPrice;
    private double googlePrice;

    private static int observerIDTracker = 0;
    private int observerID;
    private Subject stockGrabber;

    public StockObserver(Subject stockGrabber)
    {
        this.stockGrabber = stockGrabber;
        this.observerID = ++observerIDTracker;
        Console.WriteLine("New observer" + observerID);
        stockGrabber.register(this);
    }
    public void update(double ibmPrice, double aaplPrice, double googlePrice)
    {
        this.ibmPrice = ibmPrice;
        this.aaplPrice = aaplPrice;
        this.googlePrice = googlePrice;

        printThePrices();
    }
    public void printThePrices()
    {
        Console.WriteLine(observerID + Environment.NewLine + "ibm:" + ibmPrice + Environment.NewLine + "aapl:" + aaplPrice + Environment.NewLine + "google:" + googlePrice);
    }
}
