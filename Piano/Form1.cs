using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleLoans.Tools;

namespace Piano
{
    public partial class Piano : Form
    {
        public Piano()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void A3_Click(object sender, EventArgs e)
        {
            
        }

        private void A3s_Click(object sender, EventArgs e)
        {
            Sound.Play(Note.A3s);
        }

        private void B3_Click(object sender, EventArgs e)
        {
            Sound.Play(Note.B3);
        }

        private void C4_Click(object sender, EventArgs e)
        {
            Sound.Play(Note.C4);
        }

        private void C4s_Click(object sender, EventArgs e)
        {
            Sound.Play(Note.C4s);
        }

        private void D4_Click(object sender, EventArgs e)
        {
            Sound.Play(Note.D4);
        }

        private void D4s_Click(object sender, EventArgs e)
        {
            Sound.Play(Note.D4s);
        }

        private void E4_Click(object sender, EventArgs e)
        {
            Sound.Play(Note.E4);
        }

        private void F4_Click(object sender, EventArgs e)
        {
            Sound.Play(Note.F4);
        }

        private void F4s_Click(object sender, EventArgs e)
        {
            Sound.Play(Note.F4s);
        }

        private void G4_Click(object sender, EventArgs e)
        {
            Sound.Play(Note.G4);
        }

        private void G4s_Click(object sender, EventArgs e)
        {
            Sound.Play(Note.G4s);
        }

        private void A4_Click(object sender, EventArgs e)
        {
            Sound.Play(Note.A4);
        }

        private void A4s_Click(object sender, EventArgs e)
        {
            Sound.Play(Note.A4s);
        }

        private void B4_Click(object sender, EventArgs e)
        {
            Sound.Play(Note.B4);
        }

        private void C5_Click(object sender, EventArgs e)
        {
            Sound.Play(Note.C5);
        }
    }
}
