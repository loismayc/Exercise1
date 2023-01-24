namespace Exercise1 {
    namespace Models {
    public class SmartPhone : MobilePhone {
        private string browser;
        public List<App> applications {get; set;}

        public SmartPhone (string brand, string color, SimCard simCard, string model, string browser)
        :base (brand, color, simCard, model)
        {
            this.browser = browser;
            this.applications = new List<App>();
        }
        public void CallFromBrowser(string phoneNumber){
            Console.WriteLine("Calling from " + browser);
            base.Call(phoneNumber);
        }

        public void CallFromBrowser(MobilePhone mobilePhone){
            Console.WriteLine("Calling from " + browser);
            base.Call(mobilePhone);
        }

        public void AddApplication(App app){
            applications.Add(app);
        }

        public float GetTotalSize()
    {
        float totalSize = 0;
        foreach (App app in applications)
        {
            totalSize += app.size;
        }
        return totalSize;
    }

    }
    }
}