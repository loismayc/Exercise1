namespace Exercise1 {
    namespace Models {
    public class MobilePhone {
        private string brand;
        private string color;
        public SimCard simCard;
        private string model;

        public MobilePhone (string brand, string color, SimCard simCard, string model){
            this.brand = brand;
            this.color = color;
            this.simCard = simCard;
            this.model = model;
        }

        public string GetPhoneNumber(){
            return simCard.phoneNumber;
        }

        public void SwapSimCard(SimCard simCard){
            this.simCard = simCard;
        }
        
        public void Call (string phoneNumber){
            Console.WriteLine("Calling " + phoneNumber + " from number " + GetPhoneNumber());
        }

        public void Call (MobilePhone mobilePhone){
            Console.WriteLine("Calling " + mobilePhone.simCard.phoneNumber + " from number " + GetPhoneNumber());
        }

        }
    }
}