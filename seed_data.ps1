$targetConnStr = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Kasir;Integrated Security=True"

try {
    $targetConn = New-Object System.Data.SqlClient.SqlConnection($targetConnStr)
    $targetConn.Open()
    $cmd = $targetConn.CreateCommand()
    
    # Kosongkan dulu agar tidak duplikat saat dijalankan ulang
    $cmd.CommandText = "DELETE FROM TBL_BARANG"
    $cmd.ExecuteNonQuery()

    # Isi Data Dummy
    $cmd.CommandText = @"
INSERT INTO TBL_BARANG (KodeBarang, NamaBarang, HargaJual, HargaBeli, JumlahBarang, SatuanBarang, Distributor) 
VALUES 
('B001', 'Laptop ASUS', 12000000, 10000000, 5, 'Unit', 'PT. ASUS INDO'),
('B002', 'Mouse Gaming', 500000, 350000, 20, 'Pcs', 'PT. LOGITECH'),
('B003', 'Keyboard Mech', 750000, 600000, 10, 'Unit', 'PT. TECH JAYA')
"@
    $cmd.ExecuteNonQuery()
    $targetConn.Close()
    Write-Host "Dummy data inserted successfully!"
}
catch {
    Write-Error $_.Exception.Message
}
