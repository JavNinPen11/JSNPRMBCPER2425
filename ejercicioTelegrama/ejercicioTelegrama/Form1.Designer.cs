namespace ejercicioTelegrama
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
            btnCalcularPrecio = new Button();
            txtTelegrama = new RichTextBox();
            txtPrecio = new TextBox();
            label1 = new Label();
            label2 = new Label();
            radioOrdinario = new RadioButton();
            radioUrgente = new RadioButton();
            SuspendLayout();
            // 
            // btnCalcularPrecio
            // 
            btnCalcularPrecio.Location = new Point(301, 255);
            btnCalcularPrecio.Name = "btnCalcularPrecio";
            btnCalcularPrecio.Size = new Size(94, 29);
            btnCalcularPrecio.TabIndex = 0;
            btnCalcularPrecio.Text = "Calcular precio";
            btnCalcularPrecio.UseVisualStyleBackColor = true;
            btnCalcularPrecio.Click += btnCalcularPrecio_Click;
            // 
            // txtTelegrama
            // 
            txtTelegrama.Location = new Point(86, 55);
            txtTelegrama.Margin = new Padding(3, 4, 3, 4);
            txtTelegrama.Name = "txtTelegrama";
            txtTelegrama.Size = new Size(308, 153);
            txtTelegrama.TabIndex = 2;
            txtTelegrama.Text = "";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(165, 255);
            txtPrecio.Margin = new Padding(3, 4, 3, 4);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(114, 27);
            txtPrecio.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 16);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 4;
            label1.Text = "Texto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 260);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 5;
            label2.Text = "Coste";
            // 
            // radioOrdinario
            // 
            radioOrdinario.AutoSize = true;
            radioOrdinario.Location = new Point(86, 215);
            radioOrdinario.Name = "radioOrdinario";
            radioOrdinario.Size = new Size(93, 24);
            radioOrdinario.TabIndex = 6;
            radioOrdinario.TabStop = true;
            radioOrdinario.Text = "Ordinario";
            radioOrdinario.UseVisualStyleBackColor = true;
            // 
            // radioUrgente
            // 
            radioUrgente.AutoSize = true;
            radioUrgente.Location = new Point(185, 215);
            radioUrgente.Name = "radioUrgente";
            radioUrgente.Size = new Size(83, 24);
            radioUrgente.TabIndex = 7;
            radioUrgente.TabStop = true;
            radioUrgente.Text = "Urgente";
            radioUrgente.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 353);
            Controls.Add(radioUrgente);
            Controls.Add(radioOrdinario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPrecio);
            Controls.Add(txtTelegrama);
            Controls.Add(btnCalcularPrecio);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcularPrecio;
        private RichTextBox txtTelegrama;
        private TextBox txtPrecio;
        private Label label1;
        private Label label2;
        private RadioButton radioOrdinario;
        private RadioButton radioUrgente;
    }
}
