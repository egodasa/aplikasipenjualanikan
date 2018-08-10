Public Class Flaporan
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If jenis_pengguna = "Admin" Then
            main_form.Show()
        Else
            Flogin.Show()
        End If
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button3.Click
        Flaporan1.CR.Load("laporan/Penjualan.rpt")
        If Math.Ceiling((penjualan_akhir.Value - penjualan_awal.Value).TotalDays) < 1 Then
            Flaporan1.CR.SetParameterValue("judul", "Per Tanggal " & penjualan_awal.Value.ToString("dd MMMM yyyy"))
        Else
            Flaporan1.CR.SetParameterValue("judul", "Per Tanggal " & penjualan_awal.Value.ToString("dd MMMM yyyy") & " - " & penjualan_akhir.Value.ToString("dd MMMM yyyy"))
        End If
        Flaporan1.CR.SetParameterValue("judul", "Per Tanggal ")
        Flaporan1.tipe_laporan = "penjualan"
        Flaporan1.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button1.Click
        Flaporan1.CR.Load("laporan/Pembelian.rpt")
        If Math.Ceiling((pembelian_akhir.Value - pembelian_awal.Value).TotalDays) < 1 Then
            Flaporan1.CR.SetParameterValue("judul", "Per Tanggal " & pembelian_awal.Value.ToString("dd MMMM yyyy"))
        Else
            Flaporan1.CR.SetParameterValue("judul", "Per Tanggal " & pembelian_awal.Value.ToString("dd MMMM yyyy") & " - " & pembelian_akhir.Value.ToString("dd MMMM yyyy"))
        End If
        Flaporan1.tipe_laporan = "pembelian"
        Flaporan1.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button2.Click
        Flaporan1.CR.Load("laporan/LabaRugi.rpt")
        If Math.Ceiling((laba_akhir.Value - laba_awal.Value).TotalDays) < 1 Then
            Flaporan1.CR.SetParameterValue("judul", "Per Tanggal " & laba_awal.Value.ToString("dd MMMM yyyy"))
        Else
            Flaporan1.CR.SetParameterValue("judul", "Per Tanggal " & laba_awal.Value.ToString("dd MMMM yyyy") & " - " & laba_akhir.Value.ToString("dd MMMM yyyy"))
        End If
        Flaporan1.tipe_laporan = "laba"
        Flaporan1.ShowDialog()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button4.Click
        Flaporan1.CR.Load("laporan/Produk.rpt")
        Flaporan1.tipe_laporan = "produk"
        Flaporan1.ShowDialog()
    End Sub
End Class