using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace perpustakaan
{
    internal class koneksi
    {
        public static string conn = "Data Source = JALALUDDIN\\SQLEXPRESS; Initial Catalog = perpustakaan; Integrated Security = True";
    }

    internal static class TemaPopup
    {
        private static readonly Color Ungu = Color.FromArgb(124, 90, 194);
        private static readonly Color UnguGelap = Color.FromArgb(82, 57, 139);
        private static readonly Color Latar = Color.FromArgb(248, 246, 253);
        private static readonly Color Teks = Color.FromArgb(48, 42, 61);

        public static void Tampilkan(
            IWin32Window pemilik,
            string pesan,
            string judul,
            MessageBoxIcon jenis)
        {
            using (Form popup = BuatPopup(pesan, judul, jenis, false))
            {
                popup.ShowDialog(pemilik);
            }
        }

        public static DialogResult Konfirmasi(
            IWin32Window pemilik,
            string pesan,
            string judul)
        {
            using (Form popup = BuatPopup(pesan, judul, MessageBoxIcon.Question, true))
            {
                return popup.ShowDialog(pemilik);
            }
        }

        private static Form BuatPopup(
            string pesan,
            string judul,
            MessageBoxIcon jenis,
            bool konfirmasi)
        {
            Color aksen = jenis == MessageBoxIcon.Information
                ? Ungu
                : jenis == MessageBoxIcon.Warning ? Color.FromArgb(190, 125, 35)
                : jenis == MessageBoxIcon.Error ? Color.FromArgb(183, 62, 82)
                : Ungu;

            string simbol = jenis == MessageBoxIcon.Information ? "✓"
                : jenis == MessageBoxIcon.Warning ? "!"
                : jenis == MessageBoxIcon.Error ? "×" : "?";

            Form popup = new Form
            {
                Text = judul,
                ClientSize = new Size(460, 224),
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterParent,
                MaximizeBox = false,
                MinimizeBox = false,
                ShowInTaskbar = false,
                ControlBox = false,
                BackColor = Latar,
                Font = new Font("Segoe UI", 9.5F),
                KeyPreview = true
            };

            Panel kepala = new Panel
            {
                BackColor = Ungu,
                Location = new Point(0, 0),
                Size = new Size(460, 66)
            };

            Label badge = new Label
            {
                Text = simbol,
                BackColor = Color.White,
                ForeColor = aksen,
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(18, 14),
                Size = new Size(38, 38)
            };

            Label judulLabel = new Label
            {
                Text = judul,
                ForeColor = Color.White,
                Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold),
                Location = new Point(70, 18),
                AutoSize = true
            };

            Label pesanLabel = new Label
            {
                Text = pesan,
                ForeColor = Teks,
                Font = new Font("Segoe UI", 10F),
                Location = new Point(25, 83),
                Size = new Size(410, 65),
                AutoEllipsis = true
            };

            Button utama = new Button
            {
                Text = konfirmasi
                    ? (judul.IndexOf("hapus", StringComparison.OrdinalIgnoreCase) >= 0 ? "Hapus" : "Simpan")
                    : "Mengerti",
                DialogResult = konfirmasi ? DialogResult.Yes : DialogResult.OK,
                BackColor = Ungu,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                Location = new Point(konfirmasi ? 330 : 350, 170),
                Size = new Size(85, 34),
                UseVisualStyleBackColor = false
            };
            utama.FlatAppearance.BorderSize = 0;

            popup.Controls.Add(kepala);
            kepala.Controls.Add(badge);
            kepala.Controls.Add(judulLabel);
            popup.Controls.Add(pesanLabel);
            popup.Controls.Add(utama);

            if (konfirmasi)
            {
                Button batal = new Button
                {
                    Text = "Batal",
                    DialogResult = DialogResult.No,
                    BackColor = Color.White,
                    ForeColor = UnguGelap,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Segoe UI", 9F),
                    Location = new Point(235, 170),
                    Size = new Size(85, 34)
                };
                batal.FlatAppearance.BorderColor = Color.FromArgb(210, 201, 230);
                popup.Controls.Add(batal);
                popup.CancelButton = batal;
            }

            popup.AcceptButton = utama;
            return popup;
        }
    }

    public class Model
    {
        public static string name {  get; set; }

        public static string iduser { get; set; }
        public static string username { get; set; }
    }
}
