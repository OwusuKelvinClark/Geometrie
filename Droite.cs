public Droite
{
    private Point start;
    private Pont end;
    public Droite(Point start, Point end)
    {
        /// parametres Point, Point => Les deux points qui représentent le début et la fin de la ligne.
        // this.a = end.Y - start.Y;
        // this.b = start.X - end.X;
        // this.c = (a * start.X) + (b*start.Y);
        this.start = start;
        this.end = end;
    }

    public Point Start
    {
        /// Renvoie le point représentant le début de la ligne
        get() {return start;}
    }

    public Point End
    {
        /// Renvoie le point représentant la fin de la ligne
        get() {return end;}
    }

    public float slope
    {
        /// Renvoie la pente de la ligne
        get() {
            return (end.Y - start.Y)/(end.X - start.X);
        }
    }

    public float yIntercept{
        /// Renvoie l'ordonnée à l'origine de la ligne
        get() {
            return start.Y - (slope * start.X);
        }
    }

    public bool parallele Droite otherDroite) 
    {
        /// parametres Droite => La ligne à comparer à la ligne actuelle
        /// Type de retour bool
        /// Vrai si les lignes sont parallèles et faux si les lignes ne le sont pas.
        if (this.slope == otherDroite.slope && (this.yIntercept != otherDroite.yIntercept)) return true;
        return false;
    }

    public bool apartien(Point point)
    {
        /// parametres Point => Le point à tester
        /// Type de retour bool
        /// Vrai si le point est dans la ligne et faux sinon.
        if (point.Y == (slope * point.x) + yIntercept) return true;
        return false;
    }

    public bool apartien (Droite droite)
    {
        /// parametres Droite = La Droite à tester
        if ((this.start.X * droite.end.y) - (this.end.y * droite.start.X) == 0) return true;
        return false
    }
}