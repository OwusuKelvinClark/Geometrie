using System;

public class Cercle: Ellipse
{
    /// <summary>Initializes a new instance of the <see cref="Cercle" /> class.</summary>
    /// <param name="droite">The droite.</param>
    public Cercle(Droite droite): base(droite, droite){}

    /// <summary>
    ///   <para>
    /// Calculates the area of the circle</para>
    /// </summary>
    /// <returns>
    ///   <br />
    /// </returns>
    new public double Superficie() 
    {
        /// parametres void
        /// Type de retour float
        /// Renvoie la superficie de la cercle
        double distance = Math.Sqrt(Math.Pow((diametre1.End.X - diametre1.Start.X), 2) + Math.Pow((diametre1.End.Y - diametre1.Start.Y), 2));
        return 3.142 * distance;
    }

    /// <summary>
    ///   <para>Calculates the circumference of the circle</para>
    /// </summary>
    /// parametres void
    /// Type de retour float
    /// Renvoie la circonférence de la cercle
    new public double circonference()
    {
        double distance = Math.Sqrt(Math.Pow((diametre1.End.X - diametre1.Start.X), 2) + Math.Pow((diametre1.End.Y - diametre1.Start.Y), 2));
        return 2 * 3.142 * (distance/2);
    }
}