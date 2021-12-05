public class Droite
{
    private Point start;
    private Point end;
    /// <summary>Initializes a new instance of the <see cref="Droite" /> class.</summary>
    /// <param name="start">The start.</param>
    /// <param name="end">The end.</param>
    public Droite(Point start, Point end)
    {
        
        this.start = start;
        this.end = end;
    }

    /// <summary>Gets the start point.</summary>
    /// <value>The start.</value>
    public Point Start
    {
        
        get{return start;}
    }

    /// <summary>Gets the end point.</summary>
    /// <value>The end.</value>
    public Point End
    {
        
        get{return end;}
    }

    /// <summary>Gets the slope.</summary>
    /// <value>The slope.</value>
    public float slope
    {
        
        get{
            return (end.Y - start.Y)/(end.X - start.X);
        }
    }

    /// <summary>Gets the y intercept.</summary>
    /// <value>The y intercept.</value>
    public float yIntercept{
        
        get{
            return start.Y - (slope * start.X);
        }
    }

    /// <summary>
    ///   <para>
    /// Checks if the line passed as a param is parallel to the current line</para>
    /// </summary>
    /// <param name="otherDroite">The other droite.</param>
    /// <returns>
    ///   <br />
    /// </returns>
    public bool parallele (Droite otherDroite) 
    {
        
        if (this.slope == otherDroite.slope && (this.yIntercept != otherDroite.yIntercept)) return true;
        return false;
    }

    /// <summary>
    ///   <para>
    /// Checks if the point can be found on the line</para>
    /// </summary>
    /// <param name="point">The point.</param>
    /// <returns>
    ///   <br />
    /// </returns>
    public bool apartien(Point point)
    {
        
        if (point.Y == (slope * point.X) + yIntercept) return true;
        return false;
    }

    /// <summary>
    ///   <para>
    /// Checks if the line is found on the current line</para>
    /// </summary>
    /// <param name="droite">The droite.</param>
    /// <returns>
    ///   <br />
    /// </returns>
    public bool apartien (Droite droite)
    {
        
        if ((this.start.X * droite.end.Y) - (this.end.Y * droite.start.X) == 0) return true;
        return false;
    }
}