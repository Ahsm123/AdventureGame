using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame.GUI
{
    class CombatLog
    {
        private RichTextBox TxtBoxCombatLog;

        public CombatLog(RichTextBox textBox)
        {
            TxtBoxCombatLog = textBox;
        }

        public void AppendText(string text, Color color, bool bold = false)
        {
            TxtBoxCombatLog.SelectionStart = TxtBoxCombatLog.TextLength;
            TxtBoxCombatLog.SelectionLength = 0;
            TxtBoxCombatLog.SelectionColor = color;

            if (bold)
            {
                TxtBoxCombatLog.SelectionFont = new Font(TxtBoxCombatLog.Font, FontStyle.Bold);
            }
            TxtBoxCombatLog.AppendText(text);
            TxtBoxCombatLog.SelectionColor = TxtBoxCombatLog.ForeColor;
            TxtBoxCombatLog.ScrollToCaret();
        }
    }
}
