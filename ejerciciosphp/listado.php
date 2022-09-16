<?php
$conn = mysqli_connect('localhost', 'root', '', 'escuela');
if(!$conn){
    die('Error de conexion' . mysqli_connect_error());
}



    $sql="SELECT * FROM materias ;";

    $query=mysqli_query($conn, $sql);
    if(!$query){
        die ('Error de consulta' . mysqli_error($conn));
    }
    
    ?>
    <table border=1> 
        <?php while ($fila = mysqli_fetch_assoc($query)){
            echo ("<tr> <td>" . $fila["id"] . "</td> <td>" . $fila["nombre"] . "</td> </tr>");
        }  ?>  
    </table>



