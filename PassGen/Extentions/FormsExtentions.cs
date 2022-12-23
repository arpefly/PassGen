using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;

namespace PassGen.Extentions
{
    public static class FormsExtentions
    {
        /// <summary>
        /// Покраска формы
        /// </summary>
        /// <param name="color1">Первый цвет градиента</param>
        /// <param name="color2">Второй цвет градиента</param>
        public static void FormPaint(this Form form, Color color1, Color color2)
        {
            void OnPaintEventHandler(object s, PaintEventArgs e)
            {
                if (form.ClientRectangle == Rectangle.Empty)
                    return;

                var lgb = new LinearGradientBrush(form.ClientRectangle, Color.Empty, Color.Empty, 90);
                var cblend = new ColorBlend { Colors = new[] { color1, color1, color2, color2 }, Positions = new[] { 0, 0.05f, 0.05f, 1 } };

                lgb.InterpolationColors = cblend;
                e.Graphics.FillRectangle(lgb, form.ClientRectangle);
            }

            form.Paint -= OnPaintEventHandler;
            form.Paint += OnPaintEventHandler;

            form.Invalidate();
        }
        /// <summary>
        /// Плавное появление формы
        /// </summary>
        /// <param name="form">Экземпляр формы</param>
        /// <returns></returns>
        public static async Task SmoothFormAppearance(this Form form)
        {
            for (form.Opacity = 0; form.Opacity < 1; form.Opacity += .1)
                await Task.Delay(5);
        }
        /// <summary>
        /// Плавное закрытие формы
        /// </summary>
        /// <param name="form">Экземпляр формы</param>
        /// <param name="close">Закрывать форму ?</param>
        /// <returns></returns>
        public static async Task SmoothFormClosing(this Form form, bool close = true)
        {
            for (form.Opacity = 1; form.Opacity > .0; form.Opacity -= .2)
                await Task.Delay(7);

            if (close)
            {
                form.Close();
            }
            else
            {
                form.WindowState = FormWindowState.Minimized;
                form.Opacity = 1;
            }
        }
    }
}
