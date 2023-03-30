function login(){
var usuario= document.getElementById("usuario").value;
var clave=document.getElementById("clave").value;

switch (usuario) {
    case "Wolverine": console.log("Usuario ingresado correctamente");
    break;
default:
    console.log("Usuario incorrecto");
}
switch (clave) {
    case "abj123g": console.log("Contraseña ingresada correctamente");
    break;
default:
    console.log("Contraseña incorrecta");
}

}