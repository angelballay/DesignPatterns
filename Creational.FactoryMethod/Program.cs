/* 
 Metodo Fabrica, Constructor Vital
Patron de diseño creacional que proporciona una interfaz para crear objetos en una superclase, 
minetas permitea a las subclases alterar el tipo de objetos que se crearan.
 */

using Creational.FactoryMethod;
using Creational.FactoryMethod.Creators;

Dialog _dialog;


if (GetOS() == "HTML")
{
    _dialog = new WebDialog();
}
else
{
    if(GetOS() == "linux")
    {
        _dialog = new LinuxDialog();
    }
    else
    {
        _dialog = new WebDialog();
    }
}

_dialog.Render();



// Leen las configuraciones
static string GetOS()
{
    return "linux";
}