using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL4;
using OpenTK.Platform.Windows;
using OpenTK.Input;

namespace Clothier3D
{
    public partial class MainForm : Form
    {
        private bool IsLoaded;

        

        public MainForm()
        {
            InitializeComponent();
        }

        private void SceneView_Load(object sender, EventArgs e)
        {
            GL.ClearColor(0.5f, 0.5f, 1.0f, 1.0f);
            GL.Enable(EnableCap.DepthTest);

            IsLoaded = true;

            SceneView.Invalidate();
        }

        private void SceneView_Resize(object sender, EventArgs e)
        {
            if (!IsLoaded)
                return;

            GL.Viewport(0, 0, SceneView.Width, SceneView.Height);

            SceneView.Invalidate();
        }

        private void SceneView_Paint(object sender, PaintEventArgs e)
        {
            if (!IsLoaded)
                return;

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            SceneView.SwapBuffers();
        }

        private void PatternView_Load(object sender, EventArgs e)
        {
            GL.ClearColor(0.5f, 0.5f, 1.0f, 1.0f);
            GL.Enable(EnableCap.DepthTest);

            IsLoaded = true;

            SceneView.Invalidate();
        }

        private void PatternView_Resize(object sender, EventArgs e)
        {
            if (!IsLoaded)
                return;

            GL.Viewport(0, 0, PatternView.Width, PatternView.Height);

            SceneView.Invalidate();
        }

        private void PatternView_Paint(object sender, PaintEventArgs e)
        {
            if (!IsLoaded)
                return;

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            SceneView.SwapBuffers();
        }
    }
}
