﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Numerics;
using OpenSage.Mathematics;
using OpenSage.LowLevel.Graphics3D;
using OpenSage.Data.Utilities;

namespace OpenSage.Data.Apt
{
    public enum GeometryStyle
    {
        Undefined,
        TexturedTri,
        SolidTri,
        Line
    }

    public interface GeometryEntry
    {
        GeometryStyle Type { get; }

    }


    public sealed class Geometry
    {
        public List<GeometryEntry> Entries { get; private set; }
        public RectangleF BoundingBox { get; private set; }


        public Geometry()
        {
            Entries = new List<GeometryEntry>();
        }

        public static Geometry FromFileSystemEntry(FileSystemEntry entry)
        {
            var geometry = new Geometry();

            using (var stream = entry.Open())
            using (var reader = new StreamReader(stream))
            {
                string line;
                int image = 0;
                float thickness = 0;
                Matrix2x2 rotMat;
                Vector2 translation;
                ColorRgba color = new ColorRgba(0, 0, 0, 0);
                GeometryStyle style = GeometryStyle.Undefined;
                var tris = new List<Triangle2D>();
                var lines = new List<Line2D>();

                Action ApplyStyle = () =>
                {
                    switch (style)
                    {
                        //no data parsed yet
                        case GeometryStyle.Undefined:
                            break;
                        case GeometryStyle.TexturedTri:
                            geometry.Entries.Add(new GeometryTexturedTriangles(tris, color));
                            tris.Clear();
                            break;
                        case GeometryStyle.SolidTri:
                            geometry.Entries.Add(new GeometrySolidTriangles(tris, color));
                            tris.Clear();
                            break;
                        case GeometryStyle.Line:
                            geometry.Entries.Add(new GeometryLines(lines, color, thickness));
                            lines.Clear();
                            break;
                    }

                    style = GeometryStyle.Undefined;
                };

                while ((line = reader.ReadLine()) != null)
                {
                    line = line.Trim();

                    var lineMode = line.First();
                    line = line.TrimStart('c', 's', 'l', 't');
                    var paramList = line.Split(':');

                    //trim each entry of the param list
                    for (var i = 0; i < paramList.Length; ++i)
                    {
                        paramList[i] = paramList[i].Trim();
                    }

                    switch (lineMode)
                    {
                        //Clear - Finish the last geometry
                        case 'c':
                            ApplyStyle();
                            break;
                        //Style - Header for the following data
                        case 's':
                            //Check that we have atleast 1 param
                            if (paramList.Length < 1)
                                throw new InvalidDataException();

                            //Check which style we are using
                            switch (paramList.First())
                            {
                                //this is the solid triangle style
                                case "s":
                                    if (paramList.Length != 5)
                                        throw new InvalidDataException();

                                    style = GeometryStyle.SolidTri;
                                    color.R = Convert.ToByte(paramList[1]);
                                    color.G = Convert.ToByte(paramList[2]);
                                    color.B = Convert.ToByte(paramList[3]);
                                    color.A = Convert.ToByte(paramList[4]);
                                    break;
                                //this is the line style
                                case "l":
                                    if (paramList.Length != 6)
                                        throw new InvalidDataException();

                                    style = GeometryStyle.Line;
                                    thickness = ParseUtility.ParseFloat(paramList[1]);
                                    color.R = Convert.ToByte(paramList[2]);
                                    color.G = Convert.ToByte(paramList[3]);
                                    color.B = Convert.ToByte(paramList[4]);
                                    color.A = Convert.ToByte(paramList[5]);
                                    break;
                                //this is the textured triangle style
                                case "tc":
                                    if (paramList.Length != 12)
                                        throw new InvalidDataException();

                                    style = GeometryStyle.TexturedTri;
                                    color.R = Convert.ToByte(paramList[1]);
                                    color.G = Convert.ToByte(paramList[2]);
                                    color.B = Convert.ToByte(paramList[3]);
                                    color.A = Convert.ToByte(paramList[4]);
                                    //image id used
                                    image = Convert.ToInt32(paramList[5]);
                                    //transformation parameters, to map the geometry above the texture
                                    rotMat.M11 = ParseUtility.ParseFloat(paramList[6]);
                                    rotMat.M12 = ParseUtility.ParseFloat(paramList[7]);
                                    rotMat.M21 = ParseUtility.ParseFloat(paramList[8]);
                                    rotMat.M22 = ParseUtility.ParseFloat(paramList[9]);
                                    translation.X = ParseUtility.ParseFloat(paramList[10]);
                                    translation.Y = ParseUtility.ParseFloat(paramList[11]);
                                    break;
                            }
                            break;
                        //A line
                        case 'l':
                            Line2D lin;
                            lin.V0 = new Vector2(ParseUtility.ParseFloat(paramList[0]), ParseUtility.ParseFloat(paramList[1]));
                            lin.V1 = new Vector2(ParseUtility.ParseFloat(paramList[2]), ParseUtility.ParseFloat(paramList[3]));
                            lines.Add(lin);
                            break;
                        //A triangle
                        case 't':
                            Triangle2D tri;
                            tri.V0 = new Vector2(ParseUtility.ParseFloat(paramList[0]), ParseUtility.ParseFloat(paramList[1]));
                            tri.V1 = new Vector2(ParseUtility.ParseFloat(paramList[2]), ParseUtility.ParseFloat(paramList[3]));
                            tri.V2 = new Vector2(ParseUtility.ParseFloat(paramList[4]), ParseUtility.ParseFloat(paramList[5]));
                            tris.Add(tri);
                            break;
                    }

                }

                ApplyStyle();
            }

            geometry.CalculateBoundings();
            return geometry;
        }

