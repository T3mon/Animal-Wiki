using System.Collections.ObjectModel;

namespace AnimaWiki
{
    internal class Node
    {
        public string Name { get; set; }
        public ObservableCollection<Node> Nodes { get; set; }
    }
}