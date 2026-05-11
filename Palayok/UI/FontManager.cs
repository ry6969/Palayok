using System.Runtime.InteropServices;

namespace Palayok.UI
{
    public static class FontManager
    {
        [DllImport("gdi32.dll")]
        private static extern int AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, out uint pcFonts);

        private static List<IntPtr> loadedFonts = new();

        public static void LoadEmbeddedFonts()
        {
            try
            {
                string fontsDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Fonts");
                if (!Directory.Exists(fontsDirectory))
                {
                    return;
                }

                string[] fontFiles = Directory.GetFiles(fontsDirectory, "*.ttf")
                    .Concat(Directory.GetFiles(fontsDirectory, "*.otf"))
                    .ToArray();

                foreach (string fontPath in fontFiles)
                {
                    try
                    {
                        byte[] fontData = File.ReadAllBytes(fontPath);
                        IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
                        Marshal.Copy(fontData, 0, fontPtr, fontData.Length);

                        AddFontMemResourceEx(fontPtr, (uint)fontData.Length, IntPtr.Zero, out uint cFonts);
                        loadedFonts.Add(fontPtr);
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
