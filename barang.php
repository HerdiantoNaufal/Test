<?php

error_reporting(E_ALL ^ E_DEPRECATED);

$Server = "fdb17.awardspace.net";
$User = "2326813_admin";
$Pass = "zzz1312000";
$Db = "2326813_admin";
$Connection = mysql_connect($Server, $User, $Pass, $Db);

if(mysql_error()){
	die("Connection Failed!=". mysql_error());
}
mysql_select_db("2326813_admin", $Connection) or die("Could not load to database" . mysql_error());

$check = "SELECT nama_barang FROM barang";
$result=mysql_query($check);
$numrows = mysql_num_rows($result);

//while($row=mysql_fetch_array($result))
if($numrows > 0 ){ 
	while($row=mysql_fetch_array($result))
	{ 
		echo "\nNama Barang : ".$row['nama_barang']." ";
	}
}
?>