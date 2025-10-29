namespace Ejercicio1
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
            listBox1 = new ListBox();
            btnVerCuentas = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(528, 304);
            listBox1.TabIndex = 0;
            // 
            // btnVerCuentas
            // 
            btnVerCuentas.Location = new Point(574, 12);
            btnVerCuentas.Name = "btnVerCuentas";
            btnVerCuentas.Size = new Size(164, 54);
            btnVerCuentas.TabIndex = 1;
            btnVerCuentas.Text = "1-Ver cuentas ";
            btnVerCuentas.UseVisualStyleBackColor = true;
            btnVerCuentas.Click += btnVerCuentas_Click;
            // 
            // button2
            // 
            button2.Location = new Point(574, 72);
            button2.Name = "button2";
            button2.Size = new Size(164, 54);
            button2.TabIndex = 2;
            button2.Text = "2-Importar Cuentas";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(574, 133);
            button3.Name = "button3";
            button3.Size = new Size(164, 54);
            button3.TabIndex = 3;
            button3.Text = "3-Exportar Cuentas";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(574, 201);
            button4.Name = "button4";
            button4.Size = new Size(164, 54);
            button4.TabIndex = 4;
            button4.Text = "4-Resguardar(backup)";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(574, 262);
            button5.Name = "button5";
            button5.Size = new Size(164, 54);
            button5.TabIndex = 5;
            button5.Text = "5-Restaurar(Restore)";
            button5.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 327);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnVerCuentas);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button btnVerCuentas;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
    }
}
