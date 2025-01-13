namespace Projekt_AiSD___Minimalne_Drzewo_Rozpinające
{
    public class NodeG
    {
        public string data;
        public override bool Equals(object obj)
        {
            if (obj is NodeG other)
            {
                return string.Equals(this.data, other.data, StringComparison.Ordinal);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return data != null ? data.GetHashCode() : 0;
        }

        public NodeG(string uprawa)
        {
            data = uprawa;
        }
    }
}
