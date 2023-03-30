<?php 

$conn = mysqli_connect('localhost', 'root', '', 'ejer1');

if (!$conn) {
    die('Error de Conexión (' . mysqli_connect_errno() . ') '
        . mysqli_connect_error());
}

$sqlData = "SELECT * FROM profesores";
$resultData = mysqli_query($conn, $sqlData);
if(!$resultData){
    die("Error de consulta 2:" . mysqli_error($conn));
}
$rowData = mysqli_fetch_all($resultData, MYSQLI_ASSOC);
//print_r($rowData);

?>
<table border="1">
<tr>
    <th>Nombre</th>
    <th>Apellido</th>
    <th>Horas trabajadas</th>
    <th>Valor por hora</th>
    <th>Sueldo</th>
</tr>
<?php 

foreach($rowData as $valores){
    $sueldo = ($valores['horas_trabajadas'] * $valores['valor_hora']) * 30?>
<tr>
    
    <td><?php echo $valores['nombre'] ?></td>
    <td><?php echo $valores['apellido'] ?></td>
    <td><?php echo $valores['horas_trabajadas'] ?></td>
    <td>$<?php echo $valores['valor_hora'] ?></td>
    <td>$<?php echo $sueldo ?></td>
    <?php }?>
</tr>
</table>
<button><a href="home.php">Home</a></button>