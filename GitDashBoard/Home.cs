using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibGit2Sharp;

namespace GitDashBoard
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CloneRepo cloneRepo = new CloneRepo();
            cloneRepo.ShowDialog();  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var repo = new Repository(@"C:\MergeRep\GitDashboard"))
            {
                TreeChanges changes = repo.Diff.Compare(repo.Head.Tip.Tree, DiffTarget.WorkingDirectory);  
            }
        }
    }
}
