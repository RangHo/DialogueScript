using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RangHo.DialogueScript.Utility
{
    public class InputReader<T>
    {
        private T[] _input;

        public uint Position;

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
