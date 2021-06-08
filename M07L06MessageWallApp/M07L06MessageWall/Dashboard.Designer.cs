
namespace M07L06MessageWall
{
    partial class Dashboard
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
            this.helloWorldButton = new System.Windows.Forms.Button();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.goodByeLable = new System.Windows.Forms.Label();
            this.goodByButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // helloWorldButton
            // 
            this.helloWorldButton.Location = new System.Drawing.Point(169, 279);
            this.helloWorldButton.Name = "helloWorldButton";
            this.helloWorldButton.Size = new System.Drawing.Size(132, 35);
            this.helloWorldButton.TabIndex = 0;
            this.helloWorldButton.Tag = "1234";
            this.helloWorldButton.Text = "Hello World";
            this.helloWorldButton.UseVisualStyleBackColor = true;
            this.helloWorldButton.Click += new System.EventHandler(this.HelloWorldButton_Click);
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(312, 222);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(220, 28);
            this.firstNameText.TabIndex = 1;
            // 
            // goodByeLable
            // 
            this.goodByeLable.AutoSize = true;
            this.goodByeLable.Location = new System.Drawing.Point(166, 232);
            this.goodByeLable.Name = "goodByeLable";
            this.goodByeLable.Size = new System.Drawing.Size(98, 18);
            this.goodByeLable.TabIndex = 2;
            this.goodByeLable.Text = "First Name";
            // 
            // goodByButton
            // 
            this.goodByButton.Location = new System.Drawing.Point(320, 279);
            this.goodByButton.Name = "goodByButton";
            this.goodByButton.Size = new System.Drawing.Size(92, 35);
            this.goodByButton.TabIndex = 3;
            this.goodByButton.Text = "Good Bye";
            this.goodByButton.UseVisualStyleBackColor = true;
            this.goodByButton.Click += new System.EventHandler(this.GoodByButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.goodByButton);
            this.Controls.Add(this.goodByeLable);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.helloWorldButton);
            this.Name = "Dashboard";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button helloWorldButton;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.Label goodByeLable;
        private System.Windows.Forms.Button goodByButton;
    }
}

