namespace ParkingLot {
    class Program {
        static void Main(string[] args) {
            var pL = new Parking();
            pL.Accommodate(new Car() {Number = "123", Make = "Lada"});
            pL.Accommodate(new Car() {Number = "456", Make = "Toyota"});
            pL.Accommodate(new Car() {Number = "789", Make = "Ford"});
            foreach (var c in pL.CarList()) {
                Console.WriteLine(c.Make);
            }
        }
    }
}