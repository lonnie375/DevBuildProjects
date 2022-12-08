
Polygon ply1 = new Polygon("Fred", new Edge("a", 5), new Edge("b", 4), new Edge("c", 3));

Console.WriteLine(ply1);

ply1.AddEdge(new Edge("d", 6));
Console.WriteLine(ply1);

ply1.ChangeEdge("b", 5);
Console.WriteLine(ply1);

Console.WriteLine();
Console.Write("Which edge would you like to change? ");
string edge = Console.ReadLine().ToLower();
Console.Write("What size do you want to change it do? ");
string entry = Console.ReadLine().ToLower();
double length = double.Parse(entry);

ply1.ChangeEdge(edge, length);
Console.WriteLine(ply1);
public class Edge
{
    public string name { get; set; }
    public double length { get; set; }
    public Edge(string name, double length)
    {
        this.name = name;
        this.length = length;
    }   
}

public class Polygon
{
    public string name { get; set; }
    public List<Edge> edges { get; set; }
    public Polygon (string _name, Edge edge1, Edge  edge2, Edge edg3)
    {
        this.name = _name;
        edges = new List<Edge>();
        edges.Add (edge1);
        edges.Add (edge2);
        edges.Add(edg3);
    }

    public void AddEdge(Edge another)
    {
        edges.Add (another);    
    }

    public void ChangeEdge(string which, double newLength)
    {
        foreach (Edge edge in edges)
        {
            if (edge.name == which)
            {
                edge.length = newLength;
                return; 
            }
        }
    }
    public override string ToString()
    {
        string result = " ";
        string comma = " ";
        foreach (Edge ed in edges)
        {
            result = result + $"{comma}{ed.name}:{ed.length}";
            comma = ",";
        }
        return $"Name: {name} = {result}";
    }


}