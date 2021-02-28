using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace BuilderDesignPattern
{
    public class Demo
    {
        public class HtmlElement
        {
            public string Name, Text;
            public List<HtmlElement> Elements = new List<HtmlElement>();
            private const int indentsize = 2;

            public HtmlElement(string name, string text)
            {
                Name = name ?? throw new System.ArgumentNullException(nameof(name));
                Text = text ?? throw new System.ArgumentNullException(nameof(text));
            }

            public HtmlElement()
            {
            }

            private string ToStringImpl(int indent)
            {
                var sb = new StringBuilder();
                var i = new string(' ', indentsize * indent);
                sb.Append($"{i}<{Name}>");

                if (!string.IsNullOrWhiteSpace(Text))
                {
                    sb.Append(new string(' ', indentsize * (indent + 1)));
                    sb.AppendLine(Text);
                }

                foreach(var e in Elements)
                {
                    sb.Append(e.ToStringImpl(indent + 1));
                }

                sb.Append($"{i}</{Name}>");

                return sb.ToString();
            }

            public override string ToString()
            {
                return ToStringImpl(0);
            }
        }

        public class HtmlBuilder
        {
            private readonly string rootname;
            HtmlElement root = new HtmlElement();

            public HtmlBuilder(string rootname)
            {
                this.rootname = rootname;
                root.Name = rootname;
            }

            public void AddChild(string childName, string childText)
            {
                var e = new HtmlElement(childName, childText);
                root.Elements.Add(e);
            }

            public override string ToString()
            {
                return root.ToString();
            }

            public void Clear()
            {
                root = new HtmlElement { Name = rootname };
            }
        }

        static void Main(string[] args)
        {
            var hello = "hello";
            var sb = new StringBuilder();

            sb.Append("<p>");
            sb.Append(hello);
            sb.Append("</p>");
            WriteLine(sb);

            var words = new[] { "hello", "world" };
            sb.Clear();
            sb.Append("<ul>");
            foreach(var word in words)
            {
                sb.AppendFormat("<li>{0}</li>", word);            
            }
            sb.Append("</ul>");
            WriteLine(sb);
        }
    }
}
