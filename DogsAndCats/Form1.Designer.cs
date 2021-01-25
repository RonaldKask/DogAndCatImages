namespace DogsAndCats
{
    partial class Form1
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
            this.DogPicture = new System.Windows.Forms.PictureBox();
            this.GetADog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DogPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // DogPicture
            // 
            this.DogPicture.Location = new System.Drawing.Point(578, 29);
            this.DogPicture.Name = "DogPicture";
            this.DogPicture.Size = new System.Drawing.Size(210, 250);
            this.DogPicture.TabIndex = 0;
            this.DogPicture.TabStop = false;
            // 
            // GetADog
            // 
            this.GetADog.Location = new System.Drawing.Point(598, 304);
            this.GetADog.Name = "GetADog";
            this.GetADog.Size = new System.Drawing.Size(165, 66);
            this.GetADog.TabIndex = 1;
            this.GetADog.Text = "Get an image";
            this.GetADog.UseVisualStyleBackColor = true;
            this.GetADog.Click += new System.EventHandler(this.GetADog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GetADog);
            this.Controls.Add(this.DogPicture);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DogPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox DogPicture;
        private System.Windows.Forms.Button GetADog;
    }
}

