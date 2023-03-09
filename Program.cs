namespace ParkingLot {
    class Program {
        static void Main(string[] args) {
            var pL = new Parking();
            pL.Accommodate(new Car() {Number = "123"});
            pL.Accommodate(new Car() {Number = "456"});
            pL.Accommodate(new Car() {Number = "789"});
            foreach (var c in pL.CarList()) {
                Console.WriteLine(c);
            }
        }
    }
}