using System.Drawing.Text;

namespace Palayok.UI
{
    public static class FontManager
    {
        private static PrivateFontCollection? privateFonts;

        public static PrivateFontCollection GetFontCollection()
        {
            if (privateFonts == null)
            {
                LoadEmbeddedFonts();
            }
            return privateFonts ?? new PrivateFontCollection();
        }

        public static Font? GetPixelifyFont(float size = 12f, FontStyle style = FontStyle.Regular)
        {
            try
            {
                var collection = GetFontCollection();
                if (collection.Families.Length > 0)
                {
                    return new Font(collection.Families[0], size, style);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"GetPixelifyFont error: {ex.Message}");
            }
            return null;
        }

        public static void ApplyPixelifyFontToControl(Control control, float size = 12f)
        {
            var pixelifyFont = GetPixelifyFont(size);
            if (pixelifyFont != null)
            {
                control.Font = pixelifyFont;
            }
        }

        public static void ApplyPixelifyFontToAllControls(Control parent, float defaultSize = 12f)
        {
            try
            {
                var pixelifyFont = GetPixelifyFont(defaultSize);
                if (pixelifyFont == null)
                    return;

                foreach (Control control in GetAllControls(parent))
                {
                    // Check if the control is using Pixelify Sans
                    if (control.Font?.Name == "Pixelify Sans" || control.Font?.Name.Contains("Pixelify") == true)
                    {
                        float currentSize = control.Font?.Size ?? defaultSize;
                        control.Font = new Font(pixelifyFont.FontFamily, currentSize, control.Font?.Style ?? FontStyle.Regular);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"ApplyPixelifyFontToAllControls error: {ex.Message}");
            }
        }

        private static IEnumerable<Control> GetAllControls(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                yield return control;
                foreach (Control child in GetAllControls(control))
                {
                    yield return child;
                }
            }
        }

        public static void LoadEmbeddedFonts()
        {
            try
            {
                privateFonts = new PrivateFontCollection();

                string fontsDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Fonts");
                if (!Directory.Exists(fontsDirectory))
                {
                    System.Diagnostics.Debug.WriteLine($"Fonts directory not found: {fontsDirectory}");
                    return;
                }

                string[] fontFiles = Directory.GetFiles(fontsDirectory, "*.ttf")
                    .Concat(Directory.GetFiles(fontsDirectory, "*.otf"))
                    .ToArray();

                System.Diagnostics.Debug.WriteLine($"Found {fontFiles.Length} font files");

                foreach (string fontPath in fontFiles)
                {
                    try
                    {
                        privateFonts.AddFontFile(fontPath);
                        System.Diagnostics.Debug.WriteLine($"Successfully loaded font: {Path.GetFileName(fontPath)}");
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine($"Failed to load font {fontPath}: {ex.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"FontManager error: {ex.Message}");
            }
        }
    }
}
