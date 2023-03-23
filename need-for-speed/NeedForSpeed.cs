using System;

class RemoteControlCar
{
    private int speed;
    private int batteryDrain = 0;  
    private int battery = 100; 
    private int distanceDriven;

    public RemoteControlCar(int inputSpeed, int inputBatteryDrain) {
       speed = inputSpeed;
       batteryDrain = inputBatteryDrain; 
    }
    public bool BatteryDrained()
    {
        bool isTrue = false;
        isTrue = battery == 0 ? true: false;
        return isTrue;
    }
    public int DistanceDriven()
    {
        return distanceDriven;
    }
    public void Drive()
    {
        distanceDriven += speed;
        battery -= batteryDrain;
    }
    public static RemoteControlCar Nitro()
    {
        var car = new RemoteControlCar(50, 4);
        return car;
    }
}

class RaceTrack
{
    private int distance;

    public RaceTrack(int inputDistance) {
        distance = inputDistance;
    }
    public bool TryFinishTrack(RemoteControlCar car)
    {
        throw new NotImplementedException("Please implement the RaceTrack.TryFinishTrack() method");
    }
}
