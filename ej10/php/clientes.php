<?php
    $init = $_GET['page'] * 5;
    $con  = mysqli_connect("localhost","root","","base_foromilitar");
    $query = "SELECT * FROM `autoridades` Limit " . $init . ", 5";
    $resultado = mysqli_query($con,$query);
    while($row = mysqli_fetch_assoc($resultado)) {
        $res[] = $row;
    }

    echo json_encode($res);
 //   header('location:../paginador2.php');
?>