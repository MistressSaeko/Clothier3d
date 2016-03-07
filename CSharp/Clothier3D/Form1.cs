using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL4;
using OpenTK.Platform.Windows;

namespace Clothier3D
{
    public partial class MainForm : Form
    {
        bool Loaded(false);

        private void SetupViewport()
        {
            int W = SceneView.Width;
            int H = SceneView.Height;
            
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog Mesh  = new OpenFileDialog();
            Mesh.Title           = "Load Mannequin";
            Mesh.Filter          = "Wavefront OBJ files (.obj)|*.obj";
            Mesh.CheckFileExists = true;
            Mesh.CheckPathExists = true;

            if (Mesh.ShowDialog(this) == DialogResult.OK)
            {
                // Parse OBJ file here and add it to the SceneView Pane and outline to the PatternView pane.
            }
        }
    }
}
