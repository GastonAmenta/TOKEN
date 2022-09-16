<?php
$conn = mysqli_connect('localhost', 'root', '', 'escuela');
if(!$conn){
    die('Error de conexion' . mysqli_connect_error());
}

if(!empty($_POST)){
    $materia = $_POST['materia'];

    $sql="INSERT INTO materias (nombre) VALUES ('" . $materia . "');";

    $query=mysqli_query($conn, $sql);
    if(!$query){
        die ('Error de consulta' . mysqli_error($conn));
    }

    header("Location:listado.php");



}

?>