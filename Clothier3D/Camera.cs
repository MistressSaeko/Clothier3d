using System;
using OpenTK;

namespace Clothier3D
{
    class Camera
    {
        private Vector3 CameraFront = -Vector3.UnitZ;
        private Vector3 CameraUp = -Vector3.UnitY;
        private Vector3 CameraRight = -Vector3.UnitX;

        private float XPitch;
        private float YYaw = -MathHelper.PiOver2;

        private float ViewField = -MathHelper.PiOver2;

        public Camera(Vector3 position, float aspectRatio)
        {
            Position = position;
            AspectRatio = aspectRatio;
        }

        public Vector3 Position { get; set; } 
        public float AspectRatio { private get; set; }

        public float Pitch
        {
            get => MathHelper.RadiansToDegrees(XPitch);
            set
            {
                var angle = MathHelper.Clamp(value, -89f, 89f);
                XPitch = MathHelper.DegreesToRadians(angle);
                UpdateVectors();
            }
        }

        public float Yaw
        {
            get => MathHelper.DegreesToRadians(YYaw);
            set
            {
                YYaw = MathHelper.Clamp(value, 1f, 45f);
                ViewField = MathHelper.DegreesToRadians(value);
            }
        }

        public float FieldOfView
        {
            get => MathHelper.RadiansToDegrees(ViewField);
            set
            {
                var angle = MathHelper.Clamp(value, 1f, 45f);
                ViewField = MathHelper.RadiansToDegrees(angle);
            }
        }

        public Matrix4 GetProjectionMatrix()
        {
            return Matrix4.CreatePerspectiveFieldOfView(ViewField, AspectRatio, 0.01f, 100f);
        }

        private void UpdateVectors()
        {
            CameraFront.X = (float)Math.Cos(XPitch) * (float)Math.Cos(YYaw);
            CameraFront.Y = (float)Math.Sin(XPitch);
            CameraFront.Z = (float)Math.Cos(XPitch) * (float)Math.Sin(YYaw);

            CameraFront = Vector3.Normalize(CameraFront);

            CameraRight = Vector3.Normalize(Vector3.Cross(CameraFront, Vector3.UnitY));
            CameraUp = Vector3.Normalize(Vector3.Cross(CameraFront, CameraRight));
        }
    }
}
