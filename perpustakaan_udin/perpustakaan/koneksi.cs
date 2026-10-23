using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace perpustakaan
{
    internal static class TemaWarna
    {
        public static readonly Color UnguTua = Color.FromArgb(59, 31, 63);
        public static readonly Color Plum = Color.FromArgb(101, 43, 82);
        public static readonly Color MawarTua = Color.FromArgb(141, 74, 115);
        public static readonly Color Mawar = Color.FromArgb(196, 122, 158);
        public static readonly Color Lavender = Color.FromArgb(233, 220, 237);
        public static readonly Color Latar = Color.FromArgb(248, 243, 248);

        public static void Terapkan(Control induk)
        {
            if (induk == null) return;

            if (induk is Form) induk.BackColor = Latar;
            induk.ForeColor = UnguTua;

            foreach (Control kontrol in induk.Controls)
            {
                if (kontrol is DataGridView grid)
                {
                    grid.BackgroundColor = Latar;
                    grid.BorderStyle = BorderStyle.FixedSingle;
                    grid.GridColor = Mawar;
                    grid.EnableHeadersVisualStyles = false;
                    grid.ColumnHeadersDefaultCellStyle.BackColor = Plum;
                    grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                    grid.DefaultCellStyle.BackColor = Latar;
                    grid.DefaultCellStyle.ForeColor = UnguTua;
                    grid.DefaultCellStyle.SelectionBackColor = MawarTua;
                    grid.DefaultCellStyle.SelectionForeColor = Color.White;
                    grid.AlternatingRowsDefaultCellStyle.BackColor = Lavender;
                    grid.AlternatingRowsDefaultCellStyle.ForeColor = UnguTua;
                    grid.RowHeadersDefaultCellStyle.BackColor = Plum;
                    grid.RowHeadersDefaultCellStyle.ForeColor = Color.White;
                }
                else if (kontrol is Button tombol)
                {
                    bool tombolSidebar = tombol.Parent is TableLayoutPanel &&
                        tombol.Parent.Parent is Panel;
                    tombol.BackColor = tombolSidebar ? Lavender : Latar;
                    tombol.ForeColor = UnguTua;
                    tombol.FlatStyle = FlatStyle.Flat;
                    tombol.UseVisualStyleBackColor = false;
                    tombol.FlatAppearance.BorderColor = Mawar;
                    tombol.FlatAppearance.MouseOverBackColor = MawarTua;
                    tombol.FlatAppearance.MouseDownBackColor = UnguTua;
                    tombol.FlatAppearance.BorderSize = 1;
                    tombol.Font = new Font("Segoe UI", tombol.Font.Size, FontStyle.Bold);
                }
                else if (kontrol is TextBoxBase || kontrol is ComboBox || kontrol is DateTimePicker || kontrol is NumericUpDown)
                {
                    kontrol.BackColor = Latar;
                    kontrol.ForeColor = UnguTua;
                    kontrol.Font = new Font("Segoe UI", kontrol.Font.Size, kontrol.Font.Style);
                }
                else if (kontrol is Label)
                {
                    kontrol.ForeColor = UnguTua;
                    kontrol.Font = new Font("Segoe UI", kontrol.Font.Size, kontrol.Font.Style);
                    if (kontrol.Name == "label1")
                    {
                        kontrol.ForeColor = Color.White;
                    }
                }
                else if (kontrol is Panel || kontrol is GroupBox || kontrol is TableLayoutPanel || kontrol is FlowLayoutPanel)
                {
                    kontrol.BackColor = Lavender;
                    kontrol.ForeColor = UnguTua;
                }
                else if (kontrol is Label label && label.BackColor != Color.Transparent)
                {
                    label.BackColor = kontrol.Name == "lLine" || kontrol.Name == "label4"
                        ? MawarTua
                        : Plum;
                    label.ForeColor = Color.White;
                }

                if (kontrol.HasChildren) Terapkan(kontrol);
            }
        }
    }

    internal class koneksi
    {
        public static string conn = "Data Source = JALALUDDIN\\SQLEXPRESS; Initial Catalog = perpustakaan; Integrated Security = True";
    }

    internal static class TemaPopup
    {
        private static readonly Color Ungu = TemaWarna.Plum;
        private static readonly Color UnguGelap = TemaWarna.UnguTua;
        private static readonly Color Latar = TemaWarna.Latar;
        private static readonly Color Teks = TemaWarna.UnguTua;

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
            Color aksen = jenis == MessageBoxIcon.Error ? TemaWarna.MawarTua : TemaWarna.Plum;

            string simbol = jenis == MessageBoxIcon.Information ? "✓"
                : jenis == MessageBoxIcon.Warning ? "!"
                : jenis == MessageBoxIcon.Error ? "×" : "?";

            Form popup = new Form
            {
                Text = judul,
                ClientSize = new Size(480, 236),
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterParent,
                MaximizeBox = false,
                MinimizeBox = false,
                ShowInTaskbar = false,
                ControlBox = false,
                BackColor = Latar,
                Font = new Font("Segoe UI", 9.5F),
                Padding = new Padding(1),
                KeyPreview = true
            };

            Panel kepala = new Panel
            {
                BackColor = TemaWarna.Plum,
                Location = new Point(0, 0),
                Size = new Size(480, 70)
            };

            Label badge = new Label
            {
                Text = simbol,
                BackColor = TemaWarna.Lavender,
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
                Location = new Point(28, 88),
                Size = new Size(424, 76),
                AutoEllipsis = false,
                TextAlign = ContentAlignment.MiddleLeft
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
                Location = new Point(konfirmasi ? 354 : 366, 184),
                Size = new Size(88, 36),
                UseVisualStyleBackColor = false
            };
            utama.FlatAppearance.BorderSize = 0;
            utama.FlatAppearance.MouseOverBackColor = TemaWarna.MawarTua;
            utama.FlatAppearance.MouseDownBackColor = TemaWarna.UnguTua;

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
                    BackColor = TemaWarna.Lavender,
                    ForeColor = UnguGelap,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Segoe UI", 9F),
                    Location = new Point(254, 184),
                    Size = new Size(88, 36)
                };
                batal.FlatAppearance.BorderColor = TemaWarna.Mawar;
                batal.FlatAppearance.MouseOverBackColor = TemaWarna.Mawar;
                batal.FlatAppearance.MouseDownBackColor = TemaWarna.MawarTua;
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
