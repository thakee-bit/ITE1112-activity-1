namespace WinFormsApp1
{
	public partial class Form1 : Form
	{

		public Form1()
		{
			InitializeComponent();
			txtBoxResult.ReadOnly = true;
		}

		private void txtBoxValidating(TextBox txtBox)
		{
			errorProvider.SetError(txtBox, "");
			if (!int.TryParse(txtBox.Text, out int validation))
			{
				errorProvider.SetError(txtBox, "Invalid integer.");
			}
		}

		private void txtBox1Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			txtBoxValidating(txtBoxNumber1);
		}

		private void txtBox2Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			txtBoxValidating(txtBoxNumber2);
		}

		private void sumButton_Click(object sender, EventArgs e)
		{
			try
			{
				if (ValidateChildren(ValidationConstraints.Enabled))
				{
					int number1 = int.Parse(txtBoxNumber1.Text);
					int number2 = int.Parse(txtBoxNumber2.Text);
					txtBoxResult.Text = (number1 + number2).ToString();
				}
			} catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}