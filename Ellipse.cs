public Ellipse
{
    protected Droite diametre1;
    protected Droite diametre2;

    public Ellipse(Droite premierDiametre, Droite deuxiemeDiametre)
    {
        /// parametres Droite, Droite => Les deux lignes formant le diamètre de l'ellipse
        this.diametre1 = premierDiametre;
        this.diametre2 = deuxiemeDiametre;
    }

    public float superficie()
    {
        /// parametres void
        /// Type de retour float
        /// Renvoie la superficie du ellipse
        float distance1 = Math.Sqrt(Math.Pow((diametre1.End.X - diametre1.Start.X), 2) + Math.Pow((diametre1.End.Y - diametre1.Start.Y)));
        float distance2 = Math.Sqrt(Math.Pow((diametre2.End.X - diametre2.Start.X), 2) + Math.Pow((diametre2.End.Y - diametre2.Start.Y)));

        return 3.142 * (distance1/2) * (distance2/2);
    }

    public float circonference()
    {
        /// parametres void
        /// Type de retour float
        /// Renvoie la circonférence du ellipse
        float distance1 = Math.Sqrt(Math.Pow((diametre1.End.X - diametre1.Start.X), 2) + Math.Pow((diametre1.End.Y - diametre1.Start.Y)));
        float distance2 = Math.Sqrt(Math.Pow((diametre2.End.X - diametre2.Start.X), 2) + Math.Pow((diametre2.End.Y - diametre2.Start.Y)));

        return 3.142 * ((distance1/2) + (distance2/2));
    }
}