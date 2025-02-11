namespace WinFormsApp
{
    partial class LabelDialogBox
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label3 = new Label();
            MsSerifRadioButton = new RadioButton();
            arialRadioButton = new RadioButton();
            timesNewRomanRadioButton = new RadioButton();
            tabPage2 = new TabPage();
            pickColorButton = new Button();
            tabPage3 = new TabPage();
            largeSizeRadioButton = new RadioButton();
            mediumSizeRadioButton = new RadioButton();
            smallSizeRadioButton = new RadioButton();
            tabPage4 = new TabPage();
            label2 = new Label();
            label1 = new Label();
            newTextBox = new TextBox();
            currTextBox = new TextBox();
            okButton = new Button();
            cancelButton = new Button();
            colorDialog1 = new ColorDialog();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(56, 41);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(656, 321);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(MsSerifRadioButton);
            tabPage1.Controls.Add(arialRadioButton);
            tabPage1.Controls.Add(timesNewRomanRadioButton);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(648, 288);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Font";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 17F);
            label3.Location = new Point(256, 20);
            label3.Name = "label3";
            label3.Size = new Size(150, 40);
            label3.TabIndex = 3;
            label3.Text = "Pick a font";
            // 
            // MsSerifRadioButton
            // 
            MsSerifRadioButton.AutoSize = true;
            MsSerifRadioButton.Location = new Point(256, 138);
            MsSerifRadioButton.Name = "MsSerifRadioButton";
            MsSerifRadioButton.Size = new Size(161, 24);
            MsSerifRadioButton.TabIndex = 2;
            MsSerifRadioButton.TabStop = true;
            MsSerifRadioButton.Text = "Microsoft Sans Serif";
            MsSerifRadioButton.UseVisualStyleBackColor = true;
            // 
            // arialRadioButton
            // 
            arialRadioButton.AutoSize = true;
            arialRadioButton.Location = new Point(256, 108);
            arialRadioButton.Name = "arialRadioButton";
            arialRadioButton.Size = new Size(61, 24);
            arialRadioButton.TabIndex = 1;
            arialRadioButton.TabStop = true;
            arialRadioButton.Text = "Arial";
            arialRadioButton.UseVisualStyleBackColor = true;
            // 
            // timesNewRomanRadioButton
            // 
            timesNewRomanRadioButton.AutoSize = true;
            timesNewRomanRadioButton.Location = new Point(256, 78);
            timesNewRomanRadioButton.Name = "timesNewRomanRadioButton";
            timesNewRomanRadioButton.Size = new Size(154, 24);
            timesNewRomanRadioButton.TabIndex = 0;
            timesNewRomanRadioButton.TabStop = true;
            timesNewRomanRadioButton.Text = "Times New Roman";
            timesNewRomanRadioButton.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(pickColorButton);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(648, 288);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Color";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // pickColorButton
            // 
            pickColorButton.Location = new Point(255, 86);
            pickColorButton.Name = "pickColorButton";
            pickColorButton.Size = new Size(126, 91);
            pickColorButton.TabIndex = 0;
            pickColorButton.Text = "Pick a Color";
            pickColorButton.UseVisualStyleBackColor = true;
            pickColorButton.Click += button3_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(largeSizeRadioButton);
            tabPage3.Controls.Add(mediumSizeRadioButton);
            tabPage3.Controls.Add(smallSizeRadioButton);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(648, 288);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Size";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // largeSizeRadioButton
            // 
            largeSizeRadioButton.AutoSize = true;
            largeSizeRadioButton.Location = new Point(289, 62);
            largeSizeRadioButton.Name = "largeSizeRadioButton";
            largeSizeRadioButton.Size = new Size(46, 24);
            largeSizeRadioButton.TabIndex = 2;
            largeSizeRadioButton.TabStop = true;
            largeSizeRadioButton.Text = "24";
            largeSizeRadioButton.UseVisualStyleBackColor = true;
            // 
            // mediumSizeRadioButton
            // 
            mediumSizeRadioButton.AutoSize = true;
            mediumSizeRadioButton.Location = new Point(289, 92);
            mediumSizeRadioButton.Name = "mediumSizeRadioButton";
            mediumSizeRadioButton.Size = new Size(46, 24);
            mediumSizeRadioButton.TabIndex = 1;
            mediumSizeRadioButton.TabStop = true;
            mediumSizeRadioButton.Text = "16";
            mediumSizeRadioButton.UseVisualStyleBackColor = true;
            // 
            // smallSizeRadioButton
            // 
            smallSizeRadioButton.AutoSize = true;
            smallSizeRadioButton.Location = new Point(289, 122);
            smallSizeRadioButton.Name = "smallSizeRadioButton";
            smallSizeRadioButton.Size = new Size(46, 24);
            smallSizeRadioButton.TabIndex = 0;
            smallSizeRadioButton.TabStop = true;
            smallSizeRadioButton.Text = "12";
            smallSizeRadioButton.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(label2);
            tabPage4.Controls.Add(label1);
            tabPage4.Controls.Add(newTextBox);
            tabPage4.Controls.Add(currTextBox);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(648, 288);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Text";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(222, 121);
            label2.Name = "label2";
            label2.Size = new Size(117, 20);
            label2.TabIndex = 3;
            label2.Text = "Enter a new Text";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(222, 60);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 2;
            label1.Text = "Current text";
            // 
            // newTextBox
            // 
            newTextBox.Location = new Point(222, 144);
            newTextBox.Name = "newTextBox";
            newTextBox.Size = new Size(196, 27);
            newTextBox.TabIndex = 1;
            // 
            // currTextBox
            // 
            currTextBox.Enabled = false;
            currTextBox.Location = new Point(222, 83);
            currTextBox.Name = "currTextBox";
            currTextBox.Size = new Size(196, 27);
            currTextBox.TabIndex = 0;
            // 
            // okButton
            // 
            okButton.Location = new Point(591, 390);
            okButton.Name = "okButton";
            okButton.Size = new Size(94, 29);
            okButton.TabIndex = 1;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += button1_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(694, 390);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(94, 29);
            cancelButton.TabIndex = 2;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += button2_Click;
            // 
            // LabelDialogBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Controls.Add(tabControl1);
            Name = "LabelDialogBox";
            Text = "Company Label Customization";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private RadioButton MsSerifRadioButton;
        private RadioButton arialRadioButton;
        private RadioButton timesNewRomanRadioButton;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Button okButton;
        private Button cancelButton;
        private Button pickColorButton;
        private ColorDialog colorDialog1;
        private RadioButton largeSizeRadioButton;
        private RadioButton mediumSizeRadioButton;
        private RadioButton smallSizeRadioButton;
        private Label label1;
        private TextBox newTextBox;
        private TextBox currTextBox;
        private Label label3;
        private Label label2;
    }
}