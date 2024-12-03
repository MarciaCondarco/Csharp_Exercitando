namespace Formulario.Aula2._1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Titulo = new System.Windows.Forms.TextBox();
            this.textBox_Genero = new System.Windows.Forms.TextBox();
            this.textBox_Ano = new System.Windows.Forms.TextBox();
            this.textBox_Avaliacao = new System.Windows.Forms.TextBox();
            this.button_Cadastrar = new System.Windows.Forms.Button();
            this.button_Limpar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_Cadastrado = new System.Windows.Forms.Label();
            this.label_Titulo = new System.Windows.Forms.Label();
            this.label_Genero = new System.Windows.Forms.Label();
            this.label_Ano = new System.Windows.Forms.Label();
            this.label_Avaliacao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Filmes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Titulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Genero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ano";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Avaliação";
            // 
            // textBox_Titulo
            // 
            this.textBox_Titulo.Location = new System.Drawing.Point(123, 76);
            this.textBox_Titulo.Name = "textBox_Titulo";
            this.textBox_Titulo.Size = new System.Drawing.Size(100, 20);
            this.textBox_Titulo.TabIndex = 1;
            this.textBox_Titulo.TextChanged += new System.EventHandler(this.textBox_Titulo_TextChanged);
            // 
            // textBox_Genero
            // 
            this.textBox_Genero.Location = new System.Drawing.Point(123, 131);
            this.textBox_Genero.Name = "textBox_Genero";
            this.textBox_Genero.Size = new System.Drawing.Size(100, 20);
            this.textBox_Genero.TabIndex = 2;
            // 
            // textBox_Ano
            // 
            this.textBox_Ano.Location = new System.Drawing.Point(123, 179);
            this.textBox_Ano.Name = "textBox_Ano";
            this.textBox_Ano.Size = new System.Drawing.Size(100, 20);
            this.textBox_Ano.TabIndex = 3;
            // 
            // textBox_Avaliacao
            // 
            this.textBox_Avaliacao.Location = new System.Drawing.Point(123, 228);
            this.textBox_Avaliacao.Name = "textBox_Avaliacao";
            this.textBox_Avaliacao.Size = new System.Drawing.Size(100, 20);
            this.textBox_Avaliacao.TabIndex = 4;
            // 
            // button_Cadastrar
            // 
            this.button_Cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Cadastrar.Location = new System.Drawing.Point(41, 314);
            this.button_Cadastrar.Name = "button_Cadastrar";
            this.button_Cadastrar.Size = new System.Drawing.Size(119, 53);
            this.button_Cadastrar.TabIndex = 5;
            this.button_Cadastrar.Text = "Cadastrar";
            this.button_Cadastrar.UseVisualStyleBackColor = true;
            this.button_Cadastrar.Click += new System.EventHandler(this.button_Cadastrar_Click);
            // 
            // button_Limpar
            // 
            this.button_Limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Limpar.Location = new System.Drawing.Point(200, 314);
            this.button_Limpar.Name = "button_Limpar";
            this.button_Limpar.Size = new System.Drawing.Size(119, 53);
            this.button_Limpar.TabIndex = 6;
            this.button_Limpar.Text = "Limpar";
            this.button_Limpar.UseVisualStyleBackColor = true;
            this.button_Limpar.Click += new System.EventHandler(this.button_Limpar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(419, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 267);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // label_Cadastrado
            // 
            this.label_Cadastrado.AutoSize = true;
            this.label_Cadastrado.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label_Cadastrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Cadastrado.Location = new System.Drawing.Point(509, 134);
            this.label_Cadastrado.Name = "label_Cadastrado";
            this.label_Cadastrado.Size = new System.Drawing.Size(155, 31);
            this.label_Cadastrado.TabIndex = 0;
            this.label_Cadastrado.Text = "Cadastrado";
            this.label_Cadastrado.Visible = false;
            // 
            // label_Titulo
            // 
            this.label_Titulo.AutoSize = true;
            this.label_Titulo.Location = new System.Drawing.Point(411, 295);
            this.label_Titulo.Name = "label_Titulo";
            this.label_Titulo.Size = new System.Drawing.Size(0, 13);
            this.label_Titulo.TabIndex = 13;
            // 
            // label_Genero
            // 
            this.label_Genero.AutoSize = true;
            this.label_Genero.Location = new System.Drawing.Point(411, 333);
            this.label_Genero.Name = "label_Genero";
            this.label_Genero.Size = new System.Drawing.Size(0, 13);
            this.label_Genero.TabIndex = 14;
            // 
            // label_Ano
            // 
            this.label_Ano.AutoSize = true;
            this.label_Ano.Location = new System.Drawing.Point(411, 369);
            this.label_Ano.Name = "label_Ano";
            this.label_Ano.Size = new System.Drawing.Size(0, 13);
            this.label_Ano.TabIndex = 15;
            // 
            // label_Avaliacao
            // 
            this.label_Avaliacao.AutoSize = true;
            this.label_Avaliacao.Location = new System.Drawing.Point(411, 403);
            this.label_Avaliacao.Name = "label_Avaliacao";
            this.label_Avaliacao.Size = new System.Drawing.Size(0, 13);
            this.label_Avaliacao.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_Avaliacao);
            this.Controls.Add(this.label_Ano);
            this.Controls.Add(this.label_Genero);
            this.Controls.Add(this.label_Titulo);
            this.Controls.Add(this.label_Cadastrado);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_Limpar);
            this.Controls.Add(this.button_Cadastrar);
            this.Controls.Add(this.textBox_Avaliacao);
            this.Controls.Add(this.textBox_Ano);
            this.Controls.Add(this.textBox_Genero);
            this.Controls.Add(this.textBox_Titulo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Titulo;
        private System.Windows.Forms.TextBox textBox_Genero;
        private System.Windows.Forms.TextBox textBox_Ano;
        private System.Windows.Forms.TextBox textBox_Avaliacao;
        private System.Windows.Forms.Button button_Cadastrar;
        private System.Windows.Forms.Button button_Limpar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_Cadastrado;
        private System.Windows.Forms.Label label_Titulo;
        private System.Windows.Forms.Label label_Genero;
        private System.Windows.Forms.Label label_Ano;
        private System.Windows.Forms.Label label_Avaliacao;
    }
}

