using System;

namespace Exercicio02.Entities
{
    class Comment
    {

        public string Text { get; set; }
        public Comment() { }

        public Comment(string text)
        {
            Text = text;
        }


    }
}
