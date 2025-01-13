namespace Projekt_AiSD___Minimalne_Drzewo_Rozpinające
{
    public class Edge
    {
        public NodeG start;
        public NodeG end;
        public int distance;

        public Edge(NodeG start, NodeG end, int distance)
        {
            this.start = start;
            this.end = end;
            this.distance = distance;
        }
    }
}
