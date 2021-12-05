using System;

public class Ellipse
{
    protected Droite diametre1;
    protected Droite diametre2;

    /// <summary>Initializes a new instance of the <see cref="Ellipse" /> class.</summary>
    /// <param name="premierDiametre">The premier diametre.</param>
    /// <param name="deuxiemeDiametre">The deuxieme diametre.</param>
    public Ellipse(Droite premierDiametre, Droite deuxiemeDiametre)
    {
        this.diametre1 = premierDiametre;
        this.diametre2 = deuxiemeDiametre;
    }

    /// <summary>
    ///   <para>
    /// Calcualtes the area of the ellipse</para>
    /// </summary>
    /// <returns>
    ///   <br />
    /// </returns>
    public double Superficie()
    {
        double distance1 = Math.Sqrt(Math.Pow((diametre1.End.X - diametre1.Start.X), 2) + Math.Pow((diametre1.End.Y - diametre1.Start.Y),2 ));
        double distance2 = Math.Sqrt(Math.Pow((diametre2.End.X - diametre2.Start.X), 2) + Math.Pow((diametre2.End.Y - diametre2.Start.Y), 2));

        return 3.142 * (distance1/2) * (distance2/2);
    }

    /// <summary>
    ///   <para>Calculates the circumference of the circle</para>
    /// </summary>
    /// <returns>
    ///   <br />
    /// </returns>
    public double circonference()
    {
        double distance1 = Math.Sqrt(Math.Pow((diametre1.End.X - diametre1.Start.X), 2) + Math.Pow((diametre1.End.Y - diametre1.Start.Y), 2));
        double distance2 = Math.Sqrt(Math.Pow((diametre2.End.X - diametre2.Start.X), 2) + Math.Pow((diametre2.End.Y - diametre2.Start.Y), 2));

        return 3.142 * ((distance1/2) + (distance2/2));
    }
}