using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TyperSharkLessonGenerator
{
    public partial class Generator : Form
    {
        public Generator()
        {
            InitializeComponent();
            lessonSelect.SelectedIndex = 0;
        }

        /// <summary>
        /// Word wraps the given text to fit within the specified width.
        /// </summary>
        /// <param name="text">Text to be word wrapped</param>
        /// <param name="width">Width, in characters, to which the text
        /// should be word wrapped</param>
        /// <returns>The modified text</returns>
        public static string WordWrap(string text, int width)
        {
            int pos, next;
            StringBuilder sb = new StringBuilder();

            // Lucidity check
            if (width < 1)
                return text;

            // Parse each line of text
            for (pos = 0; pos < text.Length; pos = next)
            {
                // Find end of line
                int eol = text.IndexOf(Environment.NewLine, pos);
                if (eol == -1)
                    next = eol = text.Length;
                else
                    next = eol + Environment.NewLine.Length;

                // Copy this line of text, breaking into smaller lines as needed
                if (eol > pos)
                {
                    do
                    {
                        int len = eol - pos;
                        if (len > width)
                            len = BreakLine(text, pos, width);
                        sb.Append(text, pos, len);
                        sb.Append(Environment.NewLine);

                        // Trim whitespace following break
                        pos += len;
                        while (pos < eol && Char.IsWhiteSpace(text[pos]))
                            pos++;
                    } while (eol > pos);
                }
                else sb.Append(Environment.NewLine); // Empty line
            }
            return sb.ToString();
        }

        /// <summary>
        /// Locates position to break the given line so as to avoid
        /// breaking words.
        /// </summary>
        /// <param name="text">String that contains line of text</param>
        /// <param name="pos">Index where line of text starts</param>
        /// <param name="max">Maximum line length</param>
        /// <returns>The modified line length</returns>
        private static int BreakLine(string text, int pos, int max)
        {
            // Find last whitespace in line
            int i = max;
            while (i >= 0 && !Char.IsWhiteSpace(text[pos + i]))
                i--;

            // If no whitespace found, break at maximum length
            if (i < 0)
                return max;

            // Find start of whitespace
            while (i >= 0 && Char.IsWhiteSpace(text[pos + i]))
                i--;

            // Return length of text before whitespace
            return i + 1;
        }

        /*
            <LessonTime>-1</LessonTime>
            <MaxErrors>-1</MaxErrors>
            <MinWPM>-1</MinWPM>
            <MinAccuracy>-1</MinAccuracy>
        */

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // TODO: figure out the exact width of each character and compensate for that here
            // instead of doing blind word wrap
            string wrapped = WordWrap(textInput.Text, 50);

            StringBuilder sb = new StringBuilder();

            sb.Append(string.Concat("<LESSON>", Environment.NewLine, Environment.NewLine, "<DESCRIPTION>", descInput.Text, "</DESCRIPTION>",Environment.NewLine, Environment.NewLine));

            sb.Append(string.Concat("<LessonTime>", lessonTimeChk.Checked ? lessonTimeBox.Value : -1 , "</LessonTime>", Environment.NewLine));
            sb.Append(string.Concat("<MaxErrors>", maxErrorsChk.Checked ? maxErrorsBox.Value : -1, "</MaxErrors>", Environment.NewLine));
            sb.Append(string.Concat("<MinWPM>", minWpmChk.Checked ? minWpmBox.Value : -1, "</MinWPM>", Environment.NewLine));
            sb.Append(string.Concat("<MinAccuracy>", minAccuracyChk.Checked ? minAccuracyBox.Value : -1, "</MinAccuracy>", Environment.NewLine, Environment.NewLine));

            using (StringReader reader = new StringReader(wrapped))
            {
                string line;
                int count = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    if(count % 4 == 0) sb.Append(string.Concat("<TASK>",Environment.NewLine));
                    sb.Append(string.Concat("<TEXT>", line, "</TEXT>", Environment.NewLine));
                    if(count % 4 == 3) sb.Append(string.Concat("</TASK>",Environment.NewLine, Environment.NewLine));
                    count++;
                }
                if (count % 4 > 0) sb.Append(string.Concat("</TASK>", Environment.NewLine, Environment.NewLine));
            }

            sb.Append(string.Concat("</LESSON>",Environment.NewLine));

            File.WriteAllText(@$"Lesson{lessonSelect.SelectedIndex}.xml", sb.ToString());

            MessageBox.Show($"Lesson{lessonSelect.SelectedIndex}.xml generated!","Typer Shark Lesson Generator");
        }

        private void lessonTimeChk_CheckedChanged(object sender, EventArgs e)
        {
            lessonTimeBox.Enabled = lessonTimeChk.Checked;
        }

        private void maxErrorsChk_CheckedChanged(object sender, EventArgs e)
        {
            maxErrorsBox.Enabled = maxErrorsChk.Checked;
        }

        private void minWpmChk_CheckedChanged(object sender, EventArgs e)
        {
            minWpmBox.Enabled = minWpmChk.Checked;
        }

        private void minAccuracyChk_CheckedChanged(object sender, EventArgs e)
        {
            minAccuracyBox.Enabled = minAccuracyChk.Checked;
        }
    }
}
