namespace PrimeNumbersGenerator
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
            this.components = new System.ComponentModel.Container();
            this.startButton = new System.Windows.Forms.Button();
            this.LastCycleDataTextBox = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.showLastCycleDataButton = new System.Windows.Forms.Button();
            this.pathSelectionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(90, 70);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(177, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Uruchom obliczenie";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // LastCycleDataTextBox
            // 
            this.LastCycleDataTextBox.Location = new System.Drawing.Point(90, 151);
            this.LastCycleDataTextBox.Multiline = true;
            this.LastCycleDataTextBox.Name = "LastCycleDataTextBox";
            this.LastCycleDataTextBox.Size = new System.Drawing.Size(177, 126);
            this.LastCycleDataTextBox.TabIndex = 1;
            // 
            // timer
            // 
            this.timer.Interval = 60000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // showLastCycleDataButton
            // 
            this.showLastCycleDataButton.Enabled = false;
            this.showLastCycleDataButton.Location = new System.Drawing.Point(90, 99);
            this.showLastCycleDataButton.Name = "showLastCycleDataButton";
            this.showLastCycleDataButton.Size = new System.Drawing.Size(177, 46);
            this.showLastCycleDataButton.TabIndex = 2;
            this.showLastCycleDataButton.Text = "Wyświetl dane z ostaniego cyklu";
            this.showLastCycleDataButton.UseVisualStyleBackColor = true;
            this.showLastCycleDataButton.Click += new System.EventHandler(this.ShowLastCycleDataButton_Click);
            // 
            // pathSelectionButton
            // 
            this.pathSelectionButton.Location = new System.Drawing.Point(90, 39);
            this.pathSelectionButton.Name = "pathSelectionButton";
            this.pathSelectionButton.Size = new System.Drawing.Size(177, 25);
            this.pathSelectionButton.TabIndex = 3;
            this.pathSelectionButton.Text = "Wybierz ścieżkę zapisu pliku xml";
            this.pathSelectionButton.UseVisualStyleBackColor = true;
            this.pathSelectionButton.Click += new System.EventHandler(this.PathSelectionButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 348);
            this.Controls.Add(this.pathSelectionButton);
            this.Controls.Add(this.showLastCycleDataButton);
            this.Controls.Add(this.LastCycleDataTextBox);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "Generator liczb pierwszych";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox LastCycleDataTextBox;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button showLastCycleDataButton;
        private System.Windows.Forms.Button pathSelectionButton;
    }
}

