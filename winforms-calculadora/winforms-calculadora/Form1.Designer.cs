namespace winforms_calculadora
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
            input_n2 = new TextBox();
            input_n1 = new TextBox();
            button1 = new Button();
            resultado_output = new TextBox();
            resultado = new Label();
            resta = new Button();
            multiplicacion = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // input_n2
            // 
            input_n2.Location = new Point(46, 26);
            input_n2.Name = "input_n2";
            input_n2.Size = new Size(100, 23);
            input_n2.TabIndex = 0;
            input_n2.TextChanged += textBox1_TextChanged;
            // 
            // input_n1
            // 
            input_n1.Location = new Point(46, 73);
            input_n1.Name = "input_n1";
            input_n1.Size = new Size(100, 23);
            input_n1.TabIndex = 1;
            input_n1.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(46, 126);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "sumar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // resultado_output
            // 
            resultado_output.Location = new Point(46, 401);
            resultado_output.Name = "resultado_output";
            resultado_output.Size = new Size(100, 23);
            resultado_output.TabIndex = 3;
            // 
            // resultado
            // 
            resultado.AutoSize = true;
            resultado.Location = new Point(46, 383);
            resultado.Name = "resultado";
            resultado.Size = new Size(56, 15);
            resultado.TabIndex = 4;
            resultado.Text = "resultado";
            // 
            // resta
            // 
            resta.Location = new Point(143, 126);
            resta.Name = "resta";
            resta.Size = new Size(75, 23);
            resta.TabIndex = 5;
            resta.Text = "restar";
            resta.UseVisualStyleBackColor = true;
            resta.Click += resta_Click;
            // 
            // multiplicacion
            // 
            multiplicacion.Location = new Point(236, 126);
            multiplicacion.Name = "multiplicacion";
            multiplicacion.Size = new Size(75, 23);
            multiplicacion.TabIndex = 6;
            multiplicacion.Text = "multiplicacion";
            multiplicacion.UseVisualStyleBackColor = true;
            multiplicacion.Click += multiplicacion_Click;
            // 
            // button2
            // 
            button2.Location = new Point(46, 170);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "divicion";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(161, 400);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 8;
            button3.Text = "reset";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(405, 460);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(multiplicacion);
            Controls.Add(resta);
            Controls.Add(resultado);
            Controls.Add(resultado_output);
            Controls.Add(button1);
            Controls.Add(input_n1);
            Controls.Add(input_n2);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private TextBox input_n2;
        private TextBox input_n1;
        private Button button1;
        private TextBox resultado_output;
        private Label resultado;
        private Button resta;
        private Button multiplicacion;
        private Button button2;
        private Button button3;
    }
}
