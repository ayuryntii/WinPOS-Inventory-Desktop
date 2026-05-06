$masterConnStr = "Data Source=(localdb)\MSSQLLocalDB;Integrated Security=True"
$dbName = "Kasir"
$targetConnStr = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=$dbName;Integrated Security=True"

try {
    # 1. Create Database if not exists
    $masterConn = New-Object System.Data.SqlClient.SqlConnection($masterConnStr)
    $masterConn.Open()
    $cmd = $masterConn.CreateCommand()
    $cmd.CommandText = "IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = '$dbName') CREATE DATABASE $dbName"
    $cmd.ExecuteNonQuery()
    $masterConn.Close()
    Write-Host "Database $dbName check/creation complete."

    # 2. Create Table if not exists
    $targetConn = New-Object System.Data.SqlClient.SqlConnection($targetConnStr)
    $targetConn.Open()
    $cmd = $targetConn.CreateCommand()
    $cmd.CommandText = @"
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'TBL_BARANG')
CREATE TABLE TBL_BARANG (
    KodeBarang VARCHAR(50) PRIMARY KEY,
    NamaBarang VARCHAR(100),
    HargaJual INT,
    HargaBeli INT,
    JumlahBarang INT,
    SatuanBarang VARCHAR(50),
    Distributor VARCHAR(100)
)
"@
    $cmd.ExecuteNonQuery()
    $targetConn.Close()
    Write-Host "Table TBL_BARANG check/creation complete."
    Write-Host "ALL DONE! You can now run the application."
}
catch {
    Write-Error $_.Exception.Message
}
