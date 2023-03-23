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
        battery == 0 ? isTrue = true: isTrue = false;
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
        throw new NotImplementedException("Please implement the (static) RemoteControlCar.Nitro() method");
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
