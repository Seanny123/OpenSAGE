﻿using System;
using OpenSage.Mathematics;
using Veldrid;
using Rectangle = OpenSage.Mathematics.Rectangle;

namespace OpenSage.Gui.Wnd.Images
{
    public sealed class Image
    {
        private readonly Func<Size, Texture> _createTexture;
        private Texture _texture;
        private Size _size;

        public Size NaturalSize { get; }

        internal Image(in Size naturalSize, Func<Size, Texture> createTexture)
        {
            NaturalSize = naturalSize;
            _createTexture = createTexture;
        }

        internal void SetSize(in Size size)
        {
            if (_size == size)
            {
                return;
            }

            if (_texture != null)
            {
                _texture.Dispose();
                _texture = null;
            }

            _texture = _createTexture(size);

            _size = size;
        }

        internal void Draw(DrawingContext2D drawingContext, in Rectangle destinationRect)
        {
            drawingContext.DrawImage(_texture, null, destinationRect);
        }
    }
}
