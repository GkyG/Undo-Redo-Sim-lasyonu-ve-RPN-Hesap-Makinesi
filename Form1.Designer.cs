namespace RPN_Hesap_Makinesi_ve_Undo_Redo_Simülasyonu
{
    partial class Form1
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            listBox1 = new ListBox();
            panel1 = new Panel();
            btnRedo = new Button();
            btnUndo = new Button();
            button1 = new Button();
            txtInput = new TextBox();
            tabPage2 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 426);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(listBox1);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(btnRedo);
            tabPage1.Controls.Add(btnUndo);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(txtInput);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Metin Düzenleyici";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.Lime;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(6, 308);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(756, 79);
            listBox1.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Location = new Point(6, 57);
            panel1.Name = "panel1";
            panel1.Size = new Size(756, 247);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // btnRedo
            // 
            btnRedo.BackColor = Color.Turquoise;
            btnRedo.Location = new Point(618, 18);
            btnRedo.Name = "btnRedo";
            btnRedo.Size = new Size(81, 23);
            btnRedo.TabIndex = 4;
            btnRedo.Text = "Redo";
            btnRedo.UseVisualStyleBackColor = false;
            btnRedo.Click += btnRedo_Click;
            // 
            // btnUndo
            // 
            btnUndo.BackColor = Color.GreenYellow;
            btnUndo.Location = new Point(453, 18);
            btnUndo.Name = "btnUndo";
            btnUndo.Size = new Size(81, 23);
            btnUndo.TabIndex = 3;
            btnUndo.Text = "Undo";
            btnUndo.UseVisualStyleBackColor = false;
            btnUndo.Click += btnUndo_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Location = new Point(270, 19);
            button1.Name = "button1";
            button1.Size = new Size(81, 23);
            button1.TabIndex = 2;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(6, 19);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(208, 23);
            txtInput.TabIndex = 1;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.DeepSkyBlue;
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "RPN Hesap Makinesi";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Undo/Redo & RPN Stack Calculator";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnRedo;
        private Button btnUndo;
        private Button button1;
        private TextBox txtInput;
        private Panel panel1;
        private ListBox listBox1;
    }
}
