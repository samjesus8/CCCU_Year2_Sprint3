using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chatbot
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            keywordChecker KWC = new keywordChecker();

            KWC.WeatherInput(inputBox.Text, outputBox);
            
            KWC.WOTDInput(inputBox.Text, outputBox);


        }
    }
}
