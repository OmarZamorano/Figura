abstract class Figura
{
    public int x,y;
    public int l;
    public int a;
    public string c;
    public Figura(int x,int y,int l, int a, string c)
    {
        this.x=x; this.y=y; this.l=l; this.a=a; this.c=c;
    }
    public abstract void Dibuja()
    {
    }
    public abstract void Area()
    {
    }
}
class Rectangulo:Figura
{
    public Rectangulo(int x,int y,int l, int a, string c):base(x,y,l,a,c)
    {
    }
    public override void Dibuja()
    {
        
    }
    public override int Area()
    {
        return l*a;
    }
}
class Circulo:Figura
{
    private int radio;
    private int diametro;
    public Circulo(int x,int y,int l, int a, string c,int r, int d):base(x,y,l,a,c)
    {
        this.radio=r; this.diametro=d;
    }
    public override void Dibuja()
    {
        Console.WriteLine("Se dibuja un circulo");
    }
    public override int Area()
    {
        return Math.PI(Math.Pow(radio,2));
    }
}
class Triangulo:Figura
{
    private int b;
    private int h;
    public Triangulo(int x,int y, int l, int a,string c,int b,int h):base(x,y,l,a,c)
    {
        this.b=b; this.h=h;
    }
    public override void Dibuja()
    {
    }
    public override void Area()
    {
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        
    }
}