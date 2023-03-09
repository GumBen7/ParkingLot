namespace ParkingLot {
    class Parking {
        private Dictionary<string, ParkingRecord> _cars = new Dictionary<string, ParkingRecord>();
        public void Accommodate(Car car) {
            this._cars.Add(car.Number, new ParkingRecord(car, DateTime.Now));
        }
        public void TurnOut(Car car) {
            this.TurnOutTheCarWithNumber(car.Number);
        }
        public void TurnOutTheCarWithNumber(string number) {
            var parkedDateTime = this._cars[number].ParkedDateTime;
            var turnedOutDateTime = DateTime.Now;
            Console.WriteLine($"Машина с номером {number} вывезена");
            Console.WriteLine($"Время прибытия: {parkedDateTime}");
            Console.WriteLine($"Время убытия: {turnedOutDateTime}");
            Console.WriteLine($"Простояла {(turnedOutDateTime - parkedDateTime).Hours} часов и {(turnedOutDateTime - parkedDateTime).Minutes % 60} минуту");
            this._cars.Remove(number);
        }
        public int CarsCount() => this._cars.Count;

        public List<Car> CarList() {
            List<Car> list = new List<Car>();
            foreach (var rec in this._cars.Values) {
                list.Add(rec.ParkedCar);
            }
            return list;
        }

        public Car GetCarByNumber(string number) => this._cars[number].ParkedCar;
    }

    struct ParkingRecord {
        public ParkingRecord(Car car, DateTime dateTime) {
            this.ParkedCar = car;
            this.ParkedDateTime = dateTime;
        }
        public Car ParkedCar {init; get;}
        public DateTime ParkedDateTime {init; get;}
    }
}