using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using OpenTK;
using OpenTK.Graphics.OpenGL4;

namespace Clothier3D
{
    class Shader
    {
        public readonly int Handle;

        private readonly Dictionary<string, int> keyValuePairs;

        public Shader(string VertPath, string FragPath)
        {
            var ShaderSource = LoadSource(VertPath);
            var VertexShader = GL.CreateShader(ShaderType.VertexShader);
            GL.ShaderSource(VertexShader, ShaderSource);
            CompileShader(VertexShader);

            ShaderSource = LoadSource(FragPath);
            var FragShader = GL.CreateShader(ShaderType.FragmentShader);
            GL.ShaderSource(FragShader, ShaderSource);
            CompileShader(FragShader);

            Handle = GL.CreateProgram();
            GL.AttachShader(Handle, VertexShader);
            GL.AttachShader(Handle, FragShader);

            LinkProgram(Handle);

            GL.DetachShader(Handle, VertexShader);
            GL.DetachShader(Handle, FragShader);
            GL.DeleteShader(VertexShader);
            GL.DeleteShader(FragShader);

            GL.GetProgram(Handle, GetProgramParameterName.ActiveUniforms, out var UniformNumbers);

            keyValuePairs = new Dictionary<string, int>();

            for (var i = 0; i < UniformNumbers; i++)
            {
                var Key = GL.GetActiveUniform(Handle, i, out _, out _);
                var Location = GL.GetUniformLocation(Handle, Key);
                keyValuePairs.Add(Key, Location);
            }
        }

        private static void CompileShader(int Shader)
        {
            GL.CompileShader(Shader);

            GL.GetShader(Shader, ShaderParameter.CompileStatus, out var Code);
            if (Code != (int)All.True)
            {
                var Logging = GL.GetShaderInfoLog(Shader);
                throw new Exception($"Error occurred while compiling shader({Shader})!\n\n{Logging}");
            }
        }

        private static void LinkProgram(int Program)
        {
            GL.LinkProgram(Program);

            GL.GetProgram(Program, GetProgramParameterName.LinkStatus, out var Code);
            if (Code != (int)All.True)
            {
                throw new Exception($"Error occurred while linking program({Program})");
            }
        }

        public void Use()
        {
            GL.UseProgram(Handle);
        }

        public int GetAttributeLocation(string AttributeName)
        {
            return GL.GetAttribLocation(Handle, AttributeName);
        }

        private static string LoadSource(string Path)
        {
            using (var ShaderReader = new StreamReader(Path, Encoding.UTF8))
            {
                return ShaderReader.ReadToEnd();
            }
        }

        public void SetInt(string Name, int Data)
        {
            GL.UseProgram(Handle);
            GL.Uniform1(keyValuePairs[Name], Data);
        }

        public void SetFloat(string Name, float Data)
        {
            GL.UseProgram(Handle);
            GL.Uniform1(keyValuePairs[Name], Data);
        }

        public void SetMatrix4(string Name, Matrix4 Data)
        {
            GL.UseProgram(Handle);
            GL.UniformMatrix4(keyValuePairs[Name], true, ref Data);
        }

        public void SetVector3(string Name, Vector3 Data)
        {
            GL.UseProgram(Handle);
            GL.Uniform3(keyValuePairs[Name], Data);
        }
    }
}
