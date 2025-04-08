namespace RPN_Hesap_Makinesi_ve_Undo_Redo_Simülasyonu
{
    public partial class Form1 : Form
    {
        private LinkedList linkedList = new LinkedList();
        private Stack<LinkedList> historyStack = new Stack<LinkedList>();
        private Stack<LinkedList> undoStack = new Stack<LinkedList>();
        private Stack<LinkedList> redoStack = new Stack<LinkedList>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtInput.Text))
            {
                undoStack.Push(CloneLinkedList());
                linkedList.Add(txtInput.Text);
                redoStack.Clear();
                panel1.Invalidate();
                UpdateListBox();

                txtInput.Clear();
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; // Çizim yapabilmek için
            Node current = linkedList.head;
            int x = 10;
            int y = panel1.Height / 2;

            while (current != null)
            {
                g.FillRectangle(Brushes.LightBlue, x, y - 15, 100, 30);
                g.DrawString(current.Data, Font, Brushes.Black, x + 10, y - 10);

                if (current.Next != null)
                    g.DrawLine(Pens.Red, x + 100, y, x + 130, y);
                x += 120;
                current = current.Next;
            }
        }

        private LinkedList CloneLinkedList()
        {
            LinkedList newList = new LinkedList();
            Node current = linkedList.head;
            while (current != null)
            {
                newList.Add(current.Data);
                current = current.Next;
            }
            return newList;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
                panel1.Invalidate();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (undoStack.Count > 0)
            {
                redoStack.Push(CloneLinkedList());

                linkedList = undoStack.Pop();

                panel1.Invalidate();
                UpdateListBox();
            }
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            if(redoStack.Count > 0)
            {
                undoStack.Push(CloneLinkedList());
                linkedList = redoStack.Pop();
                panel1.Invalidate();
                UpdateListBox();
            }
        }

        private void UpdateListBox()
        {
            listBox1.Items.Clear();
            Node current = linkedList.head;
            while (current != null)
            {
                listBox1.Items.Add(current.Data);
                current = current.Next;
            }
        }
    }
}
