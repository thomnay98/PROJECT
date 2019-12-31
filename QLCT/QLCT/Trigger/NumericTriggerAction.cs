using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace QLCT
{
    public class NumericTriggerAction : TriggerAction<Entry>
    {
        string prevText = string.Empty;

        protected override void Invoke(Entry entry)
        {
            var isNumeric = double.TryParse(entry.Text, out double value);

            if (!string.IsNullOrWhiteSpace(entry.Text) && !isNumeric)
            {
                entry.Text = prevText;
                return;
            }

            prevText = entry.Text;
        }
    }
}
