internal class Program
{
    private static void Main(string[] args)
    {
        Plane plane = new Plane();
        plane.Price = 1000;
        plane.Speed = 500;
        plane.Year = 1999;
        plane.Height = 1000;
        plane.QuantityOfPassangers = 80;
        Console.WriteLine($"Plane: Price = {plane.Price}, Speed = {plane.Speed}, Year = {plane.Year}, Height = {plane.Height}, Quantity of passangers = {plane.QuantityOfPassangers}.");

        Ship ship = new Ship();
        ship.Price = 2000;
        ship.Speed = 200;
        ship.Year = 2000;
        ship.QuantityOfPassangers = 100;
        ship.Port = "New Port";
        Console.WriteLine($"Ship: Price = {ship.Price}, Speed = {ship.Speed}, Year = {ship.Year}, Quantity of passangers = {ship.QuantityOfPassangers}, Home port = {ship.Port}.");

        Car car = new Car();
        car.Price = 500;
        car.Speed = 190;
        car.Year = 2010;
        car.Mileage = 250;
        Console.WriteLine($"Car: Price = {car.Price}, Speed = {car.Speed}, Year = {car.Year}, Mileage = {car.Mileage}.");

    }
}
class Vehicle
{
    public int Price { get; set; }
    public int Speed {  get; set; }
    public int Year { get; set; }

}
class Plane : Vehicle
{
    public int Height { get; set; }
    public int QuantityOfPassangers { get; set; }
}
class Ship : Vehicle
{
    public int QuantityOfPassangers { get; set; }
    public string Port {  get; set; }
}
class Car : Vehicle
{
    public int Mileage { get; set; }
}