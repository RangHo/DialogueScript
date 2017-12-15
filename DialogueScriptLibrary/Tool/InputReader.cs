using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RangHo.DialogueScript.Tool
{
    internal class InputReader<T>
    {
        private T[] _input;

        private int _position;

        public int Position
        {
            get
            {
                return this._position;
            }
            set
            {
                if (this._input.Length <= value)
                    throw new IndexOutOfRangeException();

                this._position = value;
            }

        }

        public bool IsEnd { get => this._input.Length <= this.Position; }

        public T this[int index] => this._input[index];

        public InputReader(T[] array)
        {
            this._input = array;
            this.Position = 0;
        }

        public T Read() => this._input[this.Position++];

        public T Peek() => this._input[this.Position];
    }
}
