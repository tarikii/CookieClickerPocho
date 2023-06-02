namespace CutiClicker
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonCookie = new Button();
            labelCookies = new Label();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // buttonCookie
            // 
            buttonCookie.BackColor = Color.Transparent;
            buttonCookie.BackgroundImage = (Image)resources.GetObject("buttonCookie.BackgroundImage");
            buttonCookie.BackgroundImageLayout = ImageLayout.Stretch;
            buttonCookie.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            buttonCookie.FlatAppearance.BorderSize = 0;
            buttonCookie.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 0, 0);
            buttonCookie.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 0, 0);
            buttonCookie.FlatStyle = FlatStyle.Flat;
            buttonCookie.Location = new Point(131, 88);
            buttonCookie.Name = "buttonCookie";
            buttonCookie.Size = new Size(372, 278);
            buttonCookie.TabIndex = 0;
            buttonCookie.UseVisualStyleBackColor = false;
            buttonCookie.Click += buttonCookie_Click;
            // 
            // labelCookies
            // 
            labelCookies.AutoSize = true;
            labelCookies.BackColor = Color.Transparent;
            labelCookies.Font = new Font("Segoe UI Symbol", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelCookies.ForeColor = Color.WhiteSmoke;
            labelCookies.Location = new Point(241, 52);
            labelCookies.Name = "labelCookies";
            labelCookies.Size = new Size(157, 40);
            labelCookies.TabIndex = 1;
            labelCookies.Text = "Cookies: 0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Symbol", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(12, 30);
            label2.Name = "label2";
            label2.Size = new Size(149, 30);
            label2.TabIndex = 2;
            label2.Text = "Suicide in: 20";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(643, 450);
            Controls.Add(label2);
            Controls.Add(labelCookies);
            Controls.Add(buttonCookie);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCookie;
        private Label labelCookies;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}