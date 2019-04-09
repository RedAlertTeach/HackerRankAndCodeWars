using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

class Graph
{
    private Dictionary<Point, Node> theGraph = new Dictionary<Point, Node>();
    
    class Node
    {
        private int id;
        public int data;
        private ArrayList<Node> adjacents = new ArrayList<Node>();
        private Node(int id, int data)
        {
            this.id = id;
            this.data = data;
        }
    }
    
    public Node getNode(int id){
        try
        {
           return theGraph.Item(id);
        }
        catch (KeyNotFoundException)
        {
            return null;
        }
    }
    public void addNode(int id, int data)
    {
        Node node = new Node(id, data);
        try
        {
           theGraph.Add(id, node);
        }
        catch(ArgumentException)
        {
            Console.WriteLine("The id {0} already exists.", id);
        }
    }
    public void addEdge(int source, int destination)
    {
                    
        Node s = getNode(source);
        Node d = getNode(destination);
        s.adjacents.Add(d);
        
    }
    public bool hasPathDFS(int source, int destination)
    {
        Node s = getNode(source);
        Node d = getNode(destination);
        Dictonary<int, int> visited = new Dictionary<int, int>();
        return hasPathDFS(s, d, visited);
    }
    private bool hasPathDFS(Node source, Node destination, Dictionary<int, int> visited)
    {
        if (visited.ContainsKey(source.id))
        {
           return false;
        }
        visited.Add(source.id, source.id);
        if (source == destination)
        {
            return true;
        }
        foreach (Node child in source.adjacents)
        {
           if hasPathDFS(child, destination, visited)
                          return true;
        }
        return false;
    }
    public bool hasPathBFS(Node source, Node destination)
    {
        Queue<Node> nextToVisit = new Queue<Node>();
        Dictonary<int, int> visited = new Dictionary<int, int>();
        nextToVisit.Enqueue(source);
        while (nextToVisit.Count !=0)
        {
            Node node = nextToVisit.Dequeue();
            if (node == destination)
            {
                return true;
            }
         
            if (visited.ContainsKey(node.id))
            {
                continue;
            }
            visited.Add(node.id, node.id);
            foreach (Node child in node.adjacents)
            {
                nextToVisit.Queue(child);
            }
        }
        return false;
    }
} // Graph class
public struct Point
{
    private int x;
    private int y;

    public Point(int x, int y)
    {
       this.x = x;
       this.y = y;
    }

    public override bool Equals(Object obj)
    {
       if (!(obj is Point)) return false;

       Point p = (Point) obj;
       return x == p.x & y == p.y;
    }

    public override int GetHashCode()
    { 
        return ShiftAndWrap(x.GetHashCode(), 2) ^ y.GetHashCode();
    } 

    private int ShiftAndWrap(int value, int positions)
    {
        positions = positions & 0x1F;

        // Save the existing bit pattern, but interpret it as an unsigned integer.
        uint number = BitConverter.ToUInt32(BitConverter.GetBytes(value), 0);
        // Preserve the bits to be discarded.
        uint wrapped = number >> (32 - positions);
        // Shift and wrap the discarded bits.
        return BitConverter.ToInt32(BitConverter.GetBytes((number << positions) | wrapped), 0);
    }
} 

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int m = Convert.ToInt32(Console.ReadLine());
        int[,] grid = new int[n,m];
        for(int grid_i = 0; grid_i < n; grid_i++)
        {
           string[] grid_temp = Console.ReadLine().Split(' ');
           for (int k = 0; k < m; k++)
           {
           grid[grid_i,k] = Convert.ToInt32(grid_temp[k]);
           }
        }
        Graph cells = new Graph();
        // add all cells to the graph
        for (int i=0; i < grid.GetLength(0); i++)
        {
            for (int j=0; j < grid.GetLength(1); j++)
            {
                Point pt  = new Point(i,j);
                cells.addNode(pt, grid[i,j]);
               // Console.Write("{0} ", grid[i,j]);
            }
          //  Console.WriteLine();
        }
        // the corners are special cases
        
        // add edges for upper left corner
        cells.addEdge((new Point(0,0)).GetHashCode(), (new Point(0,1)).GetHashCode());
        cells.addEdge((new Point(0,0)).GetHashCode(), (new Point(1,1)).GetHashCode());
        cells.addEdge((new Point(0,0)).GetHashCode(), (new Point(1,0)).GetHashCode());
        
        // add edges for upper right corner
        cells.addEdge((new Point(0,m-1)).GetHashCode(), (new Point(1,m-1)).GetHashCode());
        cells.addEdge((new Point(0,m-1)).GetHashCode(), (new Point(1,m-2)).GetHashCode());
        cells.addEdge((new Point(0,m-1)).GetHashCode(), (new Point(0,m-2)).GetHashCode());
        
        //add edges for lower left corner
        cells.addEdge((new Point(n-1,0)).GetHashCode(), (new Point(n-2,0)).GetHashCode());
        cells.addEdge((new Point(n-1,0)).GetHashCode(), (new Point(n-2,1)).GetHashCode());
        cells.addEdge((new Point(n-1,0)).GetHashCode(), (new Point(n-1,1)).GetHashCode());
        
        // add edges for lower right corner
        cells.addEdge((new Point(n-1,m-1)).GetHashCode(), (new Point(n-2,m-1)).GetHashCode());
        cells.addEdge((new Point(n-1,m-1)).GetHashCode(), (new Point(n-2,m-2)).GetHashCode());
        cells.addEdge((new Point(n-1,m-1)).GetHashCode(), (new Point(n-1,m-2)).GetHashCode());
        
        
        // add edges for first row - special case
        for (int k = 1; k < grid.GetLength(1) - 1; k++ )
        {
            cells.AddEdge((new Point(0,k)).GetHashCode(), (new Point(0, k+1)).GetHashCode());
            cells.AddEdge((new Point(0,k)).GetHashCode(), (new Point(1, k+1)).GetHashCode());
            cells.AddEdge((new Point(0,k)).GetHashCode(), (new Point(1, k)).GetHashCode());
            cells.AddEdge((new Point(0,k)).GetHashCode(), (new Point(1, k-1)).GetHashCode());
            cells.AddEdge((new Point(0,k)).GetHashCode(), (new Point(0, k-1)).GetHashCode());
        }
        
        // add edges for interior cells
        
        for (int m = 1; m < grid.GetLength(0) - 1; m++)
        {
            for (int n = 1; n < grid.GetLength(1) - 1; n++)
            {
                cells.AddEdge((new Point(m,n)).GetHashCode(), (new Point(m-1, n-1)).GetHashCode());
                cells.AddEdge((new Point(m,n)).GetHashCode(), (new Point(m-1, n)).GetHashCode());
                cells.AddEdge((new Point(m,n)).GetHashCode(), (new Point(m-1, n+1)).GetHashCode());
                cells.AddEdge((new Point(m,n)).GetHashCode(), (new Point(m, n+1)).GetHashCode());
                cells.AddEdge((new Point(m,n)).GetHashCode(), (new Point(m+1, n+1)).GetHashCode());
                cells.AddEdge((new Point(m,n)).GetHashCode(), (new Point(m+1, n)).GetHashCode());
                cells.AddEdge((new Point(m,n)).GetHashCode(), (new Point(m+1, n-1)).GetHashCode());
                cells.AddEdge((new Point(m,n)).GetHashCode(), (new Point(m, n-1)).GetHashCode());
                
            }
        }
        
        
        
    }
}
