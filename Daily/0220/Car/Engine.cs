namespace Vehicle;

public class Engine
{
    public int engineCylinder;
	public int engineHp;
	public int engineVolume;
	public string engineType;
	public Engine(
		int engineCylinder,
		int engineHp,
		int engineVolume,
		string engineType
		) 
	{
		this.engineCylinder = engineCylinder;
		this.engineHp = engineHp;
		this.engineVolume = engineVolume;
		this.engineType = engineType;
	}
}
