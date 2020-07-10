using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Assignment2_KnightsTour
{
        public class TextBoxWriter : TextWriter
        {
            TextBox newOutput = null;

            public TextBoxWriter(TextBox output)
            {
                newOutput = output;
            }

            public override void Write(char value)
            {
                base.Write(value);
                newOutput.AppendText(value.ToString());
            }

            public override Encoding Encoding
            {
                get { return System.Text.Encoding.UTF8; }
            }
        }
    }

