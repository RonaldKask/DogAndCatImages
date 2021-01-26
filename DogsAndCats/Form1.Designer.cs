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
            this.pictureCat = new System.Windows.Forms.PictureBox();
            this.GetACat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DogPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCat)).BeginInit();
            this.SuspendLayout();
            // 
            // DogPicture
            // 
            this.DogPicture.Location = new System.Drawing.Point(510, 29);
            this.DogPicture.Name = "DogPicture";
            this.DogPicture.Size = new System.Drawing.Size(262, 250);
            this.DogPicture.TabIndex = 0;
            this.DogPicture.TabStop = false;
            // 
            // GetADog
            // 
            this.GetADog.Location = new System.Drawing.Point(562, 303);
            this.GetADog.Name = "GetADog";
            this.GetADog.Size = new System.Drawing.Size(165, 66);
            this.GetADog.TabIndex = 1;
            this.GetADog.Text = "Get an image";
            this.GetADog.UseVisualStyleBackColor = true;
            this.GetADog.Click += new System.EventHandler(this.GetADog_Click);
            // 
            // pictureCat
            // 
            this.pictureCat.Location = new System.Drawing.Point(76, 29);
            this.pictureCat.Name = "pictureCat";
            this.pictureCat.Size = new System.Drawing.Size(262, 250);
            this.pictureCat.TabIndex = 2;
            this.pictureCat.TabStop = false;
            this.pictureCat.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // GetACat
            // 
            this.GetACat.Location = new System.Drawing.Point(116, 303);
            this.GetACat.Name = "GetACat";
            this.GetACat.Size = new System.Drawing.Size(165, 66);
            this.GetACat.TabIndex = 3;
            this.GetACat.Text = "Get an image";
            this.GetACat.UseVisualStyleBackColor = true;
            this.GetACat.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GetACat);
            this.Controls.Add(this.pictureCat);
            this.Controls.Add(this.GetADog);
            this.Controls.Add(this.DogPicture);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DogPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox DogPicture;
        private System.Windows.Forms.Button GetADog;
        private System.Windows.Forms.PictureBox pictureCat;
        private System.Windows.Forms.Button GetACat;
    }
}

