using System;

public class Operacije
{
    float a;
    float b;

	public Operacije(float first, float second)
	{
        this.a = first;
        this.b = second;
	}

    public float sabiranje() {
        float c;
        c = this.a + this.b;
        return c;
    }
    public float B { get => b; set => b = value; }
    public float A { get => a; set => a = value; }
}


