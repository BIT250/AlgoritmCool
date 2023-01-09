using System.Runtime.Versioning;

namespace AlgoritmCool
{
    public partial class Sortari : Form
    {

        int count = 0,n;
        FlowLayoutPanel mainFlowLayoutPanel = new FlowLayoutPanel();
        List<TableLayoutPanel> listaDeSortat = new List<TableLayoutPanel>();
        List<PictureBox> listaImagini = new List<PictureBox>();
        List<TextBox> listaTextBoxes = new List<TextBox>();
        int object1=0, object2=0,aux;



        public Sortari()
        {
            InitializeComponent();
        }

        private void Sortari_Load(object sender, EventArgs e)
        {

            
            mainFlowLayoutPanel.Size = new Size(this.Width,300);
            mainFlowLayoutPanel.BorderStyle = BorderStyle.FixedSingle;
            mainFlowLayoutPanel.BackColor = Color.White;
            mainFlowLayoutPanel.Location = new Point(0, Bottom-mainFlowLayoutPanel.Height-100);
            this.Controls.Add(mainFlowLayoutPanel);
        }

        private void generate_Click(object sender, EventArgs e)
        {
            mainFlowLayoutPanel.Controls.Clear();

            timer1.Stop();

            int result;
            Random rnd = new Random();

            if (int.TryParse(nrEl.Text, out result) == false) 
                nrEl.Text = "Introduceti un numar";
            else
                n = int.Parse(nrEl.Text);


            
            int x = 0, y = 0;

            for (int i = 0; i < n; i++)
            {


                listaImagini.Add(new PictureBox());
                listaTextBoxes.Add(new TextBox());
                listaDeSortat.Add(new TableLayoutPanel());

                listaDeSortat[i].ColumnCount = 1;
                listaDeSortat[i].ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
                listaDeSortat[i].Controls.Add(listaTextBoxes[i], 0, 1);
                listaDeSortat[i].Controls.Add(listaImagini[i], 0, 0);
                listaDeSortat[i].RowCount = 2;
                listaDeSortat[i].RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
                listaDeSortat[i].RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
                listaDeSortat[i].Size = new System.Drawing.Size(40, 280);


                listaTextBoxes[i].Anchor = System.Windows.Forms.AnchorStyles.Bottom;
                listaTextBoxes[i].Text = rnd.Next(1,100).ToString();
                listaTextBoxes[i].ReadOnly = false;


                listaImagini[i].Anchor = System.Windows.Forms.AnchorStyles.Bottom;
                listaImagini[i].BackColor = Color.LightBlue;
                listaImagini[i].TabIndex = 1;
                listaImagini[i].TabStop = false;
                listaImagini[i].Height = 280;

               // listaDeSortat[i].Location = new Point(x, mainFlowLayoutPanel.Bottom);

                
                x += 100; 
                

                mainFlowLayoutPanel.Controls.Add(listaDeSortat[i]);
            }

           timer1.Start();

            
        }

        private void mySwap(int i, int j)
        {
            //swapItems.Stop();

            object1 = i;
            object2 = j;
            aux = listaDeSortat[object1].Location.X;
           
            listaImagini[j].BackColor = Color.Green;
            
           
        }

        private void sortareBasic()
        {
            swapItems.Start();

            mySwap(0, 1);
            //System.Threading.Thread.Sleep(1000);
            mySwap(1, 2);
            //System.Threading.Thread.Sleep(1000);
            mySwap(2, 3);

            swapItems.Stop();
           
        }


        private void startSortare_Click(object sender, EventArgs e)
        {
            
            timer1.Stop();
            for(int i=0;i<n;i++)
            {
                listaTextBoxes[i].ReadOnly = true;
            }
            mainFlowLayoutPanel.WrapContents = false;
            mainFlowLayoutPanel.SuspendLayout();

            sortareBasic();

        }

        private void swapItems_Tick(object sender, EventArgs e)
        {
            
            
            listaDeSortat[object1].Location = new Point(listaDeSortat[object1].Location.X+1, listaDeSortat[object1].Location.Y);
            listaDeSortat[object2].Location = new Point(listaDeSortat[object2].Location.X-1, listaDeSortat[object2].Location.Y);

            if (listaDeSortat[object2].Location.X < aux)
                swapItems.Stop();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            List<int> valori = new List<int>();

            int procent;
            int result,maxim;
            for(int i=0;i<n;i++)
            {
                if (int.TryParse(listaTextBoxes[i].Text, out result) == false)
                    valori.Add(0);
                else
                    valori.Add(int.Parse(listaTextBoxes[i].Text));
            }

            maxim = valori.Max();
            if(maxim==0)
                maxim = 1;

            for(int i=0;i<n;i++)
            {
                procent = valori[i] * 100 / maxim;
                listaImagini[i].Height = procent * listaDeSortat[i].Height / 100;
            }



        }
    }
}