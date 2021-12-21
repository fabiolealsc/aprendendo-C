using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class fLinkLabel : Form
    {
        public fLinkLabel()
        {
            InitializeComponent();
            llblMultiplosLink.Links.Add(0, 6,"http://google.com.br");
            llblMultiplosLink.Links.Add(9, 5, "http://youtube.com/cfbcursos");
            llblMultiplosLink.Links.Add(17, 7, "http://youtube.com");
        }

        private void llblCanal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://github.com//" + txtGit.Text);
            LinkLabel ll = (LinkLabel)sender;
            ll.LinkVisited = true;
        }

        private void llblCalculadora_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
            LinkLabel ll = (LinkLabel)sender;
            ll.LinkVisited = true;
        }

        private void llblMultiplosLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
            LinkLabel ll = (LinkLabel)sender;
            ll.LinkVisited = true;
        }

        private void llLikedin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://linkedin.com//" + txtGit.Text);
        }
    }
}