        private void CalculateBoundings()
        {
            //find topleft and botright point
            var topLeft = new Vector2 { X = float.MaxValue, Y = float.MaxValue };
            var botRight = new Vector2 { X = float.MinValue, Y = float.MinValue };

            foreach (var entry in Entries)
            {
                if (entry is GeometryLines gl)
                {
                    foreach (var line in gl.Lines)
                    {
                        if (line.V0.X < topLeft.X) topLeft.X = line.V0.X;
                        if (line.V1.X < topLeft.X) topLeft.X = line.V1.X;
                        if (line.V0.Y < topLeft.Y) topLeft.Y = line.V0.Y;
                        if (line.V1.Y < topLeft.Y) topLeft.Y = line.V1.Y;

                        if (line.V0.X > botRight.X) botRight.X = line.V0.X;
                        if (line.V1.X > botRight.X) botRight.X = line.V1.X;
                        if (line.V0.Y > botRight.Y) botRight.Y = line.V0.Y;
                        if (line.V1.Y > botRight.Y) botRight.Y = line.V1.Y;
                    }
                }
                else if (entry is GeometrySolidTriangles gst)
                {
                    foreach (var tri in gst.Triangles)
                    {
                        if (tri.V0.X < topLeft.X) topLeft.X = tri.V0.X;
                        if (tri.V1.X < topLeft.X) topLeft.X = tri.V1.X;
                        if (tri.V2.X < topLeft.X) topLeft.X = tri.V2.X;
                        if (tri.V0.Y < topLeft.Y) topLeft.Y = tri.V0.Y;
                        if (tri.V1.Y < topLeft.Y) topLeft.Y = tri.V1.Y;
                        if (tri.V2.Y < topLeft.Y) topLeft.Y = tri.V2.Y;

                        if (tri.V0.X > botRight.X) botRight.X = tri.V0.X;
                        if (tri.V1.X > botRight.X) botRight.X = tri.V1.X;
                        if (tri.V2.X > botRight.X) botRight.X = tri.V2.X;
                        if (tri.V0.Y > botRight.Y) botRight.Y = tri.V0.Y;
                        if (tri.V1.Y > botRight.Y) botRight.Y = tri.V1.Y;
                        if (tri.V2.Y > botRight.Y) botRight.Y = tri.V2.Y;
                    }
                }
                else if (entry is GeometryTexturedTriangles gtt)
                {
                    foreach (var tri in gtt.Triangles)
                    {
                        if (tri.V0.X < topLeft.X) topLeft.X = tri.V0.X;
                        if (tri.V1.X < topLeft.X) topLeft.X = tri.V1.X;
                        if (tri.V2.X < topLeft.X) topLeft.X = tri.V2.X;
                        if (tri.V0.Y < topLeft.Y) topLeft.Y = tri.V0.Y;
                        if (tri.V1.Y < topLeft.Y) topLeft.Y = tri.V1.Y;
                        if (tri.V2.Y < topLeft.Y) topLeft.Y = tri.V2.Y;

                        if (tri.V0.X > botRight.X) botRight.X = tri.V0.X;
                        if (tri.V1.X > botRight.X) botRight.X = tri.V1.X;
                        if (tri.V2.X > botRight.X) botRight.X = tri.V2.X;
                        if (tri.V0.Y > botRight.Y) botRight.Y = tri.V0.Y;
                        if (tri.V1.Y > botRight.Y) botRight.Y = tri.V1.Y;
                        if (tri.V2.Y > botRight.Y) botRight.Y = tri.V2.Y;
                    }
                }
            }

            var size = botRight - topLeft;
            BoundingBox = new RectangleF(topLeft.X, topLeft.Y, size.X, size.Y);
        }
    }

    public struct GeometrySolidTriangles : GeometryEntry
    {
        public ColorRgba Color { get; private set; }
        public List<Triangle2D> Triangles { get; private set; }

        public GeometryStyle Type
        {
            get
            {
                return GeometryStyle.SolidTri;
            }
        }

        public GeometrySolidTriangles(List<Triangle2D> triangles, ColorRgba color)
        {
            Color = color;
            Triangles = new List<Triangle2D>(triangles);
        }
    }

    public struct GeometryLines : GeometryEntry
    {
        public ColorRgba Color { get; private set; }
        public float Thickness { get; private set; }
        public List<Line2D> Lines { get; private set; }

        public GeometryStyle Type
        {
            get
            {
                return GeometryStyle.Line;
            }
        }

        public GeometryLines(List<Line2D> lines, ColorRgba color, float thickness)
        {
            Color = color;
            Lines = new List<Line2D>(lines);
            Thickness = thickness;
        }
    }

    public struct GeometryTexturedTriangles : GeometryEntry
    {
        public ColorRgba Color { get; private set; }
        public List<Triangle2D> Triangles { get; private set; }

        public GeometryStyle Type
        {
            get
            {
                return GeometryStyle.TexturedTri;
            }
        }

        public GeometryTexturedTriangles(List<Triangle2D> triangles, ColorRgba color)
        {
            Color = color;
            Triangles = new List<Triangle2D>(triangles);
        }
    }
}
