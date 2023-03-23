using System;

class RemoteControlCar
{
    private int speed;
    private int batteryDrain = 0;   
    private int distanceDriven;

    public RemoteControlCar(int inputSpeed, int inputBatteryDrain) {
       speed = inputSpeed;
       batteryDrain = inputBatteryDrain; 
    }
    public bool BatteryDrained()
    {
        throw new NotImplementedException("Please implement the RemoteControlCar.BatteryDrained() method");
    }
    public int DistanceDriven()
    {
        return distanceDriven;
    }
    public void Drive()
    {
        distanceDriven += speed;
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
