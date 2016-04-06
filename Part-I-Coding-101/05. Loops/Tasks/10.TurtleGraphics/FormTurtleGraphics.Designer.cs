namespace TurtleGraphics
{
    public partial class FormTurtleGraphics
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            this.btnDraw = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnHideTurtle = new System.Windows.Forms.Button();
            this.btnHexagon = new System.Windows.Forms.Button();
            this.btnStar = new System.Windows.Forms.Button();
            this.btnSpiral = new System.Windows.Forms.Button();
            this.btnSun = new System.Windows.Forms.Button();
            this.btnTriangle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(23, 22);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(97, 35);
            this.btnDraw.TabIndex = 0;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(23, 76);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(97, 35);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnHideTurtle
            // 
            this.btnHideTurtle.Location = new System.Drawing.Point(23, 130);
            this.btnHideTurtle.Name = "btnHideTurtle";
            this.btnHideTurtle.Size = new System.Drawing.Size(97, 35);
            this.btnHideTurtle.TabIndex = 2;
            this.btnHideTurtle.Text = "Hide Turtle";
            this.btnHideTurtle.UseVisualStyleBackColor = true;
            this.btnHideTurtle.Click += new System.EventHandler(this.btnHideTurtle_Click);
            // 
            // btnHexagon
            // 
            this.btnHexagon.Location = new System.Drawing.Point(23, 184);
            this.btnHexagon.Name = "btnHexagon";
            this.btnHexagon.Size = new System.Drawing.Size(97, 35);
            this.btnHexagon.TabIndex = 3;
            this.btnHexagon.Text = "Hexagon";
            this.btnHexagon.UseVisualStyleBackColor = true;
            this.btnHexagon.Click += new System.EventHandler(this.btnHexagon_Click);
            // 
            // btnStar
            // 
            this.btnStar.Location = new System.Drawing.Point(23, 238);
            this.btnStar.Name = "btnStar";
            this.btnStar.Size = new System.Drawing.Size(97, 35);
            this.btnStar.TabIndex = 4;
            this.btnStar.Text = "Star";
            this.btnStar.UseVisualStyleBackColor = true;
            this.btnStar.Click += new System.EventHandler(this.btnStar_Click);
            // 
            // btnSpiral
            // 
            this.btnSpiral.Location = new System.Drawing.Point(23, 292);
            this.btnSpiral.Name = "btnSpiral";
            this.btnSpiral.Size = new System.Drawing.Size(97, 35);
            this.btnSpiral.TabIndex = 5;
            this.btnSpiral.Text = "Spiral";
            this.btnSpiral.UseVisualStyleBackColor = true;
            this.btnSpiral.Click += new System.EventHandler(this.btnSpiral_Click);
            // 
            // btnSun
            // 
            this.btnSun.Location = new System.Drawing.Point(23, 346);
            this.btnSun.Name = "btnSun";
            this.btnSun.Size = new System.Drawing.Size(97, 35);
            this.btnSun.TabIndex = 6;
            this.btnSun.Text = "Sun";
            this.btnSun.UseVisualStyleBackColor = true;
            this.btnSun.Click += new System.EventHandler(this.btnSun_Click);
            // 
            // btnTriangle
            // 
            this.btnTriangle.Location = new System.Drawing.Point(23, 400);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(97, 35);
            this.btnTriangle.TabIndex = 7;
            this.btnTriangle.Text = "Triangle";
            this.btnTriangle.UseVisualStyleBackColor = true;
            this.btnTriangle.Click += new System.EventHandler(this.btnTriangle_Click);
            // 
            // FormTurtleGraphics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 582);
            this.Controls.Add(this.btnTriangle);
            this.Controls.Add(this.btnSun);
            this.Controls.Add(this.btnSpiral);
            this.Controls.Add(this.btnStar);
            this.Controls.Add(this.btnHexagon);
            this.Controls.Add(this.btnHideTurtle);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDraw);
            this.Name = "FormTurtleGraphics";
            this.Text = "Turtle Graphics - Example";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnHideTurtle;
        private System.Windows.Forms.Button btnHexagon;
        private System.Windows.Forms.Button btnStar;
        private System.Windows.Forms.Button btnSpiral;
        private System.Windows.Forms.Button btnSun;
        private System.Windows.Forms.Button btnTriangle;
    }
}