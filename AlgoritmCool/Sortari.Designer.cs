namespace AlgoritmCool
{
    partial class Sortari
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.nrEl = new System.Windows.Forms.TextBox();
            this.generate = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.startSortare = new System.Windows.Forms.Button();
            this.swapItems = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(87, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numar elemente";
            // 
            // nrEl
            // 
            this.nrEl.Location = new System.Drawing.Point(289, 121);
            this.nrEl.Name = "nrEl";
            this.nrEl.Size = new System.Drawing.Size(38, 23);
            this.nrEl.TabIndex = 1;
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(373, 122);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(75, 23);
            this.generate.TabIndex = 2;
            this.generate.Text = "Generate";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // startSortare
            // 
            this.startSortare.Location = new System.Drawing.Point(600, 316);
            this.startSortare.Name = "startSortare";
            this.startSortare.Size = new System.Drawing.Size(109, 48);
            this.startSortare.TabIndex = 3;
            this.startSortare.Text = "Sorteaza";
            this.startSortare.UseVisualStyleBackColor = true;
            this.startSortare.Click += new System.EventHandler(this.startSortare_Click);
            // 
            // swapItems
            // 
            this.swapItems.Tick += new System.EventHandler(this.swapItems_Tick);
            // 
            // Sortari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 560);
            this.Controls.Add(this.startSortare);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.nrEl);
            this.Controls.Add(this.label1);
            this.Name = "Sortari";
            this.Text = "Sortari";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Sortari_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox nrEl;
        private Button generate;
        private System.Windows.Forms.Timer timer1;
        private Button startSortare;
        private System.Windows.Forms.Timer swapItems;
    }
}