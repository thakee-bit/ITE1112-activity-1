namespace WinFormsApp1
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
			labelNumber1 = new Label();
			labelNumber2 = new Label();
			labelResult = new Label();
			txtBoxNumber1 = new TextBox();
			txtBoxNumber2 = new TextBox();
			txtBoxResult = new TextBox();
			sumButton = new Button();
			errorProvider = new ErrorProvider(components);
			((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			labelNumber1.AutoSize = true;
			labelNumber1.Location = new Point(12, 33);
			labelNumber1.Name = "label1";
			labelNumber1.Size = new Size(60, 15);
			labelNumber1.TabIndex = 0;
			labelNumber1.Text = "Number 1";
			// 
			// label2
			// 
			labelNumber2.AutoSize = true;
			labelNumber2.Location = new Point(12, 64);
			labelNumber2.Name = "label2";
			labelNumber2.Size = new Size(60, 15);
			labelNumber2.TabIndex = 1;
			labelNumber2.Text = "Number 2";
			// 
			// label3
			// 
			labelResult.AutoSize = true;
			labelResult.Location = new Point(12, 96);
			labelResult.Name = "label3";
			labelResult.Size = new Size(39, 15);
			labelResult.TabIndex = 2;
			labelResult.Text = "Result";
			// 
			// txtBoxNumber1
			// 
			txtBoxNumber1.Location = new Point(99, 33);
			txtBoxNumber1.Name = "txtBoxNumber1";
			txtBoxNumber1.Size = new Size(208, 23);
			txtBoxNumber1.TabIndex = 3;
			txtBoxNumber1.Text = "0";
			txtBoxNumber1.Validating += txtBox1Validating;
			// 
			// txtBoxNumber2
			// 
			txtBoxNumber2.Location = new Point(99, 64);
			txtBoxNumber2.Name = "txtBoxNumber2";
			txtBoxNumber2.Size = new Size(208, 23);
			txtBoxNumber2.TabIndex = 4;
			txtBoxNumber2.Text = "0";
			txtBoxNumber2.Validating += txtBox2Validating;
			// 
			// txtBoxResult
			// 
			txtBoxResult.Location = new Point(99, 96);
			txtBoxResult.Name = "txtBoxResult";
			txtBoxResult.Size = new Size(208, 23);
			txtBoxResult.TabIndex = 5;
			txtBoxResult.Text = "0";
			// 
			// button1
			// 
			sumButton.Location = new Point(99, 141);
			sumButton.Name = "button1";
			sumButton.Size = new Size(208, 23);
			sumButton.TabIndex = 6;
			sumButton.Text = "Sum";
			sumButton.UseVisualStyleBackColor = true;
			sumButton.Click += sumButton_Click;
			// 
			// errorProvider
			// 
			errorProvider.ContainerControl = this;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(339, 184);
			Controls.Add(sumButton);
			Controls.Add(txtBoxResult);
			Controls.Add(txtBoxNumber2);
			Controls.Add(txtBoxNumber1);
			Controls.Add(labelResult);
			Controls.Add(labelNumber2);
			Controls.Add(labelNumber1);
			Name = "Form1";
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label labelNumber1;
		private Label labelNumber2;
		private Label labelResult;
		private TextBox txtBoxNumber1;
		private TextBox txtBoxNumber2;
		private TextBox txtBoxResult;
		private Button sumButton;
		private ErrorProvider errorProvider;
	}
}