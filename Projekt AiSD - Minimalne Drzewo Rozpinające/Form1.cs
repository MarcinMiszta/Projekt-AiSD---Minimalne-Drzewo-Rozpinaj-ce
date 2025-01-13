namespace Projekt_AiSD___Minimalne_Drzewo_Rozpinające
{
    public partial class Form1 : Form
    {
        public string name;
        public string data;
        List<string> lista = new List<string>();
        List<NodeG> punkty = new List<NodeG>();
        List<Edge> krawedzie = new List<Edge>();

        public Form1()
        {
            InitializeComponent();
            textBox_list.Multiline = true;
            this.BackColor = System.Drawing.Color.FromArgb(239, 227, 194);
            this.panel1.BackColor = System.Drawing.Color.FromArgb(133, 169, 71);
            this.panel2.BackColor = System.Drawing.Color.FromArgb(133, 169, 71);
            this.panel3.BackColor = System.Drawing.Color.FromArgb(133, 169, 71);
            this.label2.BackColor = System.Drawing.Color.FromArgb(133, 169, 71);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lista.Add("Marchew");
            lista.Add("Pomidory");
            lista.Add("Cebula");
            lista.Add("Groch");
            lista.Add("Pietruszka");
            lista.Add("Fasola");
            UpdateSelectors();
        }

        private void AdderClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(name))
            {

                lista.Add(name);
                textBox_name.Clear();
                UpdateSelectors();

                selector_remover.SelectedIndex = selector_remover.Items.Count - 1;
            }
            else
            {
                MessageBox.Show("Proszę wpisać nazwę uprawy!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox_name_TextChanged(object sender, EventArgs e)
        {
            name = textBox_name.Text;
        }

        private void Remover_Click(object sender, EventArgs e)
        {
            if (selector_remover.SelectedIndex >= 0)
            {
                lista.RemoveAt(selector_remover.SelectedIndex);
                UpdateSelectors();

                MessageBox.Show("Usunięto wybraną uprawę.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Proszę wybrać element do usunięcia!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateSelectors()
        {
            selector_remover.Items.Clear();
            selector1.ResetText();
            selector1.Items.Clear();
            selector2.Items.Clear();
            selector2.ResetText();
            selector_remover.ResetText();

            if (lista.Count == 0)
            {
                selector_remover.Items.Add("Lista jest pusta");
                selector1.Items.Add("Lista jest pusta");
                selector2.Items.Add("Lista jest pusta");
                selector_remover.Enabled = false;
                selector1.Enabled = false;
                selector2.Enabled = false;
                textBox_list.Clear();
            }
            else
            {

                selector_remover.Items.AddRange(lista.ToArray());
                selector_remover.Enabled = true;
                selector1.Items.AddRange(lista.ToArray());
                selector1.Enabled = true;
                selector2.Items.AddRange(lista.ToArray());
                UpdateTextBoxList();
            }
        }
        private void UpdateTextBoxList()
        {
            textBox_list.Text = string.Join(Environment.NewLine, lista);
            List<NodeG> temp = new List<NodeG>();
            foreach (string item in lista)
            {
                temp.Add(new NodeG(item));
            }
            punkty = temp;
        }

        private void textBox_distance_TextChanged(object sender, EventArgs e)
        {
            data = textBox_distance.Text;
        }

        private void confirm_distance_Click(object sender, EventArgs e)
        {
            int distance;
            if (!string.IsNullOrEmpty(data) && selector1.SelectedItem != null && selector2.SelectedItem != null && selector1.SelectedItem != selector2.SelectedItem)
            {
                bool result = int.TryParse(data, out distance);
                if (result)
                {
                    bool edgeExists = krawedzie.Any(e =>
                        (e.start.data == selector1.SelectedItem.ToString() && e.end.data == selector2.SelectedItem.ToString()) ||
                        (e.start.data == selector2.SelectedItem.ToString() && e.end.data == selector1.SelectedItem.ToString()));

                    if (!edgeExists)
                    {
                        krawedzie.Add(new Edge(
                            new NodeG(selector1.SelectedItem.ToString()),
                            new NodeG(selector2.SelectedItem.ToString()),
                            distance));
                    }
                    Graph graph = new Graph(punkty, krawedzie);
                    textBox_list_distance.Text = graph.Write();
                    textBox1.Text = graph.CalculateMinimalDistanceString();
                    textBox2.Text = graph.WriteMDR();

                }
                else
                {
                    MessageBox.Show("Proszę wpisać liczbę całkowitą!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Wybierz uprawy i wpisz odległość!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_list_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
