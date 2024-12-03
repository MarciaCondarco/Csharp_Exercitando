namespace Formulario.Aula2._0
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button_Mostrar1 = new System.Windows.Forms.Button();
            this.button_Apagar1 = new System.Windows.Forms.Button();
            this.button_ApagarTodo = new System.Windows.Forms.Button();
            this.button_Mostrar2 = new System.Windows.Forms.Button();
            this.button_Apagar2 = new System.Windows.Forms.Button();
            this.button_MostrarDuasImagens = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Zoom2 = new System.Windows.Forms.Button();
            this.button_stretchimage2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(466, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(50, 174);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(270, 190);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // button_Mostrar1
            // 
            this.button_Mostrar1.Location = new System.Drawing.Point(25, 12);
            this.button_Mostrar1.Name = "button_Mostrar1";
            this.button_Mostrar1.Size = new System.Drawing.Size(136, 47);
            this.button_Mostrar1.TabIndex = 1;
            this.button_Mostrar1.Text = "Mostrar imagem 1";
            this.button_Mostrar1.UseVisualStyleBackColor = true;
            this.button_Mostrar1.Click += new System.EventHandler(this.button_Mostrar1_Click);
            // 
            // button_Apagar1
            // 
            this.button_Apagar1.Location = new System.Drawing.Point(25, 75);
            this.button_Apagar1.Name = "button_Apagar1";
            this.button_Apagar1.Size = new System.Drawing.Size(136, 43);
            this.button_Apagar1.TabIndex = 2;
            this.button_Apagar1.Text = "Apagar imagem 1";
            this.button_Apagar1.UseVisualStyleBackColor = true;
            this.button_Apagar1.Click += new System.EventHandler(this.button_Apagar1_Click);
            // 
            // button_ApagarTodo
            // 
            this.button_ApagarTodo.Location = new System.Drawing.Point(626, 309);
            this.button_ApagarTodo.Name = "button_ApagarTodo";
            this.button_ApagarTodo.Size = new System.Drawing.Size(137, 46);
            this.button_ApagarTodo.TabIndex = 3;
            this.button_ApagarTodo.Text = "Apagar as duas imagens";
            this.button_ApagarTodo.UseVisualStyleBackColor = true;
            this.button_ApagarTodo.Click += new System.EventHandler(this.button_ApagarTodo_Click);
            // 
            // button_Mostrar2
            // 
            this.button_Mostrar2.Location = new System.Drawing.Point(211, 20);
            this.button_Mostrar2.Name = "button_Mostrar2";
            this.button_Mostrar2.Size = new System.Drawing.Size(137, 46);
            this.button_Mostrar2.TabIndex = 4;
            this.button_Mostrar2.Text = "Mostrar imagem 2";
            this.button_Mostrar2.UseVisualStyleBackColor = true;
            this.button_Mostrar2.Click += new System.EventHandler(this.button_Mostrar2_Click);
            // 
            // button_Apagar2
            // 
            this.button_Apagar2.Location = new System.Drawing.Point(211, 72);
            this.button_Apagar2.Name = "button_Apagar2";
            this.button_Apagar2.Size = new System.Drawing.Size(137, 46);
            this.button_Apagar2.TabIndex = 5;
            this.button_Apagar2.Text = "Apagar imagem 2";
            this.button_Apagar2.UseVisualStyleBackColor = true;
            this.button_Apagar2.Click += new System.EventHandler(this.button_Apagar2_Click);
            // 
            // button_MostrarDuasImagens
            // 
            this.button_MostrarDuasImagens.Location = new System.Drawing.Point(626, 361);
            this.button_MostrarDuasImagens.Name = "button_MostrarDuasImagens";
            this.button_MostrarDuasImagens.Size = new System.Drawing.Size(146, 48);
            this.button_MostrarDuasImagens.TabIndex = 6;
            this.button_MostrarDuasImagens.Text = "Mostrar as duas imagens";
            this.button_MostrarDuasImagens.UseVisualStyleBackColor = true;
            this.button_MostrarDuasImagens.Click += new System.EventHandler(this.button_MostrarDuasImagens_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(436, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 54);
            this.button1.TabIndex = 7;
            this.button1.Text = "Zoom imagem 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(606, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 48);
            this.button2.TabIndex = 8;
            this.button2.Text = "StretchImage Image 1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(530, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Imagem 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Imagem 2";
            // 
            // button_Zoom2
            // 
            this.button_Zoom2.Location = new System.Drawing.Point(27, 390);
            this.button_Zoom2.Name = "button_Zoom2";
            this.button_Zoom2.Size = new System.Drawing.Size(114, 48);
            this.button_Zoom2.TabIndex = 11;
            this.button_Zoom2.Text = "Zoom Imagem 2";
            this.button_Zoom2.UseVisualStyleBackColor = true;
            this.button_Zoom2.Click += new System.EventHandler(this.button_Zoom2_Click);
            // 
            // button_stretchimage2
            // 
            this.button_stretchimage2.Location = new System.Drawing.Point(176, 390);
            this.button_stretchimage2.Name = "button_stretchimage2";
            this.button_stretchimage2.Size = new System.Drawing.Size(144, 48);
            this.button_stretchimage2.TabIndex = 12;
            this.button_stretchimage2.Text = "StretchImage Image 2";
            this.button_stretchimage2.UseVisualStyleBackColor = true;
            this.button_stretchimage2.Click += new System.EventHandler(this.button_stretchimage2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_stretchimage2);
            this.Controls.Add(this.button_Zoom2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_MostrarDuasImagens);
            this.Controls.Add(this.button_Apagar2);
            this.Controls.Add(this.button_Mostrar2);
            this.Controls.Add(this.button_ApagarTodo);
            this.Controls.Add(this.button_Apagar1);
            this.Controls.Add(this.button_Mostrar1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Trabalhando com imagens";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button_Mostrar1;
        private System.Windows.Forms.Button button_Apagar1;
        private System.Windows.Forms.Button button_ApagarTodo;
        private System.Windows.Forms.Button button_Mostrar2;
        private System.Windows.Forms.Button button_Apagar2;
        private System.Windows.Forms.Button button_MostrarDuasImagens;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Zoom2;
        private System.Windows.Forms.Button button_stretchimage2;
    }
}

