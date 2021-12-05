using System;


public class Point 
{
    private int x;
    private int y;
    private int z;


    /// <summary>Gets the x value of the point.</summary>
    public int X
    {
        get{return x;}
    }

    /// <summary>Gets the y value of the point.</summary>
    public int Y
    {
        get{return y;}
    }

    /// <summary>Gets the z value of the point.</summary>
    public int Z
    {
        get{return z;}
    }


    /// <summary>Initializes a new instance of the <see cref="Point" /> class.</summary>
    /// <param name="x">int</param>
    /// <param name="y">int</param>
    /// <param name="z">int</param>
    public Point(int x = 0, int y = 0, int z = 0)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }


    /// <summary>
    ///   <para>
    /// Transalates the point by the specified scalars for the x.y.z coordinates
    /// </para>
    /// </summary>
    /// <param name="scalarX">The scalar x.</param>
    /// <param name="scalarY">The scalar y.</param>
    /// <param name="scalarZ">The scalar z.</param>
    public void Transalation(int scalarX, int scalarY, int scalarZ) {
        this.x += scalarX;
        this.y += scalarY;
        this.z += scalarZ;
    }


    /// <summary>
    ///   <para>
    /// Checks if a point equals the current point</para>
    /// </summary>
    /// <param name="otherPoint">The other point.</param>
    /// <returns>
    ///   <br />
    /// </returns>
    public bool egal(Point otherPoint)
    {
        if (this.x - otherPoint.x == 0 && (this.y - otherPoint.y == 0) && (this.z - otherPoint.z == 0)) return true;
        return false;
    }
}