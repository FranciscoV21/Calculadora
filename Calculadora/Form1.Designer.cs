namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
            //bENFEF
            //Hola Jair wuu hola x2
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Igual = new System.Windows.Forms.Button();
            this.suma = new System.Windows.Forms.Button();
            this.resta = new System.Windows.Forms.Button();
            this.multiplicacion = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.nueve = new System.Windows.Forms.Button();
            this.ocho = new System.Windows.Forms.Button();
            this.siete = new System.Windows.Forms.Button();
            this.chexa = new System.Windows.Forms.Button();
            this.seis = new System.Windows.Forms.Button();
            this.cinco = new System.Windows.Forms.Button();
            this.cuatro = new System.Windows.Forms.Button();
            this.tres = new System.Windows.Forms.Button();
            this.dos = new System.Windows.Forms.Button();
            this.uno = new System.Windows.Forms.Button();
            this.punto = new System.Windows.Forms.Button();
            this.cero = new System.Windows.Forms.Button();
            this.dhexa = new System.Windows.Forms.Button();
            this.ehexa = new System.Windows.Forms.Button();
            this.fhexa = new System.Windows.Forms.Button();
            this.bhexa = new System.Windows.Forms.Button();
            this.ahexa = new System.Windows.Forms.Button();
            this.borrar = new System.Windows.Forms.Button();
            this.operaciones = new System.Windows.Forms.TextBox();
            this.resultado = new System.Windows.Forms.TextBox();
            this.hexa = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Igual
            // 
            this.Igual.Location = new System.Drawing.Point(363, 643);
            this.Igual.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Igual.Name = "Igual";
            this.Igual.Size = new System.Drawing.Size(104, 35);
            this.Igual.TabIndex = 0;
            this.Igual.Text = "=";
            this.Igual.UseVisualStyleBackColor = true;
            this.Igual.Click += new System.EventHandler(this.Numero_Click);
            // 
            // suma
            // 
            this.suma.Location = new System.Drawing.Point(363, 577);
            this.suma.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(104, 35);
            this.suma.TabIndex = 1;
            this.suma.Text = " + ";
            this.suma.UseVisualStyleBackColor = true;
            this.suma.Click += new System.EventHandler(this.Numero_Click);
            // 
            // resta
            // 
            this.resta.Location = new System.Drawing.Point(363, 517);
            this.resta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resta.Name = "resta";
            this.resta.Size = new System.Drawing.Size(104, 35);
            this.resta.TabIndex = 2;
            this.resta.Text = " - ";
            this.resta.UseVisualStyleBackColor = true;
            this.resta.Click += new System.EventHandler(this.Numero_Click);
            // 
            // multiplicacion
            // 
            this.multiplicacion.Location = new System.Drawing.Point(363, 457);
            this.multiplicacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.multiplicacion.Name = "multiplicacion";
            this.multiplicacion.Size = new System.Drawing.Size(104, 35);
            this.multiplicacion.TabIndex = 3;
            this.multiplicacion.Text = " x ";
            this.multiplicacion.UseVisualStyleBackColor = true;
            this.multiplicacion.Click += new System.EventHandler(this.Numero_Click);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(363, 397);
            this.division.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(104, 35);
            this.division.TabIndex = 4;
            this.division.Text = " / ";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.Numero_Click);
            // 
            // nueve
            // 
            this.nueve.Location = new System.Drawing.Point(270, 457);
            this.nueve.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nueve.Name = "nueve";
            this.nueve.Size = new System.Drawing.Size(84, 35);
            this.nueve.TabIndex = 5;
            this.nueve.Text = "9";
            this.nueve.UseVisualStyleBackColor = true;
            this.nueve.Click += new System.EventHandler(this.Numero_Click);
            // 
            // ocho
            // 
            this.ocho.Location = new System.Drawing.Point(177, 457);
            this.ocho.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ocho.Name = "ocho";
            this.ocho.Size = new System.Drawing.Size(84, 35);
            this.ocho.TabIndex = 6;
            this.ocho.Text = "8";
            this.ocho.UseVisualStyleBackColor = true;
            this.ocho.Click += new System.EventHandler(this.Numero_Click);
            // 
            // siete
            // 
            this.siete.Location = new System.Drawing.Point(84, 457);
            this.siete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.siete.Name = "siete";
            this.siete.Size = new System.Drawing.Size(84, 35);
            this.siete.TabIndex = 7;
            this.siete.Text = "7";
            this.siete.UseVisualStyleBackColor = true;
            this.siete.Click += new System.EventHandler(this.Numero_Click);
            // 
            // chexa
            // 
            this.chexa.Location = new System.Drawing.Point(4, 457);
            this.chexa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chexa.Name = "chexa";
            this.chexa.Size = new System.Drawing.Size(70, 35);
            this.chexa.TabIndex = 8;
            this.chexa.Text = "C";
            this.chexa.UseVisualStyleBackColor = true;
            this.chexa.Click += new System.EventHandler(this.Numero_Click);
            // 
            // seis
            // 
            this.seis.Location = new System.Drawing.Point(270, 517);
            this.seis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.seis.Name = "seis";
            this.seis.Size = new System.Drawing.Size(84, 35);
            this.seis.TabIndex = 9;
            this.seis.Text = "6";
            this.seis.UseVisualStyleBackColor = true;
            this.seis.Click += new System.EventHandler(this.Numero_Click);
            // 
            // cinco
            // 
            this.cinco.Location = new System.Drawing.Point(177, 517);
            this.cinco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cinco.Name = "cinco";
            this.cinco.Size = new System.Drawing.Size(84, 35);
            this.cinco.TabIndex = 10;
            this.cinco.Text = "5";
            this.cinco.UseVisualStyleBackColor = true;
            this.cinco.Click += new System.EventHandler(this.Numero_Click);
            // 
            // cuatro
            // 
            this.cuatro.Location = new System.Drawing.Point(84, 517);
            this.cuatro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cuatro.Name = "cuatro";
            this.cuatro.Size = new System.Drawing.Size(84, 35);
            this.cuatro.TabIndex = 11;
            this.cuatro.Text = "4";
            this.cuatro.UseVisualStyleBackColor = true;
            this.cuatro.Click += new System.EventHandler(this.Numero_Click);
            // 
            // tres
            // 
            this.tres.Location = new System.Drawing.Point(270, 577);
            this.tres.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tres.Name = "tres";
            this.tres.Size = new System.Drawing.Size(84, 35);
            this.tres.TabIndex = 12;
            this.tres.Text = "3";
            this.tres.UseVisualStyleBackColor = true;
            this.tres.Click += new System.EventHandler(this.Numero_Click);
            // 
            // dos
            // 
            this.dos.Location = new System.Drawing.Point(177, 577);
            this.dos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dos.Name = "dos";
            this.dos.Size = new System.Drawing.Size(84, 35);
            this.dos.TabIndex = 13;
            this.dos.Text = "2";
            this.dos.UseVisualStyleBackColor = true;
            this.dos.Click += new System.EventHandler(this.Numero_Click);
            // 
            // uno
            // 
            this.uno.Location = new System.Drawing.Point(84, 577);
            this.uno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uno.Name = "uno";
            this.uno.Size = new System.Drawing.Size(84, 35);
            this.uno.TabIndex = 14;
            this.uno.Text = "1";
            this.uno.UseVisualStyleBackColor = true;
            this.uno.Click += new System.EventHandler(this.Numero_Click);
            // 
            // punto
            // 
            this.punto.Location = new System.Drawing.Point(270, 643);
            this.punto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.punto.Name = "punto";
            this.punto.Size = new System.Drawing.Size(84, 35);
            this.punto.TabIndex = 15;
            this.punto.Text = ".";
            this.punto.UseVisualStyleBackColor = true;
            this.punto.Click += new System.EventHandler(this.Numero_Click);
            // 
            // cero
            // 
            this.cero.Location = new System.Drawing.Point(177, 643);
            this.cero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cero.Name = "cero";
            this.cero.Size = new System.Drawing.Size(84, 35);
            this.cero.TabIndex = 16;
            this.cero.Text = "0";
            this.cero.UseVisualStyleBackColor = true;
            this.cero.Click += new System.EventHandler(this.Numero_Click);
            // 
            // dhexa
            // 
            this.dhexa.Location = new System.Drawing.Point(4, 517);
            this.dhexa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dhexa.Name = "dhexa";
            this.dhexa.Size = new System.Drawing.Size(70, 35);
            this.dhexa.TabIndex = 17;
            this.dhexa.Text = "D";
            this.dhexa.UseVisualStyleBackColor = true;
            this.dhexa.Click += new System.EventHandler(this.Numero_Click);
            // 
            // ehexa
            // 
            this.ehexa.Location = new System.Drawing.Point(4, 577);
            this.ehexa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ehexa.Name = "ehexa";
            this.ehexa.Size = new System.Drawing.Size(70, 35);
            this.ehexa.TabIndex = 18;
            this.ehexa.Text = "E";
            this.ehexa.UseVisualStyleBackColor = true;
            this.ehexa.Click += new System.EventHandler(this.Numero_Click);
            // 
            // fhexa
            // 
            this.fhexa.Location = new System.Drawing.Point(4, 643);
            this.fhexa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fhexa.Name = "fhexa";
            this.fhexa.Size = new System.Drawing.Size(70, 35);
            this.fhexa.TabIndex = 19;
            this.fhexa.Text = "F";
            this.fhexa.UseVisualStyleBackColor = true;
            this.fhexa.Click += new System.EventHandler(this.Numero_Click);
            // 
            // bhexa
            // 
            this.bhexa.Location = new System.Drawing.Point(4, 397);
            this.bhexa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bhexa.Name = "bhexa";
            this.bhexa.Size = new System.Drawing.Size(70, 35);
            this.bhexa.TabIndex = 20;
            this.bhexa.Text = "B";
            this.bhexa.UseVisualStyleBackColor = true;
            this.bhexa.Click += new System.EventHandler(this.Numero_Click);
            // 
            // ahexa
            // 
            this.ahexa.Location = new System.Drawing.Point(4, 338);
            this.ahexa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ahexa.Name = "ahexa";
            this.ahexa.Size = new System.Drawing.Size(70, 35);
            this.ahexa.TabIndex = 21;
            this.ahexa.Text = "A";
            this.ahexa.UseVisualStyleBackColor = true;
            this.ahexa.Click += new System.EventHandler(this.Numero_Click);
            // 
            // borrar
            // 
            this.borrar.Location = new System.Drawing.Point(363, 338);
            this.borrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(104, 35);
            this.borrar.TabIndex = 22;
            this.borrar.Text = "Borrar";
            this.borrar.UseVisualStyleBackColor = true;
            this.borrar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // operaciones
            // 
            this.operaciones.Location = new System.Drawing.Point(18, 69);
            this.operaciones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.operaciones.Name = "operaciones";
            this.operaciones.Size = new System.Drawing.Size(422, 26);
            this.operaciones.TabIndex = 23;
            // 
            // resultado
            // 
            this.resultado.Location = new System.Drawing.Point(18, 137);
            this.resultado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(422, 26);
            this.resultado.TabIndex = 24;
            // 
            // hexa
            // 
            this.hexa.Location = new System.Drawing.Point(84, 397);
            this.hexa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hexa.Name = "hexa";
            this.hexa.Size = new System.Drawing.Size(120, 35);
            this.hexa.TabIndex = 25;
            this.hexa.Text = "Hexadecimal";
            this.hexa.UseVisualStyleBackColor = true;
            this.hexa.Click += new System.EventHandler(this.hexa_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(226, 397);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 35);
            this.button2.TabIndex = 26;
            this.button2.Text = "Binario";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 712);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.hexa);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.operaciones);
            this.Controls.Add(this.borrar);
            this.Controls.Add(this.ahexa);
            this.Controls.Add(this.bhexa);
            this.Controls.Add(this.fhexa);
            this.Controls.Add(this.ehexa);
            this.Controls.Add(this.dhexa);
            this.Controls.Add(this.cero);
            this.Controls.Add(this.punto);
            this.Controls.Add(this.uno);
            this.Controls.Add(this.dos);
            this.Controls.Add(this.tres);
            this.Controls.Add(this.cuatro);
            this.Controls.Add(this.cinco);
            this.Controls.Add(this.seis);
            this.Controls.Add(this.chexa);
            this.Controls.Add(this.siete);
            this.Controls.Add(this.ocho);
            this.Controls.Add(this.nueve);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multiplicacion);
            this.Controls.Add(this.resta);
            this.Controls.Add(this.suma);
            this.Controls.Add(this.Igual);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Igual;
        private System.Windows.Forms.Button suma;
        private System.Windows.Forms.Button resta;
        private System.Windows.Forms.Button multiplicacion;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button nueve;
        private System.Windows.Forms.Button ocho;
        private System.Windows.Forms.Button siete;
        private System.Windows.Forms.Button chexa;
        private System.Windows.Forms.Button seis;
        private System.Windows.Forms.Button cinco;
        private System.Windows.Forms.Button cuatro;
        private System.Windows.Forms.Button tres;
        private System.Windows.Forms.Button dos;
        private System.Windows.Forms.Button uno;
        private System.Windows.Forms.Button punto;
        private System.Windows.Forms.Button cero;
        private System.Windows.Forms.Button dhexa;
        private System.Windows.Forms.Button ehexa;
        private System.Windows.Forms.Button fhexa;
        private System.Windows.Forms.Button bhexa;
        private System.Windows.Forms.Button ahexa;
        private System.Windows.Forms.Button borrar;
        private System.Windows.Forms.TextBox operaciones;
        private System.Windows.Forms.TextBox resultado;
        private System.Windows.Forms.Button hexa;
        private System.Windows.Forms.Button button2;
    }
}

