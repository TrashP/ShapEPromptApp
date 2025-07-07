using System;
using System.Windows.Forms;

namespace ShapEPromptApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string prompt = txtPrompt.Text.Trim();
            if (string.IsNullOrEmpty(prompt))
            {
                lblResult.Text = "Please enter a prompt.";
            }
            else
            {
                lblResult.Text = $"Generating 3D model for: {prompt}";
                // Future integration: Call Shap-E pipeline here with the prompt.
            }
        }
    }
}