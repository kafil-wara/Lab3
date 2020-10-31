public class Triangle {

	private int x;
	private int y;
	private int z;

	public setX(a) {
		x = a;
	}

	public setY(b) {
		y = b;
	}

	public setZ(c) {
		z = c;
	}

	public getX() {
		return x;
	}

	public getY() {
		return y;
	}

	public getZ() {
		return z;
	}



	public void ShowInfo() {
		Console.WriteLine("X = " + getX());
		Console.WriteLine("Y = " + getY());
		Console.WriteLine("Z = " + getZ());
		}

	public TestTriangle() {
	}
}