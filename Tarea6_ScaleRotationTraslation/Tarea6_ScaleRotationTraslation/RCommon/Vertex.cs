using OpenTK;
using OpenTK.Graphics;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Classes
{
    public struct Vertex
    {
        public const int Size = (4 + 4) * 4; // size of struct in bytes

        private readonly Vector4 _position;
        private readonly Color4 _color;

        public Vertex(Vector4 position, Color4 color)
        {
            _position = position;
            _color = color;
        }
    }

    public struct TexturedVertex
    {
        public const int Size = (4 + 2) * 4; // size of struct in bytes

        private readonly Vector4 _position;
        private readonly Vector2 _textureCoordinate;

        public TexturedVertex(Vector4 position, Vector2 textureCoordinate)
        {
            _position = position;
            _textureCoordinate = textureCoordinate;
        }
    }

    public class HashList<T>
    {
        public Hashtable list { get; }
        public int Count { get => list.Count; }

        public HashList() => list = new Hashtable();

        public T Get(object key) => (T)list[key];

        public void Del(string key) => list.Remove(key);
        public void Set(string key, T element) => list[key] = element;
        public void Add(string key, T element) => list.Add(key, element);

        public IDictionaryEnumerator GetEnumerator() => list.GetEnumerator();
    }
}
