using System.Text;

namespace Projekt_AiSD___Minimalne_Drzewo_Rozpinające
{
    public class Graph
    {
        private List<NodeG> nodes;
        private List<Edge> edges;

        public Graph(List<NodeG> nodes, List<Edge> edges)
        {
            this.nodes = nodes ?? new List<NodeG>();
            this.edges = edges ?? new List<Edge>();
        }

        public void Sort()
        {
            edges = edges.OrderBy(o => o.distance).ToList();
        }

        public string Write()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Edge edge in edges)
            {
                sb.AppendLine($"({edge.start.data}, {edge.end.data}) {edge.distance}");
            }
            return sb.ToString();
        }

        public List<Edge> KruskalMST(Graph graph)
        {
            if (graph == null) return new List<Edge>();

            graph.Sort();
            var edges = graph.edges;
            List<Edge> mst = new List<Edge>();
            List<Graph> subgraphs = new List<Graph>();

            foreach (Edge edge in edges)
            {
                int newNodesCount = IleNowychWezlow(edge, subgraphs);

                switch (newNodesCount)
                {
                    case 2:
                        var newGraph = new Graph(
                            new List<NodeG> { edge.start, edge.end },
                            new List<Edge> { edge }
                        );
                        subgraphs.Add(newGraph);
                        mst.Add(edge);
                        break;

                    case 1:
                        var existingGraph = subgraphs.FirstOrDefault(g =>
                            g.nodes.Contains(edge.start) || g.nodes.Contains(edge.end));
                        existingGraph?.Add(edge);
                        mst.Add(edge);
                        break;

                    case 0:
                        var startSubgraph = subgraphs.FirstOrDefault(g => g.nodes.Contains(edge.start));
                        var endSubgraph = subgraphs.FirstOrDefault(g => g.nodes.Contains(edge.end));
                        if (startSubgraph != null && endSubgraph != null)
                        {
                            startSubgraph.Join(endSubgraph);
                            subgraphs.Remove(endSubgraph);
                            mst.Add(edge);
                        }
                        break;

                    case -1:
                        break;
                }
            }
            if (subgraphs.Count == 1) return mst;
            return new List<Edge> { };
        }

        public string CalculateMinimalDistanceString()
        {
            List<Edge> mst = KruskalMST(this);
            if (mst == null || !mst.Any())
            {
                return "Brak połączeń między działkami.";
            }
            int totalDistance = mst.Sum(edge => edge.distance);
            HashSet<NodeG> uniqueNodes = new HashSet<NodeG>();
            foreach (var edge in mst)
            {
                uniqueNodes.Add(edge.start);
                uniqueNodes.Add(edge.end);
            }
            string działkiString = string.Join(", ", uniqueNodes.Select(n => n.data).Distinct());
            return $"Do podlewania działek z {działkiString} potrzeba {totalDistance} metrów węża.";
        }

        public string WriteMDR()
        {
            var mstEdges = KruskalMST(this);

            if (mstEdges == null || !mstEdges.Any()) return "Brak drzewa rozpinającego.";

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Minimalne drzewo rozpinające:");
            foreach (var edge in mstEdges)
            {
                sb.AppendLine($"({edge.start.data}, {edge.end.data}) {edge.distance}");
            }
            return sb.ToString();
        }

        public void Add(Edge edge)
        {
            if (!nodes.Contains(edge.start))
                nodes.Add(edge.start);

            if (!nodes.Contains(edge.end))
                nodes.Add(edge.end);

            edges.Add(edge);
        }

        public void Join(Graph other)
        {
            foreach (var node in other.nodes)
            {
                if (!nodes.Contains(node))
                    nodes.Add(node);
            }

            foreach (var edge in other.edges)
            {
                if (!edges.Contains(edge))
                    edges.Add(edge);
            }
        }

        private int IleNowychWezlow(Edge edge, List<Graph> subgraphs)
        {
            Graph startSubgraph = subgraphs.FirstOrDefault(g => g.nodes.Contains(edge.start));
            Graph endSubgraph = subgraphs.FirstOrDefault(g => g.nodes.Contains(edge.end));

            if (startSubgraph == null && endSubgraph == null)
            {
                return 2;
            }
            else if (startSubgraph == null || endSubgraph == null)
            {
                return 1;
            }
            else if (startSubgraph != endSubgraph)
            {
                return 0;
            }
            return -1;
        }
    }
}
