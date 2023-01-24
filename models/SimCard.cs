namespace Exercise1 {
    namespace Models {
    public class SimCard {
        public string phoneNumber {set; get;}
        private string network;

        public SimCard (string phoneNumber, string network){
            this.phoneNumber = phoneNumber;
            this.network = network;
        }
    }
}
}