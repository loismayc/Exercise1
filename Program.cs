using Exercise1.Models;

namespace Exercise1{
    public class Exercise1 {
        static void Main(string[] args){

        SimCard sim1 = new SimCard("+639123456789", "Smart");
        SimCard sim2 = new SimCard("+639132165400", "Globe");

        // 2 instances of mobilephone
        MobilePhone mobilePhone1 = new MobilePhone("Samsung", "White", sim1, "Galaxy Note");
        MobilePhone mobilePhone2 = new MobilePhone("Apple", "Midnight", sim2, "iPhone 14");
        //2 instance of smartphone
        SmartPhone smartPhone1 = new SmartPhone("Oppo", "Black", sim1, "F5", "Chrome");
        SmartPhone smartPhone2 = new SmartPhone("Blackberry", "Red", sim2, "B1", "Edge");

        //mobilephone talking to another mobilephone
        mobilePhone1.Call(mobilePhone2);
        mobilePhone2.Call(mobilePhone1);

        //smartphone talking to another smartphone
        smartPhone1.CallFromBrowser(smartPhone2);
        smartPhone2.CallFromBrowser(smartPhone1);


        App app = new App("Instagram", 20.23f);
        App app1 = new App("Facebook", 5.13f);

        smartPhone1.AddApplication(app);
        smartPhone1.AddApplication(app1);

        Console.WriteLine("Total Size of apps (in MB): " + smartPhone1.GetTotalSize());


        }
    }
}