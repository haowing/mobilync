using System;   
using System.Data;
using System.ComponentModel;
using System.Windows.Forms;
namespace mobilync
{
    partial class HelloForm
    {
        Button btnTest;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "Hello Posten Form";
            this.Text = "Hello Posten!";

            btnTest = new Button();
            
        }

        #endregion

        private void layoutComponents() {
            btnTest.Name="testButton";
            btnTest.Location = new System.Drawing.Point(120,48);
            btnTest.Size = new System.Drawing.Size(160,32);
            btnTest.TabIndex = 0;
            btnTest.Text = "Click";

            this.Controls.Add(btnTest);// this.Controls.AddRange(new System.Windows.Forms.Control[] { this.btnTest });

        }

        private void configureComponents() {
            btnTest.Click += new System.EventHandler(this.btnTest); 

        }
    }


}