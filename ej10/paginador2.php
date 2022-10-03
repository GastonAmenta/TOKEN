<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js"></script>
    <script>
        var latitud = -34.6140489;
        var page = 1;
        
        var contenido;

        function sumar (){
            page = page+1;
        }
        function restar (){
            page = page-1;
        }
        $.ajax({
            url: 'php/clientes.php?page=' + page,
            dataType: 'json',
            success: function(datos) {
                var vHtml = "<table border = 1>";

                for (x = 0; x < datos.length; x++) {
                    vHtml += "<tr>";
                    vHtml += "<td>" + datos[x]['IDtrabajadores'] + "</td>";
                    vHtml += "<td>" + datos[x]['nombre'] + "</td>";
                    vHtml += "<td>" + datos[x]['apellidopat'] + "</td>";

                    vHtml += "</tr>";
                }
                vHtml += "</table>";


                $("#content").html(vHtml);
            }
        });
    </script>
    <!-- JavaScript Bundle with Popper -->
</head>

<body>
    
    <table border="1">
        <tr style="height:100px">
            <td>
                1
            </td>
        </tr>
        <tr>
            <td>
                <div id="content">10</div>
            </td>
        </tr>
        <tr>
            <td>
                <div id="content2"></div>
                <script>
                    var el = document.getElementById('content2');
                    if (page != 0) {
                    contenido = '<button type="button" onclick="restar()" id="anterior">Anterior</button>';    
                    el.insertAdjacentHTML('afterbegin', contenido);
                    
                    console.log(page);
                }
                    
                contenido = '<a href="php/clientes.php?page=" . page >Siguiente</a>'  
                el.insertAdjacentHTML('afterbegin', contenido); 
                </script>
                
                
                
            </td>
        </tr>
    </table>
</body>

</html>