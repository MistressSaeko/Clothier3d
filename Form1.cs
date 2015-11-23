using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL4;
using OpenTK.Input;
using BulletSharp;
using BulletSharp.SoftBody;
using System.IO;

namespace _3DPatternMaker
{
    public partial class MainForm : Form
    {
        bool Loaded = false;
        double FieldOfView, FieldOfViewTan, Aspect;
        MouseState Current, Previous;
        

        private void SetupSceneView()
        {
            int Width = SceneView.Width;
            int Height = SceneView.Height;
            GL.Viewport(0, 0, Width, Height);
            
        }

        private void SetupPatternView()
        {
            int Width = PatternView.Width;
            int Height = PatternView.Height;
            GL.Viewport(0, 0, Width, Height);
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void SceneView_Resize(object sender, EventArgs e)
        {
            SetupSceneView();
            SceneView.Invalidate();
        }

        private void PatternView_Resize(object sender, EventArgs e)
        {
            SetupPatternView();
            PatternView.Invalidate();
        }

        private void SceneView_Load(object sender, EventArgs e)
        {
            Loaded = true;
            SetupSceneView();
            GL.ClearColor(Color.LightPink);
        }

        private void PatternView_Load(object sender, EventArgs e)
        {
            Loaded = true;
            SetupPatternView();
            GL.ClearColor(Color.LightPink);
        }

        private void importModelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
