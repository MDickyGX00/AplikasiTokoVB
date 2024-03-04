Public Class yellow
    Public Class Buku
        Public Property ID As Integer
        Public Property Nama As String
        Public Property Brand As String
        Public Property Tersedia As Boolean
        Public Property Kategori As String
        Public Property Expired As String
    End Class

    Private daftarBuku As New List(Of Buku)

    Private Sub FormPeminjamanBuku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        daftarBuku.Add(New Buku With {.ID = 1, .Nama = "Air Mineral", .Brand = "Aqua", .Kategori = "Minuman", .Expired = "1 Maret 2024", .Tersedia = True})
        daftarBuku.Add(New Buku With {.ID = 2, .Nama = "Mie Goreng Rendang", .Brand = "Indomie", .Kategori = "Makanan", .Expired = "15 April 2025", .Tersedia = False})
        daftarBuku.Add(New Buku With {.ID = 3, .Nama = "Crackers", .Brand = "Malkist Roma", .Kategori = "Cemilan", .Expired = "7 Mei 2024", .Tersedia = True})
        daftarBuku.Add(New Buku With {.ID = 4, .Nama = "Wafer", .Brand = "Tango", .Kategori = "Cemilan", .Expired = " 2 Januari 2025", .Tersedia = False})
        daftarBuku.Add(New Buku With {.ID = 5, .Nama = "Kopi", .Brand = "Kopi Kenangan", .Kategori = "Minuman", .Expired = "19 April 2025", .Tersedia = True})
    End Sub

    Private Sub LabelStatus_Click(sender As Object, e As EventArgs) Handles LabelStatus.Click

    End Sub

    Private Sub ButtonCari_Click(sender As Object, e As EventArgs) Handles ButtonCari.Click
        Dim idCari As Integer
        If Integer.TryParse(TextBoxIDCari.Text, idCari) Then
            Dim buku As Buku = CariBukuByID(idCari)

            If buku IsNot Nothing Then
                TextBoxBarang.Text = buku.Nama
                TextBoxBrand.Text = buku.Brand
                TextBoxKategori.Text = buku.Kategori
                TextBoxExpired.Text = buku.Expired
                If buku.Tersedia Then
                    LabelStatus.Text = "Tersedia"
                Else
                    LabelStatus.Text = "Dibeli (Sold Out)"
                End If
            Else
                MessageBox.Show("Barang dengan ID tersebut tidak ditemukan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("ID yang dimasukkan tidak valid.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Function CariBukuByID(id As Integer) As Buku
        Return daftarBuku.FirstOrDefault(Function(buku) buku.ID = id)
    End Function

    Private Sub ButtonBeli_Click(sender As Object, e As EventArgs) Handles ButtonBeli.Click
        Dim idPinjam As Integer = Integer.Parse(TextBoxIDCari.Text)
        Dim buku As Buku = CariBukuByID(idPinjam)

        If buku IsNot Nothing AndAlso buku.Tersedia Then
            buku.Tersedia = False
            LabelStatus.Text = "Dibeli (Sold Out)"
            MessageBox.Show("Barang berhasil dibeli.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf buku IsNot Nothing AndAlso Not buku.Tersedia Then
            MessageBox.Show("Barang ini kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            MessageBox.Show("Barang dengan ID tersebut tidak ditemukan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub ButtonRestok_Click(sender As Object, e As EventArgs) Handles ButtonRestok.Click
        Dim idKembalikan As Integer = Integer.Parse(TextBoxIDCari.Text)
        Dim buku As Buku = CariBukuByID(idKembalikan)

        If buku IsNot Nothing AndAlso Not buku.Tersedia Then
            buku.Tersedia = True
            LabelStatus.Text = "Tersedia"
            MessageBox.Show("Barang telah di restok.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf buku IsNot Nothing AndAlso Not buku.Tersedia Then
            MessageBox.Show("Barang ini sudah di restok.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            MessageBox.Show("Barang dengan ID tersebut tidak ditemukan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        TextBoxIDCari.Clear()
        TextBoxBarang.Clear()
        TextBoxKategori.Clear()
        TextBoxBrand.Clear()
        TextBoxExpired.Clear()
        LabelStatus.Refresh()
    End Sub
End Class