public class Cercle: Ellipse
{
    public Cercle(Droite droite): base(droite, droite){}

    new public float superficie() 
    {
        /// parametres void
        /// Type de retour float
        /// Renvoie la superficie de la cercle
        float distance = Math.Sqrt(Math.Pow((diametre1.End.X - diametre1.Start.X), 2) + Math.Pow((diametre1.End.Y - diametre1.Start.Y)));
        return 3.142 * distance;
    }

    new public float circonference()
    {
        /// parametres void
        /// Type de retour float
        /// Renvoie la circonférence de la cercle
        float distance = Math.Sqrt(Math.Pow((diametre1.End.X - diametre1.Start.X), 2) + Math.Pow((diametre1.End.Y - diametre1.Start.Y)));
        return 2 * 3.142 * (distance/2);
    }
}