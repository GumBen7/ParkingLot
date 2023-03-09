namespace ParkingLot {
    class Car {
        private string _number;
        private string _color;
        public string Number {
            init => this._number = value; 
            get => this._number;
        }
        public string Make {init; get;}
        public string Model {init; get;}
        public string Color {
            init => this._color = value; 
            get => this._color;
        }
    }
}