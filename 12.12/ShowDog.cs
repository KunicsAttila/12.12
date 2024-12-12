using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12._12
{
    class ShowDog : UserControl
    {
        private Button button1;
        private Label label1;

        public Dog oneDog { get; set; }
        public ShowDog(Dog oneDog)
        {
            InitializeComponent();
            this.oneDog = oneDog;
            label1.Text += oneDog.name;
            button1.Click += BarkButtonEvent;
        }
        void BarkButtonEvent(Object s, EventArgs e)
        {
            oneDog.Bark();
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ugat";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ShowDog
            // 
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "ShowDog";
            this.Size = new System.Drawing.Size(232, 57);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
