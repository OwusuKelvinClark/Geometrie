using System;


public class Point 
{
    private int x;
    private int y;
    private int z;

    public int X
    {
        /// Renvoie la valeur de x
        get() {return x;}
    }

    public int Y
    {
        /// Renvoie la valeur de y
        get() {return y;}
    }

    public int Z
    {
        /// Renvoie la valeur de z
        get() {return z;}
    }

    public Point(int x = 0, int y = 0, int z = 0)
    {
        /// parametres int, int, int => Valeurs pour les trois points (Défaut = 0)
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public void Transalation(int scalarX, int scalarY, int scalarZ) {
        /// parametres int int int => Les scalaires à ajouter aux points d'origine
        /// type de retour void
        this.x += scalarX;
        this.y += scalarY;
        this.z += scalarZ;
    }

    public bool egal(Point otherPoint)
    {
        /// parametres Point => Le point à comparer au point actuel
        /// type de retour bool
        /// Vrai si les points sont égaux et faux s'ils ne sont pas égaux
        if (this.x - otherPoint.x == 0 && (this.y - otherPoint.y == 0) && (this.z - otherPoint.z == 0)) return true;
        return false;
    }
}