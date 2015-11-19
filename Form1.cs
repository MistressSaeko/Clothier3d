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
using BulletSharp;
using BulletSharp.SoftBody;

namespace _3DPatternMaker
{
    public partial class MainForm : Form
    {

        bool Loaded = false;

        private void SetupSceneView()
        {
            int Width = SceneView.Width;
            int Height = SceneView.Height;
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(0, w, 0, h, -1, 1);
            GL.Viewport(0, 0, w, h);
        }

        private void SetupPatternView()
        {
            int Width = PatternView.Width;
            int Height = PatternView.Height;
            GL.



        public MainForm()
        {
            InitializeComponent();
        }
    }
}
