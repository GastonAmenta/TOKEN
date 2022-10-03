<?php
$conn = mysqli_connect('localhost', 'root', '', 'world');
if(!$conn){
    die ("Error de conexion". mysqli_connect_error());
}

$query = "SELECT * FROM country";
$result = mysqli_query($conn, $query);
if(!$result){
    die ("Error de consulta" . mysqli_error($conn));
}


?>