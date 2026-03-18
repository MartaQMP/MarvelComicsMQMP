namespace TestingComics
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
            label1 = new Label();
            txtBusqueda = new TextBox();
            btnBuscar = new Button();
            lstComics = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 21);
            label1.TabIndex = 0;
            label1.Text = "Busqueda";
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(40, 61);
            txtBusqueda.Margin = new Padding(4);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(127, 29);
            txtBusqueda.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(42, 110);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(125, 35);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lstComics
            // 
            lstComics.FormattingEnabled = true;
            lstComics.Location = new Point(186, 40);
            lstComics.Name = "lstComics";
            lstComics.Size = new Size(239, 277);
            lstComics.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 348);
            Controls.Add(lstComics);
            Controls.Add(btnBuscar);
            Controls.Add(txtBusqueda);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBusqueda;
        private Button btnBuscar;
        private ListBox lstComics;
    }
}
