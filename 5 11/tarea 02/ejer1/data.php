<?php 

$conn = mysqli_connect('localhost', 'root', '', 'ejer1');

if (!$conn) {
    die('Error de Conexión (' . mysqli_connect_errno() . ') '
        . mysqli_connect_error());
}
if(!isset($_POST)){
    header('Location: home.php');
}else{

$nombre=$_POST['nombre'];
$apellido=$_POST['apellido'];
$horas=$_POST['horas'];
$valor=$_POST['valor'];
$sqlInsert= "INSERT INTO profesores (nombre, apellido, horas_trabajadas, valor_hora) VALUES ('". $nombre ."','".$apellido. "','". $horas ."','". $valor ."')";
$resultInsert= mysqli_query($conn, $sqlInsert);
if(!$resultInsert){
    die("Error de consulta 1: " . mysqli_error($conn));
}
header('Location: tabla.php');
}