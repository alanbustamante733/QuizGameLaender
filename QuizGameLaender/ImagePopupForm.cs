using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGameLaender
{
    public partial class ImagePopupForm : Form
    {
        public ImagePopupForm()
        {
            InitializeComponent();
        }
        public void ShowPopup(Image image)
        {
            pictureBoxPopUp.Image = image;
            this.ShowDialog();
        }
    }
}
