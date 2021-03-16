using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWork2_elementyUprvlenia
{
    public class FormsStyle
    {
        private static readonly Lazy<FormsStyle> lazy = new Lazy<FormsStyle>(() => new FormsStyle());

        private FormsStyle() { }

        public static FormsStyle GetInstance()
        {
            return lazy.Value;
        }

        public string GetInfoString()
        {
            return $"ширина: {Form.ActiveForm.Width};\r\n" +
                $"высота{Form.ActiveForm.Height}\n\r" +
                $"передний цвет: {Form.ActiveForm.ForeColor}";
        }
    }
}
