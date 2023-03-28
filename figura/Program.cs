abstract class Figura
{
    public double x,y;
    public double l;
    public double a;
    public string c;
    public Figura(double x,double y,double l,double a,string c)
    {
        this.x=x; this.y=y; this.l=l; this.a=a; this.c=c;
    }
    public abstract void Dibuja();
    public abstract double Area();
}
class Rectangulo:Figura
{
    public Rectangulo(double x,double y,double l,double a,string c):base(x,y,l,a,c)
    {
    }
    public override void Dibuja()
    {
        Console.WriteLine("Se dibuja un rectangulo");
    }
    public override double Area()
    {
        return l*a;
    }
}
class Circulo:Figura
{
    public double radio;
    public double diametro;
    public Circulo(double x,double y,double l,double a, string c,double r,double d):base(x,y,l,a,c)
    {
        this.radio=r; this.diametro=d;
    }
    public override void Dibuja()
    {
        Console.WriteLine("Se dibuja un circulo");
    }
    public override double Area()
    {
        return Math.PI*(Math.Pow(radio,2));
    }
}
class Triangulo:Figura
{
    public double b;
    public double h;
    public Triangulo(double x,double y,double l,double a,string c,double b,double h):base(x,y,l,a,c)
    {
        this.b=b; this.h=h;
    }
    public override void Dibuja()
    {
        Console.WriteLine("Se dibuja un triangulo");
    }
    public override double Area()
    {
        return (b*h)/2;
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        Rectangulo r1=new Rectangulo(2,3,20.4,12.7,"Negro");
        r1.Dibuja();
        Console.WriteLine($"{"El area del rectangulo es "}{r1.Area()}");
        Circulo c1=new Circulo(5,8,0,0,"Rojo",12,24);
        c1.Dibuja();
        Console.WriteLine($"{"El area del circulo es "}{c1.Area()}");
        Triangulo t1=new Triangulo(0,7,0,0,"Azul",7.89,5.47);
        t1.Dibuja();
        Console.WriteLine($"{"El area del triangulo es "}{t1.Area()}");
    }
}