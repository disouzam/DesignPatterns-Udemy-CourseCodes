using System;
using System.Collections.Generic;
using System.Text;

namespace Coding.Exercise
{
    public class Field
    {
        public string name, type;

        public Field(string name, string type)
        {
            this.name = name;
            this.type = type;
        }
    }

    public class Code
    {
        public string classname;
        public int indentsize = 2;
        public List<Field> fields;


    }
    public class CodeBuilder
    {
        private Code code;

        public CodeBuilder()
        {

        }

        public CodeBuilder(string classname)
        {
            code = new Code();
            this.code.classname = classname;
            this.code.fields = new List<Field>();
        }

        private string ToStringImpl(int indent)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"public class {this.code.classname}");
            sb.AppendLine("{");
            foreach (var f in this.code.fields)
            {
                sb.Append(new string(' ', this.code.indentsize * (indent + 1)));
                sb.Append($"public {f.type.ToLower()} {f.name};");
                sb.Append("\n");
            }
            sb.AppendLine("}");
            return sb.ToString();
        }

        public override string ToString()
        {
            return ToStringImpl(0);
        }

        public CodeBuilder AddField(string name, string type)
        {
            this.code.fields.Add(new Field(name, type));
            return this;
        }


    }

    public class Exercise
    {
        static void Main(string[] args)
        {
            var cb = new CodeBuilder("Person").AddField("Name", "string").AddField("Age", "int");
            Console.WriteLine(cb);
        }
    }
}
