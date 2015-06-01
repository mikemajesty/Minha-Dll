using System.Windows.Forms;

namespace Mike.Utilities.Desktop
{
    public static class AdapterScreen
    {

        public static void Adaptar(Form form)
        {
            int x = Screen.PrimaryScreen.Bounds.Size.Width;
            int y = Screen.PrimaryScreen.Bounds.Size.Height;
            form.Size = new System.Drawing.Size(x, y);
            form.Location = new System.Drawing.Point(0, 0);

        }
        
		
    }
}
