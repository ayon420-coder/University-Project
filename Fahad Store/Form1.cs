using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Fahad_Store
{
    public partial class Form1 : Form
    {
        private int currentAd = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadAdsImages();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Login button clicked - implement login flow here if needed.
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        // Load images from a folder named "Images" next to the executable.
        // If no images are found it will fall back to pictureBox1.Image (if present).
        private void LoadAdsImages()
        {
            try
            {
                ads.Images.Clear();

                string imagesDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");
                string[] extensions = new[] { "*.png", "*.jpg", "*.jpeg", "*.bmp", "*.gif" };

                if (Directory.Exists(imagesDir))
                {
                    foreach (var ext in extensions)
                    {
                        foreach (var file in Directory.GetFiles(imagesDir, ext))
                        {
                            try
                            {
                                using var img = Image.FromFile(file);
                                // Add a copy so the file isn't locked
                                ads.Images.Add(new Bitmap(img));
                            }
                            catch
                            {
                                // Skip invalid images
                            }
                        }
                    }
                }

                // Fallback to small bundled image if nothing found
                if (ads.Images.Count == 0 && pictureBox1?.Image != null)
                {
                    ads.Images.Add(new Bitmap(pictureBox1.Image));
                }

                if (ads.Images.Count > 0)
                {
                    currentAd = 0;
                    adsImage.Image = ads.Images[currentAd];
                    timer1.Enabled = true;
                }
                else
                {
                    adsImage.Image = null;
                    timer1.Enabled = false;
                }
            }
            catch
            {
                // If loading fails, disable timer and clear image to avoid repeated exceptions.
                timer1.Enabled = false;
                adsImage.Image = null;
            }
        }

        // Handler wired in designer (timer1.Tick += timer1_Tick_1)
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (ads?.Images?.Count > 0 && adsImage != null)
            {
                currentAd = (currentAd + 1) % ads.Images.Count;
                adsImage.Image = ads.Images[currentAd];
            }
            else
            {
                timer1.Enabled = false;
            }
        }
    }
}
