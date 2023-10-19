namespace KafeOnline6
{
    partial class AnaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            tsmİUrunler = new ToolStripMenuItem();
            tsmiGecmisSiparisler = new ToolStripMenuItem();
            listView1 = new ListView();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmİUrunler, tsmiGecmisSiparisler });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmİUrunler
            // 
            tsmİUrunler.Name = "tsmİUrunler";
            tsmİUrunler.Size = new Size(58, 20);
            tsmİUrunler.Text = "Ürünler";
            // 
            // tsmiGecmisSiparisler
            // 
            tsmiGecmisSiparisler.Name = "tsmiGecmisSiparisler";
            tsmiGecmisSiparisler.Size = new Size(108, 20);
            tsmiGecmisSiparisler.Text = "Geçmiş Siparişler";
            // 
            // listView1
            // 
            listView1.Location = new Point(0, 40);
            listView1.Name = "listView1";
            listView1.Size = new Size(779, 385);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // AnaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "AnaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kafe Online6";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ListView listView1;
        private ToolStripMenuItem tsmİUrunler;
        private ToolStripMenuItem tsmiGecmisSiparisler;
    }
}