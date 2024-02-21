class Program {
	static void Main() {
		Child child = new();
		//child.Kuliah();
		GrandParent gp = child;
		gp.Kuliah();
	}
}
class GrandParent {
	public virtual void Kuliah() {
		"ITB".Dump();
	}
}
class Parent : GrandParent {
	public override void Kuliah() {
		//base.Kuliah();
		"UGM".Dump();
	}
}
class Child : Parent {
	public override void Kuliah() {
		base.Kuliah();
		"Binus".Dump();
	}
}

public static class Extension
{
	public static void Dump(this object x) 
	{
		Console.WriteLine(x);
	}
}